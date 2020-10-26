using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticket.DAL;
using Ticket.DTO;

namespace Ticket
{
    public partial class frmTicketIn : Form
    {
        private string textValue = "";
        private string textAccept = "";
        private string real_time = "";

        private Staff getStaffInfo;
        public Staff GetStaffInfo
        {
            get { return getStaffInfo; }
            set { getStaffInfo = value; }
        }

        public frmTicketIn(Staff info)
        {
            InitializeComponent();
            this.getStaffInfo = info;
            if(GetStaffInfo.Type.Equals("staff") == true)
            {
                btnAdmin.Visible = false;
            }

            pbProfile.Image = GetStaffInfo.ProfilePic;
            lbFullname.Text = GetStaffInfo.Fullname;
        }

        private void frmTicketIn_Load(object sender, EventArgs e)
        {


            bwTicketIn.WorkerReportsProgress = true;
            bwTicketIn.WorkerSupportsCancellation = true;
//            bwTicketIn.DoWork += new DoWorkEventHandler(bwTicketIn_DoWork);
//            bwTicketIn.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwTicketIn_RunWorkerCompleted);


            if (bwTicketIn.IsBusy != true)
            {
                // Start the asynchronous operation.
                bwTicketIn.RunWorkerAsync();
            }
        }

        #region background_worker
        private void bwTicketIn_DoWork(object sender, DoWorkEventArgs e)
        {


            String location = @"C:\Users\UwU\source\repos\Ticket\Ticket\note\reader.txt";
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


                            bwTicketIn.CancelAsync();


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

        private void bwTicketIn_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {


                textAccept = textValue;

                Customer getCus = GuestDAL.Instance.getCustomerByID(textAccept);

                real_time = DateTime.Now.ToString("yyyy-M-dd HH:mm:ss");



                if (textAccept != null)
                {

                    txtcardID.Text = textAccept;

                    Bitmap myImg;

                    string directory = @"C:\Users\UwU\source\repos\Ticket\Ticket\images\";

                    int id = Int32.Parse(textAccept[textAccept.Length - 1].ToString()) + Int32.Parse(textAccept[textAccept.Length - 2].ToString());

                    directory = directory + id.ToString() + ".png";

                    myImg = new Bitmap(directory);

                    pbImage.ClientSize = new Size(myImg.Width, myImg.Height);

                    pbImage.Image = (Image)myImg;


                    if (getCus != null)
                    {
                        txtType.Text = getCus.Type;

                        if (getCus.Type.ToString().Equals("GUEST") == true)
                        {


                            txtTimeIn.Text = DateTime.Parse(getCus.Time).ToString("yyyy-M-dd HH:mm:ss");
                            txtStatus.Text = getCus.Status.ToString();
                            txtStatusOut.Text = "OUT";
                            txtTimeOut.Text = real_time;
                            txtcardIDOut.Text = textAccept;
                            pbImageOut.ClientSize = new Size(myImg.Width, myImg.Height);
                            pbImageOut.Image = (Image)myImg;
                        }

                        else

                        if (getCus.Type.ToString().Equals("USER") == true && getCus.Status.ToString().Equals("IN") == true)
                        {
                            txtcardID.Text = getCus.CardID;
                            txtStatus.Text = getCus.Status;
                            txtTimeIn.Text = DateTime.Parse(getCus.Time).ToString("yyyy-M-dd HH:mm:ss");

                            txtcardIDOut.Text = getCus.CardID;
                            txtTimeOut.Text = real_time;
                            txtStatusOut.Text = "OUT";
                            pbImageOut.ClientSize = new Size(myImg.Width, myImg.Height);
                            pbImageOut.Image = (Image)myImg;

                        }

                        else

                        if (getCus.Type.ToString().Equals("USER") == true && getCus.Status.ToString().Equals("OUT") == true)
                        {
                            txtcardIDOut.Text = getCus.CardID;
                            txtTimeOut.Text = DateTime.Parse(getCus.Time).ToString("yyyy-M-dd HH:mm:ss");
                            txtStatusOut.Text = getCus.Status;
                            pbImageOut.ClientSize = new Size(myImg.Width, myImg.Height);
                            pbImageOut.Image = (Image)myImg;

                            txtcardID.Text = getCus.CardID;
                            txtTimeIn.Text = real_time;
                            txtStatus.Text = "IN";

                        }

                    }
                    else
                    {
                        txtType.Text = "GUEST";
                        txtTimeIn.Text = real_time;
                        txtStatus.Text = "IN";
                    }

                }

                else
                {
                    MessageBox.Show("Không quét được thẻ", "Lỗi");
                }

                textValue = "";
            }
            catch { }

        }
        #endregion


