namespace Cafeteria
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chbshowpass = new System.Windows.Forms.CheckBox();
            this.btlogin = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.tbuser = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(425, 759);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(111, 553);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 64);
            this.label4.TabIndex = 1;
            this.label4.Text = "COFFEE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(582, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "SIGN IN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(473, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(473, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // chbshowpass
            // 
            this.chbshowpass.AutoSize = true;
            this.chbshowpass.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.chbshowpass.Location = new System.Drawing.Point(481, 507);
            this.chbshowpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbshowpass.Name = "chbshowpass";
            this.chbshowpass.Size = new System.Drawing.Size(239, 42);
            this.chbshowpass.TabIndex = 6;
            this.chbshowpass.Text = "Show Password";
            this.chbshowpass.UseVisualStyleBackColor = true;
            this.chbshowpass.CheckedChanged += new System.EventHandler(this.chbshowpass_CheckedChanged);
            // 
            // btlogin
            // 
            this.btlogin.BackColor = System.Drawing.Color.SeaGreen;
            this.btlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btlogin.Location = new System.Drawing.Point(480, 613);
            this.btlogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(168, 65);
            this.btlogin.TabIndex = 7;
            this.btlogin.Text = "LOGIN";
            this.btlogin.UseVisualStyleBackColor = false;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // btexit
            // 
            this.btexit.BackColor = System.Drawing.Color.SeaGreen;
            this.btexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btexit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btexit.Location = new System.Drawing.Point(723, 613);
            this.btexit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(168, 65);
            this.btexit.TabIndex = 8;
            this.btexit.Text = "EXIT";
            this.btexit.UseVisualStyleBackColor = false;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // tbuser
            // 
            this.tbuser.AutoRoundedCorners = true;
            this.tbuser.BorderColor = System.Drawing.Color.CadetBlue;
            this.tbuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbuser.DefaultText = "";
            this.tbuser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbuser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbuser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbuser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbuser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbuser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbuser.ForeColor = System.Drawing.Color.Black;
            this.tbuser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbuser.IconLeft = ((System.Drawing.Image)(resources.GetObject("tbuser.IconLeft")));
            this.tbuser.IconLeftSize = new System.Drawing.Size(32, 20);
            this.tbuser.Location = new System.Drawing.Point(480, 255);
            this.tbuser.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.tbuser.Name = "tbuser";
            this.tbuser.PlaceholderText = "Enter your username";
            this.tbuser.SelectedText = "";
            this.tbuser.Size = new System.Drawing.Size(401, 66);
            this.tbuser.TabIndex = 9;
            // 
            // tbpass
            // 
            this.tbpass.AutoRoundedCorners = true;
            this.tbpass.BorderColor = System.Drawing.Color.CadetBlue;
            this.tbpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbpass.DefaultText = "";
            this.tbpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbpass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbpass.ForeColor = System.Drawing.Color.Black;
            this.tbpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbpass.IconLeft = ((System.Drawing.Image)(resources.GetObject("tbpass.IconLeft")));
            this.tbpass.IconLeftSize = new System.Drawing.Size(32, 20);
            this.tbpass.Location = new System.Drawing.Point(481, 411);
            this.tbpass.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.tbpass.Name = "tbpass";
            this.tbpass.PlaceholderText = "Enter your password";
            this.tbpass.SelectedText = "";
            this.tbpass.Size = new System.Drawing.Size(400, 66);
            this.tbpass.TabIndex = 10;
            this.tbpass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(24, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(382, 80);
            this.label5.TabIndex = 2;
            this.label5.Text = "STARBUCKS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 413);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(-33, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(469, 64);
            this.label6.TabIndex = 4;
            this.label6.Text = ".                                       ";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(-33, -26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(469, 64);
            this.label7.TabIndex = 5;
            this.label7.Text = ".                                       ";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 759);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tbuser);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.chbshowpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbshowpass;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbuser;
        private Guna.UI2.WinForms.Guna2TextBox tbpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}