using System.ComponentModel;

namespace FilterGenerator
{
    public partial class BrightnessOptions : Form, IFilter
    {
        private BackgroundWorker? backgroundWorker;
        private Image? imageBuffer;
        private int trackbarValue;

        public BrightnessOptions() => InitializeComponent();

        public BrightnessOptions(BackgroundWorker worker) : this()
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
                    bitmap.SetPixel(j, i,
                        Color.FromArgb((int)ChangePixelBrightness((uint)input.GetPixel(j, i).ToArgb(),
                        brightness)));

                backgroundWorker!.ReportProgress((int)Math.Round(100 * (double)i / bitmap.Height));
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return bitmap;
        }

        private uint ChangePixelBrightness(uint point, int brightness)
        {
            const int length = 10;
            var value = 100 / length * brightness;

            int r, g, b;

            r = (int)(((point & 0x00FF0000) >> 16) + value * 128 / 100);
            g = (int)(((point & 0x0000FF00) >> 8) + value * 128 / 100);
            b = (int)((point & 0x000000FF) + value * 128 / 100);

            if (r < 0) r = 0;
            if (r > 255) r = 255;
            if (g < 0) g = 0;
            if (g > 255) g = 255;
            if (b < 0) b = 0;
            if (b > 255) b = 255;

            point = 0xFF000000 | ((uint)r << 16) | ((uint)g << 8) | ((uint)b);
            return point;
        }

        private void TrackBarScrolled(object sender, EventArgs e)
        {
            var trackbar = sender as TrackBar;
            label.Text = $"Значение яркости: {trackbar!.Value}";
            trackbarValue = trackbar.Value;
        }
    }
}