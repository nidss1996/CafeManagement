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

namespace CafeManagement
{
    public partial class ListOfOrder : Form
    {
        public ListOfOrder()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\NIDHI\DOCUMENTS\CAFEMANAGEDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manu objNew = new Manu();
            objNew.Show();
        }
        void Populate()
        {
            con.Open();
            string query1 = "select * from Orderdb1";
            SqlDataAdapter sDA = new SqlDataAdapter(query1, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sDA);
            DataSet DS = new DataSet();
            sDA.Fill(DS);
            ListofOrdergridview.DataSource = DS.Tables[0];
            con.Close();
        }

        private void ListOfOrder_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=====MyCafe House=====", new Font("Abeezee", 20, FontStyle.Bold), Brushes.Red,new Point(200, 30));
            e.Graphics.DrawString("=====Order Summary=====", new Font("Abeezee", 20, FontStyle.Bold), Brushes.Red, new Point(220,80));
            e.Graphics.DrawString("Order Num="+ ListofOrdergridview.SelectedRows[0].Cells[0].Value.ToString(), new Font("Abeezee", 15, FontStyle.Regular), Brushes.Black, new Point(120,150));
            e.Graphics.DrawString("Order Date=" + ListofOrdergridview.SelectedRows[0].Cells[1].Value.ToString(), new Font("Abeezee", 15, FontStyle.Regular), Brushes.Black, new Point(120, 180));
            e.Graphics.DrawString("User Name =" + ListofOrdergridview.SelectedRows[0].Cells[2].Value.ToString(), new Font("Abeezee", 15, FontStyle.Regular), Brushes.Black, new Point(120, 210));
            e.Graphics.DrawString("Order Amount  =" + ListofOrdergridview.SelectedRows[0].Cells[3].Value.ToString(), new Font("Abeezee", 15, FontStyle.Regular), Brushes.Black, new Point(120, 240));
            e.Graphics.DrawString("======Thank you======", new Font("Abeezee", 20, FontStyle.Bold), Brushes.Red, new Point(400, 600));
            //e.Graphics.DrawString("=====Order Summary=====", new Font("Abeezee", 20, FontStyle.Bold), Brushes.Red, new Point(200));
            //e.Graphics.DrawString("=====Order Summary=====", new Font("Abeezee", 20, FontStyle.Bold), Brushes.Red, new Point(200));
        }

        private void ListofOrdergridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
