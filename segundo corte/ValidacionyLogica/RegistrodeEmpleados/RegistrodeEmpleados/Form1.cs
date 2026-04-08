using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegistrodeEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblIdentificacion_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            bool isValid = true;

            if (txtNombres.Text == "")
            {
                lblNombres.Visible = true;
                isValid = false;
            }
            else
            {
                lblNombres.Visible =false;
            }

            if (txtApellidos.Text == "")
            {
                lblApellidos.Visible = true;
                isValid = false;
            }
            else
            {
                lblApellidos.Visible = false;
            }

            if (!Regex.IsMatch(email, "@") && !Regex.IsMatch(email, "\\."))
            {
                lblEmail.Visible = true;
                isValid = false;
            }
            else
            {
                lblEmail.Visible = false;
            }

            if (txtIdentificacion.Text.Length != 10)
            {
                lblIdentificacion.Visible = true;
                isValid = false;
            }
            else
            {
                lblIdentificacion.Visible = false;
            }

            if (cmbDepartamento.Text == "")
            {
                lblDepartamento.Visible = true;
                isValid = false;
            }
            else
            {
                lblDepartamento.Visible = false;
            }

            if (isValid)
            {
                decimal sueldo = numSueldoBase.Value - (numSueldoBase.Value * 0.1m);
                lblSueldoNeto.Visible = true;
                lblSueldoNeto.Text = sueldo.ToString("C");
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblNombres.Visible = false;
            lblApellidos.Visible=false;
            lblEmail.Visible=false;
            lblIdentificacion.Visible = false;
            lblSueldoNeto.Visible = false;
            lblDepartamento.Visible = false;

            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtEmail.Text = "";
            numSueldoBase.Value = 1000;
            txtIdentificacion.Text = "";
            cmbDepartamento.Text = "";
            

        }
    }
}
