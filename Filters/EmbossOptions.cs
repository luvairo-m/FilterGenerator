using FilterGenerator.Extra;
using System.ComponentModel;

namespace FilterGenerator.Filters
{
    public partial class EmbossOptions : Form, IFilter
    {
        private int[,] bothKernel = new int[,]
        {
            { -1, -1, -1 },
            { -1, 8, -1 },
            { -1, -1, -1 },
        };

        private int[,] horizontalKernel = new int[,]
        {
            { 0, 0, 0 },
            { -1, 2, -1 },
            { 0, 0, 0 },
        };

        private int[,] verticalKernel = new int[,]
        {
            { 0, -1, 0 },
            { 0, 0, 0 },
            { 0, 1, 0 },
        };

        private BackgroundWorker? backgroundWorker;
        private Image? imageBuffer;
        private Form1? baseForm;

        public EmbossOptions() => InitializeComponent();

        public EmbossOptions(BackgroundWorker worker, Form1 baseForm) : this()
            => (backgroundWorker, this.baseForm) = (worker, baseForm);

        public Image GetFilteredImage(Image image)
        {
            imageBuffer ??= image;

            var embossKernel = bothKernel;

            if (horizontalRadio.Checked) embossKernel = horizontalKernel;
            else if (verticalRadio.Checked) embossKernel = verticalKernel;
            else if (bothRadio.Checked) embossKernel = bothKernel;

            var output = new Bitmap(imageBuffer.Width, imageBuffer.Height);

            var offset = embossKernel.GetLength(0) / 2;
            var extendedMatrix = ImageUtils.GetExtendedByKernelImageMatrix(
                ImageUtils.GetImageMatrix(imageBuffer), embossKernel.GetLength(0));

            for (var i = offset; i < extendedMatrix.GetLength(0) - offset; i++)
            {
                for (var j = offset; j < extendedMatrix.GetLength(1) - offset; j++)
                {
                    var (red, green, blue) = (0f, 0f, 0f);
                    var alpha = ImageUtils.DecomposeColor(extendedMatrix[i, j]).a;
                    var (iBuffer, jBuffer) = (i - offset, j - offset);

                    for (var x = i - offset; x <= i + offset; x++)
                        for (var y = j - offset; y <= j + offset; y++)
                        {
                            var (_, r, g, b) = ImageUtils.DecomposeColor(extendedMatrix[x, y]);
                            red += r * embossKernel[x - iBuffer, y - jBuffer];
                            green += g * embossKernel[x - iBuffer, y - jBuffer];
                            blue += b * embossKernel[x - iBuffer, y - jBuffer];
                        }

                    red += 127;
                    green += 127;
                    blue += 127;

                    ImageUtils.ControlChannelsOverflow(ref red, ref green, ref blue);
                    output.SetPixel(j - offset, i - offset, ImageUtils.ComposeColor((alpha, (int)red, (int)green, (int)blue)));
                }

                backgroundWorker!.ReportProgress((int)Math.Round(100 * (double)i / output.Height));
            }

            GarbageCollectorUtils.ActivateGarbageCollection();

            return output;
        }

        private void BackButtonClicked(object sender, EventArgs e)
        {
            if (imageBuffer != null)
                baseForm!.ChangeImage(imageBuffer);
        }
    }
}