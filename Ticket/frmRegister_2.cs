using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticket.DAL;
using Ticket.DTO;

namespace Ticket
{
    public partial class frmRegister_2 : Form
    {
        string imageLocation = "";
        string username = frmRegister_1.setUsername;
        string pwd = frmRegister_1.setPassword;
        string fullname = frmRegister_1.setFullname;
        public frmRegister_2()
        {
            InitializeComponent();
            this.CenterToScreen();

            cbGender.Items.Add("Nam");
            cbGender.Items.Add("Nữ");

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            StaffDAL.Instance.deleteStaffByID(username);

            this.Hide();
            frmLogin df = new frmLogin();
            df.ShowDialog();
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pbProfile.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            string gender = cbGender.SelectedItem.ToString();
            StaffDAL.Instance.updateStaffByID(username, pwd, "staff", fullname, imageLocation, gender);

            MessageBox.Show("Hoàn tất đăng ký", "Thành công");

            this.Hide();
            frmLogin df = new frmLogin();
            df.ShowDialog();
            this.Close();
        }
    }
}
