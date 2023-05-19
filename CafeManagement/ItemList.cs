using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeManagement
{
    public partial class ItemList : Form
    {
        public ItemList()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\NIDHI\DOCUMENTS\CAFEMANAGEDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        void Populate()
        {
            con.Open();
            string query1 = "select Itemlistdb1.Itemnum as ItemNum, Itemlistdb1.Itemname as ItemName, Itemlistdb1.Category as ItemCat, Itemlistdb1.ItemPrice as ItemPrice from Itemlistdb1 ";
            SqlDataAdapter DA = new SqlDataAdapter(query1, con);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridViewItemManage.DataSource = DS.Tables[0];
            con.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListOfOrder objNew = new ListOfOrder();
            objNew.Show();

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
            UserList objNew = new UserList();   
            objNew.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            int itemNum = Convert.ToInt32(txtItemNum.Text);
            int itemPrice = Convert.ToInt32(txtItemPrice.Text);
            con.Open();
            string query1 = "insert into Itemlistdb1 values(" + itemNum + ",'" + txtItemName.Text + "','" + comboBoxItemCat.Text + "', "+itemPrice+" )";

            SqlCommand cmd = new SqlCommand(query1, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Item detail added sucessfully", " Information", MessageBoxButtons.OK);
            con.Close();
            Populate();
        }

        private void dataGridViewItemManage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ItemList_Load(object sender, EventArgs e)
        {
            Populate();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtItemNum.Text == "" || txtItemName.Text == "" || txtItemPrice.Text == "" || comboBoxItemCat.Text == "")
            {
                MessageBox.Show("fields are empty ", "Warning !", MessageBoxButtons.OK);
            }

            else
            {
                int Itemnum = Convert.ToInt32(txtItemNum.Text);
                int Itemprice = Convert.ToInt32(txtItemPrice.Text);
                con.Open();
                string query1 = "update Itemlistdb1 set Itemnum = " + Itemnum + ", Itemname ='" + txtItemName.Text + "', Category = '"+comboBoxItemCat.Text+"', Itemprice = "+Itemprice+" where Itemnum = " + Itemnum + "";

                SqlCommand cmd = new SqlCommand(query1, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User detail updated sucessfully", " Information", MessageBoxButtons.OK);
                con.Close();
                Populate();
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete the record ", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int Itemnum = Convert.ToInt32(txtItemNum.Text);
                con.Open();
                string query1 = "delete from Itemlistdb1 where Itemnum = " +  Itemnum + "";

                SqlCommand cmd = new SqlCommand(query1, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Item detail deleted sucessfully", " Information", MessageBoxButtons.OK);
                con.Close();
                Populate();
            }
        }

        private void dataGridViewItemManage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItemNum.Text = dataGridViewItemManage.SelectedRows[0].Cells[0].Value.ToString();
            txtItemName.Text = dataGridViewItemManage.SelectedRows[0].Cells[1].Value.ToString();
            comboBoxItemCat.Text = dataGridViewItemManage.SelectedRows[0].Cells[2].Value.ToString();
            txtItemPrice.Text = dataGridViewItemManage.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
