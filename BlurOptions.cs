using System.ComponentModel;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace FilterGenerator
{
    public partial class BlurOptions : Form, IFilter
    {
        private BackgroundWorker? backgroundWorker;
        private Image? imageBuffer;

        public BlurOptions() => InitializeComponent();

        public BlurOptions(BackgroundWorker worker) : this()
            => backgroundWorker = worker;

        public Image GetFilteredImage(Image image)
        {
            if (errorProvider.GetError(textBox2) != string.Empty
                || textBox2.Text == string.Empty)
            {
                MessageBox.Show(
                    "Неверные настройки фильтра",
                    "Ошибка фильтрации",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return image;
            }

            imageBuffer ??= image;

            var kernel = GetGaussianKernel(10, double.Parse(textBox2.Text));
            return Convolve(new Bitmap(imageBuffer), kernel);
        }

        private Image Convolve(Bitmap sourceImage, double[,] kernel)
        {
            var (width, height) = (sourceImage.Width, sourceImage.Height);

            BitmapData srcData = sourceImage.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            int bytes = srcData.Stride * srcData.Height;
            var (buffer, result) = (new byte[bytes], new byte[bytes]);

            Marshal.Copy(srcData.Scan0, buffer, 0, bytes);
            sourceImage.UnlockBits(srcData);

            var colorChannels = 3;
            var rgb = new double[colorChannels];

            var foff = (kernel.GetLength(0) - 1) / 2;
            var (kcenter, kpixel) = (0, 0);

            for (var y = foff; y < height - foff; y++)
            {
                for (var x = foff; x < width - foff; x++)
                {
                    for (var c = 0; c < colorChannels; c++)
                        rgb[c] = 0.0;

                    kcenter = y * srcData.Stride + x * 4;

                    for (var fy = -foff; fy <= foff; fy++)
                        for (var fx = -foff; fx <= foff; fx++)
                        {
                            kpixel = kcenter + fy * srcData.Stride + fx * 4;
                            for (var c = 0; c < colorChannels; c++)
                                rgb[c] += buffer[kpixel + c] * kernel[fy + foff, fx + foff];
                        }

                    for (var c = 0; c < colorChannels; c++)
                    {
                        if (rgb[c] > 255)
                            rgb[c] = 255;
                        else if (rgb[c] < 0)
                            rgb[c] = 0;
                    }

                    for (var c = 0; c < colorChannels; c++)
                        result[kcenter + c] = (byte)rgb[c];

                    result[kcenter + 3] = 255;
                }

                backgroundWorker!.ReportProgress((int)Math.Round(100 * (double)y / (height - foff)));
            }

            Bitmap resultImage = new Bitmap(width, height);
            BitmapData resultData = resultImage.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(result, 0, resultData.Scan0, bytes);
            resultImage.UnlockBits(resultData);

            return resultImage;
        }

        private double[,] GetGaussianKernel(int length, double weight)
        {
            var kernel = new double[length, length];
            var kernelSum = 0d;
            var foff = (length - 1) / 2;

            var distance = 0d;
            var constant = 1d / (2 * Math.PI * weight * weight);

            for (var y = -foff; y <= foff; y++)
                for (var x = -foff; x <= foff; x++)
                {
                    distance = ((y * y) + (x * x)) / (2 * weight * weight);
                    kernel[y + foff, x + foff] = constant * Math.Exp(-distance);
                    kernelSum += kernel[y + foff, x + foff];
                }

            for (var y = 0; y < length; y++)
                for (var x = 0; x < length; x++)
                    kernel[y, x] = kernel[y, x] * 1d / kernelSum;

            return kernel;
        }

        private void PowerTextBoxChanged(object sender, EventArgs e) =>
            ValidateDoubleInput((TextBox)sender);

        private void ValidateDoubleInput(TextBox sender)
        {
            var line = sender.Text;

            if (double.TryParse(line, out double value))
            {
                if (value <= 0d || value > 10d)
                    errorProvider.SetError(textBox2, "Значение должно принадлежать отрезку: [0, 10]");
                else
                    errorProvider.Clear();

                return;
            }

            errorProvider.SetError(textBox2, "Неверный формат числа");
        }
    }
}