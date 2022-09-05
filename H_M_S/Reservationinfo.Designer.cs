
namespace WindowsFormsApp1
{
    partial class Reservationinfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservationinfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReservationGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.reseridlb = new System.Windows.Forms.TextBox();
            this.datein = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateout = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.reservationsearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ReserDeletebtn = new System.Windows.Forms.Button();
            this.ReserEditbtn = new System.Windows.Forms.Button();
            this.ReserAddbtn = new System.Windows.Forms.Button();
            this.Roomcb = new System.Windows.Forms.ComboBox();
            this.Clientcb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Roomcombo = new System.Windows.Forms.ComboBox();
            this.backbtn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 106);
            this.panel1.TabIndex = 3;
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.ForeColor = System.Drawing.SystemColors.Info;
            this.Datelbl.Location = new System.Drawing.Point(687, 80);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(60, 26);
            this.Datelbl.TabIndex = 0;
            this.Datelbl.Text = "Date ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(222, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation information";
            // 
            // ReservationGridView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ReservationGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ReservationGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReservationGridView.BackgroundColor = System.Drawing.Color.White;
            this.ReservationGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReservationGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReservationGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReservationGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ReservationGridView.ColumnHeadersHeight = 24;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReservationGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.ReservationGridView.EnableHeadersVisualStyles = false;
            this.ReservationGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReservationGridView.Location = new System.Drawing.Point(335, 166);
            this.ReservationGridView.Name = "ReservationGridView";
            this.ReservationGridView.RowHeadersVisible = false;
            this.ReservationGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReservationGridView.Size = new System.Drawing.Size(513, 385);
            this.ReservationGridView.TabIndex = 23;
            this.ReservationGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ReservationGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ReservationGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ReservationGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ReservationGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ReservationGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ReservationGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReservationGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.ReservationGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ReservationGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ReservationGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ReservationGridView.ThemeStyle.HeaderStyle.Height = 24;
            this.ReservationGridView.ThemeStyle.ReadOnly = false;
            this.ReservationGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ReservationGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReservationGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ReservationGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ReservationGridView.ThemeStyle.RowsStyle.Height = 22;
            this.ReservationGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReservationGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ReservationGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReservationGridView_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(17, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "Reservation Id";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // reseridlb
            // 
            this.reseridlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reseridlb.Location = new System.Drawing.Point(166, 167);
            this.reseridlb.Name = "reseridlb";
            this.reseridlb.Size = new System.Drawing.Size(155, 26);
            this.reseridlb.TabIndex = 24;
            this.reseridlb.TextChanged += new System.EventHandler(this.staffidlb_TextChanged);
            // 
            // datein
            // 
            this.datein.CalendarFont = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datein.CalendarForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.datein.CalendarTitleBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.datein.CalendarTitleForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.datein.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datein.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datein.Location = new System.Drawing.Point(102, 348);
            this.datein.Name = "datein";
            this.datein.Size = new System.Drawing.Size(219, 22);
            this.datein.TabIndex = 25;
            this.datein.ValueChanged += new System.EventHandler(this.datein_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.CalendarForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePicker2.CalendarTitleForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePicker2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(163, 345);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(84, 22);
            this.dateTimePicker2.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(12, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date Out";
            // 
            // dateout
            // 
            this.dateout.CalendarFont = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateout.CalendarForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateout.CalendarTitleBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateout.CalendarTitleForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateout.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateout.Location = new System.Drawing.Point(102, 387);
            this.dateout.Name = "dateout";
            this.dateout.Size = new System.Drawing.Size(219, 22);
            this.dateout.TabIndex = 25;
            this.dateout.ValueChanged += new System.EventHandler(this.dateout_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(802, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchbtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchbtn.Location = new System.Drawing.Point(721, 122);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 34);
            this.searchbtn.TabIndex = 33;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // reservationsearch
            // 
            this.reservationsearch.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationsearch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.reservationsearch.Location = new System.Drawing.Point(560, 126);
            this.reservationsearch.Name = "reservationsearch";
            this.reservationsearch.Size = new System.Drawing.Size(155, 25);
            this.reservationsearch.TabIndex = 32;
            this.reservationsearch.Text = "Res Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(17, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Date In";
            // 
            // ReserDeletebtn
            // 
            this.ReserDeletebtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ReserDeletebtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReserDeletebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReserDeletebtn.Location = new System.Drawing.Point(230, 454);
            this.ReserDeletebtn.Name = "ReserDeletebtn";
            this.ReserDeletebtn.Size = new System.Drawing.Size(88, 34);
            this.ReserDeletebtn.TabIndex = 36;
            this.ReserDeletebtn.Text = "DELETE";
            this.ReserDeletebtn.UseVisualStyleBackColor = false;
            this.ReserDeletebtn.Click += new System.EventHandler(this.ReserDeletebtn_Click);
            // 
            // ReserEditbtn
            // 
            this.ReserEditbtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ReserEditbtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReserEditbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReserEditbtn.Location = new System.Drawing.Point(125, 454);
            this.ReserEditbtn.Name = "ReserEditbtn";
            this.ReserEditbtn.Size = new System.Drawing.Size(75, 34);
            this.ReserEditbtn.TabIndex = 37;
            this.ReserEditbtn.Text = "EDIT";
            this.ReserEditbtn.UseVisualStyleBackColor = false;
            this.ReserEditbtn.Click += new System.EventHandler(this.ReserEditbtn_Click);
            // 
            // ReserAddbtn
            // 
            this.ReserAddbtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ReserAddbtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReserAddbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReserAddbtn.Location = new System.Drawing.Point(22, 454);
            this.ReserAddbtn.Name = "ReserAddbtn";
            this.ReserAddbtn.Size = new System.Drawing.Size(75, 34);
            this.ReserAddbtn.TabIndex = 38;
            this.ReserAddbtn.Text = "ADD";
            this.ReserAddbtn.UseVisualStyleBackColor = false;
            this.ReserAddbtn.Click += new System.EventHandler(this.ReserAddbtn_Click);
            // 
            // Roomcb
            // 
            this.Roomcb.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roomcb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Roomcb.FormattingEnabled = true;
            this.Roomcb.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple Family"});
            this.Roomcb.Location = new System.Drawing.Point(166, 276);
            this.Roomcb.Name = "Roomcb";
            this.Roomcb.Size = new System.Drawing.Size(155, 30);
            this.Roomcb.TabIndex = 39;
            this.Roomcb.Text = "Room Num";
            // 
            // Clientcb
            // 
            this.Clientcb.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientcb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Clientcb.FormattingEnabled = true;
            this.Clientcb.Location = new System.Drawing.Point(166, 220);
            this.Clientcb.Name = "Clientcb";
            this.Clientcb.Size = new System.Drawing.Size(155, 30);
            this.Clientcb.TabIndex = 39;
            this.Clientcb.Text = "Client Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(17, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "Client";
            this.label2.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(17, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "Room";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(125, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 37;
            this.button1.Text = "EDIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ReserEditbtn_Click);
            // 
            // Roomcombo
            // 
            this.Roomcombo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roomcombo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Roomcombo.FormattingEnabled = true;
            this.Roomcombo.Location = new System.Drawing.Point(166, 276);
            this.Roomcombo.Name = "Roomcombo";
            this.Roomcombo.Size = new System.Drawing.Size(155, 30);
            this.Roomcombo.TabIndex = 39;
            this.Roomcombo.Text = "Room Num";
            // 
            // backbtn
            // 
            this.backbtn.AutoSize = true;
            this.backbtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.backbtn.Location = new System.Drawing.Point(134, 506);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(69, 26);
            this.backbtn.TabIndex = 22;
            this.backbtn.Text = "BACK";
            this.backbtn.Click += new System.EventHandler(this.label3_Click);
            // 
            // Reservationinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 553);
            this.Controls.Add(this.Clientcb);
            this.Controls.Add(this.Roomcombo);
            this.Controls.Add(this.Roomcb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReserDeletebtn);
            this.Controls.Add(this.ReserEditbtn);
            this.Controls.Add(this.ReserAddbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.reservationsearch);
            this.Controls.Add(this.dateout);
            this.Controls.Add(this.datein);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reseridlb);
            this.Controls.Add(this.ReservationGridView);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reservationinfo";
            this.Text = "Reservationinfo";
            this.Load += new System.EventHandler(this.Reservationinfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView ReservationGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reseridlb;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker datein;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox reservationsearch;
        private System.Windows.Forms.Button ReserDeletebtn;
        private System.Windows.Forms.Button ReserEditbtn;
        private System.Windows.Forms.Button ReserAddbtn;
        private System.Windows.Forms.ComboBox Roomcb;
        private System.Windows.Forms.ComboBox Clientcb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Roomcombo;
        private System.Windows.Forms.Label backbtn;
    }
}