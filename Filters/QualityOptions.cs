using System.ComponentModel;
using FilterGenerator.Extra;
using FilterGenerator.Filters;

namespace FilterGenerator
{
    public partial class QualityOptions : Form, IFilter
    {
        private BackgroundWorker? backgroundWorker;
        private Image? imageBuffer;
        private Form1? baseForm;

        public QualityOptions() => InitializeComponent();

        public QualityOptions(BackgroundWorker worker, Form1 baseForm) : this()
            => (backgroundWorker, this.baseForm) = (worker, baseForm);

        public Image GetFilteredImage(Image image)
        {
            imageBuffer ??= image;

            var input = new Bitmap(imageBuffer);
            var output = new Bitmap(input.Width, input.Height);

            for (var i = 1; i < input.Height - 1; i++)
            {
                for (var j = 1; j < input.Width - 1; j++)
                {
                    var alpha = ImageUtils.DecomposeColor(input.GetPixel(j, i).ToArgb()).a;
                    var (r, g, b) = (0, 0, 0);

                    for (var x = i - 1; x <= i + 1; x++)
                        for (var y = j - 1; y <= j + 1; y++)
                        {
                            var (_, red, green, blue) 
                                = ImageUtils.DecomposeColor(input.GetPixel(y, x).ToArgb());

                            int coefficient;
                            if (x == i && y == j) coefficient = 9;
                            else coefficient = -1;

                            r += red * coefficient;
                            g += green * coefficient;
                            b += blue * coefficient;
                        }

                    ImageUtils.ControlChannelsOverflow(ref r, ref g, ref b);

                    var newPixel = ImageUtils.ComposeColor(((int)alpha, r, g, b));
                    output.SetPixel(j, i, newPixel);
                }

                backgroundWorker!.ReportProgress((int)Math.Round(100 * (double)i / output.Height));
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return output;
        }

        private void BackButtonClicked(object sender, EventArgs e)
        {
            if (imageBuffer != null)
                baseForm!.ChangeImage(imageBuffer);
        }
    }
}