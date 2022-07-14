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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        #region Properties

        private string _id;
        private string _name;
        private string _salary;



        [Category("Custom Props")]
        public string Id
        {
            get { return _id; }
            set { _id = value; IdLbl.Text = value; }
        }
        [Category("Custom Props")]
        public string FirstName
        {
            get { return _name; }
            set { _name = value; NameLbl.Text = value; }
        }
        [Category("Custom Props")]
        public string Salary
        {
            get { return _salary; }
            set { _salary = value; SalaryLbl.Text = value; }
        }
        #endregion
    }
}
