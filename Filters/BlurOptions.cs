using FilterGenerator.Extra;
using System.ComponentModel;

namespace FilterGenerator.Filters
{
    public partial class BlurOptions : Form, IFilter
    {
        private BackgroundWorker? backgroundWorker;
        private Image? imageBuffer;
        private Form1? baseForm;

        public BlurOptions() => InitializeComponent();

        public BlurOptions(BackgroundWorker worker, Form1 baseForm) : this()
            => (backgroundWorker, this.baseForm) = (worker, baseForm);

        public Image GetFilteredImage(Image image)
        {
            imageBuffer ??= image;

            var kernelSize = 0;
            if (lowBlurRadio.Checked) kernelSize = 11;
            else if (middleBlurRadio.Checked) kernelSize = 21;
            else if (highBlurRadio.Checked) kernelSize = 31;

            var output = new Bitmap(imageBuffer.Width, imageBuffer.Height);
            var kernel = new float[kernelSize, kernelSize];

            for (var i = 0; i < kernel.GetLength(0); i++)
                for (var j = 0; j < kernel.GetLength(1); j++)
                    kernel[i, j] = 1.0f / kernel.Length;

            var offset = kernel.GetLength(0) / 2;
            var extendedMatrix = ImageUtils.GetExtendedByKernelImageMatrix(
                ImageUtils.GetImageMatrix(imageBuffer), kernel.GetLength(0));

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
                            red += r * kernel[x - iBuffer, y - jBuffer];
                            green += g * kernel[x - iBuffer, y - jBuffer];
                            blue += b * kernel[x - iBuffer, y - jBuffer];
                        }

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