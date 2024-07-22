using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoFinalProcesamientoImagenes.Filtros;

namespace ProyectoFinalProcesamientoImagenes
{
    public partial class Form4 : Form
    {

        VideoCapture capture = null;
        Image<Bgr, Byte> currentFrame;
        double duracion;
        double FPS;
        bool IsVideoLoad = false;
        string filtro = "";
        public Form4()
        {
            InitializeComponent();
        }

        private void btnUploadVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string formats = "Videos Files | *.mp4; ";
            openFileDialog.Filter = formats;
            openFileDialog.Title = "Selecciona un video.";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                capture = new VideoCapture(openFileDialog.FileName);
                capture.QueryFrame();
                Mat m = new Mat();
                capture.Read(m);
                currentFrame = m.ToImage<Bgr, byte>();
                currentFrame.Resize(pictureBox1.Width, pictureBox1.Height, Inter.Cubic);
                pictureBox1.Image = currentFrame.ToBitmap();
                duracion = capture.Get(CapProp.FrameCount);
                FPS = capture.Get(CapProp.PosFrames);
                IsVideoLoad = true;
                pictureBox1.BackgroundImage = null;

            }
        }

        private void Reproducir(object sender, EventArgs e)
        {
            if (FPS < duracion - 2)
            {
                Mat m = new Mat();
                capture.Read(m);
                currentFrame = m.ToImage<Bgr, byte>();
                currentFrame.Resize(pictureBox1.Width, pictureBox1.Height, Inter.Cubic);
                FPS = capture.Get(CapProp.PosFrames);
            }
            else
            {
                FPS = 0;
                capture.Set(CapProp.PosFrames, 0);
            }
            switch (filtro)
            {
                case "Sepia":
                    pictureBox1.Image = SepiaRGBW(currentFrame.ToBitmap());
                    break;
                case "Grises":
                    pictureBox1.Image = EscalaGrisesRGBW(currentFrame.ToBitmap());
                    break;
                case "SepiaF":
                    pictureBox1.Image = ColdSepiaRGBW(currentFrame.ToBitmap());
                    break;
                case "Polaroid":
                    pictureBox1.Image = PolaroidRGBW(currentFrame.ToBitmap());
                    break;
                case "Papel":
                    //pictureBox1.Image = PapelViejoRGBW(currentFrame.ToBitmap());
                    break;
                default:
                    pictureBox1.Image = currentFrame.ToBitmap();
                    break;
            }
        }

        private void btnPlayVideo_Click(object sender, EventArgs e)
        {
            if (IsVideoLoad)
            {
                DialogResult result = MessageBox.Show("El video se reproducira indefinidamente.", "Aviso", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    Application.Idle += new EventHandler(Reproducir);
                }
            }
            else
            {
                MessageBox.Show("No se ah cargado ningun video.", "Error");
            }
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            filtro = "Grises";
        }

        private void btnSepia_Click(object sender, EventArgs e)
        {
            filtro = "Sepia";
        }

        private void btnSepiaC_Click(object sender, EventArgs e)
        {
            filtro = "SepiaF";
        }

        private void btnPolaroid_Click(object sender, EventArgs e)
        {
            filtro = "Polaroid";
        }

        private void btnOP_Click(object sender, EventArgs e)
        {
            filtro = "Papel";
        }
    }
}
