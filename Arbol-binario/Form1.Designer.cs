﻿namespace Arbol_binario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFormato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(576, 182);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(225, 69);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(216, 196);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(300, 55);
            this.txtDato.TabIndex = 1;
            // 
            // txtListado
            // 
            this.txtListado.Location = new System.Drawing.Point(278, 349);
            this.txtListado.Multiline = true;
            this.txtListado.Name = "txtListado";
            this.txtListado.Size = new System.Drawing.Size(1246, 125);
            this.txtListado.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Arbol Binario busqeda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "InOrder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 563);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "Formato web";
            // 
            // txtFormato
            // 
            this.txtFormato.Location = new System.Drawing.Point(283, 536);
            this.txtFormato.Multiline = true;
            this.txtFormato.Name = "txtFormato";
            this.txtFormato.Size = new System.Drawing.Size(1246, 125);
            this.txtFormato.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1642, 1196);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFormato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtListado);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.TextBox txtListado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFormato;
    }
}
