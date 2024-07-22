using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using ProyectoFinalProcesamientoImagenes.Properties;

namespace ProyectoFinalProcesamientoImagenes
{
    public class Filtros
    {
        public static Bitmap Sepia(Bitmap bmp)
        {
            //get image dimension
            int width = bmp.Width;
            int height = bmp.Height;

            //color of pixel
            Color p;

            //sepia
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //get pixel value
                    p = bmp.GetPixel(x, y);

                    //extract pixel component ARGB
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //calculate temp value
                    int tr = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                    int tg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                    int tb = (int)(0.272 * r + 0.534 * g + 0.131 * b);

                    //set new RGB value
                    if (tr > 255)
                    {
                        r = 255;
                    }
                    else
                    {
                        r = tr;
                    }

                    if (tg > 255)
                    {
                        g = 255;
                    }
                    else
                    {
                        g = tg;
                    }

                    if (tb > 255)
                    {
                        b = 255;
                    }
                    else
                    {
                        b = tb;
                    }

                    //set the new RGB value in image pixel
                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            return bmp;
        }
        public static Bitmap ByN(Bitmap bmp)
        {
            int width = bmp.Width;
            int height = bmp.Height;
            for (int i = 0; i < width; i++)
            {
                for (int e = 0; e < height; e++)
                {
                    Color col = bmp.GetPixel(i, e);
                    int inten = (col.R+col.B+col.G)/3;
                    if (inten > 255)
                        inten = 255;
                    Color n= Color.FromArgb(inten,inten,inten);
                    bmp.SetPixel(i, e, n);
                }
            }
            return bmp;
        }
        public static Bitmap Rojizo(Bitmap bmp)
        {
            int width = bmp.Width;
            int height = bmp.Height;
            for (int i = 0; i < width; i++)
            {
                for (int e = 0; e < height; e++)
                {
                    Color col = bmp.GetPixel(i, e);
                    int inten = (col.R + col.B + col.G) / 3;
                    if (inten > 255)
                        inten = 255;
                    Color n = Color.FromArgb(100, inten, inten);
                    bmp.SetPixel(i, e, n);
                }
            }
            return bmp;
        }
        public static Bitmap Azul(Bitmap bmp)
        {
            int width = bmp.Width;
            int height = bmp.Height;
            for (int i = 0; i < width; i++)
            {
                for (int e = 0; e < height; e++)
                {
                    Color col = bmp.GetPixel(i, e);
                    int inten = (col.R + col.B + col.G) / 3;
                    if (inten > 255)
                        inten = 255;
                    Color n = Color.FromArgb(inten, inten, 100);
                    bmp.SetPixel(i, e, n);
                }
            }
            return bmp;
        }
        public static Bitmap Verde(Bitmap bmp)
        {
            int width = bmp.Width;
            int height = bmp.Height;
            for (int i = 0; i < width; i++)
            {
                for (int e = 0; e < height; e++)
                {
                    Color col = bmp.GetPixel(i, e);
                    int inten = (col.R + col.B + col.G) / 3;
                    if (inten > 255)
                        inten = 255;
                    Color n = Color.FromArgb(inten, 100, inten);
                    bmp.SetPixel(i, e, n);
                }
            }
            return bmp;
        }
        public static Bitmap Negativo(Bitmap bmp)
        {
            return bmp;
        }
        public static Bitmap Icono(Bitmap bmp)
        {
            // Bitmap con la imagen binaria
            int width = bmp.Width;
            int height = bmp.Height;
            // Recorrer pixel de la imagen
            for (int i = 0; i < width; i++)
            {
                for (int e = 0; e < height; e++)
                {
                    // Color del pixel
                    Color col = bmp.GetPixel(i, e);
                    //Escala de grises
                    byte gray = (byte)(col.R * 0.3f + col.G * 0.59f + col.B * 0.11f);
                    // Blanco o negro
                    byte value = 0;
                    if (gray > 145)
                    {
                        value = 255;
                    }
                    // Asginar nuevo color
                    Color newColor = System.Drawing.Color.FromArgb(value, value, value);
                    bmp.SetPixel(i, e, newColor);

                }
            }
            bmp.MakeTransparent(Color.White);
            return bmp;
        }
        public static Bitmap ByN2(Bitmap bmp)
        {
            // Bitmap con la imagen binaria
            int width = bmp.Width;
            int height = bmp.Height;
            // Recorrer pixel de la imagen
            for (int i = 0; i < width; i++)
            {
                for (int e = 0; e < height; e++)
                {
                    // Color del pixel
                    Color col = bmp.GetPixel(i, e);
                    //Escala de grises
                    byte gray = (byte)(col.R * 0.3f + col.G * 0.59f + col.B * 0.11f);
                    // Blanco o negro
                    byte value = 0;
                    if (gray > 135)
                    {
                        value = 255;
                    }
                    // Asginar nuevo color
                    Color newColor = System.Drawing.Color.FromArgb(value, value, value);
                    bmp.SetPixel(i, e, newColor);

                }
            }
            return bmp;
        }

