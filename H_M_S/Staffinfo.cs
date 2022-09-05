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
    public partial class Staffinfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\Hoteldb1.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Staff_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StaffGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public Staffinfo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            MainForm Minfo = new MainForm();
            Minfo.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Staff_tbl values(" + staffidlb.Text + ",'" + staffnamelb.Text + "','" + staffphonelb.Text + "','" + genderbox.SelectedItem.ToString() + "','" + passwordlb.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff Successfully added");
            Con.Close();
            populate();
        }

        private void Staffinfo_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            populate();
        }

        private void StaffEditbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string myquery = "UPDATE Staff_tbl set StaffName ='" + staffnamelb.Text + "',StaffPhone ='" + staffphonelb.Text + "',gender ='" + genderbox.SelectedItem.ToString() + "',StaffPassword ='" + passwordlb.Text + "' where StaffId = " + staffidlb.Text + "";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff successfully edited");
            Con.Close();
            populate();
        }

        private void StaffGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            staffidlb.Text = StaffGridView.SelectedRows[0].Cells[0].Value.ToString();
            staffnamelb.Text = StaffGridView.SelectedRows[0].Cells[1].Value.ToString();
            staffphonelb.Text = StaffGridView.SelectedRows[0].Cells[2].Value.ToString();
            passwordlb.Text = StaffGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void StaffDeletebtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Staff_tbl where StaffId=" + staffidlb.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff successfully deleted");

            Con.Close();
            populate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Staff_tbl where StaffName ='" + staffsearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StaffGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            populate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void staffsearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
