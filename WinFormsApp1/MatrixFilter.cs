﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class MatrixFilter : Filters
    {
        protected float[,] kernel = null;
        protected MatrixFilter() { }
        public MatrixFilter(float[,] kernel)
        {
            this.kernel = kernel;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radX = kernel.GetLength(0) / 2;
            int radY = kernel.GetLength(1) / 2;
            float resR = 0;
            float resG = 0;
            float resB = 0;
            for(int l=-radY; l<=radY; l++)
            {
                for(int k=-radX; k<=radX; k++) {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height-1);
                    Color neighbour= sourceImage.GetPixel(idX, idY);
                    resR += neighbour.R * kernel[k + radX, l + radY];
                    resG += neighbour.G * kernel[k + radX, l + radY];
                    resB += neighbour.B * kernel[k + radX, l + radY];
                }
            }
            return Color.FromArgb(
                Clamp((int)resR, 0, 255),
                Clamp((int)resG, 0, 255),
                Clamp((int)resB, 0, 255)
                );
        }
    }
}
