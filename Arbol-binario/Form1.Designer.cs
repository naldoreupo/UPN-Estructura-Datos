namespace Arbol_binario
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtListado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFormato = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPreOrder = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPostOrder = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtValoraBuscar = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(766, 192);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(225, 69);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(430, 199);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(300, 55);
            this.txtValor.TabIndex = 1;
            // 
            // txtListado
            // 
            this.txtListado.Location = new System.Drawing.Point(262, 577);
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
            this.label2.Location = new System.Drawing.Point(93, 602);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "InOrder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1588, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "Formato web";
            // 
            // txtFormato
            // 
            this.txtFormato.Location = new System.Drawing.Point(1570, 542);
            this.txtFormato.Multiline = true;
            this.txtFormato.Name = "txtFormato";
            this.txtFormato.Size = new System.Drawing.Size(786, 597);
            this.txtFormato.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 779);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 48);
            this.label7.TabIndex = 14;
            this.label7.Text = "Preorder";
            // 
            // txtPreOrder
            // 
            this.txtPreOrder.Location = new System.Drawing.Point(262, 754);
            this.txtPreOrder.Multiline = true;
            this.txtPreOrder.Name = "txtPreOrder";
            this.txtPreOrder.Size = new System.Drawing.Size(1246, 125);
            this.txtPreOrder.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 943);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 48);
            this.label8.TabIndex = 16;
            this.label8.Text = "PostOrder";
            // 
            // txtPostOrder
            // 
            this.txtPostOrder.Location = new System.Drawing.Point(262, 922);
            this.txtPostOrder.Multiline = true;
            this.txtPostOrder.Name = "txtPostOrder";
            this.txtPostOrder.Size = new System.Drawing.Size(1246, 125);
            this.txtPostOrder.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtValoraBuscar);
            this.groupBox1.Location = new System.Drawing.Point(1588, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 330);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(424, 226);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(225, 69);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.txtElimnar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(87, 226);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(225, 69);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtValoraBuscar
            // 
            this.txtValoraBuscar.Location = new System.Drawing.Point(96, 110);
            this.txtValoraBuscar.Name = "txtValoraBuscar";
            this.txtValoraBuscar.Size = new System.Drawing.Size(300, 55);
            this.txtValoraBuscar.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(1047, 192);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(225, 69);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2526, 1196);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPostOrder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPreOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFormato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtListado);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtListado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFormato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPreOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPostOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtValoraBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}
