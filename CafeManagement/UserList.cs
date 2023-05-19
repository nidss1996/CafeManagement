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

namespace CafeManagement
{
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\NIDHI\DOCUMENTS\CAFEMANAGEDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        void Populate()
        {
            con.Open();
            string query1 = "select Userdb1.Uname as UserName, Userdb1.Phone as MobileNo, Userdb1.Password as Password from Userdb1 ";
            SqlDataAdapter DA = new SqlDataAdapter(query1, con);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridUserList.DataSource = DS.Tables[0];
            con.Close();
        }
        private void btnItme_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListOfOrder objNew = new ListOfOrder();
            objNew.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemList objNew = new ItemList();
            objNew.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListOfOrder objNew = new ListOfOrder();
            objNew.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUname.Text == "" || txtPhone.Text == "" || ttxtUpassword.Text == "")
            {
                MessageBox.Show("fields are empty ", "Warning !", MessageBoxButtons.OK);
            }
            else
            {
                con.Open();
                string query1 = "insert into Userdb1 values('" + txtUname.Text + "','" + txtPhone.Text + "','" + ttxtUpassword.Text + "' )";

                SqlCommand cmd = new SqlCommand(query1, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User detail added sucessfully", " Information", MessageBoxButtons.OK);
                con.Close();
                Populate();
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
                {
                 int total = dataGridUserList.Rows.Count;
                 Console.WriteLine(total);

                txtUname.Text = dataGridUserList.SelectedRows[0].Cells[0].Value.ToString();
                txtPhone.Text = dataGridUserList.SelectedRows[0].Cells[1].Value.ToString();
                ttxtUpassword.Text = dataGridUserList.SelectedRows[0].Cells[2].Value.ToString();

                }

               
           
                

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
             
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(txtUname.Text == "" || txtPhone.Text == "" || ttxtUpassword.Text == "")
            {
                MessageBox.Show("fields are empty ", "Warning !", MessageBoxButtons.OK);
            }

            else
            {
                con.Open();
                string query1 = "update Userdb1 set Uname = '" + txtUname + "', Phone ='" + txtPhone.Text + "' where Password = '" + ttxtUpassword.Text + "'";

                SqlCommand cmd = new SqlCommand(query1, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User detail updated sucessfully", " Information", MessageBoxButtons.OK);
                con.Close();
                Populate();
            }
            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to delete the record ","Confirm", MessageBoxButtons.OKCancel ) == DialogResult.OK)
            {
                con.Open();
                string query1 = "delete from Userdb1 where Password ='" + ttxtUpassword.Text + "'";

                SqlCommand cmd = new SqlCommand(query1, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User detail deleted sucessfully", " Information", MessageBoxButtons.OK);
                con.Close();
                Populate() ;
            }
            
        }
    }
}
