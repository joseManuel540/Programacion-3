namespace InventariodeProductos
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmCategoria = new System.Windows.Forms.ComboBox();
            this.numStockInicial = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbExento = new System.Windows.Forms.RadioButton();
            this.rbGeneral = new System.Windows.Forms.RadioButton();
            this.rbReducido = new System.Windows.Forms.RadioButton();
            this.chkEsPerecedero = new System.Windows.Forms.CheckBox();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.numStockMinimo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numStockInicial)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMinimo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(58, 85);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(268, 26);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria";
            // 
            // cmCategoria
            // 
            this.cmCategoria.FormattingEnabled = true;
            this.cmCategoria.Items.AddRange(new object[] {
            "Electronica",
            "Alimentos",
            "Ropa"});
            this.cmCategoria.Location = new System.Drawing.Point(369, 85);
            this.cmCategoria.Name = "cmCategoria";
            this.cmCategoria.Size = new System.Drawing.Size(121, 28);
            this.cmCategoria.TabIndex = 3;
            // 
            // numStockInicial
            // 
            this.numStockInicial.Location = new System.Drawing.Point(812, 87);
            this.numStockInicial.Name = "numStockInicial";
            this.numStockInicial.Size = new System.Drawing.Size(120, 26);
            this.numStockInicial.TabIndex = 4;
            this.numStockInicial.ValueChanged += new System.EventHandler(this.numStockInicial_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(601, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stock min";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbReducido);
            this.groupBox1.Controls.Add(this.rbGeneral);
            this.groupBox1.Controls.Add(this.rbExento);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(58, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 240);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IVA";
            // 
            // rbExento
            // 
            this.rbExento.AutoSize = true;
            this.rbExento.Location = new System.Drawing.Point(20, 58);
            this.rbExento.Name = "rbExento";
            this.rbExento.Size = new System.Drawing.Size(75, 33);
            this.rbExento.TabIndex = 0;
            this.rbExento.TabStop = true;
            this.rbExento.Text = "0%";
            this.rbExento.UseVisualStyleBackColor = true;
            // 
            // rbGeneral
            // 
            this.rbGeneral.AutoSize = true;
            this.rbGeneral.Location = new System.Drawing.Point(20, 119);
            this.rbGeneral.Name = "rbGeneral";
            this.rbGeneral.Size = new System.Drawing.Size(89, 33);
            this.rbGeneral.TabIndex = 1;
            this.rbGeneral.TabStop = true;
            this.rbGeneral.Text = "19%";
            this.rbGeneral.UseVisualStyleBackColor = true;
            // 
            // rbReducido
            // 
            this.rbReducido.AutoSize = true;
            this.rbReducido.Location = new System.Drawing.Point(20, 188);
            this.rbReducido.Name = "rbReducido";
            this.rbReducido.Size = new System.Drawing.Size(75, 33);
            this.rbReducido.TabIndex = 2;
            this.rbReducido.TabStop = true;
            this.rbReducido.Text = "5%";
            this.rbReducido.UseVisualStyleBackColor = true;
            // 
            // chkEsPerecedero
            // 
            this.chkEsPerecedero.AutoSize = true;
            this.chkEsPerecedero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEsPerecedero.Location = new System.Drawing.Point(550, 186);
            this.chkEsPerecedero.Name = "chkEsPerecedero";
            this.chkEsPerecedero.Size = new System.Drawing.Size(214, 33);
            this.chkEsPerecedero.TabIndex = 7;
            this.chkEsPerecedero.Text = "Es Perecedero";
            this.chkEsPerecedero.UseVisualStyleBackColor = true;
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVencimiento.Enabled = false;
            this.dtpFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(550, 230);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(348, 30);
            this.dtpFechaVencimiento.TabIndex = 8;
            // 
            // numStockMinimo
            // 
            this.numStockMinimo.Location = new System.Drawing.Point(606, 87);
            this.numStockMinimo.Name = "numStockMinimo";
            this.numStockMinimo.Size = new System.Drawing.Size(120, 26);
            this.numStockMinimo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(805, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stock inicial";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 637);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numStockMinimo);
            this.Controls.Add(this.dtpFechaVencimiento);
            this.Controls.Add(this.chkEsPerecedero);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numStockInicial);
            this.Controls.Add(this.cmCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numStockInicial)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMinimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmCategoria;
        private System.Windows.Forms.NumericUpDown numStockInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbReducido;
        private System.Windows.Forms.RadioButton rbGeneral;
        private System.Windows.Forms.RadioButton rbExento;
        private System.Windows.Forms.CheckBox chkEsPerecedero;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.NumericUpDown numStockMinimo;
        private System.Windows.Forms.Label label4;
    }
}

