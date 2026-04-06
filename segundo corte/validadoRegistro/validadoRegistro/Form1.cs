using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace validadoRegistro
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

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (txtCorreo.Text == "")
            {
                lblcorreo.Visible = true;
                lblcorreo.Text = "El campo correo es obligatorio";
                isValid = false;
            }
            else
            {
                lblcorreo.Visible = false;
            }

            if (txtCorreo.Text != txtValidarCorreo.Text)
            {
                lblvalidadCorreo.Visible = true;
                lblvalidadCorreo.Text = "los correos no coinciden";
                isValid = false;
            }
            else
            {
                lblvalidadCorreo.Visible = false;
            }

            if (txtNombres.Text == "")
            {
                lblNombres.Visible = true;
                lblNombres.Text = "El campo nombre es obligatorio";
                isValid = false;
            }
            else
            {
                lblNombres.Visible= false;
            }


            if (!rbMasculino.Checked && !rbFemenino.Checked)
            {
                lblMasculino.Visible = true;
                lblMasculino.Text = "Debe seleccionar un género";
                isValid = false;
            }
            else
            {
                lblMasculino.Visible = false;
            }

            if (isValid)
            {
                if (rbMasculino.Checked)
                {
                    lblRegistroExitoso.Visible = true;
                    lblRegistroExitoso.Text = "Registro exitoso para el señor " + txtNombres.Text;
                }
                else
                {
                    lblRegistroExitoso.Visible = true;
                    lblRegistroExitoso.Text = "Registro exitoso para la señora " + txtNombres.Text;
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblcorreo_Click(object sender, EventArgs e)
        {

        }
    }
}
