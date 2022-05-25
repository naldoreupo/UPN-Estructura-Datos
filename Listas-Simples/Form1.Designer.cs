namespace Listas_Simples
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.txtListado = new System.Windows.Forms.TextBox();
            this.txtListadoConLibreria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(609, 364);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(225, 69);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(581, 188);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(300, 55);
            this.txtDato.TabIndex = 1;
            // 
            // txtListado
            // 
            this.txtListado.Location = new System.Drawing.Point(59, 534);
            this.txtListado.Multiline = true;
            this.txtListado.Name = "txtListado";
            this.txtListado.Size = new System.Drawing.Size(462, 629);
            this.txtListado.TabIndex = 2;
            // 
            // txtListadoConLibreria
            // 
            this.txtListadoConLibreria.Location = new System.Drawing.Point(734, 534);
            this.txtListadoConLibreria.Multiline = true;
            this.txtListadoConLibreria.Name = "txtListadoConLibreria";
            this.txtListadoConLibreria.Size = new System.Drawing.Size(504, 629);
            this.txtListadoConLibreria.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 1330);
            this.Controls.Add(this.txtListadoConLibreria);
            this.Controls.Add(this.txtListado);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAgregar;
        private TextBox txtDato;
        private TextBox txtListado;
        private TextBox txtListadoConLibreria;
    }
}