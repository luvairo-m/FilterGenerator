using System.ComponentModel;
using FilterGenerator.Extra;
using FilterGenerator.Filters;

namespace FilterGenerator
{
    public partial class GrayScaleOptions : Form, IFilter
    {
        private BackgroundWorker? backgroundWorker;
        private Image? imageBuffer;
        private Form1? baseForm;

        public GrayScaleOptions() => InitializeComponent();

        public GrayScaleOptions(BackgroundWorker worker, Form1 baseForm) : this()
            => (backgroundWorker, this.baseForm) = (worker, baseForm);

        public Image GetFilteredImage(Image image)
        {
            if (redErrorProvider.GetError(redWeight) != string.Empty
                || greenErrorProvider.GetError(greenWeight) != string.Empty
                || blueErrorProvider.GetError(blueWeight) != string.Empty)
            {
                MessageBox.Show(
                    "Неверные настройки фильтра.",
                    "Ошибка фильтрации",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return image;
            }

            imageBuffer ??= image;

            var (rWeight, gWeight, bWeight) =
                (float.Parse(redWeight.Text),
                float.Parse(greenWeight.Text),
                float.Parse(blueWeight.Text));

            var input = new Bitmap(imageBuffer);
            var bitmap = new Bitmap(input.Width, input.Height);

            for (var i = 0; i < bitmap.Height; i++)
            {
                for (var j = 0; j < bitmap.Width; j++)
                {
                    var (alpha, red, green, blue) = ImageUtils.DecomposeColor(input.GetPixel(j, i).ToArgb());
                    var value = (int)(rWeight * red + gWeight * green + bWeight * blue);
                    var newPixel = ImageUtils.ComposeColor((alpha, value, value, value));
                    bitmap.SetPixel(j, i, newPixel);
                }

                backgroundWorker!.ReportProgress((int)Math.Round(100 * (double)i / bitmap.Height));
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

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
                    provider.SetError(sender, "Значение должно принадлежать отрезку: [0, 1]");
                else
                    provider.Clear();

                return;
            }

            provider.SetError(sender, "Неверный формат числа. Может, Вы используете . вместо , ?");
        }

        private void BackButtonClicked(object sender, EventArgs e)
        {
            if (imageBuffer != null)
                baseForm!.ChangeImage(imageBuffer);
        }
    }
}