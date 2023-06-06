﻿namespace FilterGenerator
{
    public partial class ContrastOptions : Form, IFilter
    {
        private int? contrastBuffer;

        public ContrastOptions() => InitializeComponent();

        public Image GetFilteredImage(Image image)
        {
            var contrast = trackBar.Value;

            if (contrastBuffer == contrast)
                return image;

            if (contrastBuffer == null)
                contrastBuffer = contrast;

            var input = new Bitmap(image);
            var bitmap = new Bitmap(input.Width, input.Height);

            for (var i = 0; i < input.Height; i++)
                for (var j = 0; j < input.Width; j++)
                    bitmap.SetPixel(j, i,
                        Color.FromArgb((int)ChangePixelContrast((uint)input.GetPixel(j, i).ToArgb(),
                        contrast)));

            contrastBuffer = contrast;

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

        private void TrackBarScrolled(object sender, EventArgs e) =>
            label.Text = $"Current contrast: {((TrackBar)sender).Value}";
    }
}