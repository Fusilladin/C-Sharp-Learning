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

namespace Flow3
{
    public partial class Form2 : Form
    {
        public static string ServerName = string.Empty;
        public static string UserName = string.Empty;
        public static string Password = string.Empty;
        public static DataSet ds = new DataSet();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServerName = ServerTb.Text;
            UserName = UserNameTb.Text;
            Password = PasswordTb.Text;
            string str = "Data Source =" + ServerName + ";User ID =" + UserName + ";Password =" + Password + "";
            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT db.[name] as dbname FROM [master].[sys].[database] db", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Database");
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
