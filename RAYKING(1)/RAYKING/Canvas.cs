using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace RAYKING
{
    class Canvas
    {
        public Bitmap BMP;
        public float Width, Height;

        public Canvas(int width, int height)
        {
            Init(width, height);
        }

        private void Init(int width, int height)
        {
            BMP = new Bitmap(width, height);
            Width = width;
            Height = height;
        }

        public void FillColumn(int x, Color c)
        {
            unsafe
            {               
                BitmapData bitmapData = BMP.LockBits(new Rectangle(0, 0, BMP.Width, BMP.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
                int bytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(BMP.PixelFormat) / 8;
                int heightInPixels = bitmapData.Height;
                int widthInBytes = bitmapData.Width * bytesPerPixel;
                byte* PtrFirstPixel = (byte*)bitmapData.Scan0;
                x *= 4;

                int tot;
                float h;
                h = (float)c.R / 255;

                tot = bitmapData.Height - (int)((bitmapData.Height * h));
                tot /= 2;

                Parallel.For(tot, bitmapData.Height-tot, y =>
                {
                    byte* bits = PtrFirstPixel + (y * bitmapData.Stride);

                    bits[x + 0] = c.B;//(byte)oldBlue;
                    bits[x + 1] = c.G;// (byte)oldGreen;
                    bits[x + 2] = c.R;// (byte)oldRed;
                    bits[x + 3] = c.A;// (byte)oldALPHA;                    
                });
                BMP.UnlockBits(bitmapData);               
            }
        }

        public void FastClear()
        {
            unsafe
            {
                BitmapData bitmapData = BMP.LockBits(new Rectangle(0, 0, BMP.Width, BMP.Height), ImageLockMode.ReadWrite, BMP.PixelFormat);
                int bytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(BMP.PixelFormat) / 8;
                int heightInPixels = bitmapData.Height;
                int widthInBytes = bitmapData.Width * bytesPerPixel;
                byte* PtrFirstPixel = (byte*)bitmapData.Scan0;

                Parallel.For(0, heightInPixels, y =>
                {
                    byte* bits = PtrFirstPixel + (y * bitmapData.Stride);
                    for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                    {
                        bits[x + 0] = 0;// (byte)oldBlue;
                        bits[x + 1] = 0;// (byte)oldGreen;
                        bits[x + 2] = 0;// (byte)oldRed;
                        bits[x + 3] = 0;// (byte)oldRed;
                    }
                });
                BMP.UnlockBits(bitmapData);
            }
        }
    }
}
