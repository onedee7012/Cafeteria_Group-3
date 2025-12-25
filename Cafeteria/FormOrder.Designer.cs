namespace Cafeteria
{
    partial class FormOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.lvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbmenu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbeverage = new Guna.UI2.WinForms.Guna2ComboBox();
            this.numquantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btaddb = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.tbtotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbdiscount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbprice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbamount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbchange = new System.Windows.Forms.TextBox();
            this.btpay = new Guna.UI2.WinForms.Guna2Button();
            this.btlogout = new Guna.UI2.WinForms.Guna2Button();
            this.tbstaff = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbmb = new System.Windows.Forms.TextBox();
            this.cbphone = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbidmb = new System.Windows.Forms.TextBox();
            this.tbmp = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numquantity)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbmp);
            this.tabPage3.Controls.Add(this.tbidmb);
            this.tabPage3.Controls.Add(this.tbmb);
            this.tabPage3.Controls.Add(this.cbbeverage);
            this.tabPage3.Controls.Add(this.cbmenu);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.cbphone);
            this.tabPage3.Controls.Add(this.tbstaff);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.btaddb);
            this.tabPage3.Controls.Add(this.numquantity);
            this.tabPage3.Controls.Add(this.lvBill);
            this.tabPage3.Controls.Add(this.flpTable);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1378, 631);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Order";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flpTable
            // 
            this.flpTable.BackColor = System.Drawing.Color.AliceBlue;
            this.flpTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpTable.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpTable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flpTable.Location = new System.Drawing.Point(8, 194);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(414, 424);
            this.flpTable.TabIndex = 10;
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvBill.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBill.GridLines = true;
            this.lvBill.HideSelection = false;
            this.lvBill.Location = new System.Drawing.Point(442, 194);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(447, 424);
            this.lvBill.TabIndex = 12;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Beverage";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total Price";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 80;
            // 
            // cbmenu
            // 
            this.cbmenu.BackColor = System.Drawing.Color.Transparent;
            this.cbmenu.BorderColor = System.Drawing.Color.Teal;
            this.cbmenu.BorderThickness = 2;
            this.cbmenu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbmenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmenu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmenu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cbmenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbmenu.ItemHeight = 30;
            this.cbmenu.Location = new System.Drawing.Point(442, 15);
            this.cbmenu.Name = "cbmenu";
            this.cbmenu.Size = new System.Drawing.Size(220, 36);
            this.cbmenu.TabIndex = 13;
            this.cbmenu.SelectedIndexChanged += new System.EventHandler(this.cbmenu_SelectedIndexChanged);
            // 
            // cbbeverage
            // 
            this.cbbeverage.BackColor = System.Drawing.Color.Transparent;
            this.cbbeverage.BorderColor = System.Drawing.Color.Teal;
            this.cbbeverage.BorderThickness = 2;
            this.cbbeverage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbeverage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbeverage.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbeverage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbeverage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbeverage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbeverage.ItemHeight = 30;
            this.cbbeverage.Location = new System.Drawing.Point(442, 72);
            this.cbbeverage.Name = "cbbeverage";
            this.cbbeverage.Size = new System.Drawing.Size(220, 36);
            this.cbbeverage.TabIndex = 14;
            // 
            // numquantity
            // 
            this.numquantity.BackColor = System.Drawing.Color.Transparent;
            this.numquantity.BorderColor = System.Drawing.Color.Teal;
            this.numquantity.BorderThickness = 2;
            this.numquantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numquantity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.numquantity.Location = new System.Drawing.Point(442, 130);
            this.numquantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numquantity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numquantity.Name = "numquantity";
            this.numquantity.Size = new System.Drawing.Size(220, 48);
            this.numquantity.TabIndex = 15;
            this.numquantity.UpDownButtonFillColor = System.Drawing.Color.LightSeaGreen;
            // 
            // btaddb
            // 
            this.btaddb.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btaddb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btaddb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btaddb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btaddb.FillColor = System.Drawing.Color.DarkCyan;
            this.btaddb.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btaddb.ForeColor = System.Drawing.Color.White;
            this.btaddb.Location = new System.Drawing.Point(692, 15);
            this.btaddb.Name = "btaddb";
            this.btaddb.Size = new System.Drawing.Size(197, 163);
            this.btaddb.TabIndex = 16;
            this.btaddb.Text = "ADD";
            this.btaddb.Click += new System.EventHandler(this.btaddb_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btlogout);
            this.panel2.Controls.Add(this.btpay);
            this.panel2.Controls.Add(this.tbchange);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.tbamount);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.tbprice);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.tbdiscount);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.tbtotal);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(895, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 612);
            this.panel2.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(54, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 31);
            this.label16.TabIndex = 0;
            this.label16.Text = "Total (VND):";
            // 
            // tbtotal
            // 
            this.tbtotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtotal.Location = new System.Drawing.Point(234, 37);
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.ReadOnly = true;
            this.tbtotal.Size = new System.Drawing.Size(207, 38);
            this.tbtotal.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(41, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 31);
            this.label15.TabIndex = 2;
            this.label15.Text = "Discount (%):";
            // 
            // tbdiscount
            // 
            this.tbdiscount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdiscount.Location = new System.Drawing.Point(234, 109);
            this.tbdiscount.Name = "tbdiscount";
            this.tbdiscount.Size = new System.Drawing.Size(207, 38);
            this.tbdiscount.TabIndex = 3;
            this.tbdiscount.TextChanged += new System.EventHandler(this.tbdiscount_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(54, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 31);
            this.label14.TabIndex = 4;
            this.label14.Text = "Price (VND):";
            // 
            // tbprice
            // 
            this.tbprice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbprice.Location = new System.Drawing.Point(234, 181);
            this.tbprice.Name = "tbprice";
            this.tbprice.ReadOnly = true;
            this.tbprice.Size = new System.Drawing.Size(207, 38);
            this.tbprice.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 31);
            this.label13.TabIndex = 6;
            this.label13.Text = "Amount (VND):";
            // 
            // tbamount
            // 
            this.tbamount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbamount.Location = new System.Drawing.Point(234, 253);
            this.tbamount.Name = "tbamount";
            this.tbamount.Size = new System.Drawing.Size(207, 38);
            this.tbamount.TabIndex = 7;
            this.tbamount.TextChanged += new System.EventHandler(this.tbamount_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 31);
            this.label12.TabIndex = 8;
            this.label12.Text = "Change (VND):";
            // 
            // tbchange
            // 
            this.tbchange.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbchange.Location = new System.Drawing.Point(234, 324);
            this.tbchange.Name = "tbchange";
            this.tbchange.ReadOnly = true;
            this.tbchange.Size = new System.Drawing.Size(207, 38);
            this.tbchange.TabIndex = 9;
            // 
            // btpay
            // 
            this.btpay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btpay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btpay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btpay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btpay.FillColor = System.Drawing.Color.DarkCyan;
            this.btpay.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btpay.ForeColor = System.Drawing.Color.White;
            this.btpay.Location = new System.Drawing.Point(135, 416);
            this.btpay.Name = "btpay";
            this.btpay.Size = new System.Drawing.Size(210, 89);
            this.btpay.TabIndex = 10;
            this.btpay.Text = "PAY";
            this.btpay.Click += new System.EventHandler(this.btpay_Click);
            // 
            // btlogout
            // 
            this.btlogout.BorderColor = System.Drawing.Color.DarkCyan;
            this.btlogout.BorderThickness = 2;
            this.btlogout.CustomBorderColor = System.Drawing.Color.Teal;
            this.btlogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btlogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btlogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btlogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btlogout.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btlogout.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogout.ForeColor = System.Drawing.Color.Teal;
            this.btlogout.Location = new System.Drawing.Point(158, 531);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(163, 60);
            this.btlogout.TabIndex = 11;
            this.btlogout.Text = "LOGOUT";
            this.btlogout.Click += new System.EventHandler(this.btlogout_Click);
            // 
            // tbstaff
            // 
            this.tbstaff.BorderColor = System.Drawing.Color.Teal;
            this.tbstaff.BorderThickness = 2;
            this.tbstaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbstaff.DefaultText = "";
            this.tbstaff.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbstaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbstaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbstaff.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbstaff.FillColor = System.Drawing.Color.DarkCyan;
            this.tbstaff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbstaff.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.tbstaff.ForeColor = System.Drawing.Color.White;
            this.tbstaff.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbstaff.Location = new System.Drawing.Point(8, 15);
            this.tbstaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbstaff.Name = "tbstaff";
            this.tbstaff.PlaceholderText = "";
            this.tbstaff.ReadOnly = true;
            this.tbstaff.SelectedText = "";
            this.tbstaff.Size = new System.Drawing.Size(414, 66);
            this.tbstaff.TabIndex = 18;
            this.tbstaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbmb
            // 
            this.tbmb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmb.ForeColor = System.Drawing.Color.Teal;
            this.tbmb.Location = new System.Drawing.Point(88, 140);
            this.tbmb.Name = "tbmb";
            this.tbmb.Size = new System.Drawing.Size(211, 38);
            this.tbmb.TabIndex = 12;
            // 
            // cbphone
            // 
            this.cbphone.ForeColor = System.Drawing.Color.Teal;
            this.cbphone.FormattingEnabled = true;
            this.cbphone.Location = new System.Drawing.Point(138, 95);
            this.cbphone.Name = "cbphone";
            this.cbphone.Size = new System.Drawing.Size(284, 39);
            this.cbphone.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(86, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // tbidmb
            // 
            this.tbidmb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbidmb.ForeColor = System.Drawing.Color.Teal;
            this.tbidmb.Location = new System.Drawing.Point(6, 140);
            this.tbidmb.Name = "tbidmb";
            this.tbidmb.Size = new System.Drawing.Size(76, 38);
            this.tbidmb.TabIndex = 20;
            // 
            // tbmp
            // 
            this.tbmp.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmp.ForeColor = System.Drawing.Color.Teal;
            this.tbmp.Location = new System.Drawing.Point(305, 140);
            this.tbmp.Name = "tbmp";
            this.tbmp.Size = new System.Drawing.Size(117, 38);
            this.tbmp.TabIndex = 23;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1386, 672);
            this.tabControl1.TabIndex = 1;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 672);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOrder";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numquantity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbmp;
        private System.Windows.Forms.TextBox tbidmb;
        private System.Windows.Forms.TextBox tbmb;
        private Guna.UI2.WinForms.Guna2ComboBox cbbeverage;
        private Guna.UI2.WinForms.Guna2ComboBox cbmenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbphone;
        private Guna.UI2.WinForms.Guna2TextBox tbstaff;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btlogout;
        private Guna.UI2.WinForms.Guna2Button btpay;
        private System.Windows.Forms.TextBox tbchange;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbamount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbprice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbdiscount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbtotal;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2Button btaddb;
        private Guna.UI2.WinForms.Guna2NumericUpDown numquantity;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.TabControl tabControl1;
    }
}