namespace Listas_doble_enlazadas
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
            this.txtListado = new System.Windows.Forms.TextBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtListadoReverso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtListado
            // 
            this.txtListado.Location = new System.Drawing.Point(262, 351);
            this.txtListado.Multiline = true;
            this.txtListado.Name = "txtListado";
            this.txtListado.Size = new System.Drawing.Size(462, 629);
            this.txtListado.TabIndex = 9;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(332, 111);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(300, 55);
            this.txtDato.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(356, 245);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(225, 69);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtListadoReverso
            // 
            this.txtListadoReverso.Location = new System.Drawing.Point(993, 374);
            this.txtListadoReverso.Multiline = true;
            this.txtListadoReverso.Name = "txtListadoReverso";
            this.txtListadoReverso.Size = new System.Drawing.Size(500, 645);
            this.txtListadoReverso.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 1400);
            this.Controls.Add(this.txtListadoReverso);
            this.Controls.Add(this.txtListado);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtListado;
        private TextBox txtDato;
        private Button btnAgregar;
        private TextBox txtListadoReverso;
    }
}