namespace FilterGenerator.Extra
{
    public static class ImageUtils
    {
        const uint EMPTYRGBAMASK = 0x00000000;

        const uint ALPHAMASK = 0xFF000000;
        const uint REDMASK = 0x00FF0000;
        const uint GREENMASK = 0x0000FF00;
        const uint BLUEMASK = 0x000000FF;

        const int ALPHASHIFT = 24;
        const int REDSHIFT = 16;
        const int GREENSHIFT = 8;
        const int BLUESHIFT = 0;

        public static int[,] GetExtendedByKernelImageMatrix(int[,] initialMatrix, int[,] kernel)
        {
            var initialRows = initialMatrix.GetLength(0);
            var initialColumns = initialMatrix.GetLength(1);

            var offset = kernel.GetLength(0) / 2;
            var extendedMatrix = new int[initialRows + offset * 2, initialColumns + offset * 2];

            var extendedRows = extendedMatrix.GetLength(0);
            var extendedColumns = extendedMatrix.GetLength(1);

            for (var i = offset; i < extendedRows - offset; i++)
                for (var j = offset; j < extendedColumns - offset; j++)
                    extendedMatrix[i, j] = initialMatrix[i - offset, j - offset];

            for (var i = offset; i < extendedRows - offset; i++)
                for (var j = 0; j < offset; j++)
                {
                    extendedMatrix[i, j] = initialMatrix[i - offset, 0];
                    extendedMatrix[i, extendedColumns - j - 1]
                        = initialMatrix[i - offset, initialColumns - 1];
                }

            for (var i = 0; i < offset; i++)
                for (var j = offset; j < extendedRows - offset; j++)
                {
                    extendedMatrix[i, j] = initialMatrix[0, j - offset];
                    extendedMatrix[extendedColumns - i - 1, j]
                        = initialMatrix[initialRows - 1, j - offset];
                }

            for (var i = 0; i < offset; i++)
                for (var j = 0; j < offset; j++)
                {
                    extendedMatrix[i, j] = initialMatrix[0, 0];
                    extendedMatrix[i, extendedRows - j - 1] =
                        initialMatrix[0, initialColumns - 1];
                    extendedMatrix[extendedRows - i - 1, j] =
                        initialMatrix[initialRows - 1, 0];
                    extendedMatrix[extendedRows - i - 1, extendedColumns - j - 1] =
                        initialMatrix[initialRows - 1, initialColumns - 1];
                }

            return extendedMatrix;
        }

        public static (int a, int r, int g, int b) DecomposeColor(uint colorInteger)
        {
            return ((int)(colorInteger & ALPHAMASK) >> ALPHASHIFT,
                (int)(colorInteger & REDMASK) >> REDSHIFT,
                (int)(colorInteger & GREENMASK) >> GREENSHIFT,
                (int)(colorInteger & BLUEMASK) >> BLUESHIFT);
        }

        public static Color ComposeColor((int a, int r, int g, int b) channels)
        {
            var colorInteger = EMPTYRGBAMASK 
                | ((uint)channels.a  << ALPHASHIFT) 
                | ((uint)channels.r << REDSHIFT) 
                | ((uint)channels.g << GREENSHIFT) 
                | ((uint)channels.b << BLUESHIFT);
            return Color.FromArgb((int)colorInteger);
        }

        public static void ControlChannelsOverflow(ref int red, ref int green, ref int blue)
        {
            if (red > 255) red = 255;
            if (red < 0) red = 0;
            if (green > 255) green = 255;   
            if (green < 0) green = 0;   
            if (blue > 255) blue = 255;
            if (blue < 0) blue = 0; 
        }
    }
}