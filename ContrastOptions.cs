using System.ComponentModel;

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
                    bitmap.SetPixel(j, i,
                        Color.FromArgb((int)ChangePixelContrast((uint)input.GetPixel(j, i).ToArgb(),
                        contrast)));

                backgroundWorker!.ReportProgress((int)Math.Round(100 * (double)i / bitmap.Height));
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return bitmap;
        }

        private uint ChangePixelContrast(uint point, int contrast)
        {
            const int length = 10;
            int r, g, b;
            int value = 100 / length * contrast;

            if (value >= 0)
            {
                if (value == 100) value = 99;
                r = (int)((((point & 0x00FF0000) >> 16) * 100 - 128 * value) / (100 - value));
                g = (int)((((point & 0x0000FF00) >> 8) * 100 - 128 * value) / (100 - value));
                b = (int)(((point & 0x000000FF) * 100 - 128 * value) / (100 - value));
            }
            else
            {
                r = (int)((((point & 0x00FF0000) >> 16) * (100 - (-value)) + 128 * (-value)) / 100);
                g = (int)((((point & 0x0000FF00) >> 8) * (100 - (-value)) + 128 * (-value)) / 100);
                b = (int)(((point & 0x000000FF) * (100 - (-value)) + 128 * (-value)) / 100);
            }

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
            label.Text = $"Значение контрастности: {trackbar!.Value}";
            trackbarValue = trackbar.Value;
        }
    }
}