        public static Bitmap SepiaRGBW(Bitmap bit)
        {
            Image img =bit;
            Bitmap bmpinverted = new Bitmap(img.Width, img.Height);

            ImageAttributes Ia = new ImageAttributes();
            float[][] colorMatrixElements = {
                                              new float[] {.393f, .349f, .272f, 0, 0},
                                 new float[] {.769f, .686f, .534f, 0, 0},
                                 new float[] {.189f, .168f, .131f, 0, 0},
                                 new float[] {0, 0, 0, 1, 0},
                                 new float[] {0, 0, 0, 0, 1}};
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            Ia.SetColorMatrix(colorMatrix);
            Graphics Gr = Graphics.FromImage(bmpinverted);
            Gr.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, Ia);
            Gr.Dispose();
            return bmpinverted;
        }
        public static Bitmap ColdSepiaRGBW(Bitmap bit)
        {
            Image img = bit;
            Bitmap bmpinverted = new Bitmap(img.Width, img.Height);

            ImageAttributes Ia = new ImageAttributes();
            float[][] colorMatrixElements = {
                                 new float[] {.189f, .168f, .131f, 0, 0},
                                 new float[] {.393f, .349f, .272f, 0, 0},
                                 new float[] {.189f, .393f, 1, 0, 0},
                                 new float[] {0, 0, 0, 1, 0},
                                 new float[] {0, 0, 0, 0, 1}};
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            Ia.SetColorMatrix(colorMatrix);
            Graphics Gr = Graphics.FromImage(bmpinverted);
            Gr.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, Ia);
            Gr.Dispose();
            return bmpinverted;
        }

        public static Bitmap PolaroidRGBW(Bitmap bit)
        {
            Image img = bit;
            Bitmap bmpinverted = new Bitmap(img.Width, img.Height);

            ImageAttributes Ia = new ImageAttributes();
            float[][] colorMatrixElements = {
                                              new float[] {1.438f,-.062f, -.062f, 0, 0},
                                 new float[] {-.122f,1.378f,-.122f, 0, 0},
                                 new float[] {-0.016f, -0.016f, 1.483f, 0, 0},
                                 new float[] {0, 0, 0, 1, 0},
                                 new float[] {-0.03f, 0.05f, -0.02f, 0, 1}};
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            Ia.SetColorMatrix(colorMatrix);
            Graphics Gr = Graphics.FromImage(bmpinverted);
            Gr.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, Ia);
            Gr.Dispose();
            return bmpinverted;
        }
        
        /*
        public static Bitmap PapelViejoRGBW(Bitmap bit)
        {
            Image OldPaper = Resources.ColorMatrixOldPaper__1_;
            ImageAttributes OldIa = new ImageAttributes();
            float[][] OldcolorMatrixElements = {
                                              new float[] {1, 0, 0, 0, 0},
                                 new float[] {0, 1, 0, 0, 0},
                                 new float[] {0, 0, 1, 0, 0},
                                 new float[] {0, 0, 0, 1, 0},
                                 new float[] {0, 0, 0, 0, 1}};
            ColorMatrix OldM = new ColorMatrix(OldcolorMatrixElements);
            OldIa.SetColorMatrix(OldM);
            Image img = bit;

            OldPaper = new Bitmap(OldPaper,img.Width,img.Height);
            Bitmap bmpinverted = new Bitmap(img.Width, img.Height);
            ImageAttributes Ia = new ImageAttributes();
            float[][] colorMatrixElements = {
                                              new float[] {2, 0, 0, 0, 0},
                                 new float[] {0, 2, 0, 0, 0},
                                 new float[] {0, 0, 2, 0, 0},
                                 new float[] {0, 0, 0, .5f, 0},
                                 new float[] {-0.1f, -0.1f, -0.1f, 0, 1}};
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            Ia.SetColorMatrix(colorMatrix);
            Graphics Gr = Graphics.FromImage(bmpinverted);
            Gr.DrawImage(OldPaper, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, OldIa);
            Gr.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, Ia);
            Gr.Dispose();
          
            return bmpinverted;
        }*/
        public static Bitmap EscalaGrisesRGBW(Bitmap bit)
        {
            Image img = bit;
            Bitmap bmpinverted = new Bitmap(img.Width, img.Height);

            ImageAttributes Ia = new ImageAttributes();
            float[][] colorMatrixElements = {
                                              new float[] {.3f, .3f, .3f, 0, 0},
                                 new float[] {.59f, .59f, .59f, 0, 0},
                                 new float[] {.11f, .11f, .11f, 0, 0},
                                 new float[] {0, 0, 0, 1, 0},
                                 new float[] {0, 0, 0, 0, 1}};
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            Ia.SetColorMatrix(colorMatrix);
            Graphics Gr = Graphics.FromImage(bmpinverted);
            Gr.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, Ia);
            Gr.Dispose();
            return bmpinverted;
        }
    }
}
