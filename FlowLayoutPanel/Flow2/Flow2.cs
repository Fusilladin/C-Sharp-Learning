using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// using 

namespace DataConnection
{
    public partial class Form1 : Form
    {
 









        public Form1()
        {
            InitializeComponent();
        }

        private void testBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.testBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trevenaSecuritiesDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trevenaSecuritiesDataSet.Test' table. You can move, or remove it, as needed.
            this.testTableAdapter.Fill(this.trevenaSecuritiesDataSet.Test);

        }
    }
}
