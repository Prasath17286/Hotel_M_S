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
    public partial class Reservationinfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\Hoteldb1.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Reservation_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReservationGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public Reservationinfo()
        {
            InitializeComponent();
        }

        private void staffidlb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            MainForm Minfo = new MainForm();
            Minfo.Show();
            this.Hide();
        }
        DateTime today;
        public void fillRoomcombo()
        {
            string roomstate = "free";
            Con.Open();
            SqlCommand cmd = new SqlCommand("select RoomId from Room_tbl where RoomFree= '" + roomstate + "'", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RoomId", typeof(int));
            dt.Load(rdr);
            Roomcombo.ValueMember = "RoomId";
            Roomcombo.DataSource = dt;
            Con.Close();
        }
        public void fillClientcombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select ClientName from Client_tbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ClientName", typeof(string));
            dt.Load(rdr);
            Clientcb.ValueMember = "ClientName";
            Clientcb.DataSource = dt;
            Con.Close();
        }
        private void Reservationinfo_Load(object sender, EventArgs e)
        {
            today = datein.Value;
            fillRoomcombo();
            fillClientcombo();
            Datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            populate();
        }

        private void datein_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(datein.Value, today);
            if (res < 0)
                MessageBox.Show("Wrong Date for resevation");
        }

        private void dateout_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(dateout.Value,datein.Value);
            if (res < 0)
                MessageBox.Show("Wrong DateOut for resevation");
        }
        public void updateroomstate()
        {
            Con.Open();
            string newstate = "busy";

            string myquery = "UPDATE Room_tbl set RoomFree ='" + newstate + "' where RoomId = " + Convert.ToInt32(Roomcombo.SelectedValue.ToString()) + "";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Reservation successfully edited");
            Con.Close();
            fillRoomcombo();
        }
        public void updateroomondelete()
        {
            Con.Open();
            string newstate = "free";
            int roomid= Convert.ToInt32(ReservationGridView.SelectedRows[0].Cells[2].Value.ToString());
            string myquery = "UPDATE Room_tbl set RoomFree ='" + newstate + "' where RoomId = " + roomid + "";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Reservation successfully edited");
            Con.Close();
            fillRoomcombo();
        }
        private void ReserAddbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Reservation_tbl values(" + reseridlb.Text + ",'" + Clientcb.SelectedValue.ToString() + "','" + Roomcombo.SelectedValue.ToString() + "','" + datein.Value + "','" + dateout.Value + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Reservation successfully added");

            Con.Close();
            updateroomstate();
            populate();
        }

        private void ReservationGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            reseridlb.Text = ReservationGridView.SelectedRows[0].Cells[0].Value.ToString();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void ReserDeletebtn_Click(object sender, EventArgs e)
        {
            if (reseridlb.Text == "")
            {
                MessageBox.Show("Enter the reservation to delete");
            }
            else
            {

                Con.Open();
                string query = "delete from Reservation_tbl where Resid=" + reseridlb.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation successfully deleted");

                Con.Close();
                updateroomondelete();
                populate();
            }
        }

        private void ReserEditbtn_Click(object sender, EventArgs e)
        {
            if (reseridlb.Text == "")
            {
                MessageBox.Show("Empty ResId, Enter the resevation Id");
            }
            else
            {

                Con.Open();
                string myquery = "UPDATE Reservation_tbl set Client ='" + Clientcb.SelectedValue.ToString() + "',Room ='" + Roomcombo.SelectedValue.ToString() + "',Datein ='" + datein.Value.ToString() + "',DateOut ='" + dateout.Value.ToString() + "' where ResId = " + reseridlb.Text + "";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation successfully edited");
                Con.Close();
                populate();
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Reservation_tbl where ResId ='" + reservationsearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReservationGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
