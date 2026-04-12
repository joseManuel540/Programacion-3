using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasDiarias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtID.Clear();
            numMonto.Value = 0; 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (txtID.Text == "")
            {
                isValid = false;
            }

            string nombreArchivo = "historial.csv";
            string rutaArchivo = Path.Combine(Application.StartupPath, nombreArchivo);

            // Si el archivo no existe, crear el encabezado
            if (!File.Exists(rutaArchivo))
            {
                File.WriteAllText(rutaArchivo, "ID,Monto" + Environment.NewLine, Encoding.UTF8);
            }

            if (isValid)
            {
                string linea = $"{txtID.Text},{numMonto.Value}" + Environment.NewLine;
                File.AppendAllText(rutaArchivo, linea, Encoding.UTF8);
                MessageBox.Show($"Se registro la venta.", "Venta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();

            }
            else
            {
                MessageBox.Show($"Error al registrar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numMonto_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            double total = 0;
            string nombreArchivo = "historial.csv";
            string rutaArchivo = Path.Combine(Application.StartupPath, nombreArchivo);

            // Verificar si el archivo existe
            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show("No se encontró el archivo de ventas.", "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            listVenta.Items.Clear();
            lblTotal.Text = "$0.00";

            string[] lineas = File.ReadAllLines(rutaArchivo, Encoding.UTF8);

            // Procesar cada línea (saltar la primera línea que son los encabezados)
            for (int i = 1; i < lineas.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(lineas[i]))
                {
                    string[] campos = lineas[i].Split(',');
                    if (campos.Length >= 2)
                    {
                        string ID = campos[0].Trim();
                        string monto = campos[1].Trim();
                        double total2 = double.Parse(monto);
                        total = total2 + total;

                        // Concatenar toda la información del producto
                        string ventaCompleta = $"[{ID}] - Monto: ${monto}";
                        listVenta.Items.Add(ventaCompleta);
                    }
                }
            }

            lblTotal.Text = $"${total.ToString()}";

            MessageBox.Show($"Se cargaron {listVenta.Items.Count} ventas.", "Carga exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
