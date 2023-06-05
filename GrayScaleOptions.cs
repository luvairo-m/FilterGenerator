namespace FilterGenerator
{
    public partial class GrayScaleOptions : Form, IFilter
    {
        public GrayScaleOptions() => InitializeComponent();

        public Image GetFilteredImage(Image image)
        {
            var input = new Bitmap(image);
            var bitmap = new Bitmap(input.Width, input.Height);

            for (var j = 0; j < bitmap.Height; j++)
                for (var i = 0; i < bitmap.Width; i++)
                {
                    var pixel = input.GetPixel(i, j).ToArgb();

                    var r = (float)((pixel & 0x00FF0000) >> 16);
                    var g = (float)((pixel & 0x0000FF00) >> 8);
                    var b = (float)(pixel & 0x000000FF);

                    r = g = b = (r + g + b) / 3.0f;

                    var filteredPixel = 0xFF000000 | ((uint)r << 16) | ((uint)g << 8) | ((uint)b);
                    bitmap.SetPixel(i, j, Color.FromArgb((int)filteredPixel));
                }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return bitmap;
        }
    }
}