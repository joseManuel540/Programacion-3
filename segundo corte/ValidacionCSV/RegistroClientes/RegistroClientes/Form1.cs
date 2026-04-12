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

namespace RegistroClientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LimpiarCampos() 
        {
            txtNombre.Clear();
            txtCodigo.Clear();
            txtCiudad.Clear();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (txtCodigo.Text == "" && txtNombre.Text == "")
            {
                isValid = false;
            }

            if (txtCiudad.Text == "")
            {
                txtCiudad.Text = "No especificado";
            }


            string nombreArchivo = "clientes.csv";
            string rutaArchivo = Path.Combine(Application.StartupPath, nombreArchivo);

            // Si el archivo no existe, crear el encabezado
            if (!File.Exists(rutaArchivo))
            {
                File.WriteAllText(rutaArchivo, "Codigo,Ciudad,Nombre" + Environment.NewLine, Encoding.UTF8);
            }

            if (isValid)
            {
                string linea = $"{txtCodigo.Text},{txtCiudad.Text},{txtNombre.Text}" + Environment.NewLine;
                File.AppendAllText(rutaArchivo, linea, Encoding.UTF8);
                MessageBox.Show($"Se registro el cliente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();

            }
            else
            {
                MessageBox.Show($"Error al registrar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string nombreArchivo = "clientes.csv";
            string rutaArchivo = Path.Combine(Application.StartupPath, nombreArchivo);

            // Verificar si el archivo existe
            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show("No se encontró el archivo de clientes.", "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            listClientesRegistrados.Items.Clear();

            string[] lineas = File.ReadAllLines(rutaArchivo, Encoding.UTF8);

            // Procesar cada línea (saltar la primera línea que son los encabezados)
            for (int i = 1; i < lineas.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(lineas[i]))
                {
                    string[] campos = lineas[i].Split(',');
                    if (campos.Length >= 3)
                    {
                        string codigo = campos[0].Trim();
                        string ciudad = campos[1].Trim();
                        string nombre = campos[2].Trim();
                        

                        // Concatenar toda la información del producto
                        string productoCompleto = $"[{codigo}] {nombre} - ciudad: {ciudad}";
                        listClientesRegistrados.Items.Add(productoCompleto);
                    }
                }
            }

            MessageBox.Show($"Se cargaron {listClientesRegistrados.Items.Count} clientes.", "Carga exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
