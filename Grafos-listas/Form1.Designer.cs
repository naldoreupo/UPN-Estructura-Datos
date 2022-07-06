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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDatoABuscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCantidadNodos = new System.Windows.Forms.Label();
            this.lblAristas = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBFS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRutaMinima = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            this.txtOrigen.Location = new System.Drawing.Point(32, 389);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(300, 55);
            this.txtOrigen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "Destino";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(383, 389);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(300, 55);
            this.txtDestino.TabIndex = 5;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(980, 382);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(225, 69);
            this.btnConectar.TabIndex = 7;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtListaAdyacencias
            // 
            this.txtListaAdyacencias.Location = new System.Drawing.Point(161, 719);
            this.txtListaAdyacencias.Multiline = true;
            this.txtListaAdyacencias.Name = "txtListaAdyacencias";
            this.txtListaAdyacencias.Size = new System.Drawing.Size(704, 471);
            this.txtListaAdyacencias.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 644);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 48);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lista Adyacencias";
            // 
            // txtDFS
            // 
            this.txtDFS.Location = new System.Drawing.Point(1091, 684);
            this.txtDFS.Multiline = true;
            this.txtDFS.Name = "txtDFS";
            this.txtDFS.Size = new System.Drawing.Size(774, 165);
            this.txtDFS.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1078, 644);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 48);
            this.label5.TabIndex = 11;
            this.label5.Text = "DFS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDatoABuscar);
            this.groupBox1.Location = new System.Drawing.Point(1202, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1426, 318);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(749, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 69);
            this.button1.TabIndex = 18;
            this.button1.Text = "Rutas minimas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(482, 130);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(225, 69);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 48);
            this.label6.TabIndex = 16;
            this.label6.Text = "Dato a buscar";
            // 
            // txtDatoABuscar
            // 
            this.txtDatoABuscar.Location = new System.Drawing.Point(312, 137);
            this.txtDatoABuscar.Name = "txtDatoABuscar";
            this.txtDatoABuscar.Size = new System.Drawing.Size(146, 55);
            this.txtDatoABuscar.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 532);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 48);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nodos: ";
            // 
            // lblCantidadNodos
            // 
            this.lblCantidadNodos.AutoSize = true;
            this.lblCantidadNodos.Location = new System.Drawing.Point(365, 532);
            this.lblCantidadNodos.Name = "lblCantidadNodos";
            this.lblCantidadNodos.Size = new System.Drawing.Size(143, 48);
            this.lblCantidadNodos.TabIndex = 17;
            this.lblCantidadNodos.Text = "Nodos: ";
            // 
            // lblAristas
            // 
            this.lblAristas.AutoSize = true;
            this.lblAristas.Location = new System.Drawing.Point(1000, 532);
            this.lblAristas.Name = "lblAristas";
            this.lblAristas.Size = new System.Drawing.Size(143, 48);
            this.lblAristas.TabIndex = 19;
            this.lblAristas.Text = "Nodos: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(682, 532);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(294, 48);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cantidad Aristas :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1103, 897);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 48);
            this.label8.TabIndex = 21;
            this.label8.Text = "BFS";
            // 
            // txtBFS
            // 
            this.txtBFS.Location = new System.Drawing.Point(1091, 965);
            this.txtBFS.Multiline = true;
            this.txtBFS.Name = "txtBFS";
            this.txtBFS.Size = new System.Drawing.Size(774, 165);
            this.txtBFS.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1091, 1179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(221, 48);
            this.label10.TabIndex = 23;
            this.label10.Text = "Ruta Minima";
            // 
            // txtRutaMinima
            // 
            this.txtRutaMinima.Location = new System.Drawing.Point(1091, 1261);
            this.txtRutaMinima.Multiline = true;
            this.txtRutaMinima.Name = "txtRutaMinima";
            this.txtRutaMinima.Size = new System.Drawing.Size(774, 165);
            this.txtRutaMinima.TabIndex = 22;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(703, 320);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(141, 48);
            this.lblPeso.TabIndex = 25;
            this.lblPeso.Text = "Destino";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(703, 389);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(232, 55);
            this.txtPeso.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1041, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 69);
            this.button2.TabIndex = 19;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2750, 1542);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRutaMinima);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBFS);
            this.Controls.Add(this.lblAristas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCantidadNodos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDatoABuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCantidadNodos;
        private System.Windows.Forms.Label lblAristas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBFS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRutaMinima;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Button button2;
    }
}
