using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegalAge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int userAge = Convert.ToInt32(txtAgeBox.Text);

            if (userAge >= 19 && userAge <= 99)
                lblAnswer.Text = "Party like it's the end of the world";
            else if (userAge >= 100)
                lblAnswer.Text = "Dang! You look good!";
            else
                lblAnswer.Text = "Um... Shouldn't you be asking your parents";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = "Your output will be displayed here";
            txtAgeBox.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
