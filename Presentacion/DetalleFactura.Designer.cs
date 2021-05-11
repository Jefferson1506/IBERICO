
namespace Proyecto_IBERICO.Presentacion
{
    partial class DetalleFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleFactura));
            this.label1 = new System.Windows.Forms.Label();
            this.Tabla_Detalle = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.Button_Filtro = new System.Windows.Forms.Button();
            this.TextBox_Filtro = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle Factura";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Tabla_Detalle
            // 
            this.Tabla_Detalle.AllowUserToOrderColumns = true;
            this.Tabla_Detalle.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tabla_Detalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Tabla_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla_Detalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.Tabla_Detalle.Location = new System.Drawing.Point(83, 59);
            this.Tabla_Detalle.Name = "Tabla_Detalle";
            this.Tabla_Detalle.RowTemplate.Height = 25;
            this.Tabla_Detalle.Size = new System.Drawing.Size(642, 306);
            this.Tabla_Detalle.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo Factura";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Producto";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Codigo Producto";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Precio";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Subtotal";
            this.Column6.Name = "Column6";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(608, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Button_Filtro
            // 
            this.Button_Filtro.Location = new System.Drawing.Point(358, 384);
            this.Button_Filtro.Name = "Button_Filtro";
            this.Button_Filtro.Size = new System.Drawing.Size(75, 23);
            this.Button_Filtro.TabIndex = 2;
            this.Button_Filtro.Text = "Filtrar";
            this.Button_Filtro.UseVisualStyleBackColor = true;
            // 
            // TextBox_Filtro
            // 
            this.TextBox_Filtro.AutoSize = true;
            this.TextBox_Filtro.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_Filtro.Location = new System.Drawing.Point(83, 388);
            this.TextBox_Filtro.Name = "TextBox_Filtro";
            this.TextBox_Filtro.Size = new System.Drawing.Size(163, 15);
            this.TextBox_Filtro.TabIndex = 3;
            this.TextBox_Filtro.Text = "Buscar por Codigo de Factura";
            this.TextBox_Filtro.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 384);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(-16, -37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 496);
            this.panel1.TabIndex = 5;
            // 
            // DetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TextBox_Filtro);
            this.Controls.Add(this.Button_Filtro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Tabla_Detalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "DetalleFactura";
            this.Text = "Cerrar";
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Detalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Tabla_Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Button_Filtro;
        private System.Windows.Forms.Label TextBox_Filtro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
    }
}