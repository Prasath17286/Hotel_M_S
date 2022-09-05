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
    public partial class calculationform : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\Hoteldb1.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Myquery = "select ClientRoom,ClientCtg from Client_tbl where ClientName='" + Clientnamebx.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CalculationGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public calculationform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void ClientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void calculationform_Load(object sender, EventArgs e)
        {
            
        }

        private void calbtn_Click(object sender, EventArgs e)
        {
            populate();
            string size = CalculationGridView.SelectedRows[0].Cells[0].Value.ToString();
            string ctg = CalculationGridView.SelectedRows[0].Cells[1].Value.ToString();
            int roomfee;
            int roomctg;
            if (size == "Single")
            {
                roomfee = 500;
            }
            else 
            {
                if (size == "Double")
                {
                    roomfee = 1000;

                }
                else
                {
                   roomfee = 1500;

                }

            }
            if (ctg == "Standard")
            {
                roomctg = 1000;

            }
            else
            {
                roomctg = 2000;

            }
            int cal = roomfee+roomctg;
            double discal;
            
            int day = dateTimePicker2.Value.Day - dateTimePicker1.Value.Day;
            if (day > 5)
            {
                discal = day* cal*0.25;
                MessageBox.Show("Congrats ,you recive discount");
            }
            else
            {
                discal = day * cal;
                MessageBox.Show("sorry ,you have not discount");
            }

            Totalbillbx.Text = discal.ToString();
        }

        private void Totalbillbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MainForm Minfo = new MainForm();
            Minfo.Show();
            this.Hide();
        }
    }
}
