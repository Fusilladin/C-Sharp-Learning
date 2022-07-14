using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEachWInForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            runLoop();
        }

        public void runLoop()
        {
            foreach(Control x in this.Controls)
            {
                // TURN EVERYTHING RED 
                // x.BackColor = Color.Red;

                // TURN ALL COMPONENTS THEIR OWN COLORS
                if(x is Button)
                {
                    x.ForeColor = Color.White;
                    x.BackColor = Color.Black;
                }
                if(x is Label)
                {
                    x.ForeColor = Color.Orange;
                }
                // SEPERATE PICTUREBOXES INTO GROUPS
                if (x is PictureBox && (string)x.Tag == "Group1")
                {
                    x.BackColor = Color.MediumSeaGreen;
                }
                if (x is PictureBox && (string)x.Tag == "Group2")
                {
                    x.BackColor = Color.MediumAquamarine;

                }
                if (x is PictureBox && (string)x.Tag == "Group3")
                {
                    x.BackColor = Color.Firebrick;
                }
            }
        }
    }
}
