using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Final
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        string userName = "";
        public string User { set { userName = value; } get { return userName; } }
        

        private void frmTest_Load(object sender, EventArgs e)
        {
            camera1.Visible = false;
            dashboard1.Visible = false;

            lblUserLogin.Text = User;
           
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            camera1.Visible = false;
            dashboard1.Visible = true;

        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            camera1.Visible = true;
            dashboard1.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void lblUserLogin_Click(object sender, EventArgs e)
        {
            UC.editUser frm = new UC.editUser();
            frm.ShowDialog();
        }
    }

    }
    

