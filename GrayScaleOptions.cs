namespace FilterGenerator
{
    public partial class GrayScaleOptions : Form, IFilter
    {
        private float? rBuffer, gBuffer, bBuffer;

        public GrayScaleOptions() => InitializeComponent();

        public Image GetFilteredImage(Image image)
        {
            if (redErrorProvider.GetError(redWeight) != string.Empty
                || greenErrorProvider.GetError(greenWeight) != string.Empty
                || blueErrorProvider.GetError(blueWeight) != string.Empty)
            {
                MessageBox.Show(
                    "Bad filter's parameters",
                    "Filter error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return image;
            }

            var (rWeight, gWeight, bWeight) =
                (float.Parse(redWeight.Text),
                float.Parse(greenWeight.Text),
                float.Parse(blueWeight.Text));

            if (rBuffer == null && gBuffer == null && bBuffer == null)
                (rBuffer, gBuffer, bBuffer) = (rWeight, gWeight, bWeight);
            else if (rWeight == rBuffer && gWeight == gBuffer && bWeight == bBuffer)
                return image;

            var input = new Bitmap(image);
            var bitmap = new Bitmap(input.Width, input.Height);

            for (var i = 0; i < bitmap.Height; i++)
                for (var j = 0; j < bitmap.Width; j++)
                {
                    var pixel = input.GetPixel(j, i).ToArgb();

                    var alpha = (float)((pixel & 0xFF000000) >> 24);
                    var red = (float)((pixel & 0x00FF0000) >> 16);
                    var green = (float)((pixel & 0x0000FF00) >> 8);
                    var blue = (float)(pixel & 0x000000FF);

                    red = green = blue = rWeight * red + gWeight * green + bWeight * blue;

                    var filteredPixel = 0x00000000 |
                        ((uint)alpha << 24) | ((uint)red << 16) | ((uint)green << 8) | ((uint)blue);
                    bitmap.SetPixel(j, i, Color.FromArgb((int)filteredPixel));
                }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            (rBuffer, gBuffer, bBuffer) = (rWeight, gWeight, bWeight);
            return bitmap;
        }

        private void RedWeightTextBoxChanged(object sender, EventArgs e)
            => ValidateFloatInput((TextBox)sender, redErrorProvider);

        private void GreenWeightTextBoxChanged(object sender, EventArgs e)
            => ValidateFloatInput((TextBox)sender, greenErrorProvider);

        private void BlueWeightTextBoxChanged(object sender, EventArgs e)
            => ValidateFloatInput((TextBox)sender, blueErrorProvider);

        private void ValidateFloatInput(TextBox sender, ErrorProvider provider)
        {
            var input = sender.Text;

            if (float.TryParse(input, out float value))
            {
                if (value < 0 || value > 1)
                    provider.SetError(sender, "Value must be in [0, 1]");
                else
                    provider.Clear();

                return;
            }

            provider.SetError(sender, "Invalid number format, use comma instead of dout");
        }
    }
}