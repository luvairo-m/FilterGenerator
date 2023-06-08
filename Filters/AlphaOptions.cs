using System.ComponentModel;
using FilterGenerator.Extra;
using FilterGenerator.Filters;

namespace FilterGenerator
{
    public partial class AlphaOptions : Form, IFilter
    {
        private BackgroundWorker? backgroundWorker;
        private Image? imageBuffer;
        private int trackbarValue;

        public AlphaOptions() => InitializeComponent();

        public AlphaOptions(BackgroundWorker worker, Form1 baseForm) : this()
            => backgroundWorker = worker;

        public Image GetFilteredImage(Image image)
        {
            imageBuffer ??= image;

            var input = new Bitmap(imageBuffer);
            var output = new Bitmap(input.Width, input.Height);

            for (var i = 0; i < input.Height; i++)
            {
                for (var j = 0; j < input.Width; j++)
                {
                    var alphaValue = 255 - (float)trackbarValue / 100 * 255;
                    var (_, red, green, blue) = ImageUtils.DecomposeColor(input.GetPixel(j, i).ToArgb());
                    var newPixel = ImageUtils.ComposeColor(((int)alphaValue, red, green, blue));
                    output.SetPixel(j, i, newPixel);
                }

                backgroundWorker!.ReportProgress((int)Math.Round(100 * (double)i / output.Height));
            }

            return output;
        }

        private void TrackBarScrolled(object sender, EventArgs e)
        {
            var trackbar = sender as TrackBar;
            trackbarValue = trackbar!.Value;
            label.Text = $"Значение прозрачности: {trackbarValue}%";
        }
    }
}