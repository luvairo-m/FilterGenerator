using System.ComponentModel;
using FilterGenerator.Extra;
using FilterGenerator.Filters;

namespace FilterGenerator
{
    public partial class NegativeOptions : Form, IFilter
    {
        private BackgroundWorker? backgroundWorker;
        private Image? imageBuffer;
        private Form1? baseForm;

        public NegativeOptions() => InitializeComponent();

        public NegativeOptions(BackgroundWorker worker, Form1 baseForm) : this()
            => (backgroundWorker, this.baseForm) = (worker, baseForm);

        public Image GetFilteredImage(Image image)
        {
            imageBuffer ??= image;

            var input = new Bitmap(imageBuffer);
            var result = new Bitmap(input.Width, input.Height);

            for (var i = 0; i < input.Height; i++)
            {
                for (var j = 0; j < input.Width; j++)
                {
                    var (alpha, red, green, blue)
                        = ImageUtils.DecomposeColor(input.GetPixel(j, i).ToArgb());

                    if (redCheck.Checked) red = 255 - red;
                    if (greenCheck.Checked) green = 255 - green;
                    if (blueCheck.Checked) blue = 255 - blue;

                    result.SetPixel(j, i, ImageUtils.ComposeColor((alpha, red, green, blue)));
                }

                backgroundWorker!.ReportProgress((int)Math.Round(100 * (double)i / result.Height));
            }

            GarbageCollectorUtils.ActivateGarbageCollection();

            return result;
        }

        private void BackButtonClicked(object sender, EventArgs e)
        {
            if (imageBuffer != null)
                baseForm!.ChangeImage(imageBuffer!);
        }
    }
}