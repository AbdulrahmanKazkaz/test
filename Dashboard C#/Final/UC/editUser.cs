using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final.UC
{
    public partial class editUser : Form
    {
        public editUser()
        {
            InitializeComponent();
        }

        SqlDatabase sql;
        frmDashboard frm = new frmDashboard();
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool checkTrue = false; // Check to old password is true
            sql = new SqlDatabase();
            sql.Open();
            string check = "select count (*) from [users] where  password='" + txtOldPass.Text + "'";
            int result = sql.RunCommand_int(check);
            if(result > 0)
            {
                checkTrue = true;
            }
            if(checkTrue)
            {
                if(txtPass.Text != null)
                {
                    string editPass = "update [users] set password='" + txtPass.Text + "' where password= '" + txtOldPass.Text + "' ";
                    sql.RunCommand(editPass);
                }
                
                else if(txtEmail.Text != null)
                {
                     string editEmail = "update [users] set email='" + txtEmail.Text + "' where password= '" + txtOldPass.Text + "'";
                     sql.RunCommand(editEmail);
                }
            }
            sql.Close();
            this.Close();
        }
    }
}
