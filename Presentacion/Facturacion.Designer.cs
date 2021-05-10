
namespace Proyecto_IBERICO.Presentacion
{
    partial class Facturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboDia = new System.Windows.Forms.ComboBox();
            this.comboMes = new System.Windows.Forms.ComboBox();
            this.comboAño = new System.Windows.Forms.ComboBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.boxVaca = new System.Windows.Forms.CheckBox();
            this.boxCerdo = new System.Windows.Forms.CheckBox();
            this.lbVaca = new System.Windows.Forms.Label();
            this.txtVacaCan = new System.Windows.Forms.TextBox();
            this.lbCerdo = new System.Windows.Forms.Label();
            this.txtCantidadCerdo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtValorVaca = new System.Windows.Forms.TextBox();
            this.lbPrecioVaca = new System.Windows.Forms.Label();
            this.txtValorCerdo = new System.Windows.Forms.TextBox();
            this.lbPrecioCerdo = new System.Windows.Forms.Label();
            this.txtTotalVaca = new System.Windows.Forms.TextBox();
            this.lbTotalVaca = new System.Windows.Forms.Label();
            this.txtTotalCerdo = new System.Windows.Forms.TextBox();
            this.lbTotalCerdo = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lbLiquidar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(411, 590);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(144, 532);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(144, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Liquidar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre_Proveedor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(355, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cod_Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(179, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Facturación De Productos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(10, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 25);
            this.label12.TabIndex = 79;
            this.label12.Text = "Fecha De Facturacion";
            // 
            // comboDia
            // 
            this.comboDia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboDia.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.comboDia.FormattingEnabled = true;
            this.comboDia.Location = new System.Drawing.Point(220, 87);
            this.comboDia.Name = "comboDia";
            this.comboDia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboDia.Size = new System.Drawing.Size(84, 29);
            this.comboDia.TabIndex = 80;
            this.comboDia.Text = "Día";
            // 
            // comboMes
            // 
            this.comboMes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboMes.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.comboMes.FormattingEnabled = true;
            this.comboMes.Location = new System.Drawing.Point(330, 87);
            this.comboMes.Name = "comboMes";
            this.comboMes.Size = new System.Drawing.Size(89, 29);
            this.comboMes.TabIndex = 81;
            this.comboMes.Text = "Mes";
            // 
            // comboAño
            // 
            this.comboAño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboAño.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.comboAño.FormattingEnabled = true;
            this.comboAño.Location = new System.Drawing.Point(441, 87);
            this.comboAño.Name = "comboAño";
            this.comboAño.Size = new System.Drawing.Size(95, 29);
            this.comboAño.TabIndex = 82;
            this.comboAño.Text = "Año";
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.Salmon;
            this.btCalcular.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btCalcular.Font = new System.Drawing.Font("SimSun-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCalcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btCalcular.Location = new System.Drawing.Point(266, 370);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(110, 45);
            this.btCalcular.TabIndex = 85;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(204, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 86;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(507, 168);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 87;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxVaca
            // 
            this.boxVaca.AutoSize = true;
            this.boxVaca.BackColor = System.Drawing.Color.White;
            this.boxVaca.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxVaca.Location = new System.Drawing.Point(111, 263);
            this.boxVaca.Name = "boxVaca";
            this.boxVaca.Size = new System.Drawing.Size(60, 24);
            this.boxVaca.TabIndex = 88;
            this.boxVaca.Text = "Vaca";
            this.boxVaca.UseVisualStyleBackColor = false;
            this.boxVaca.CheckedChanged += new System.EventHandler(this.boxVaca_CheckedChanged);
            // 
            // boxCerdo
            // 
            this.boxCerdo.AutoSize = true;
            this.boxCerdo.BackColor = System.Drawing.Color.White;
            this.boxCerdo.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxCerdo.Location = new System.Drawing.Point(415, 263);
            this.boxCerdo.Name = "boxCerdo";
            this.boxCerdo.Size = new System.Drawing.Size(68, 24);
            this.boxCerdo.TabIndex = 89;
            this.boxCerdo.Text = "Cerdo";
            this.boxCerdo.UseVisualStyleBackColor = false;
            this.boxCerdo.CheckedChanged += new System.EventHandler(this.boxCerdo_CheckedChanged);
            // 
            // lbVaca
            // 
            this.lbVaca.AutoSize = true;
            this.lbVaca.BackColor = System.Drawing.Color.Transparent;
            this.lbVaca.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbVaca.Location = new System.Drawing.Point(20, 331);
            this.lbVaca.Name = "lbVaca";
            this.lbVaca.Size = new System.Drawing.Size(82, 24);
            this.lbVaca.TabIndex = 90;
            this.lbVaca.Text = "Cantidad";
            // 
            // txtVacaCan
            // 
            this.txtVacaCan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVacaCan.Location = new System.Drawing.Point(131, 333);
            this.txtVacaCan.Name = "txtVacaCan";
            this.txtVacaCan.Size = new System.Drawing.Size(100, 25);
            this.txtVacaCan.TabIndex = 91;
            this.txtVacaCan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbCerdo
            // 
            this.lbCerdo.AutoSize = true;
            this.lbCerdo.BackColor = System.Drawing.Color.Transparent;
            this.lbCerdo.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbCerdo.Location = new System.Drawing.Point(407, 331);
            this.lbCerdo.Name = "lbCerdo";
            this.lbCerdo.Size = new System.Drawing.Size(82, 24);
            this.lbCerdo.TabIndex = 92;
            this.lbCerdo.Text = "Cantidad";
            // 
            // txtCantidadCerdo
            // 
            this.txtCantidadCerdo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantidadCerdo.Location = new System.Drawing.Point(518, 333);
            this.txtCantidadCerdo.Name = "txtCantidadCerdo";
            this.txtCantidadCerdo.Size = new System.Drawing.Size(100, 25);
            this.txtCantidadCerdo.TabIndex = 93;
            this.txtCantidadCerdo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.lbLiquidar);
            this.panel1.Controls.Add(this.txtTotalCerdo);
            this.panel1.Controls.Add(this.lbTotalCerdo);
            this.panel1.Controls.Add(this.txtTotalVaca);
            this.panel1.Controls.Add(this.lbTotalVaca);
            this.panel1.Controls.Add(this.txtValorCerdo);
            this.panel1.Controls.Add(this.lbPrecioCerdo);
            this.panel1.Controls.Add(this.txtValorVaca);
            this.panel1.Controls.Add(this.lbPrecioVaca);
            this.panel1.Controls.Add(this.txtCantidadCerdo);
            this.panel1.Controls.Add(this.lbCerdo);
            this.panel1.Controls.Add(this.txtVacaCan);
            this.panel1.Controls.Add(this.lbVaca);
            this.panel1.Controls.Add(this.boxCerdo);
            this.panel1.Controls.Add(this.boxVaca);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btCalcular);
            this.panel1.Controls.Add(this.comboAño);
            this.panel1.Controls.Add(this.comboMes);
            this.panel1.Controls.Add(this.comboDia);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(402, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 589);
            this.panel1.TabIndex = 5;
            // 
            // txtValorVaca
            // 
            this.txtValorVaca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorVaca.Location = new System.Drawing.Point(131, 395);
            this.txtValorVaca.Name = "txtValorVaca";
            this.txtValorVaca.Size = new System.Drawing.Size(100, 25);
            this.txtValorVaca.TabIndex = 95;
            this.txtValorVaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbPrecioVaca
            // 
            this.lbPrecioVaca.AutoSize = true;
            this.lbPrecioVaca.BackColor = System.Drawing.Color.Transparent;
            this.lbPrecioVaca.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbPrecioVaca.Location = new System.Drawing.Point(20, 393);
            this.lbPrecioVaca.Name = "lbPrecioVaca";
            this.lbPrecioVaca.Size = new System.Drawing.Size(59, 24);
            this.lbPrecioVaca.TabIndex = 94;
            this.lbPrecioVaca.Text = "Precio";
            // 
            // txtValorCerdo
            // 
            this.txtValorCerdo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorCerdo.Location = new System.Drawing.Point(518, 393);
            this.txtValorCerdo.Name = "txtValorCerdo";
            this.txtValorCerdo.Size = new System.Drawing.Size(100, 25);
            this.txtValorCerdo.TabIndex = 97;
            this.txtValorCerdo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbPrecioCerdo
            // 
            this.lbPrecioCerdo.AutoSize = true;
            this.lbPrecioCerdo.BackColor = System.Drawing.Color.Transparent;
            this.lbPrecioCerdo.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbPrecioCerdo.Location = new System.Drawing.Point(407, 391);
            this.lbPrecioCerdo.Name = "lbPrecioCerdo";
            this.lbPrecioCerdo.Size = new System.Drawing.Size(59, 24);
            this.lbPrecioCerdo.TabIndex = 96;
            this.lbPrecioCerdo.Text = "Precio";
            // 
            // txtTotalVaca
            // 
            this.txtTotalVaca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalVaca.Location = new System.Drawing.Point(131, 456);
            this.txtTotalVaca.Name = "txtTotalVaca";
            this.txtTotalVaca.Size = new System.Drawing.Size(100, 25);
            this.txtTotalVaca.TabIndex = 99;
            this.txtTotalVaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTotalVaca
            // 
            this.lbTotalVaca.AutoSize = true;
            this.lbTotalVaca.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalVaca.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbTotalVaca.Location = new System.Drawing.Point(20, 454);
            this.lbTotalVaca.Name = "lbTotalVaca";
            this.lbTotalVaca.Size = new System.Drawing.Size(87, 24);
            this.lbTotalVaca.TabIndex = 98;
            this.lbTotalVaca.Text = "Sub-Total";
            // 
            // txtTotalCerdo
            // 
            this.txtTotalCerdo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalCerdo.Location = new System.Drawing.Point(518, 456);
            this.txtTotalCerdo.Name = "txtTotalCerdo";
            this.txtTotalCerdo.Size = new System.Drawing.Size(100, 25);
            this.txtTotalCerdo.TabIndex = 101;
            this.txtTotalCerdo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTotalCerdo
            // 
            this.lbTotalCerdo.AutoSize = true;
            this.lbTotalCerdo.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalCerdo.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbTotalCerdo.Location = new System.Drawing.Point(407, 454);
            this.lbTotalCerdo.Name = "lbTotalCerdo";
            this.lbTotalCerdo.Size = new System.Drawing.Size(87, 24);
            this.lbTotalCerdo.TabIndex = 100;
            this.lbTotalCerdo.Text = "Sub-Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.Location = new System.Drawing.Point(319, 533);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 25);
            this.txtTotal.TabIndex = 103;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbLiquidar
            // 
            this.lbLiquidar.AutoSize = true;
            this.lbLiquidar.BackColor = System.Drawing.Color.Transparent;
            this.lbLiquidar.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbLiquidar.Location = new System.Drawing.Point(179, 533);
            this.lbLiquidar.Name = "lbLiquidar";
            this.lbLiquidar.Size = new System.Drawing.Size(124, 24);
            this.lbLiquidar.TabIndex = 102;
            this.lbLiquidar.Text = "Total Liquidar";
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 590);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboDia;
        private System.Windows.Forms.ComboBox comboMes;
        private System.Windows.Forms.ComboBox comboAño;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox boxVaca;
        private System.Windows.Forms.CheckBox boxCerdo;
        private System.Windows.Forms.Label lbVaca;
        private System.Windows.Forms.TextBox txtVacaCan;
        private System.Windows.Forms.Label lbCerdo;
        private System.Windows.Forms.TextBox txtCantidadCerdo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lbLiquidar;
        private System.Windows.Forms.TextBox txtTotalCerdo;
        private System.Windows.Forms.Label lbTotalCerdo;
        private System.Windows.Forms.TextBox txtTotalVaca;
        private System.Windows.Forms.Label lbTotalVaca;
        private System.Windows.Forms.TextBox txtValorCerdo;
        private System.Windows.Forms.Label lbPrecioCerdo;
        private System.Windows.Forms.TextBox txtValorVaca;
        private System.Windows.Forms.Label lbPrecioVaca;
    }
}