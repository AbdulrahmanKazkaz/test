using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace Final
{
    public partial class frmSendEmail : Form
    {
        public frmSendEmail()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SqlDatabase sql = new SqlDatabase();
            sql.Open();
            string checkUser = "select count (*) from users where username='" + txtUserEmail.Text + "'";
            int result = Convert.ToInt32(sql.RunCommand_int(checkUser));
            if(result > 0)
            {

                // Get Information

                string getEmail = "select email from [Users] where username='" + txtUserEmail.Text + "'";
                string email = sql.RunCommand_string(getEmail);
                string getPassword = "select password from [Users] where username='" + txtUserEmail.Text + "'";
                string password = sql.RunCommand_string(getPassword);

                // Send Message

                var fromAddress = new MailAddress("Your Email", "Mixing Machine");

                var toAddress = new MailAddress(email, "Abdulrahman");

                const string fromPassword = "Your Password";

                const string subject = "Reset Password From Login ";

                string body = "Hello , My Password Is " + password;

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }

                labSucssess.Text = "Send Message :) ";
            }

            else
            {

                labSucssess.Text = "Error Username";
            }

            sql.Close();

        }

        // Events
        void Enter1(object sender, EventArgs e)
        {
            if (txtUserEmail.Text == "Username")
            {
                txtUserEmail.Text = string.Empty;
            }


        }
        void Leave1(object sender, EventArgs e)
        {
            if (txtUserEmail.Text == string.Empty)
            {
                txtUserEmail.Text = "Username";
            }

        }

        private void labClose_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Close();
        }

        private void txtUserEmail_Click(object sender, EventArgs e)
        {
            labSucssess.Text = "";
        }
    }
    }
