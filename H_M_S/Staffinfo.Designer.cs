
namespace WindowsFormsApp1
{
    partial class Staffinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staffinfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.staffphonelb = new System.Windows.Forms.TextBox();
            this.staffnamelb = new System.Windows.Forms.TextBox();
            this.staffidlb = new System.Windows.Forms.TextBox();
            this.genderbox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StaffGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.searchbtn = new System.Windows.Forms.Button();
            this.staffsearch = new System.Windows.Forms.TextBox();
            this.StaffDeletebtn = new System.Windows.Forms.Button();
            this.StaffEditbtn = new System.Windows.Forms.Button();
            this.StaffAddbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordlb = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 106);
            this.panel1.TabIndex = 1;
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Datelbl.Location = new System.Drawing.Point(648, 67);
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
            this.label1.Location = new System.Drawing.Point(257, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(20, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone Num.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(20, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Staff Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(20, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Staff id";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // staffphonelb
            // 
            this.staffphonelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffphonelb.Location = new System.Drawing.Point(157, 260);
            this.staffphonelb.Name = "staffphonelb";
            this.staffphonelb.Size = new System.Drawing.Size(155, 26);
            this.staffphonelb.TabIndex = 10;
            // 
            // staffnamelb
            // 
            this.staffnamelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffnamelb.Location = new System.Drawing.Point(157, 209);
            this.staffnamelb.Name = "staffnamelb";
            this.staffnamelb.Size = new System.Drawing.Size(155, 26);
            this.staffnamelb.TabIndex = 11;
            // 
            // staffidlb
            // 
            this.staffidlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffidlb.Location = new System.Drawing.Point(157, 157);
            this.staffidlb.Name = "staffidlb";
            this.staffidlb.Size = new System.Drawing.Size(155, 26);
            this.staffidlb.TabIndex = 12;
            // 
            // genderbox
            // 
            this.genderbox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderbox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.genderbox.FormattingEnabled = true;
            this.genderbox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderbox.Location = new System.Drawing.Point(157, 364);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(155, 30);
            this.genderbox.TabIndex = 13;
            this.genderbox.Text = "Gender";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(586, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // StaffGridView
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.StaffGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.StaffGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StaffGridView.BackgroundColor = System.Drawing.Color.White;
            this.StaffGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StaffGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StaffGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.StaffGridView.ColumnHeadersHeight = 24;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StaffGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.StaffGridView.EnableHeadersVisualStyles = false;
            this.StaffGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StaffGridView.Location = new System.Drawing.Point(323, 156);
            this.StaffGridView.Name = "StaffGridView";
            this.StaffGridView.RowHeadersVisible = false;
            this.StaffGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StaffGridView.Size = new System.Drawing.Size(513, 385);
            this.StaffGridView.TabIndex = 17;
            this.StaffGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.StaffGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StaffGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.StaffGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StaffGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StaffGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.StaffGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StaffGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.StaffGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.StaffGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StaffGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StaffGridView.ThemeStyle.HeaderStyle.Height = 24;
            this.StaffGridView.ThemeStyle.ReadOnly = false;
            this.StaffGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.StaffGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StaffGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.StaffGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StaffGridView.ThemeStyle.RowsStyle.Height = 22;
            this.StaffGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StaffGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StaffGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffGridView_CellContentClick);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchbtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchbtn.Location = new System.Drawing.Point(505, 110);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 34);
            this.searchbtn.TabIndex = 16;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // staffsearch
            // 
            this.staffsearch.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffsearch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.staffsearch.Location = new System.Drawing.Point(344, 114);
            this.staffsearch.Name = "staffsearch";
            this.staffsearch.Size = new System.Drawing.Size(155, 25);
            this.staffsearch.TabIndex = 14;
            this.staffsearch.Text = "Staff Name";
            this.staffsearch.TextChanged += new System.EventHandler(this.staffsearch_TextChanged);
            // 
            // StaffDeletebtn
            // 
            this.StaffDeletebtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.StaffDeletebtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffDeletebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StaffDeletebtn.Location = new System.Drawing.Point(220, 420);
            this.StaffDeletebtn.Name = "StaffDeletebtn";
            this.StaffDeletebtn.Size = new System.Drawing.Size(88, 34);
            this.StaffDeletebtn.TabIndex = 20;
            this.StaffDeletebtn.Text = "DELETE";
            this.StaffDeletebtn.UseVisualStyleBackColor = false;
            this.StaffDeletebtn.Click += new System.EventHandler(this.StaffDeletebtn_Click);
            // 
            // StaffEditbtn
            // 
            this.StaffEditbtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.StaffEditbtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffEditbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StaffEditbtn.Location = new System.Drawing.Point(115, 420);
            this.StaffEditbtn.Name = "StaffEditbtn";
            this.StaffEditbtn.Size = new System.Drawing.Size(75, 34);
            this.StaffEditbtn.TabIndex = 21;
            this.StaffEditbtn.Text = "EDIT";
            this.StaffEditbtn.UseVisualStyleBackColor = false;
            this.StaffEditbtn.Click += new System.EventHandler(this.StaffEditbtn_Click);
            // 
            // StaffAddbtn
            // 
            this.StaffAddbtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.StaffAddbtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffAddbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StaffAddbtn.Location = new System.Drawing.Point(12, 420);
            this.StaffAddbtn.Name = "StaffAddbtn";
            this.StaffAddbtn.Size = new System.Drawing.Size(75, 34);
            this.StaffAddbtn.TabIndex = 22;
            this.StaffAddbtn.Text = "ADD";
            this.StaffAddbtn.UseVisualStyleBackColor = false;
            this.StaffAddbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(20, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label5_Click);
            // 
            // passwordlb
            // 
            this.passwordlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlb.Location = new System.Drawing.Point(157, 306);
            this.passwordlb.Name = "passwordlb";
            this.passwordlb.Size = new System.Drawing.Size(155, 26);
            this.passwordlb.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(121, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "BACK";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // Staffinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 553);
            this.Controls.Add(this.StaffDeletebtn);
            this.Controls.Add(this.StaffEditbtn);
            this.Controls.Add(this.StaffAddbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StaffGridView);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.staffsearch);
            this.Controls.Add(this.genderbox);
            this.Controls.Add(this.passwordlb);
            this.Controls.Add(this.staffphonelb);
            this.Controls.Add(this.staffnamelb);
            this.Controls.Add(this.staffidlb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staffinfo";
            this.Text = "Staffinfo";
            this.Load += new System.EventHandler(this.Staffinfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox staffphonelb;
        private System.Windows.Forms.TextBox staffnamelb;
        private System.Windows.Forms.TextBox staffidlb;
        private System.Windows.Forms.ComboBox genderbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView StaffGridView;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox staffsearch;
        private System.Windows.Forms.Button StaffDeletebtn;
        private System.Windows.Forms.Button StaffEditbtn;
        private System.Windows.Forms.Button StaffAddbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordlb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
    }
}