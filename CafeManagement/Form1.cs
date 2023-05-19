using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\NIDHI\DOCUMENTS\CAFEMANAGEDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void PanelDes_Paint(object sender, PaintEventArgs e)
        {

        }
        public static string username; 
        private void button1_Click(object sender, EventArgs e)
        {
            string UserName = txtUserName.Text;
            string Password = txtPassword.Text;
            username = txtUserName.Text;
            if(UserName == "" && Password == "")
            {
                MessageBox.Show("Enter Username and Password, Warning !", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);    
            }
            else
            {
                con.Open();
                SqlDataAdapter sda =  new SqlDataAdapter("select count(*) from Userdb1 where Uname = '" + UserName + "' and Password = '" + Password + "'", con);
                DataTable da = new DataTable();
                sda.Fill(da);
                if (da.Rows[0][0].ToString() == "1")
                {
                    Manu objNew = new Manu();
                    objNew.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong username or password, Warning !", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                con.Close();

            }

        }

        private void lblguest_Click(object sender, EventArgs e)
        {
            this.Hide();
           GuestOrder objnew = new GuestOrder();
            objnew.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
