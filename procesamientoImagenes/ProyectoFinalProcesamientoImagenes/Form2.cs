using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFinalProcesamientoImagenes
{
    public partial class Form2 : Form
    {
        private Bitmap Image;
        private BitmapData ImageData;
        private byte[] buffer;
        private int r, g, b;
        private byte r2, g2, b2, grayscale;
        private byte r3, g3, b3;

        private void btnSepia_Click(object sender, EventArgs e)
        {
            ImageData = Image.LockBits(new Rectangle(0, 0, Image.Width, Image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            buffer = new byte[3 * Image.Width * Image.Height];
            pointer = ImageData.Scan0;
            Marshal.Copy(pointer, buffer, 0, buffer.Length);
            for (int i = 0; i < Image.Height * 3 * Image.Width; i += 3)
            {
                b = (int)((buffer[i]) * .131 + (buffer[i + 1]) * .534 + (buffer[i + 2]) * .272);
                g = (int)((buffer[i]) * .168 + (buffer[i + 1]) * .686 + (buffer[i + 2]) * .349);
                r = (int)((buffer[i]) * .189 + (buffer[i + 1]) * .769 + (buffer[i + 2]) * .393);
                b = (b > 255) ? 255 : b;
                g = (g > 255) ? 255 : g;
                r = (r > 255) ? 255 : r;
                buffer[i] = (byte)b;
                buffer[i + 1] = (byte)g;
                buffer[i + 2] = (byte)r;
            }
            Marshal.Copy(buffer, 0, pointer, buffer.Length);
            Image.UnlockBits(ImageData);
            pictureBox1.Image = Image;
            label1.Text = r.ToString();
            label2.Text = g.ToString();
            label3.Text = b.ToString();
            PBRed.Value = r;
            PBGreen.Value = g;
            PBBlue.Value = b;
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            ImageData = Image.LockBits(new Rectangle(0, 0, Image.Width, Image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            buffer = new byte[3 * Image.Width * Image.Height];
            pointer = ImageData.Scan0;
            Marshal.Copy(pointer, buffer, 0, buffer.Length);
            for (int i = 0; i < Image.Height * 3 * Image.Width; i += 3)
            {
                b = buffer[i];
                g = buffer[i + 1];
                r = buffer[i + 2];
                buffer[i] = (byte)(255 - r);
                buffer[i + 1] = (byte)(255 - g);
                buffer[i + 2] = (byte)(255 - b);
            }
            Marshal.Copy(buffer, 0, pointer, buffer.Length);
            Image.UnlockBits(ImageData);
            pictureBox1.Image = Image;
            label1.Text = r.ToString();
            label2.Text = g.ToString();
            label3.Text = b.ToString();
            PBRed.Value = r;
            PBGreen.Value = g;
            PBBlue.Value = b;
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            ImageData = Image.LockBits(new Rectangle(0, 0, Image.Width, Image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            buffer = new byte[3 * Image.Width * Image.Height];
            pointer = ImageData.Scan0;
            Marshal.Copy(pointer, buffer, 0, buffer.Length);
            for (int i = 0; i < Image.Height * 3 * Image.Width; i += 3)
            {
                b = buffer[i];
                g = buffer[i + 1];
                r = buffer[i + 2];
                grayscale = (byte)((r + g + b) / 3);
                if (grayscale < 128)
                {
                    buffer[i] = 0;
                    buffer[i + 1] = 0;
                    buffer[i + 2] = 0;
                }
                else
                {
                    buffer[i] = 255;
                    buffer[i + 1] = 255;
                    buffer[i + 2] = 255;
                }
            }
            Marshal.Copy(buffer, 0, pointer, buffer.Length);
            Image.UnlockBits(ImageData);
            pictureBox1.Image = Image;
            label1.Text = r.ToString();
            label2.Text = g.ToString();
            label3.Text = b.ToString();
            PBRed.Value = r;
            PBGreen.Value = g;
            PBBlue.Value = b;
        }

        private void btnSolarize_Click(object sender, EventArgs e)
        {
            ImageData = Image.LockBits(new Rectangle(0, 0, Image.Width, Image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            buffer = new byte[3 * Image.Width * Image.Height];
            pointer = ImageData.Scan0;
            Marshal.Copy(pointer, buffer, 0, buffer.Length);
            for (int i = 0; i < Image.Height * 3 * Image.Width; i += 3)
            {
                b3 = buffer[i];
                g3 = buffer[i + 1];
                r3 = buffer[i + 2];
                buffer[i] = (r3 > 127) ? (byte)(255 - r3) : r3;
                buffer[i + 1] = (g3 > 127) ? (byte)(240 - g3) : g3;
                buffer[i + 2] = (b3 > 127) ? (byte)(140 - b3) : b3;
            }
            Marshal.Copy(buffer, 0, pointer, buffer.Length);
            Image.UnlockBits(ImageData);
            pictureBox1.Image = Image;
            label1.Text = r.ToString();
            label2.Text = g.ToString();
            label3.Text = b.ToString();
            PBRed.Value = r;
            PBGreen.Value = g;
            PBBlue.Value = b;
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            ImageData = Image.LockBits(new Rectangle(0, 0, Image.Width, Image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            buffer = new byte[3 * Image.Width * Image.Height];
            pointer = ImageData.Scan0;
            Marshal.Copy(pointer, buffer, 0, buffer.Length);
            for (int i = 0; i < Image.Height * 3 * Image.Width; i += 3)
            {
                b2 = buffer[i];
                g2 = buffer[i + 1];
                r2 = buffer[i + 2];
                grayscale = (byte)((r2 + g2 + b2) / 3);
                buffer[i] = grayscale;
                buffer[i + 1] = grayscale;
                buffer[i + 2] = grayscale;
            }
            Marshal.Copy(buffer, 0, pointer, buffer.Length);
            Image.UnlockBits(ImageData);
            pictureBox1.Image = Image;

            label1.Text = r.ToString();
            label2.Text = g.ToString();
            label3.Text = b.ToString();
            PBRed.Value = r;
            PBGreen.Value = g;
            PBBlue.Value = b;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(sfd.FileName);
            }
        }

        private IntPtr pointer;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {      
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image = new Bitmap(ofd.FileName);
            }
            pictureBox1.Image = Image;
           
        }
    }
}
