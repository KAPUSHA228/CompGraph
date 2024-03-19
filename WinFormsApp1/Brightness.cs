using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Brightness : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            byte constanta = 20;
            Color sourceColor = sourceImage.GetPixel(x, y);
            Color resultColor = Color.FromArgb(Clamp(sourceColor.R + constanta, 0, 255),
                                               Clamp(sourceColor.G + constanta, 0, 255),
                                               Clamp(sourceColor.B + constanta, 0, 255));
            return resultColor;
        }
    }
}
