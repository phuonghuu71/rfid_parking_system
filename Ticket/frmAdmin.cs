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
    public partial class frmAdmin : Form
    {
        private string textValue = "";
        private string textAccept = "";
        private string next_month = "";
        private string real_time = "";

        BindingSource userList = new BindingSource();
        BindingSource statisList = new BindingSource();
        BindingSource staffList = new BindingSource();

        private Staff getStaffInfo;
        public Staff GetStaffInfo
        {
            get { return getStaffInfo; }
            set { getStaffInfo = value; }
        }

        public frmAdmin(Staff info)
        {
            InitializeComponent();

            autoDeleteExpired();

            this.getStaffInfo = info;

            DateTime today = DateTime.Now;
            dtpFrom.Value = new DateTime(today.Year, today.Month, 1);
            dtpTo.Value = dtpFrom.Value.AddMonths(1).AddDays(-1);

            Loaddtgv();
            AddDataBinding();
            bwInsertUser.WorkerReportsProgress = true;
            bwInsertUser.WorkerSupportsCancellation = true;

            loadCrystalReport();

            cbType.Items.Add("admin");
            cbType.Items.Add("staff");

            if (bwInsertUser.IsBusy != true)
            {
                // Start the asynchronous operation.
                bwInsertUser.RunWorkerAsync();
            }
        }


        #region background_worker
        private void bwInsertUser_DoWork(object sender, DoWorkEventArgs e)
        {


            String location = @"C:\Users\\UwU\source\repos\Ticket\Ticket\note\reader.txt";
            if (File.Exists(location))
            {
                try
                {

                    while (textValue == "")
                    {
                        StreamReader sr = new StreamReader(location);

                        string line = sr.ReadLine();
                        while (line != null)
                        {


                            bwInsertUser.CancelAsync();


                            textValue = line;
                            line = sr.ReadLine();


                        }

                        sr.Close();
                        StreamWriter sw = new StreamWriter(location);
                        sw.Write("");
                        sw.Close();

                        if (textValue == "")
                        {
                            System.Threading.Thread.Sleep(1000);
                        }

                    }

                }
                catch { }



            }
        }

        private void bwInsertUser_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {

                textAccept = textValue;

                txtcardID.Text = textValue;

                next_month = DateTime.Now.AddMonths(1).ToString("yyyy-M-dd HH:mm:ss");
                real_time = DateTime.Now.ToString("yyyy-M-dd HH:mm:ss");
                txtTimeIn.Text = next_month;

                Bitmap myImg;

                string directory = @"C:\Users\UwU\source\repos\Ticket\Ticket\images\";

                int id = Int32.Parse(textAccept[textAccept.Length - 1].ToString()) + Int32.Parse(textAccept[textAccept.Length - 2].ToString());

                directory = directory + id.ToString() + ".png";

                myImg = new Bitmap(directory);

                pbImage.ClientSize = new Size(myImg.Width, myImg.Height);

                pbImage.Image = (Image)myImg;


            }

            catch { }

            textValue = "";

        }


        #endregion


        #region dtgv
        public void Loaddtgv()
        {
            dtgvInsertUser.DataSource = userList;
            LoadListUser();
            dtgvStatistical.DataSource = statisList;
            LoadListStatis();
            dtgvStaff.DataSource = staffList;
            LoadListStaff();

        }
        public void AddDataBinding()
        {
            AddUserBinding();
            AddStaffBinding();
        }
        void AddUserBinding()
        {
            txtcardID.DataBindings.Add(new Binding("Text", dtgvInsertUser.DataSource, "cardID", true, DataSourceUpdateMode.Never));
            txtTimeIn.DataBindings.Add(new Binding("Text", dtgvInsertUser.DataSource, "Time", true, DataSourceUpdateMode.Never));
        }
        void LoadListUser()
        {


            userList.DataSource = UserDAL.Instance.getUserList();
            this.dtgvInsertUser.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvInsertUser.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvInsertUser.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvInsertUser.Columns[0].HeaderText = "cardID";
            this.dtgvInsertUser.Columns[1].HeaderText = "Time";
            this.dtgvInsertUser.Columns[2].HeaderText = "image";


        }
        void LoadListStaff()
        {
            staffList.DataSource = StaffDAL.Instance.getStaffList();

            this.dtgvStaff.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStaff.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStaff.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStaff.Columns[0].HeaderText = "username";
            this.dtgvStaff.Columns[1].HeaderText = "password";
            this.dtgvStaff.Columns[2].HeaderText = "type";
        }
        void AddStaffBinding()
        {
            txtUsername.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "username", true, DataSourceUpdateMode.Never));
            txtPassword.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "password", true, DataSourceUpdateMode.Never));
            cbType.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "type", true, DataSourceUpdateMode.Never));
        }
        void LoadListStatis()
        {

            statisList.DataSource = GuestDAL.Instance.getStatisticalDBByDate(dtpFrom.Value.ToString("yyyy-M-dd"), dtpTo.Value.ToString("yyyy-M-dd"));

            this.dtgvStatistical.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStatistical.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStatistical.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStatistical.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStatistical.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStatistical.Columns[0].HeaderText = "cardID";
            this.dtgvStatistical.Columns[1].HeaderText = "timeIn";
            this.dtgvStatistical.Columns[2].HeaderText = "timeOut";
            this.dtgvStatistical.Columns[3].HeaderText = "type";
            this.dtgvStatistical.Columns[4].HeaderText = "money";

        }
        #endregion



        #region button
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if(textAccept != "")
            {
                int id = Int32.Parse(textAccept[textAccept.Length - 1].ToString()) + Int32.Parse(textAccept[textAccept.Length - 2].ToString());

                String status = "IN";
                String type = "USER";
                Customer myCus = GuestDAL.Instance.getCustomerByID(textAccept);
                if (myCus == null)
                {
                    Customer myCustomer = new Customer(txtcardID.Text, real_time, id.ToString(), status, type);
                    Statistical myStatis = new Statistical(txtcardID.Text, real_time, next_month, type, 200000);
                    GuestDAL.Instance.addtoDB(myCustomer);
                    GuestDAL.Instance.addtoStatisticalDB(myStatis);
                    /*
                    txtcardID.Text = "";
                    txtTimeIn.Text = "";
                    textAccept = "";
                    pbImage.Image = null;
                    */

                    LoadListStatis();
                    Loaddtgv();
                    loadCrystalReport();

                    MessageBox.Show("Thêm tài khoản thành công", "Thành Công");
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Không quét được thẻ", "Lỗi");
            }

            btnCancel.PerformClick();
            //    MessageBox.Show("Không nhận được thẻ", "Lỗi");
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtcardID.Text = "";
            txtTimeIn.Text = "";
            textValue = "";
            textAccept = "";
            pbImage.Image = null;

            if (bwInsertUser.IsBusy != true)
            {
                bwInsertUser.RunWorkerAsync();
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if(bwInsertUser.IsBusy == true) {
                bwInsertUser.CancelAsync();
            }
            frmTicketIn df = new frmTicketIn(GetStaffInfo);
            this.Hide();
            df.ShowDialog();
            this.Close();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadListStatis();
            Loaddtgv();
            loadCrystalReport();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtcardID.Text != "")
            {
                GuestDAL.Instance.deleteCustomerByID(txtcardID.Text);
                //    GuestDAL.Instance.deleteStatisticalByID(txtcardID.Text);

                LoadListStatis();
                Loaddtgv();
                loadCrystalReport();

                MessageBox.Show("Xóa tài khoản thành công", "Thành công");
            }
            else
            {
                MessageBox.Show("Không xóa được tài khoản", "Lỗi");
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string pwd = txtPassword.Text;
            string type = cbType.SelectedItem.ToString();
            if (username != "" && StaffDAL.Instance.getStaffByID(username) != null)
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Lỗi");
            }
            else
            if (pwd != "" && type != "")
            {
                Staff staff = new Staff(username, pwd, type);
                StaffDAL.Instance.addtoStaffDB(staff);
                MessageBox.Show("Thêm tài khoản thành công", "Thành công");
                LoadListStaff();
            }
            else
            {
                MessageBox.Show("Nhập thiếu thông tin", "Lỗi");
            }
        }
        private int adminCount()
        {
            int count = 0;
            List<Staff> getList = StaffDAL.Instance.getStaffList();
            for(int i=0;i<getList.Count;i++)
            {
                if(getList[i].Type.Equals("admin") == true)
                {
                    count++;
                }
            }
            return count;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            if (adminCount() == 1)
            {
                MessageBox.Show("Đây là tài khoản admin duy nhất, không thể xóa", "Lỗi");
            }
            
            else

            if(username != "")
            {
                StaffDAL.Instance.deleteStaffByID(username);
                MessageBox.Show("Xóa tài khoản thành công", "Thành công");
                LoadListStaff();
            }
            else
            {
                MessageBox.Show("Không xóa được tài khoản", "Lỗi");
            }

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string pwd = txtPassword.Text;
            string type = cbType.SelectedItem.ToString();
            if (username != "" && StaffDAL.Instance.getStaffByID(username) == null)
            {
                MessageBox.Show("Tài khoản không tồn tại", "Lỗi");
            }
            else
            if (pwd != "" && type != "")
            {
                Staff staff = new Staff(username, pwd, type);
                StaffDAL.Instance.updateStaffByID(staff);
                MessageBox.Show("Sửa tài khoản thành công", "Thành công");
                LoadListStaff();
            }
            else
            {
                MessageBox.Show("Nhập thiếu thông tin", "Lỗi");
            }

        }

        #endregion

        private void autoDeleteExpired()
        {
           
            int count = 0;
            List<Statistical> getStatisList = GuestDAL.Instance.getStatisticalDBByUser();
            for(int i=0;i<getStatisList.Count;i++)
            {
                if(DateTime.Parse(getStatisList[i].TimeOut).ToString("yyyy-M-dd").Equals(DateTime.Now.ToString("yyyy-M-dd"))) {
                    count++;
                    GuestDAL.Instance.deleteCustomerByID(getStatisList[i].CardID);
                //    GuestDAL.Instance.deleteStatisticalByID(getStatisList[i].CardID);
                }
            }
            if(count > 0)
            {

                MessageBox.Show(string.Format("Đã xóa {0} tài khoản hết hạn", count), "Thông báo");
            }
        }

        private void loadCrystalReport()
        {
            parkingReport pr = new parkingReport();
            pr.SetDataSource(statisList);
            parkingReportViewer.ReportSource = pr;
            parkingReportViewer.Refresh();
        }

    }
}
