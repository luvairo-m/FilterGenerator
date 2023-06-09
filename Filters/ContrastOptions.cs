using System.ComponentModel;
using FilterGenerator.Extra;
using FilterGenerator.Filters;

namespace FilterGenerator
{
    public partial class ContrastOptions : Form, IFilter
    {
        private BackgroundWorker? backgroundWorker;
        private Image? imageBuffer;
        private int trackbarValue;

        public ContrastOptions() => InitializeComponent();

        public ContrastOptions(BackgroundWorker worker, Form1 baseForm) : this()
            => backgroundWorker = worker;

        public Image GetFilteredImage(Image image)
        {
            imageBuffer ??= image;

            var contrast = trackbarValue;
            var input = new Bitmap(imageBuffer);
            var bitmap = new Bitmap(input.Width, input.Height);

            for (var i = 0; i < input.Height; i++)
            {
                for (var j = 0; j < input.Width; j++)
                    bitmap.SetPixel(j, i, GetChangedPixelColor(input.GetPixel(j, i), contrast));

                backgroundWorker!.ReportProgress((int)Math.Round(100 * (double)i / bitmap.Height));
            }

            GarbageCollectorUtils.ActivateGarbageCollection();

            return bitmap;
        }

        private Color GetChangedPixelColor(Color initialPixelColor, int contrast)
        {
            const int length = 10;
            var value = 100 / length * contrast;

            var (alpha, red, green, blue) = ImageUtils.DecomposeColor(initialPixelColor.ToArgb());

            if (value >= 0)
            {
                if (value == 100) value = 99;
                red = (red * 100 - 128 * value) / (100 - value);
                green = (green * 100 - 128 * value) / (100 - value);
                blue = (blue * 100 - 128 * value) / (100 - value);
            }
            else
            {
                red = (red * (100 - (-value)) + 128 * (-value)) / 100;
                green = (green * (100 - (-value)) + 128 * (-value)) / 100;
                blue = (blue * (100 - (-value)) + 128 * (-value)) / 100;
            }

            ImageUtils.ControlChannelsOverflow(ref red, ref green, ref blue);

            return ImageUtils.ComposeColor((alpha, red, green, blue));
        }

        private void TrackBarScrolled(object sender, EventArgs e)
        {
            var trackbar = sender as TrackBar;
            label.Text = $"Значение контрастности: {trackbar!.Value}";
            trackbarValue = trackbar.Value;
        }
    }
}