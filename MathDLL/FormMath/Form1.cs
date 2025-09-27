using MathDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormMath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int a, b, c;
            if (!int.TryParse(txtA.Text, out a) || !int.TryParse(txtB.Text, out b) || !int.TryParse(txtC.Text, out c) ||
                a < 0 || a > 9 || b < 0 || b > 9 || c < 0 || c > 9)
            {
                MessageBox.Show("Chỉ nhập chữ số 0-9!");
                return;
            }

            Calculator calc = new Calculator();
            calc.NumA = a;
            calc.NumB = b;
            calc.NumC = c;
            calc.Calculate();

            lblResult.Text = calc.Message;
        }
    }
}
