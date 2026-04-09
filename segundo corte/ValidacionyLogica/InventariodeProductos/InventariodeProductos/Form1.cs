using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariodeProductos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numStockInicial_ValueChanged(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            bool IsValid = true;

            if (!Regex.IsMatch(codigo, "^PROD-")) //^ SE usa para indicar al inicio del texto
            {
                lblCodigo.Visible = true;
                IsValid = false;
            }
            else
            {
                lblCodigo.Visible = false;
            }

            if (cmCategoria.Text == "")
            {
                lblCategoria.Visible = true;
                IsValid = false;
            }
            else
            {
                lblCategoria.Visible= false;
            }

            if (numStockInicial.Value < numStockMinimo.Value)
            {
                lblStock.Visible = true;
                IsValid = false;
            }
            else
            {
                lblStock.Visible = false;
            }

            if (chkEsPerecedero.Checked)
            {
                dtpFechaVencimiento.Enabled = true;
            }

            if (!rbExento.Checked && !rbGeneral.Checked && !rbReducido.Checked)
            {
                lblIVA.Visible = true;
                IsValid = false;
            }
            else
            {
                lblIVA.Visible = false;
            }

            if (IsValid)
            {
                lblValidar.Visible = true;
            }
            else
            {
                lblValidar.Visible = false;
            }

        }

        private void lblIVA_Click(object sender, EventArgs e)
        {

        }
    }
}
