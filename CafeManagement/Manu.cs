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
    public partial class Manu : Form
    {
        public Manu()
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
            dataGridManuOption.DataSource = DS.Tables[0];
            con.Close();
        }
        void filterByCategory()
        {
            con.Open();
            string query1 = "select Itemlistdb1.Itemnum as ItemNum, Itemlistdb1.Itemname as ItemName, Itemlistdb1.Category as ItemCat, Itemlistdb1.ItemPrice as ItemPrice from Itemlistdb1 where Category = '"+comboBoxCat.SelectedItem.ToString()+"' ";
            //string quer1 = "select * from "
            SqlDataAdapter DA = new SqlDataAdapter(query1, con);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridManuOption.DataSource = DS.Tables[0];
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Visible = true;



        }

        private void btnUser_Click(object sender, EventArgs e)
        { 
            this.Hide();
            UserList objNew = new UserList();
            objNew.Show();
        }

        private void btnItme_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemList objNew = new ItemList();
            objNew.Show();
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
        int num = 0;
        int price,total;
        string Name, cat;

        private void btnaddCart_Click(object sender, EventArgs e) // second step -- code on add button 
        {
           if( txtquanty.Text == "")
            {
                MessageBox.Show("what is the quantity of Item ?");
            }
           else if (flag == 0)
            {
                MessageBox.Show("select the product to be Ordered");

            }

            else
            {
                num = num + 1;
                total = price * (Convert.ToInt32(txtquanty.Text));
                table.Rows.Add(num,Name,cat,price,total);
                dataGridView2.DataSource= table;
                flag = 0;

            }
            sum = sum + total;
            lblAmount.Text =  "Rs" + " "+ sum.ToString();
        }
        

        DataTable table = new DataTable(); // third step - create a table to store all the data
        int flag = 0;
        int sum = 0;
        

        private void dataGridManuOption_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Name = dataGridManuOption.SelectedRows[0].Cells[1].Value.ToString();
            cat = dataGridManuOption.SelectedRows[0].Cells[2].Value.ToString();
            price = Convert.ToInt32(dataGridManuOption.SelectedRows[0].Cells[3].Value.ToString());
            flag = 1;
        }

        private void dataGridManuOption_CellContentClick(object sender, DataGridViewCellEventArgs e) // first step - get data from place order
        {
            
        }

        private void comboBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterByCategory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Populate();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Manu_Load(object sender, EventArgs e)
        {
           Populate();

            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("ItemName",typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("Total", typeof(int)); 
            dataGridView2.DataSource = table;

            lblDate.Text = DateTime.Today.Date.ToShortDateString();
            txtcustomerName.Text = Login.username;




        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
