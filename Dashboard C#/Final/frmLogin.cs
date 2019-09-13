using Final.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class frmLogin : Form
    {
        frmSendEmail frm2 = new frmSendEmail();
        frmDashboard frm3 = new frmDashboard();
        UC.editUser frm4 = new editUser();


        public frmLogin()
        {
            InitializeComponent();
            picLock.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlDatabase sql = new SqlDatabase();
            sql.Open();
            string checklogin = "select count (*) from [users] where username='" + txtUser.Text + "' and password='" + txtPassword.Text + "'";
            int result = Convert.ToInt32(sql.RunCommand_int(checklogin));
            if(result > 0)
            {       
                this.Hide();
                frm2.Hide();
                frm3.User = txtUser.Text;  // Send Username to frmDashboard
                frm3.Show();
                
            }
            else
            {
                labError.Text = "invalid username or password";
            }

            sql.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            frm2.Show();
        }

        private void labExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frm2.Left += 10;
            if (frm2.Left >= 760)
            {
                timer1.Stop();
                this.TopMost = false;
                frm2.TopMost = true;
                timer2.Start();
            }
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            frm2.Left -= 10;
            if (frm2.Left <= 530)
            {
                timer2.Stop();
            }
        }

        // Events

        /////////////////////////////////////////

        void Enter1(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username")
            {
                txtUser.Text = string.Empty;
            }
            labError.Text = "";
        }
        void Leave1(object sender, EventArgs e)
        {
            if (txtUser.Text == string.Empty)
            {
                txtUser.Text = "Username";
            }
            labError.Text = "";
        }
        void Enter2(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.PasswordChar = '*';
                picLock.Enabled = true;
                txtPassword.Text = string.Empty;
            }
            labError.Text = "";
        }
        void Leave2(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.PasswordChar = '\0';
                picLock.Enabled = false;
                txtPassword.Text = "Password";
            }
            labError.Text = "";
        }

        private void picLock_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                picLock.Image = Properties.Resources.show;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                picLock.Image = Properties.Resources._lock;
            }
        }

    }
}
