using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;

namespace Velocidad_Motor
{
    public partial class FrmVelocidad : Form
    {
        //Definición de variables
        bool video, capturar;
        int mframes;
        int nframes;
        byte[] min = { 0, 0, 0 };
        byte[] max = { 255, 255, 255 };
        byte mred, mgreen, mblue, Mred, Mgreen, Mblue;
        double theta;
        double xc, yc;
        Moments moments;
        //Objetos
        Image iframe;
        Image ifframe;
        Mat frame = new Mat();
        Mat fframe = new Mat();
        TimeSpan t0, t1;

        private void txtMinRed_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            capturar = !capturar;
        }

        private void FrmVelocidad_FormClosing(object sender, FormClosingEventArgs e)
        {
            video = false;
        }

        OpenCvSharp.VideoCapture camera = new VideoCapture();

        //Rutinas creadas por el desarrollador
        private void Capturar()
        {
            camera.Open(0);
            MethodInvoker arg = delegate
            {
                if (!byte.TryParse(this.txtMinRed.Text, out mred))
                {
                    return;
                }
                if (!byte.TryParse(txtMaxRed.Text, out Mred))
                {
                    return;
                }
                if (!byte.TryParse(txtMinGreen.Text, out mgreen))
                {
                    return;
                }
                if (!byte.TryParse(txtMaxGreen.Text, out Mgreen))
                {
                    return;
                }
                if (!byte.TryParse(txtMinBlue.Text, out mblue))
                {
                    return;
                }
                if (!byte.TryParse(txtMaxBlue.Text, out Mblue))
                {
                    return;
                }
                min[0] = mred;
                min[1] = mgreen;
                min[2] = mblue;

                max[0] = Mred;
                max[1] = Mgreen;
                max[2] = Mblue;
            };
            MethodInvoker agregar = delegate
            {
                int row = this.dgvDatos.Rows.Add();
                dgvDatos[0, row].Value = t1.TotalSeconds;
                dgvDatos[1, row].Value = theta;
            };

            while (video)
            {
                if (camera.Read(frame))
                {
                    if (capturar)
                    {
                        if (nframes == 0)
                        {
                            t0 = new TimeSpan(DateTime.Now.Ticks);
                        }
                        else
                        {
                            t1 = new TimeSpan(DateTime.Now.Ticks);
                            t1 -= t0;
                        }
                        nframes++;
                    }
                    this.Invoke(arg);
                    fframe = frame.InRange(InputArray.Create(min), InputArray.Create(max));
                    moments = fframe.Moments();
                    xc = moments.M10 / moments.M00;
                    yc = moments.M01 / moments.M00;
                    theta = Math.Atan(2 * moments.Mu11 / (moments.Mu20 - moments.Mu02))/2.0;
                    OpenCvSharp.Cv2.Circle(frame, (int)xc, (int)yc, 50, 255,10);
                    iframe = Image.FromStream(frame.ToMemoryStream());
                    ifframe = Image.FromStream(fframe.ToMemoryStream());
                    if (nframes % 2 == 0)
                    {
                        pictureBox1.Image = iframe;
                        pictureBox2.Image = ifframe;
                    }
                    if(capturar)
                        this.Invoke(agregar);
                }
                else 
                {
                    mframes++;
                }
            }
            frame.Release();
            camera.Release();
        }
        //Rurinas creadas por VS
        public FrmVelocidad()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            video = !video;
            if (video)
            {
                nframes = 0;
                mframes = 0;
                dgvDatos.Rows.Clear();
                System.Threading.Thread hilo = new System.Threading.Thread(new System.Threading.ThreadStart(Capturar));
                hilo.Start();
            }
        }

        private void FrmVelocidad_Load(object sender, EventArgs e)
        {

        }
    }
}
