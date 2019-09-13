using System;
using System.Drawing;
using System.Windows.Forms;
using DarrenLee.Media;

namespace Final.UC
{
    public partial class Camera : UserControl
    {
        DarrenLee.Media.Camera mycamera = new DarrenLee.Media.Camera();

        public Camera()
        {
            InitializeComponent();
            btnStop.Enabled = false;
            GetInfo();
            mycamera.OnFrameArrived += Mycamera_OnFrameArrived;
            picImage.Image = null;
            mycamera.Stop();

        }

        void GetInfo()
        {
            var cameraDevices = mycamera.GetCameraSources();
            var resolutions = mycamera.GetSupportedResolutions();

            foreach (var d in cameraDevices)
            {
                comDevices.Items.Add(d);
            }
            foreach (var d in resolutions)
            {
                comResolution.Items.Add(d);
            }

            comDevices.SelectedIndex = 0;
            comResolution.SelectedIndex = 4;

        }
        private void Mycamera_OnFrameArrived(object source, FrameArrivedEventArgs e)
        {
            Image img = e.GetFrame();
            picImage.Image = img;
        }

        private void comDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            mycamera.ChangeCamera(comDevices.SelectedIndex);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            comDevices.Enabled = false;
            comResolution.Enabled = false;

            mycamera.Start(comResolution.SelectedIndex);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            comDevices.Enabled = true;
            comResolution.Enabled = true;
            mycamera.Stop();
            picImage.Image = null;
        }
    }
}
