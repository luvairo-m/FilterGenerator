using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace FilterGenerator
{
    public partial class NegativeOptions : Form, IFilter
    {
        public NegativeOptions() => InitializeComponent();

        public Image GetFilteredImage(Image source)
        {
            var image = new Bitmap(source);
            var (width, height) = (image.Width, image.Height);

            var sourceData = image.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            var bytes = sourceData.Stride * sourceData.Height;
            var (buffer, result) = (new byte[bytes], new byte[bytes]);

            Marshal.Copy(sourceData.Scan0, buffer, 0, bytes);
            image.UnlockBits(sourceData);

            var cChannels = 3;

            for (var y = 0; y < height; y++)
                for (var x = 0; x < width; x++)
                {
                    var current = y * sourceData.Stride + x * 4;

                    for (int c = 0; c < cChannels; c++)
                        result[current + c] = (byte)(255 - buffer[current + c]);

                    result[current + 3] = 255;
                }

            var resultedImage = new Bitmap(width, height);
            var resultData = resultedImage.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(result, 0, resultData.Scan0, bytes);
            resultedImage.UnlockBits(resultData);

            return resultedImage;
        }
    }
}