        #region button
        private void btnAccept_Click(object sender, EventArgs e)
        {

            String status = "IN";
            String type = "GUEST";
            double money = 0;

            if(textAccept != "")
            {

                int id = Int32.Parse(textAccept[textAccept.Length - 1].ToString()) + Int32.Parse(textAccept[textAccept.Length - 2].ToString());

                Customer getCus = GuestDAL.Instance.getCustomerByID(textAccept);

                Customer myCustomer = new Customer(txtcardID.Text, real_time, id.ToString(), status, type);


                if (getCus == null)
                {
                    MessageBox.Show("Thêm vé thành công", "Thành Công");

                    GuestDAL.Instance.addtoDB(myCustomer);

                }

                else

                if (getCus.Type.ToString().Equals("USER") == true && getCus.Status.ToString().Equals("OUT") == true)
                {
                    status = "IN";
                    type = "USER";
                    Customer myUser = new Customer(textAccept, DateTime.Now.ToString("yyyy-M-dd HH:mm:ss"), id.ToString(), status, type);
                    GuestDAL.Instance.updateCustomerByID(myUser);
                    MessageBox.Show(string.Format("Quét thẻ user thành công (vào) \nThời gian vào lúc {0}",real_time), "Thành công");
                }
                else

                if(getCus.Type.ToString().Equals("USER") == true && getCus.Status.ToString().Equals("IN") == true)
                {

                    status = "OUT";
                    type = "USER";
                    Customer myUser = new Customer(textAccept, DateTime.Now.ToString("yyyy-M-dd HH:mm:ss"), id.ToString(), status, type);
                    GuestDAL.Instance.updateCustomerByID(myUser);

                    MessageBox.Show(string.Format("Quét thẻ user thành công (ra) \nThời gian ra lúc {0}", real_time), "Thành công");
                }

                else

                if(getCus.Type.ToString().Equals("GUEST") == true)
                {
                    if (getCus.Status.ToString().Equals("IN") == true)
                    {
                        TimeSpan diff = (DateTime.Parse(DateTime.Parse(real_time).ToString("yyyy-M-dd HH:mm:ss"))).Subtract(DateTime.Parse(DateTime.Parse(getCus.Time).ToString("yyyy-M-dd HH:mm:ss")));
                        money = diff.TotalSeconds * 0.3 + 3000;
                        DialogResult dr = MessageBox.Show(string.Format("Số tiền cần phải trả là {0} đồng \nThời gian xe vào {1}", money, getCus.Time.ToString()), "Trả tiền", MessageBoxButtons.YesNo);
                        switch (dr)
                        {
                            case DialogResult.Yes:
                                Statistical statis = new Statistical(getCus.CardID, DateTime.Parse(getCus.Time).ToString("yyyy-M-dd HH:mm:ss"), real_time, getCus.Type, (int)money);
                                GuestDAL.Instance.addtoStatisticalDB(statis);
                                GuestDAL.Instance.deleteCustomerByID(getCus.CardID);
                                MessageBox.Show("Tính tiền thành công", " Thành công");
                                break;
                            case DialogResult.No:
                                MessageBox.Show("Tính tiền thất bại", " Thất bại");
                                break;
                        }
                    }
                }

                else

                {
                    MessageBox.Show("Mã thẻ đã tồn tại", "Lỗi");
                }


            }

            else
            {
                MessageBox.Show("Không quét được thẻ", "Lỗi");
            }

            cancel();

        }


        void cancel()
        {
            txtcardID.Text = "";
            txtTimeIn.Text = "";
            txtStatus.Text = "";
            pbImage.Image = null;

            txtcardIDOut.Text = "";
            txtTimeOut.Text = "";
            txtStatusOut.Text = "";
            pbImageOut.Image = null;

            txtType.Text = "";

            textValue = "";
            textAccept = "";
            if (bwTicketIn.IsBusy != true)
            {
                bwTicketIn.RunWorkerAsync();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel();
        }


        private void btnAdmin_Click(object sender, EventArgs e)
        {
        //  bwTicketIn.CancelAsync();
        //  if(GetStaffInfo.Type.Equals("admin") == true)
            frmAdmin df = new frmAdmin(GetStaffInfo);
            this.Hide();
            df.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin df = new frmLogin();
            df.ShowDialog();
            this.Close();
        }

        #endregion


    }
}
