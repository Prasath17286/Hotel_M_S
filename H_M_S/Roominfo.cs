using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Roominfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\Hoteldb1.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Room_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public Roominfo()
        {
            InitializeComponent();
        }

        private void RoomAddbtn_Click(object sender, EventArgs e)
        {
            string isfree;
            if (yesradio.Checked == true)
                isfree = "free";
            else
                isfree = "busy";

            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Room_tbl values(" + roomnumberlb.Text + ",'" + roomphonelb.Text + "','" + isfree + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Successfully added");
            Con.Close();
            populate();
        }

        private void RoomGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            roomnumberlb.Text = RoomGridView.SelectedRows[0].Cells[0].Value.ToString();
            roomphonelb.Text = RoomGridView.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void Roominfo_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            populate();
        }

        private void RoomDeletebtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Room_tbl where RoomId=" + roomnumberlb.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room successfully deleted");

            Con.Close();
            populate();
        }

        private void RoomEditbtn_Click(object sender, EventArgs e)
        {
            string isfree;
            if (yesradio.Checked == true)
                isfree = "free";
            else
                isfree = "busy";
            Con.Open();
            string myquery = "UPDATE Room_tbl set RoomPhone ='" + roomphonelb.Text + "',RoomFree ='" + isfree + "' where RoomId = " + roomnumberlb.Text + "";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room successfully edited");
            Con.Close();
            populate();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Room_tbl where RoomId ='" + roomsearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MainForm Minfo = new MainForm();
            Minfo.Show();
            this.Hide();
        }
    }
}
