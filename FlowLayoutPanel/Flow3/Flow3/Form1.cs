using Flow3.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Flow3
{
    
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();

            //InitializeForm();
            
        }

        private bool InitializeForm()
        {
            string str = "Data Source=wimi1-infosys1; Initial Catalog=TrevenaSecurities; Integrated Security=True";
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
                return false;


            }


            // STEP TWO - Create the menu controls
            foreach (DataRow row in dt.Rows)
            {
                //MessageBox.Show(row["Item"].ToString());

                ListItem item = new ListItem();
                item.Width = flowLayoutPanel1.Width;
                item.IconBackground = Color.Silver;
                item.Title = row["Item"].ToString();
                item.Message = "Message";
                item.DataRow = row;

                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                    flowLayoutPanel1.Controls.Add(item);
            }
            //// populate it here
            //ListItem[] listItems = new ListItem[20];
            //// loop through each item
            //for (int i = 0; i < listItems.Length; i++)
            //{
            //    listItems[i] = new ListItem();
            //    listItems[i].Width = flowLayoutPanel1.Width;
            //    listItems[i].IconBackground = Color.Silver;
            //    listItems[i].Title = "Get Data Somewhere";
            //    listItems[i].Message = "Any Data Source - ";
            //    // add to flowlayout
            //    if (flowLayoutPanel1.Controls.Count < 0)
            //    {
            //        flowLayoutPanel1.Controls.Clear();
            //    }
            //    else
            //        flowLayoutPanel1.Controls.Add(listItems[i]);
            //}

            return true;


        }
        private void Form2_Load(object sender, EventArgs e)
        {
            populateitems();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // create your items
            populateitems();
        }

        private void populateitems()
        {
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConnBtn_Click(object sender, EventArgs e)
        {
            //UserControl2.Hide();
            //UserControl1.Show();
            //UserControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {
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
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
