namespace ReservaHotel
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numPersonas = new System.Windows.Forms.NumericUpDown();
            this.clbServicios = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbResumen = new System.Windows.Forms.RichTextBox();
            this.btnCalcularReserva = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(53, 134);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(221, 26);
            this.txtCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(547, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estancia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(699, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Salida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(396, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Entrada";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Location = new System.Drawing.Point(359, 134);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(200, 26);
            this.dtpEntrada.TabIndex = 5;
            this.dtpEntrada.ValueChanged += new System.EventHandler(this.dtpEntrada_ValueChanged);
            // 
            // dtpSalida
            // 
            this.dtpSalida.Location = new System.Drawing.Point(632, 134);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(200, 26);
            this.dtpSalida.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Datos";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Numero de personas";
            // 
            // numPersonas
            // 
            this.numPersonas.Location = new System.Drawing.Point(53, 238);
            this.numPersonas.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numPersonas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPersonas.Name = "numPersonas";
            this.numPersonas.Size = new System.Drawing.Size(120, 26);
            this.numPersonas.TabIndex = 9;
            this.numPersonas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // clbServicios
            // 
            this.clbServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbServicios.FormattingEnabled = true;
            this.clbServicios.Items.AddRange(new object[] {
            "Wifi Premium",
            "Desayuno Buffet",
            "Estacionamiento",
            "Spa"});
            this.clbServicios.Location = new System.Drawing.Point(53, 374);
            this.clbServicios.Name = "clbServicios";
            this.clbServicios.Size = new System.Drawing.Size(234, 164);
            this.clbServicios.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Servicios";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // rtbResumen
            // 
            this.rtbResumen.Location = new System.Drawing.Point(359, 374);
            this.rtbResumen.Name = "rtbResumen";
            this.rtbResumen.ReadOnly = true;
            this.rtbResumen.Size = new System.Drawing.Size(605, 174);
            this.rtbResumen.TabIndex = 13;
            this.rtbResumen.Text = "";
            this.rtbResumen.TextChanged += new System.EventHandler(this.rtbResumen_TextChanged);
            // 
            // btnCalcularReserva
            // 
            this.btnCalcularReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularReserva.Location = new System.Drawing.Point(360, 228);
            this.btnCalcularReserva.Name = "btnCalcularReserva";
            this.btnCalcularReserva.Size = new System.Drawing.Size(158, 95);
            this.btnCalcularReserva.TabIndex = 14;
            this.btnCalcularReserva.Text = "Calcular Reserva";
            this.btnCalcularReserva.UseVisualStyleBackColor = true;
            this.btnCalcularReserva.Click += new System.EventHandler(this.btnCalcularReserva_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.Red;
            this.lblNombre.Location = new System.Drawing.Point(53, 167);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(137, 20);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Ingrese el nombre";
            this.lblNombre.Visible = false;
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.ForeColor = System.Drawing.Color.Red;
            this.lblEntrada.Location = new System.Drawing.Point(356, 167);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(245, 20);
            this.lblEntrada.TabIndex = 16;
            this.lblEntrada.Text = "Ingrese una fecha valida Porfavor";
            this.lblEntrada.Visible = false;
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.ForeColor = System.Drawing.Color.Red;
            this.lblSalida.Location = new System.Drawing.Point(631, 167);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(245, 20);
            this.lblSalida.TabIndex = 17;
            this.lblSalida.Text = "Ingrese una fecha valida Porfavor";
            this.lblSalida.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 574);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCalcularReserva);
            this.Controls.Add(this.rtbResumen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clbServicios);
            this.Controls.Add(this.numPersonas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.dtpEntrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numPersonas;
        private System.Windows.Forms.CheckedListBox clbServicios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbResumen;
        private System.Windows.Forms.Button btnCalcularReserva;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblSalida;
    }
}

