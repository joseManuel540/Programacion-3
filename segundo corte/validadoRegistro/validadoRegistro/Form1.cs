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
            if (txtCorreo.Text == "")
            {
                lblcorreo.Visible = true;
                lblcorreo.Text = "El campo correo es obligatorio";
            }
            else
            {
                lblcorreo.Visible = false;
            }

            if (txtCorreo.Text != txtValidarCorreo.Text)
            {
                lblvalidadCorreo.Visible = true;
                lblvalidadCorreo.Text = "los correos no coinciden";
            }
            else
            {
                lblvalidadCorreo.Visible = false;
            }

            if (txtNombres.Text == "")
            {
                lblNombres.Visible = true;
                lblNombres.Text = "El campo nombre es obligatorio";
            }
            else
            {
                lblNombres.Visible= false;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
