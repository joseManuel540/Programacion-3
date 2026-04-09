using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ReservaHotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rtbResumen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcularReserva_Click(object sender, EventArgs e)
        {
            bool IsValid = true;
            DateTime entrada = dtpEntrada.Value.Date;  //para ignorar hora
            DateTime salida = dtpSalida.Value.Date;
            TimeSpan diff = salida - entrada;
            string servicios = "";
            int cantidadServicios = 0;
            

            if (txtCliente.Text == "")
            {
                lblNombre.Visible = true;
                IsValid = false;
            }
            else
            {
                lblNombre.Visible = false;
            }

            if (dtpEntrada.Value < DateTime.Today)
            {
                lblEntrada.Visible = true;
                IsValid = false;
            }
            else
            {
                lblEntrada.Visible = false;
            }

            if (dtpEntrada.Value >= dtpSalida.Value)
            {
                lblSalida.Visible = true;
                IsValid = false;
            }
            else
            {
                lblSalida.Visible = false;
            }

            foreach (var item in clbServicios.CheckedItems)
            {
                servicios = servicios + ", " + item.ToString();
                cantidadServicios = cantidadServicios + 1;
            }

            if (IsValid)
            {
                decimal costoNoches = 50 * diff.Days;
                decimal costoPersona = 15 * (numPersonas.Value - 1) * diff.Days;
                decimal costoServicios = 10 * cantidadServicios * diff.Days;
                decimal costoTotal = costoServicios + costoNoches + costoPersona;

                rtbResumen.Text = $@" 
                ------------ Resumen de Reserva ------------
                Cliente: {txtCliente.Text}
                Estancia: {diff.Days} Noches
                Personas: {numPersonas.Value}
                Servicios: {servicios}
                --------------------------------------------
                Total a pagar: {costoTotal} ";
                //el arroba es para que conserve toda la lliena y tab
            }

        }

        private void dtpEntrada_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
