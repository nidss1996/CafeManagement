using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class GuestOrder : Form
    {
        public GuestOrder()
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
            datagridGuestView.DataSource = DS.Tables[0];
            con.Close();
        }

        void filterByCategory()
        {
            con.Open();
            string query1 = "select Itemlistdb1.Itemnum as ItemNum, Itemlistdb1.Itemname as ItemName, Itemlistdb1.Category as ItemCat, Itemlistdb1.ItemPrice as ItemPrice from Itemlistdb1 where Category = '" + comboBoxCat.SelectedItem.ToString() + "' ";
            //string quer1 = "select * from "
            SqlDataAdapter DA = new SqlDataAdapter(query1, con);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            datagridGuestView.DataSource = DS.Tables[0];
            con.Close();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListOfOrder objNew = new ListOfOrder();
            objNew.Show();
        }
        int num = 0;
        int price, total;
        string Name, cat;
        private void btnaddCart_Click(object sender, EventArgs e)
        {
            if (txtQuntity1.Text == "")
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
                total = price * (Convert.ToInt32(txtQuntity1.Text));
                table.Rows.Add(num, Name, cat, price, total);
                dataGridView2.DataSource = table;
                flag = 0;

            }
            sum = sum + total;
            txtTotalamount.Text = sum.ToString();
        }
        DataTable table = new DataTable(); // third step - create a table to store all the data
        int flag = 0;
        int sum = 0;

        private void comboBoxCat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterByCategory();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Int64 ordernum = Int64.Parse(txtOredrNo.Text);
            //Int64 totalamount = Int64.Parse(txtTotalamount.Text);

            con.Open();
            string query1 = "insert into Orderdb1 values(" + txtOredrNo.Text + ",'" + lbldate.Text + "','" + txtsellername.Text + "', "+txtTotalamount.Text+")";

            SqlCommand cmd = new SqlCommand(query1, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order is Placed sucessfully", "Information", MessageBoxButtons.OK);
            con.Close();
            
        }

        private void txtsellername_TextChanged(object sender, EventArgs e)
        {

        }

        private void datagridGuestView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Name = datagridGuestView.SelectedRows[0].Cells[1].Value.ToString();
            cat = datagridGuestView.SelectedRows[0].Cells[2].Value.ToString();
            price = Convert.ToInt32(datagridGuestView.SelectedRows[0].Cells[3].Value.ToString());
            flag = 1;
        }

        private void GuestOrder_Load(object sender, EventArgs e)
        {
            Populate();

            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("ItemName", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("Total", typeof(int));
            dataGridView2.DataSource = table;
            lbldate.Text = DateTime.Today.Date.ToShortDateString();
        }
    }
}
