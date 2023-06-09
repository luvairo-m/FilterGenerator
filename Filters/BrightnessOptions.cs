using System.ComponentModel;
using FilterGenerator.Extra;
using FilterGenerator.Filters;

namespace FilterGenerator
{
    public partial class BrightnessOptions : Form, IFilter
    {
        private BackgroundWorker? backgroundWorker;
        private Image? imageBuffer;
        private int trackbarValue;

        public BrightnessOptions() => InitializeComponent();

        public BrightnessOptions(BackgroundWorker worker, Form1 baseForm) : this()
            => backgroundWorker = worker;

        public Image GetFilteredImage(Image image)
        {
            imageBuffer ??= image;

            var brightness = trackbarValue;
            var input = new Bitmap(imageBuffer);
            var bitmap = new Bitmap(input.Width, input.Height);

            for (var i = 0; i < input.Height; i++)
            {
                for (var j = 0; j < input.Width; j++)
                    bitmap.SetPixel(j, i, GetChangedPixelColor(input.GetPixel(j, i), brightness));

                backgroundWorker!.ReportProgress((int)Math.Round(100 * (double)i / bitmap.Height));
            }

            GarbageCollectorUtils.ActivateGarbageCollection();

            return bitmap;
        }

        private Color GetChangedPixelColor(Color initialPixelColor, int brightness)
        {
            const int length = 10;
            var increment = 100 / length * brightness * 1.28f;

            var (alpha, red, green, blue) = ImageUtils.DecomposeColor(initialPixelColor.ToArgb());

            red += (int)increment;
            green += (int)increment;
            blue += (int)increment;

            ImageUtils.ControlChannelsOverflow(ref red, ref green, ref blue);    

            return ImageUtils.ComposeColor((alpha, red, green, blue));
        }

        private void TrackBarScrolled(object sender, EventArgs e)
        {
            var trackbar = sender as TrackBar;
            label.Text = $"Значение яркости: {trackbar!.Value}";
            trackbarValue = trackbar.Value;
        }
    }
}