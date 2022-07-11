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

namespace Flow3
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
