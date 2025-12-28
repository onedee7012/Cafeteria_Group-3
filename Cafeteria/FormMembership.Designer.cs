namespace Cafeteria
{
    partial class FormMembership
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
            this.label27 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvMembership = new System.Windows.Forms.DataGridView();
            this.btlogmem = new Guna.UI2.WinForms.Guna2Button();
            this.tbpoint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbmbdob = new System.Windows.Forms.TextBox();
            this.tbmbid = new System.Windows.Forms.TextBox();
            this.tbfnmb = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.btaddmb = new Guna.UI2.WinForms.Guna2Button();
            this.btupmb = new Guna.UI2.WinForms.Guna2Button();
            this.tbmbpn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btdemb = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMembership)).BeginInit();
            this.SuspendLayout();
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(563, 312);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(0, 50);
            this.label27.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 50);
            this.label1.TabIndex = 26;
            this.label1.Text = "Membership";
            // 
            // dtgvMembership
            // 
            this.dtgvMembership.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMembership.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMembership.Location = new System.Drawing.Point(20, 74);
            this.dtgvMembership.Name = "dtgvMembership";
            this.dtgvMembership.RowHeadersWidth = 51;
            this.dtgvMembership.RowTemplate.Height = 24;
            this.dtgvMembership.Size = new System.Drawing.Size(1343, 358);
            this.dtgvMembership.TabIndex = 27;
            // 
            // btlogmem
            // 
            this.btlogmem.BorderColor = System.Drawing.Color.DarkCyan;
            this.btlogmem.BorderThickness = 2;
            this.btlogmem.CustomBorderColor = System.Drawing.Color.Green;
            this.btlogmem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btlogmem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btlogmem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btlogmem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btlogmem.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btlogmem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogmem.ForeColor = System.Drawing.Color.Green;
            this.btlogmem.Location = new System.Drawing.Point(1170, 21);
            this.btlogmem.Name = "btlogmem";
            this.btlogmem.Size = new System.Drawing.Size(194, 47);
            this.btlogmem.TabIndex = 40;
            this.btlogmem.Text = "LOGOUT";
            this.btlogmem.Click += new System.EventHandler(this.btlogmem_Click);
            // 
            // tbpoint
            // 
            this.tbpoint.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpoint.Location = new System.Drawing.Point(681, 562);
            this.tbpoint.Name = "tbpoint";
            this.tbpoint.ReadOnly = true;
            this.tbpoint.Size = new System.Drawing.Size(158, 34);
            this.tbpoint.TabIndex = 49;
            this.tbpoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(655, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 38);
            this.label2.TabIndex = 48;
            this.label2.Text = "Member point:";
            // 
            // tbmbdob
            // 
            this.tbmbdob.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmbdob.Location = new System.Drawing.Point(357, 570);
            this.tbmbdob.Name = "tbmbdob";
            this.tbmbdob.Size = new System.Drawing.Size(211, 34);
            this.tbmbdob.TabIndex = 47;
            // 
            // tbmbid
            // 
            this.tbmbid.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmbid.Location = new System.Drawing.Point(357, 463);
            this.tbmbid.Name = "tbmbid";
            this.tbmbid.ReadOnly = true;
            this.tbmbid.Size = new System.Drawing.Size(206, 34);
            this.tbmbid.TabIndex = 45;
            // 
            // tbfnmb
            // 
            this.tbfnmb.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfnmb.Location = new System.Drawing.Point(357, 518);
            this.tbfnmb.Name = "tbfnmb";
            this.tbfnmb.Size = new System.Drawing.Size(211, 34);
            this.tbfnmb.TabIndex = 43;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.DarkGreen;
            this.label23.Location = new System.Drawing.Point(133, 570);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(196, 38);
            this.label23.TabIndex = 46;
            this.label23.Text = "Date of birth:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.DarkGreen;
            this.label25.Location = new System.Drawing.Point(159, 463);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(174, 38);
            this.label25.TabIndex = 44;
            this.label25.Text = "Member ID:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.DarkGreen;
            this.label26.Location = new System.Drawing.Point(176, 518);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(154, 38);
            this.label26.TabIndex = 42;
            this.label26.Text = "Full name:";
            // 
            // btaddmb
            // 
            this.btaddmb.AutoRoundedCorners = true;
            this.btaddmb.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btaddmb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btaddmb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btaddmb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btaddmb.FillColor = System.Drawing.Color.DarkGreen;
            this.btaddmb.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btaddmb.ForeColor = System.Drawing.Color.White;
            this.btaddmb.Location = new System.Drawing.Point(1076, 449);
            this.btaddmb.Name = "btaddmb";
            this.btaddmb.Size = new System.Drawing.Size(195, 61);
            this.btaddmb.TabIndex = 50;
            this.btaddmb.Text = "Add";
            // 
            // btupmb
            // 
            this.btupmb.AutoRoundedCorners = true;
            this.btupmb.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btupmb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btupmb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btupmb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btupmb.FillColor = System.Drawing.Color.DarkGreen;
            this.btupmb.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btupmb.ForeColor = System.Drawing.Color.White;
            this.btupmb.Location = new System.Drawing.Point(1076, 518);
            this.btupmb.Name = "btupmb";
            this.btupmb.Size = new System.Drawing.Size(195, 61);
            this.btupmb.TabIndex = 51;
            this.btupmb.Text = "Update";
            // 
            // tbmbpn
            // 
            this.tbmbpn.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmbpn.Location = new System.Drawing.Point(357, 626);
            this.tbmbpn.Name = "tbmbpn";
            this.tbmbpn.Size = new System.Drawing.Size(211, 34);
            this.tbmbpn.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(109, 622);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 38);
            this.label3.TabIndex = 53;
            this.label3.Text = "Phone number:";
            // 
            // btdemb
            // 
            this.btdemb.AutoRoundedCorners = true;
            this.btdemb.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btdemb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btdemb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btdemb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btdemb.FillColor = System.Drawing.Color.DarkGreen;
            this.btdemb.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdemb.ForeColor = System.Drawing.Color.White;
            this.btdemb.Location = new System.Drawing.Point(1076, 585);
            this.btdemb.Name = "btdemb";
            this.btdemb.Size = new System.Drawing.Size(195, 61);
            this.btdemb.TabIndex = 54;
            this.btdemb.Text = "Delete";
            // 
            // FormMembership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 672);
            this.Controls.Add(this.btdemb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbmbpn);
            this.Controls.Add(this.btupmb);
            this.Controls.Add(this.btaddmb);
            this.Controls.Add(this.tbpoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbmbdob);
            this.Controls.Add(this.tbmbid);
            this.Controls.Add(this.tbfnmb);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.btlogmem);
            this.Controls.Add(this.dtgvMembership);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label27);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMembership";
            this.Text = "FormMembership";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMembership)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvMembership;
        private Guna.UI2.WinForms.Guna2Button btlogmem;
        private System.Windows.Forms.TextBox tbpoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbmbdob;
        private System.Windows.Forms.TextBox tbmbid;
        private System.Windows.Forms.TextBox tbfnmb;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private Guna.UI2.WinForms.Guna2Button btaddmb;
        private Guna.UI2.WinForms.Guna2Button btupmb;
        private System.Windows.Forms.TextBox tbmbpn;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btdemb;
    }
}