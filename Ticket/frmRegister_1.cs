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
using Ticket.DAL;
using Ticket.DTO;

namespace Ticket
{
    public partial class frmRegister_1 : Form
    {
        public static string setUsername = "";
        public static string setFullname = "";
        public static string setPassword = "";
        public frmRegister_1()
        {
            InitializeComponent();
        }
        public bool IsPasswordValid(string password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum6Chars = new Regex(@".{6,}");

            var isValidated = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && hasMinimum6Chars.IsMatch(password);
            return isValidated;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin df = new frmLogin();
            df.ShowDialog();
            this.Close();
        }

        private void txtPassword_OnValueChanged(object sender,EventArgs e)
        {
            txtPassword.isPassword = true;

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            setUsername = username;
            string fullname = txtFullname.Text;
            setFullname = fullname;
            string pwd = txtPassword.Text;
            setPassword = pwd;
            if (IsPasswordValid(pwd) == false)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 kí tự phân biệt chữ hoa thường", "Lỗi");
            }
            else if(StaffDAL.Instance.getStaffByID(username) != null)
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Lỗi");
            }
            else
            {
                Staff staff = new Staff(username, pwd, "staff", fullname, null, null);
                StaffDAL.Instance.addtoStaffDB(staff);

                this.Hide();
                frmRegister_2 df = new frmRegister_2();
                df.ShowDialog();
                this.Close();
            }
        }

    }
}
