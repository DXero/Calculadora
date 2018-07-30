﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (cbOperacion.SelectedIndex == 0) {
                lblResultado.Text = "Resultado: " + (double.Parse(txtN1.Text) + double.Parse(txtN2.Text));
            }
            else if (cbOperacion.SelectedIndex == 1)
            {
                lblResultado.Text = "Resultado: " + (double.Parse(txtN1.Text) - double.Parse(txtN2.Text));
            }
            else if (cbOperacion.SelectedIndex == 2)
            {
                lblResultado.Text = "Resultado: " + (double.Parse(txtN1.Text) * double.Parse(txtN2.Text));
            }
            else if (cbOperacion.SelectedIndex == 3)
            {
                lblResultado.Text = "Resultado: " + (double.Parse(txtN1.Text) / double.Parse(txtN2.Text));
            }
        }
    }
}
