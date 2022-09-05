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
    public partial class Clientinfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\Hoteldb1.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Client_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ClientGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public Clientinfo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Client_tbl values(" + Clientidlb.Text + ",'" + Clientnamelb.Text + "','" + Clientphonelb.Text + "','" + Clientroombox.SelectedItem.ToString() + "','" + Clientctgbox.SelectedItem.ToString() + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully added");
            Con.Close();
            populate();
        }

        private void Clientinfo_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            populate();
        }

        private void ClientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clientidlb.Text = ClientGridView.SelectedRows[0].Cells[0].Value.ToString();
            Clientnamelb.Text = ClientGridView.SelectedRows[0].Cells[1].Value.ToString();
            Clientphonelb.Text = ClientGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string myquery = "UPDATE Client_tbl set ClientName ='" + Clientnamelb.Text + "',ClientPhone ='" + Clientphonelb.Text + "',ClientRoom ='" + Clientroombox.SelectedItem.ToString() + "',ClientCtg ='" + Clientctgbox.SelectedItem.ToString() + "' where ClientId = " + Clientidlb.Text + "";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client successfully edited");
            Con.Close();
            populate();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Client_tbl where Clientid=" + Clientidlb.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client successfully deleted");

            Con.Close();
            populate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Client_tbl where ClientName ='"+clientsearch.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ClientGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            MainForm Minfo = new MainForm();
            Minfo.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void clientsearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
