namespace Ticket
{
    partial class frmRegister_1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister_1));
            this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFullname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnContinue = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReturn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.beReg1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.HintForeColor = System.Drawing.Color.White;
            this.txtUsername.HintText = "Username";
            this.txtUsername.isPassword = false;
            this.txtUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.txtUsername.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.txtUsername.LineThickness = 4;
            this.txtUsername.Location = new System.Drawing.Point(55, 95);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(390, 60);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtFullname
            // 
            this.txtFullname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFullname.ForeColor = System.Drawing.Color.White;
            this.txtFullname.HintForeColor = System.Drawing.Color.White;
            this.txtFullname.HintText = "Full Name";
            this.txtFullname.isPassword = false;
            this.txtFullname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.txtFullname.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.txtFullname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.txtFullname.LineThickness = 4;
            this.txtFullname.Location = new System.Drawing.Point(55, 275);
            this.txtFullname.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(390, 60);
            this.txtFullname.TabIndex = 5;
            this.txtFullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HintForeColor = System.Drawing.Color.White;
            this.txtPassword.HintText = "Password";
            this.txtPassword.isPassword = true;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.txtPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.txtPassword.LineThickness = 4;
            this.txtPassword.Location = new System.Drawing.Point(55, 455);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(390, 60);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.OnValueChanged += new System.EventHandler(this.txtPassword_OnValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên Của Bạn Là Gì ?\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(53, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 60);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sử dụng tên thật của bạn giúp mọi người dễ dàng nhận ra bạn hơn\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(53, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 60);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hãy nhớ mật khẩu này. Mật khẩu giúp ngăn người lạ sử dụng tài khoản của bạn.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(394, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chọn Mật Khẩu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnContinue
            // 
            this.btnContinue.ActiveBorderThickness = 1;
            this.btnContinue.ActiveCornerRadius = 5;
            this.btnContinue.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(160)))));
            this.btnContinue.ActiveForecolor = System.Drawing.Color.White;
            this.btnContinue.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(160)))));
            this.btnContinue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.btnContinue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContinue.BackgroundImage")));
            this.btnContinue.ButtonText = "Tiếp tục";
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.IdleBorderThickness = 1;
            this.btnContinue.IdleCornerRadius = 5;
            this.btnContinue.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.btnContinue.IdleForecolor = System.Drawing.Color.White;
            this.btnContinue.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.btnContinue.Location = new System.Drawing.Point(55, 525);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(5);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(390, 60);
            this.btnContinue.TabIndex = 13;
            this.btnContinue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(53, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(394, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tên Đăng Nhập Của Bạn Là Gì ?\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnContinue, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtUsername, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtFullname, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnReturn, 1, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 666);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // btnReturn
            // 
            this.btnReturn.ActiveBorderThickness = 1;
            this.btnReturn.ActiveCornerRadius = 5;
            this.btnReturn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(160)))));
            this.btnReturn.ActiveForecolor = System.Drawing.Color.White;
            this.btnReturn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(160)))));
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
            this.btnReturn.ButtonText = "Quay lại";
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.IdleBorderThickness = 1;
            this.btnReturn.IdleCornerRadius = 5;
            this.btnReturn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.btnReturn.IdleForecolor = System.Drawing.Color.White;
            this.btnReturn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.btnReturn.Location = new System.Drawing.Point(55, 595);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(390, 60);
            this.btnReturn.TabIndex = 15;
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // beReg1
            // 
            this.beReg1.ElipseRadius = 15;
            this.beReg1.TargetControl = this;
            // 
            // frmRegister_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegister_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFullname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 btnContinue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuElipse beReg1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnReturn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
    }
}