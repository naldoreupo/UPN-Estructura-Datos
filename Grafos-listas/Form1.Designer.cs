namespace Grafos_listas
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtListaAdyacencias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDFS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(454, 147);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(146, 55);
            this.txtDato.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "dato\r\n";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(644, 140);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(225, 69);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(174, 382);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(300, 55);
            this.txtOrigen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "Destino";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(525, 382);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(300, 55);
            this.txtDestino.TabIndex = 5;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(852, 368);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(225, 69);
            this.btnConectar.TabIndex = 7;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtListaAdyacencias
            // 
            this.txtListaAdyacencias.Location = new System.Drawing.Point(174, 624);
            this.txtListaAdyacencias.Multiline = true;
            this.txtListaAdyacencias.Name = "txtListaAdyacencias";
            this.txtListaAdyacencias.Size = new System.Drawing.Size(704, 471);
            this.txtListaAdyacencias.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 549);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 48);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lista Adyacencias";
            // 
            // txtDFS
            // 
            this.txtDFS.Location = new System.Drawing.Point(1098, 660);
            this.txtDFS.Multiline = true;
            this.txtDFS.Name = "txtDFS";
            this.txtDFS.Size = new System.Drawing.Size(774, 165);
            this.txtDFS.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1098, 578);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 48);
            this.label5.TabIndex = 11;
            this.label5.Text = "DFS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2116, 1408);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDFS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtListaAdyacencias);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtListaAdyacencias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDFS;
        private System.Windows.Forms.Label label5;
    }
}
