using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticket.DAL;
using Ticket.DTO;

namespace Ticket
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            Load += frmLogin_Load;
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }


        #region interface 

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.White;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.White;
            }
        }

        private void txtPwd_Enter(object sender, EventArgs e)
        {

            if (txtPwd.Text == "Password")
            {
                txtPwd.Text = "";
                txtPwd.ForeColor = Color.White;
            }
        }

        private void txtPwd_Leave(object sender, EventArgs e)
        {

            if (txtPwd.Text == "")
            {
                txtPwd.Text = "Password";
                txtPwd.ForeColor = Color.White;
            }
        }
        #endregion

        private bool checkPwd(string username, string pwd)
        {
            Staff getStaffInfo = StaffDAL.Instance.getStaffByID(username);
            return StaffDAL.Instance.login(username, pwd);
        }
        void login()
        {

            String username = txtUsername.Text;
            String pwd = txtPwd.Text;
            if (username != "" && pwd != "")
            {
                if (checkPwd(username, (pwd)) == true)
                {
                    this.Hide();
                    Staff getStaffInfo = StaffDAL.Instance.getStaffByID(username);
                    frmTicketIn df = new frmTicketIn(getStaffInfo);
                    df.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thiếu", "Lỗi");
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister_1 df = new frmRegister_1();
            df.ShowDialog();
            this.Close();
        }
    }
}
  