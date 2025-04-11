﻿namespace WF.Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            BtnClose = new PictureBox();
            BtnMinimize = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            linkLabel1 = new LinkLabel();
            Login = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimize).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 574);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 133);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(276, 305);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // BtnClose
            // 
            BtnClose.AccessibleRole = AccessibleRole.TitleBar;
            BtnClose.BackColor = Color.White;
            BtnClose.BackgroundImageLayout = ImageLayout.None;
            BtnClose.BorderStyle = BorderStyle.Fixed3D;
            BtnClose.ErrorImage = Properties.Resources.fechar_incon;
            BtnClose.Image = Properties.Resources.fechar_incon;
            BtnClose.Location = new Point(973, 12);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(38, 37);
            BtnClose.SizeMode = PictureBoxSizeMode.Zoom;
            BtnClose.TabIndex = 1;
            BtnClose.TabStop = false;
            BtnClose.Click += pictureBox1_Click;
            // 
            // BtnMinimize
            // 
            BtnMinimize.Image = Properties.Resources.minimize_icon_23;
            BtnMinimize.Location = new Point(929, 11);
            BtnMinimize.Name = "BtnMinimize";
            BtnMinimize.Size = new Size(38, 38);
            BtnMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            BtnMinimize.TabIndex = 2;
            BtnMinimize.TabStop = false;
            BtnMinimize.Click += BtnMinimize_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuText;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = SystemColors.GrayText;
            textBox1.Location = new Point(401, 153);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "USUARIO";
            textBox1.Size = new Size(480, 24);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.MenuText;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = SystemColors.GrayText;
            textBox2.Location = new Point(401, 244);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "SENHA";
            textBox2.Size = new Size(480, 24);
            textBox2.TabIndex = 4;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(401, 454);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(90, 25);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            // 
            // Login
            // 
            Login.BackColor = Color.DarkGray;
            Login.FlatStyle = FlatStyle.Popup;
            Login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login.Location = new Point(401, 338);
            Login.Name = "Login";
            Login.Size = new Size(480, 55);
            Login.TabIndex = 6;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(400, 171);
            label1.Name = "label1";
            label1.Size = new Size(285, 25);
            label1.TabIndex = 7;
            label1.Text = "_______________________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(400, 259);
            label2.Name = "label2";
            label2.Size = new Size(285, 25);
            label2.TabIndex = 8;
            label2.Text = "_______________________________________";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1023, 574);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(Login);
            Controls.Add(linkLabel1);
            Controls.Add(BtnMinimize);
            Controls.Add(BtnClose);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.9D;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox BtnClose;
        private PictureBox BtnMinimize;
        private TextBox textBox1;
        private TextBox textBox2;
        private LinkLabel linkLabel1;
        private Button Login;
        private Label label1;
        private Label label2;
    }
}
