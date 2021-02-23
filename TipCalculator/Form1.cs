using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double TipTotal = double.Parse(billenter.Text) * (double.Parse(tippercenttext.Text) / 100);
            tiptotal.Text = "" + TipTotal;
            TotalTextBox.Text = "" + (TipTotal + double.Parse(billenter.Text));
        }

        private void DoubleCheck(object sender, EventArgs e)
        {
            if (Double.TryParse(billenter.Text, out _) && Double.TryParse(tippercenttext.Text, out _))
            {
                CalculateButton.Enabled = true;
            }
            else
            {
                CalculateButton.Enabled = false;
            }
        }
    }
}
