﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormaulaDeBhaskara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 5;
            int c = 2;
            double delta;
            double a1;
            double a2;

            delta = b * b - 4 * a * c;
            a1 = ((-b) + Math.Sqrt(delta)) / (2*a);
            a2 = ((-b) - Math.Sqrt(delta)) / (2 * a);
             MessageBox.Show(string.Format("Valor de A1 = {0}. Valor de A2 = {1}", a1, a2));
        }
    }
}
