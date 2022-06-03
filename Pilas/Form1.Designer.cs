namespace Pilas
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
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.txtListado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(600, 189);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(225, 69);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(222, 196);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(300, 55);
            this.txtDatos.TabIndex = 1;
            // 
            // txtListado
            // 
            this.txtListado.Location = new System.Drawing.Point(232, 433);
            this.txtListado.Multiline = true;
            this.txtListado.Name = "txtListado";
            this.txtListado.Size = new System.Drawing.Size(474, 439);
            this.txtListado.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 1424);
            this.Controls.Add(this.txtListado);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAgregar;
        private TextBox txtDatos;
        private TextBox txtListado;
    }
}