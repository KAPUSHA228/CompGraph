using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Binarization : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int intensity = (int)(0.36 * sourceColor.R + 0.53 * sourceColor.G + 0.11 * sourceColor.B);
            int threshold = 230;
            int resR = 0; int resG = 0; int resB = 0;
            if (intensity > threshold) { resR = resG = resB = 255; }
            else{resR=resG=resB = 0; }
            Color resultColor = Color.FromArgb(resR,resG,resB);
            return resultColor;
        }
    }
}
