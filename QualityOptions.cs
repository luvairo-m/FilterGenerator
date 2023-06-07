using System.ComponentModel;

namespace FilterGenerator
{
    public partial class QualityOptions : Form, IFilter
    {
        private BackgroundWorker? backgroundWorker;

        public QualityOptions() => InitializeComponent();

        public QualityOptions(BackgroundWorker worker) : this()
            => backgroundWorker = worker;

        public Image GetFilteredImage(Image image)
        {
            var input = new Bitmap(image);
            var output = new Bitmap(input.Width, input.Height); 

            for (var i = 1; i < input.Height - 1; i++)
            {
                for (var j = 1; j < input.Width - 1; j++)
                {
                    var alpha = (input.GetPixel(j, i).ToArgb() & 0xFF000000) >> 24;
                    var (r, g, b) = (0f, 0f, 0f);

                    for (var x = i - 1; x <= i + 1; x++)
                        for (var y = j - 1; y <= j + 1; y++)
                        {
                            var point = input.GetPixel(y, x).ToArgb();

                            var red = (point & 0x00FF0000) >> 16;
                            var green = (point & 0x0000FF00) >> 8;
                            var blue = point & 0x000000FF;

                            int coefficient;

                            if (x == i && y == j)
                                coefficient = 9;
                            else
                                coefficient = -1;

                            r += red * coefficient;
                            g += green * coefficient;
                            b += blue * coefficient;
                        }

                    if (r > 255) r = 255;
                    if (r < 0) r = 0;
                    if (g > 255) g = 255;
                    if (g < 0) g = 0;
                    if (b > 255) b = 255;
                    if (b < 0) b = 0;

                    var pixel = 0x00000000 | ((uint)alpha << 24) | ((uint)r << 16) | ((uint)g << 8) | (uint)b;
                    output.SetPixel(j, i, Color.FromArgb((int)pixel));
                }

                backgroundWorker!.ReportProgress((int)Math.Round(100 * (double)i / output.Height));
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return output;
        }
    }
}