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
        DataTable dt = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServerName = ServerTb.Text;
            UserName = UserNameTb.Text;
            Password = PasswordTb.Text;
            string str = "Data Source = wimi1-infosys1; Initial Catalog = TrevenaSecurities; Integrated Security = True";
            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM test", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            foreach (DataRow row in dt.Rows)
            {


                    MessageBox.Show(row["Item"].ToString());
                }
                // populate it here
                ListItem[] listItems = new ListItem[20];
                // loop through each item
                for (int i = 0; i < listItems.Length; i++)
                {
                    listItems[i] = new ListItem();
                    listItems[i].Width = flowLayoutPanel1.Width;
                    listItems[i].IconBackground = Color.Silver;
                    listItems[i].Title = "Get Data Somewhere";
                    listItems[i].Message = "Any Data Source - ";
                    // add to flowlayout
                    if (flowLayoutPanel1.Controls.Count < 0)
                    {
                        flowLayoutPanel1.Controls.Clear();
                    }
                    else
                        flowLayoutPanel1.Controls.Add(listItems[i]);
                }
                
            }

        }
        //private void UserControl11_Load(object sender, EventArgs e)
        //{
        //    string str = "Data Source = wimi1-infosys1; Initial Catalog = TrevenaSecurities; Integrated Security = True";
        //    SqlConnection con = new SqlConnection(str);
        //    try
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("SELECT * FROM test", con);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(dt);
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }

        //}

    ///

        //private void populateitems()
        //{
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        MessageBox.Show(row["Item"].ToString());
        //    }
        //    // populate it here
        //    ListItem[] listItems = new ListItem[20];
        //    // loop through each item
        //    for (int i = 0; i < listItems.Length; i++)
        //    {
        //        listItems[i] = new ListItem();
        //        listItems[i].Width = flowLayoutPanel1.Width;
        //        listItems[i].IconBackground = Color.Silver;
        //        listItems[i].Title = "Get Data Somewhere";
        //        listItems[i].Message = "Any Data Source - ";
        //        // add to flowlayout
        //        if (flowLayoutPanel1.Controls.Count < 0)
        //        {
        //            flowLayoutPanel1.Controls.Clear();
        //        }
        //        else
        //            flowLayoutPanel1.Controls.Add(listItems[i]);
        //    }
        //}

        //private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        //{

        //}
    }

