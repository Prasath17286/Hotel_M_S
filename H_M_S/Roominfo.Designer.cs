
namespace WindowsFormsApp1
{
    partial class Roominfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roominfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RoomGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roomnumberlb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yesradio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.roomphonelb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.noradio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RoomDeletebtn = new System.Windows.Forms.Button();
            this.RoomEditbtn = new System.Windows.Forms.Button();
            this.RoomAddbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.roomsearch = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 106);
            this.panel1.TabIndex = 2;
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Datelbl.Location = new System.Drawing.Point(662, 80);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(55, 26);
            this.Datelbl.TabIndex = 0;
            this.Datelbl.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(272, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room information";
            // 
            // RoomGridView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.RoomGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.RoomGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoomGridView.BackgroundColor = System.Drawing.Color.White;
            this.RoomGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RoomGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.RoomGridView.ColumnHeadersHeight = 24;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RoomGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.RoomGridView.EnableHeadersVisualStyles = false;
            this.RoomGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomGridView.Location = new System.Drawing.Point(332, 165);
            this.RoomGridView.Name = "RoomGridView";
            this.RoomGridView.RowHeadersVisible = false;
            this.RoomGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoomGridView.Size = new System.Drawing.Size(513, 385);
            this.RoomGridView.TabIndex = 20;
            this.RoomGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RoomGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RoomGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RoomGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RoomGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RoomGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RoomGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.RoomGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RoomGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RoomGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RoomGridView.ThemeStyle.HeaderStyle.Height = 24;
            this.RoomGridView.ThemeStyle.ReadOnly = false;
            this.RoomGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.RoomGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RoomGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.RoomGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RoomGridView.ThemeStyle.RowsStyle.Height = 22;
            this.RoomGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RoomGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomGridView_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(14, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Room Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(14, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 26);
            this.label3.TabIndex = 19;
            this.label3.Text = "Room number";
            // 
            // roomnumberlb
            // 
            this.roomnumberlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomnumberlb.Location = new System.Drawing.Point(152, 165);
            this.roomnumberlb.Name = "roomnumberlb";
            this.roomnumberlb.Size = new System.Drawing.Size(155, 26);
            this.roomnumberlb.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(29, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Free";
            // 
            // yesradio
            // 
            this.yesradio.AutoSize = true;
            this.yesradio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yesradio.CheckedState.BorderThickness = 0;
            this.yesradio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yesradio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.yesradio.CheckedState.InnerOffset = -4;
            this.yesradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.yesradio.Location = new System.Drawing.Point(90, 301);
            this.yesradio.Name = "yesradio";
            this.yesradio.Size = new System.Drawing.Size(14, 13);
            this.yesradio.TabIndex = 24;
            this.yesradio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.yesradio.UncheckedState.BorderThickness = 2;
            this.yesradio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.yesradio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // roomphonelb
            // 
            this.roomphonelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomphonelb.Location = new System.Drawing.Point(152, 218);
            this.roomphonelb.Name = "roomphonelb";
            this.roomphonelb.Size = new System.Drawing.Size(155, 26);
            this.roomphonelb.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(110, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Yes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(174, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "No";
            // 
            // noradio
            // 
            this.noradio.AutoSize = true;
            this.noradio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.noradio.CheckedState.BorderThickness = 0;
            this.noradio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.noradio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.noradio.CheckedState.InnerOffset = -4;
            this.noradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.noradio.Location = new System.Drawing.Point(154, 301);
            this.noradio.Name = "noradio";
            this.noradio.Size = new System.Drawing.Size(14, 13);
            this.noradio.TabIndex = 24;
            this.noradio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.noradio.UncheckedState.BorderThickness = 2;
            this.noradio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.noradio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // RoomDeletebtn
            // 
            this.RoomDeletebtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RoomDeletebtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomDeletebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RoomDeletebtn.Location = new System.Drawing.Point(220, 432);
            this.RoomDeletebtn.Name = "RoomDeletebtn";
            this.RoomDeletebtn.Size = new System.Drawing.Size(88, 34);
            this.RoomDeletebtn.TabIndex = 26;
            this.RoomDeletebtn.Text = "DELETE";
            this.RoomDeletebtn.UseVisualStyleBackColor = false;
            this.RoomDeletebtn.Click += new System.EventHandler(this.RoomDeletebtn_Click);
            // 
            // RoomEditbtn
            // 
            this.RoomEditbtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RoomEditbtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomEditbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RoomEditbtn.Location = new System.Drawing.Point(115, 432);
            this.RoomEditbtn.Name = "RoomEditbtn";
            this.RoomEditbtn.Size = new System.Drawing.Size(75, 34);
            this.RoomEditbtn.TabIndex = 27;
            this.RoomEditbtn.Text = "EDIT";
            this.RoomEditbtn.UseVisualStyleBackColor = false;
            this.RoomEditbtn.Click += new System.EventHandler(this.RoomEditbtn_Click);
            // 
            // RoomAddbtn
            // 
            this.RoomAddbtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RoomAddbtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomAddbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RoomAddbtn.Location = new System.Drawing.Point(12, 432);
            this.RoomAddbtn.Name = "RoomAddbtn";
            this.RoomAddbtn.Size = new System.Drawing.Size(75, 34);
            this.RoomAddbtn.TabIndex = 28;
            this.RoomAddbtn.Text = "ADD";
            this.RoomAddbtn.UseVisualStyleBackColor = false;
            this.RoomAddbtn.Click += new System.EventHandler(this.RoomAddbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(586, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchbtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchbtn.Location = new System.Drawing.Point(505, 121);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 34);
            this.searchbtn.TabIndex = 30;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // roomsearch
            // 
            this.roomsearch.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsearch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.roomsearch.Location = new System.Drawing.Point(344, 125);
            this.roomsearch.Name = "roomsearch";
            this.roomsearch.Size = new System.Drawing.Size(155, 25);
            this.roomsearch.TabIndex = 29;
            this.roomsearch.Text = "Room Number";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(96, 499);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 26);
            this.label7.TabIndex = 18;
            this.label7.Text = "BACK";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Roominfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.roomsearch);
            this.Controls.Add(this.RoomDeletebtn);
            this.Controls.Add(this.RoomEditbtn);
            this.Controls.Add(this.RoomAddbtn);
            this.Controls.Add(this.noradio);
            this.Controls.Add(this.yesradio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomphonelb);
            this.Controls.Add(this.roomnumberlb);
            this.Controls.Add(this.RoomGridView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Roominfo";
            this.Text = "Roominfo";
            this.Load += new System.EventHandler(this.Roominfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView RoomGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox roomnumberlb;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2RadioButton yesradio;
        private System.Windows.Forms.TextBox roomphonelb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2RadioButton noradio;
        private System.Windows.Forms.Button RoomDeletebtn;
        private System.Windows.Forms.Button RoomEditbtn;
        private System.Windows.Forms.Button RoomAddbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox roomsearch;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
    }
}