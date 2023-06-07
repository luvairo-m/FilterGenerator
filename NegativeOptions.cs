using System.ComponentModel;

namespace FilterGenerator
{
    public partial class NegativeOptions : Form, IFilter
    {
        private BackgroundWorker? backgroundWorker;
        private Image? imageBuffer;

        public NegativeOptions() => InitializeComponent();

        public NegativeOptions(BackgroundWorker worker) : this()
            => backgroundWorker = worker;

        public Image GetFilteredImage(Image image)
        {
            imageBuffer ??= image;

            var input = new Bitmap(imageBuffer);
            var result = new Bitmap(input.Width, input.Height);

            for (var i = 0; i < input.Height; i++)
            {
                for (var j = 0; j < input.Width; j++)
                {
                    var pixel = input.GetPixel(j, i).ToArgb();

                    var alpha = (float)((pixel & 0xFF000000) >> 24);
                    var red = (float)((pixel & 0x00FF0000) >> 16);
                    var green = (float)((pixel & 0x0000FF00) >> 8);
                    var blue = (float)(pixel & 0x000000FF);

                    if (redCheck.Checked)
                        red = 255 - red;
                    if (greenCheck.Checked)
                        green = 255 - green;
                    if (blueCheck.Checked)
                        blue = 255 - blue;

                    var filteredPixel = 0x00000000 |
                        ((uint)alpha << 24) | ((uint)red << 16) | ((uint)green << 8) | ((uint)blue);

                    result.SetPixel(j, i, Color.FromArgb((int)filteredPixel));
                }

                backgroundWorker!.ReportProgress((int)Math.Round(100 * (double)i / result.Height));
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return result;
        }
    }
}