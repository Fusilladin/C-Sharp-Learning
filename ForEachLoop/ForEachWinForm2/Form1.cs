using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEachWinForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            runLoop();
        }

       // private DataTable dt = new DataTable();
        public void runLoop()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Salary");
        }
        private void populateitems()
        {
            UserControl1[] rows = new UserControl1[3];
            for (int i = 0; i <3; i++)
            {
                rows[i] = new UserControl1();
                rows[i].Visible = true;
                rows[i].Width = flowLayoutPanel1.Width;
                rows[i].BackColor = Color.MediumSeaGreen;
               // rows[i].
            }
        }
    }

}
