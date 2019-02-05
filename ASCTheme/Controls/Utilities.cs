using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCTheme.Controls
{
    public class Utilities
    {
        public static Bitmap Hue(Bitmap input, int r = 255, int g = 255, int b = 255)
        {
            Bitmap bitmap = new Bitmap(input.Width, input.Height);
            for (int i = 0; i < input.Width; i++)
            {
                for (int j = 0; j < input.Height; j++)
                {
                    Color pixel = input.GetPixel(i, j);
                    int num = (int)((double)pixel.R * 0.3 + (double)pixel.G * 0.59 + (double)pixel.B * 0.11);
                    bitmap.SetPixel(i, j, Color.FromArgb((int)pixel.A, r, g, b));
                }
            }
            return bitmap;
        }
    }
}
