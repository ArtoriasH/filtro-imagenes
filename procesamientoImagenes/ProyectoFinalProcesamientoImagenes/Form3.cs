using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.Reg;
using Emgu.CV.Structure;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFinalProcesamientoImagenes
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        /*
        FilterInfoCollection filter;
        VideoCaptureDevice device;
        private Bitmap Image;
        private BitmapData ImageData;
        private byte[] buffer;
        private int r, g, b;
        private byte r2, g2, b2, grayscale;
        private byte r3, g3, b3;
        private IntPtr pointer;*/

        private bool HayDispositivos;
        private FilterInfoCollection MisDispositivos;
        private VideoCaptureDevice MiWebCam;
        private Random rnd = new Random();
        int contador = 0;

        private void Form3_Load(object sender, EventArgs e)
        {
            /*
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filter)
                cbDevice.Items.Add(device);
            cbDevice.SelectedIndex = 0;
            device = new VideoCaptureDevice();*/
        }
        
        static readonly CascadeClassifier cascadeClassifier= new CascadeClassifier("C:\\Users\\humbe\\Downloads\\ProyectoFinalProcesamientoImagenes\\ProyectoFinalProcesamientoImagenes\\haarcascade_frontalface_alt_tree.xml");
        private void btnOn_Click(object sender, EventArgs e)
        {
            CerrarWebCam();
            int i = cbDevice.SelectedIndex;
            string Nombre = MisDispositivos[i].MonikerString;
            MiWebCam = new VideoCaptureDevice(Nombre);
            MiWebCam.NewFrame += new NewFrameEventHandler(capturar);
            MiWebCam.Start();

            /*
            device = new VideoCaptureDevice(filter[cbDevice.SelectedIndex].MonikerString);
            device.NewFrame += Device_NewFrame;
            device.Start();*/
        }

        private void Deteccion_Load(object sender, EventArgs e)
        {
            cargarDispositivos();

        }
        public void cargarDispositivos()
        {
            MisDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (MisDispositivos.Count > 0)
            {
                HayDispositivos = true;
                for (int i = 0; i < MisDispositivos.Count; i++)
                {
                    cbDevice.Items.Add(MisDispositivos[i].Name.ToString());
                }
                cbDevice.Text = MisDispositivos[0].Name.ToString();
            }
            else
            {
                HayDispositivos = false;
            }
        }
        public void CerrarWebCam()
        {
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                MiWebCam.SignalToStop();
                MiWebCam = null;
            }
        }

        //static readonly CascadeClassifier cascadeClass = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");


        private void capturar(object sender, NewFrameEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Bitmap Bit = (Bitmap)e.Frame.Clone();
            Image<Bgr, byte> gray = Bit.ToImage<Bgr, byte>();
            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(gray, 1.2, 1);
            foreach (Rectangle rectangle in rectangles)
            {
                using (Graphics graphics = Graphics.FromImage(Bit))
                {
                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    using (Pen pen = new Pen(randomColor, 5))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                    }
                    contador += 1;
                }
            }
            lblContador.Text = contador.ToString();
            contador = 0;
            pictureBox1.Image = Bit;
        }
        /*
        private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            //Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);
            Image<Bgr, Byte> grayImage = bitmap.ToImage<Bgr, byte>();
            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1);
            foreach (Rectangle rectangle in rectangles)
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Pen pen = new Pen(Color.Red, 1))
                    {
                        graphics.DrawRectangle(pen, rectangle);

                    }
                   
                }
            }
           
            pictureBox1.Image = bitmap;
            //Image = bitmap; 
            
        }*/

        private void btnGray_Click(object sender, EventArgs e)
        {
           
        }
    }
}
