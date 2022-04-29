using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblHours.Visible = false;
        }

        private void btnShowHours_Click(object sender, EventArgs e)
        {
            lblHours.Visible = true; // This will show the label
        }

        private void btnHideHours_Click(object sender, EventArgs e)
        {
            lblHours.Visible = false; // This will hide the label
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); // This will close the form
        }
    }
}
