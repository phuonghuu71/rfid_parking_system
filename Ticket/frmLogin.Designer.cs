﻿namespace Ticket
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnRegister = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnExit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtUsername.Location = new System.Drawing.Point(96, 156);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(364, 23);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "Username";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPwd.Location = new System.Drawing.Point(96, 214);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(364, 23);
            this.txtPwd.TabIndex = 3;
            this.txtPwd.Text = "Password";
            this.txtPwd.Enter += new System.EventHandler(this.txtPwd_Enter);
            this.txtPwd.Leave += new System.EventHandler(this.txtPwd_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.panel1.Location = new System.Drawing.Point(60, 182);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 4);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.panel2.Location = new System.Drawing.Point(60, 240);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 4);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(126, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 55);
            this.label2.TabIndex = 9;
            this.label2.Text = "BÃI GIỮ XE";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnRegister
            // 
            this.btnRegister.ActiveBorderThickness = 1;
            this.btnRegister.ActiveCornerRadius = 5;
            this.btnRegister.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(160)))));
            this.btnRegister.ActiveForecolor = System.Drawing.Color.White;
            this.btnRegister.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(160)))));
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.ButtonText = "Đăng ký";
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.IdleBorderThickness = 1;
            this.btnRegister.IdleCornerRadius = 5;
            this.btnRegister.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.btnRegister.IdleForecolor = System.Drawing.Color.White;
            this.btnRegister.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.btnRegister.Location = new System.Drawing.Point(60, 400);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(400, 60);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnExit
            // 
            this.btnExit.ActiveBorderThickness = 1;
            this.btnExit.ActiveCornerRadius = 5;
            this.btnExit.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(160)))));
            this.btnExit.ActiveForecolor = System.Drawing.Color.White;
            this.btnExit.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(160)))));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.ButtonText = "Thoát";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IdleBorderThickness = 1;
            this.btnExit.IdleCornerRadius = 5;
            this.btnExit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.btnExit.IdleForecolor = System.Drawing.Color.White;
            this.btnExit.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.btnExit.Location = new System.Drawing.Point(60, 500);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(400, 60);
            this.btnExit.TabIndex = 12;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 5;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(160)))));
            this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(160)))));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Đăng nhập";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 5;
            this.btnLogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.btnLogin.IdleForecolor = System.Drawing.Color.White;
            this.btnLogin.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.btnLogin.Location = new System.Drawing.Point(60, 300);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(400, 60);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ticket.Properties.Resources.lock_solid;
            this.pictureBox2.Location = new System.Drawing.Point(60, 207);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ticket.Properties.Resources.user_alt_solid1;
            this.pictureBox1.Location = new System.Drawing.Point(60, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegister;
    }
}