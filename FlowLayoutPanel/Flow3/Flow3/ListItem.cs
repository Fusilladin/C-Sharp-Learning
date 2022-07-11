﻿using System;
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
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }

        #region Properties

        private Color _iconBack;
        private string _title;
        private string _message;
        private Image _icon;
        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; LblTitle.Text = value; }
        }
        [Category("Custom Props")]
        public Color IconBackground
        {
            get { return _iconBack; }
            set { _iconBack = value; panel1.BackColor = value; }
        }
        [Category("Custom Props")]
        public string Message
        {
            get { return _message; }
            set { _message = value; LblMessage.Text = value; }
        }
        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }

        #endregion

        private void ListItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void ListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void LblTitle_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void LblTitle_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
