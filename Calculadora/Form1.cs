﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculos;

namespace Calculadora
{
    public partial class frmMultiplicacion : Form
    {
        public frmMultiplicacion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Multiplicacion m = new Multiplicacion();
        }

        private void lblMultiplicando_Click(object sender, EventArgs e)
        {

        }

        private void lblMultiplicador_Click(object sender, EventArgs e)
        {

        }

        private void multiplicador_TextChanged(object sender, EventArgs e)
        {

        }

        private void multiplicando_TextChanged(object sender, EventArgs e)
        {

        }
    }
}