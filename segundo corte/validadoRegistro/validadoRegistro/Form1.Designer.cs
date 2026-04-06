namespace validadoRegistro
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
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtValidarCorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblvalidadCorreo = new System.Windows.Forms.Label();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lblRegistroExitoso = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblMasculino = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(73, 93);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(278, 26);
            this.txtCorreo.TabIndex = 2;
            // 
            // txtValidarCorreo
            // 
            this.txtValidarCorreo.Location = new System.Drawing.Point(404, 93);
            this.txtValidarCorreo.Name = "txtValidarCorreo";
            this.txtValidarCorreo.Size = new System.Drawing.Size(278, 26);
            this.txtValidarCorreo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirmar Correo";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(69, 370);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(124, 68);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblvalidadCorreo
            // 
            this.lblvalidadCorreo.AutoSize = true;
            this.lblvalidadCorreo.ForeColor = System.Drawing.Color.Red;
            this.lblvalidadCorreo.Location = new System.Drawing.Point(404, 126);
            this.lblvalidadCorreo.Name = "lblvalidadCorreo";
            this.lblvalidadCorreo.Size = new System.Drawing.Size(51, 20);
            this.lblvalidadCorreo.TabIndex = 6;
            this.lblvalidadCorreo.Text = "label3";
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.ForeColor = System.Drawing.Color.Red;
            this.lblcorreo.Location = new System.Drawing.Point(78, 126);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(51, 20);
            this.lblcorreo.TabIndex = 7;
            this.lblcorreo.Text = "label4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFemenino);
            this.groupBox1.Controls.Add(this.rbMasculino);
            this.groupBox1.Location = new System.Drawing.Point(408, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 108);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genero";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(6, 25);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(105, 24);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(6, 72);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(105, 24);
            this.rbFemenino.TabIndex = 1;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(73, 197);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(278, 26);
            this.txtNombres.TabIndex = 10;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(69, 165);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(73, 20);
            this.lbl5.TabIndex = 9;
            this.lbl5.Text = "Nombres";
            this.lbl5.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblRegistroExitoso
            // 
            this.lblRegistroExitoso.AutoSize = true;
            this.lblRegistroExitoso.ForeColor = System.Drawing.Color.Lime;
            this.lblRegistroExitoso.Location = new System.Drawing.Point(233, 394);
            this.lblRegistroExitoso.Name = "lblRegistroExitoso";
            this.lblRegistroExitoso.Size = new System.Drawing.Size(51, 20);
            this.lblRegistroExitoso.TabIndex = 11;
            this.lblRegistroExitoso.Text = "label3";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.ForeColor = System.Drawing.Color.Red;
            this.lblNombres.Location = new System.Drawing.Point(78, 241);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(51, 20);
            this.lblNombres.TabIndex = 12;
            this.lblNombres.Text = "label3";
            // 
            // lblMasculino
            // 
            this.lblMasculino.AutoSize = true;
            this.lblMasculino.ForeColor = System.Drawing.Color.Red;
            this.lblMasculino.Location = new System.Drawing.Point(410, 290);
            this.lblMasculino.Name = "lblMasculino";
            this.lblMasculino.Size = new System.Drawing.Size(51, 20);
            this.lblMasculino.TabIndex = 13;
            this.lblMasculino.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMasculino);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblRegistroExitoso);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblcorreo);
            this.Controls.Add(this.lblvalidadCorreo);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtValidarCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtValidarCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblvalidadCorreo;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lblRegistroExitoso;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblMasculino;
    }
}

