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

        private void btnResultado_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Resultado: "+(double.Parse(txtN1.Text) + double.Parse(txtN2.Text));
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Resultado: " + (double.Parse(txtN1.Text) - double.Parse(txtN2.Text));
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Resultado: " + (double.Parse(txtN1.Text) * double.Parse(txtN2.Text));
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Resultado: " + (double.Parse(txtN1.Text) / double.Parse(txtN2.Text));
        }
    }
}
