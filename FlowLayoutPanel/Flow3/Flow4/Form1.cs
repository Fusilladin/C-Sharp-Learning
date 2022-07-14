// using Flow4.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// using Microsoft.Data.SqlClient;

namespace Flow4
{
    public partial class Form1 : Form
    {
        private object dt;
        private DataRow row;

        public Form1()
        {
            InitializeComponent();

        }

        private DataRow GetRow()
        {
            return row;
        }

        private bool InitializeForm(DataRow row)
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
                item.Price = row["Price"]();
                item.DataRow = row;

                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                    flowLayoutPanel1.Controls.Add(item);
            }
            return true;
        }
    }

    internal class ListItem
    {
        internal int Width;
        internal string IconBackground;
        internal string Title;
        internal int Price;
        internal string DataRow;

    }

    internal class SqlDataAdapter
    {
        public SqlDataAdapter(SqlCommand cmd)
        {
        }

        internal void Fill(object dt)
        {
            throw new NotImplementedException();
        }
    }

    internal class SqlCommand
    {
        public SqlCommand(string v, SqlConnection con)
        {
        }
    }
}
    
