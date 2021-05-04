
namespace Proyecto_IBERICO.Presentacion
{
    partial class Registro_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Usuarios));
            this.checkCliente = new System.Windows.Forms.CheckBox();
            this.checEmpleado = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btRegistro = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.checProveedor = new System.Windows.Forms.CheckBox();
            this.lbNom_Proveedor = new System.Windows.Forms.Label();
            this.lbCod_Proveedor = new System.Windows.Forms.Label();
            this.lbDireccion_Proveedor = new System.Windows.Forms.Label();
            this.lbCod_Hierro = new System.Windows.Forms.Label();
            this.txtNombre_Proveedor = new System.Windows.Forms.TextBox();
            this.txtCod_Proveedor = new System.Windows.Forms.TextBox();
            this.txtCod_Hierro = new System.Windows.Forms.TextBox();
            this.txtBarrio_Proveedor = new System.Windows.Forms.TextBox();
            this.txtZona_Proveedor = new System.Windows.Forms.TextBox();
            this.txtCalle_proveedor = new System.Windows.Forms.TextBox();
            this.txtManaza_proveedor = new System.Windows.Forms.TextBox();
            this.lbBarrio_Prove = new System.Windows.Forms.Label();
            this.lbZona_Proveedor = new System.Windows.Forms.Label();
            this.lbManzana_Proveedor = new System.Windows.Forms.Label();
            this.lbCalle_Provee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // checkCliente
            // 
            this.checkCliente.AutoSize = true;
            this.checkCliente.BackColor = System.Drawing.SystemColors.HighlightText;
            this.checkCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkCliente.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.checkCliente.ForeColor = System.Drawing.SystemColors.Desktop;
            this.checkCliente.Location = new System.Drawing.Point(43, 113);
            this.checkCliente.Name = "checkCliente";
            this.checkCliente.Size = new System.Drawing.Size(93, 31);
            this.checkCliente.TabIndex = 0;
            this.checkCliente.Text = "Cliente";
            this.checkCliente.UseVisualStyleBackColor = false;
            this.checkCliente.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checEmpleado
            // 
            this.checEmpleado.AutoSize = true;
            this.checEmpleado.BackColor = System.Drawing.SystemColors.HighlightText;
            this.checEmpleado.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.checEmpleado.Location = new System.Drawing.Point(43, 199);
            this.checEmpleado.Name = "checEmpleado";
            this.checEmpleado.Size = new System.Drawing.Size(118, 31);
            this.checEmpleado.TabIndex = 1;
            this.checEmpleado.Text = "Empleado";
            this.checEmpleado.UseVisualStyleBackColor = false;
            this.checEmpleado.CheckedChanged += new System.EventHandler(this.checEmpleado_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(702, 420);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(753, 420);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btRegistro
            // 
            this.btRegistro.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRegistro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btRegistro.Location = new System.Drawing.Point(54, 267);
            this.btRegistro.Name = "btRegistro";
            this.btRegistro.Size = new System.Drawing.Size(107, 61);
            this.btRegistro.TabIndex = 4;
            this.btRegistro.Text = "Registrar";
            this.btRegistro.UseVisualStyleBackColor = false;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btExit.Location = new System.Drawing.Point(64, 362);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(87, 52);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Salir";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // checProveedor
            // 
            this.checProveedor.AutoSize = true;
            this.checProveedor.BackColor = System.Drawing.SystemColors.HighlightText;
            this.checProveedor.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.checProveedor.Location = new System.Drawing.Point(43, 36);
            this.checProveedor.Name = "checProveedor";
            this.checProveedor.Size = new System.Drawing.Size(122, 31);
            this.checProveedor.TabIndex = 6;
            this.checProveedor.Text = "Proveedor";
            this.checProveedor.UseVisualStyleBackColor = false;
            this.checProveedor.CheckedChanged += new System.EventHandler(this.checProveedor_CheckedChanged);
            // 
            // lbNom_Proveedor
            // 
            this.lbNom_Proveedor.AutoSize = true;
            this.lbNom_Proveedor.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNom_Proveedor.Location = new System.Drawing.Point(272, 45);
            this.lbNom_Proveedor.Name = "lbNom_Proveedor";
            this.lbNom_Proveedor.Size = new System.Drawing.Size(186, 28);
            this.lbNom_Proveedor.TabIndex = 7;
            this.lbNom_Proveedor.Text = "Nombre_Proveedor";
            // 
            // lbCod_Proveedor
            // 
            this.lbCod_Proveedor.AutoSize = true;
            this.lbCod_Proveedor.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCod_Proveedor.Location = new System.Drawing.Point(272, 91);
            this.lbCod_Proveedor.Name = "lbCod_Proveedor";
            this.lbCod_Proveedor.Size = new System.Drawing.Size(174, 28);
            this.lbCod_Proveedor.TabIndex = 8;
            this.lbCod_Proveedor.Text = "Codigo_Proveedor";
            // 
            // lbDireccion_Proveedor
            // 
            this.lbDireccion_Proveedor.AutoSize = true;
            this.lbDireccion_Proveedor.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDireccion_Proveedor.Location = new System.Drawing.Point(506, 198);
            this.lbDireccion_Proveedor.Name = "lbDireccion_Proveedor";
            this.lbDireccion_Proveedor.Size = new System.Drawing.Size(97, 28);
            this.lbDireccion_Proveedor.TabIndex = 9;
            this.lbDireccion_Proveedor.Text = "Direccion";
            // 
            // lbCod_Hierro
            // 
            this.lbCod_Hierro.AutoSize = true;
            this.lbCod_Hierro.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCod_Hierro.Location = new System.Drawing.Point(288, 138);
            this.lbCod_Hierro.Name = "lbCod_Hierro";
            this.lbCod_Hierro.Size = new System.Drawing.Size(142, 28);
            this.lbCod_Hierro.TabIndex = 10;
            this.lbCod_Hierro.Text = "Codigo_Hierro";
            // 
            // txtNombre_Proveedor
            // 
            this.txtNombre_Proveedor.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNombre_Proveedor.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtNombre_Proveedor.Location = new System.Drawing.Point(535, 49);
            this.txtNombre_Proveedor.Name = "txtNombre_Proveedor";
            this.txtNombre_Proveedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNombre_Proveedor.Size = new System.Drawing.Size(207, 27);
            this.txtNombre_Proveedor.TabIndex = 11;
            this.txtNombre_Proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCod_Proveedor
            // 
            this.txtCod_Proveedor.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCod_Proveedor.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtCod_Proveedor.Location = new System.Drawing.Point(535, 95);
            this.txtCod_Proveedor.Name = "txtCod_Proveedor";
            this.txtCod_Proveedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCod_Proveedor.Size = new System.Drawing.Size(119, 27);
            this.txtCod_Proveedor.TabIndex = 12;
            this.txtCod_Proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCod_Hierro
            // 
            this.txtCod_Hierro.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCod_Hierro.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtCod_Hierro.Location = new System.Drawing.Point(535, 142);
            this.txtCod_Hierro.Name = "txtCod_Hierro";
            this.txtCod_Hierro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCod_Hierro.Size = new System.Drawing.Size(119, 27);
            this.txtCod_Hierro.TabIndex = 13;
            this.txtCod_Hierro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBarrio_Proveedor
            // 
            this.txtBarrio_Proveedor.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtBarrio_Proveedor.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtBarrio_Proveedor.Location = new System.Drawing.Point(388, 267);
            this.txtBarrio_Proveedor.Name = "txtBarrio_Proveedor";
            this.txtBarrio_Proveedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBarrio_Proveedor.Size = new System.Drawing.Size(119, 27);
            this.txtBarrio_Proveedor.TabIndex = 14;
            this.txtBarrio_Proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtZona_Proveedor
            // 
            this.txtZona_Proveedor.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtZona_Proveedor.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtZona_Proveedor.Location = new System.Drawing.Point(623, 267);
            this.txtZona_Proveedor.Name = "txtZona_Proveedor";
            this.txtZona_Proveedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtZona_Proveedor.Size = new System.Drawing.Size(119, 27);
            this.txtZona_Proveedor.TabIndex = 15;
            this.txtZona_Proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCalle_proveedor
            // 
            this.txtCalle_proveedor.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCalle_proveedor.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtCalle_proveedor.Location = new System.Drawing.Point(388, 362);
            this.txtCalle_proveedor.Name = "txtCalle_proveedor";
            this.txtCalle_proveedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCalle_proveedor.Size = new System.Drawing.Size(119, 27);
            this.txtCalle_proveedor.TabIndex = 16;
            this.txtCalle_proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtManaza_proveedor
            // 
            this.txtManaza_proveedor.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtManaza_proveedor.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtManaza_proveedor.Location = new System.Drawing.Point(623, 362);
            this.txtManaza_proveedor.Name = "txtManaza_proveedor";
            this.txtManaza_proveedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtManaza_proveedor.Size = new System.Drawing.Size(119, 27);
            this.txtManaza_proveedor.TabIndex = 17;
            this.txtManaza_proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbBarrio_Prove
            // 
            this.lbBarrio_Prove.AutoSize = true;
            this.lbBarrio_Prove.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBarrio_Prove.Location = new System.Drawing.Point(272, 267);
            this.lbBarrio_Prove.Name = "lbBarrio_Prove";
            this.lbBarrio_Prove.Size = new System.Drawing.Size(69, 28);
            this.lbBarrio_Prove.TabIndex = 18;
            this.lbBarrio_Prove.Text = "Barrio";
            // 
            // lbZona_Proveedor
            // 
            this.lbZona_Proveedor.AutoSize = true;
            this.lbZona_Proveedor.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbZona_Proveedor.Location = new System.Drawing.Point(520, 266);
            this.lbZona_Proveedor.Name = "lbZona_Proveedor";
            this.lbZona_Proveedor.Size = new System.Drawing.Size(56, 28);
            this.lbZona_Proveedor.TabIndex = 20;
            this.lbZona_Proveedor.Text = "Zona";
            // 
            // lbManzana_Proveedor
            // 
            this.lbManzana_Proveedor.AutoSize = true;
            this.lbManzana_Proveedor.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbManzana_Proveedor.Location = new System.Drawing.Point(520, 361);
            this.lbManzana_Proveedor.Name = "lbManzana_Proveedor";
            this.lbManzana_Proveedor.Size = new System.Drawing.Size(92, 28);
            this.lbManzana_Proveedor.TabIndex = 21;
            this.lbManzana_Proveedor.Text = "Manzana";
            // 
            // lbCalle_Provee
            // 
            this.lbCalle_Provee.AutoSize = true;
            this.lbCalle_Provee.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCalle_Provee.Location = new System.Drawing.Point(272, 362);
            this.lbCalle_Provee.Name = "lbCalle_Provee";
            this.lbCalle_Provee.Size = new System.Drawing.Size(55, 28);
            this.lbCalle_Provee.TabIndex = 22;
            this.lbCalle_Provee.Text = "Calle";
            // 
            // Registro_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 610);
            this.Controls.Add(this.lbCalle_Provee);
            this.Controls.Add(this.lbManzana_Proveedor);
            this.Controls.Add(this.lbZona_Proveedor);
            this.Controls.Add(this.lbBarrio_Prove);
            this.Controls.Add(this.txtManaza_proveedor);
            this.Controls.Add(this.txtCalle_proveedor);
            this.Controls.Add(this.txtZona_Proveedor);
            this.Controls.Add(this.txtBarrio_Proveedor);
            this.Controls.Add(this.txtCod_Hierro);
            this.Controls.Add(this.txtCod_Proveedor);
            this.Controls.Add(this.txtNombre_Proveedor);
            this.Controls.Add(this.lbCod_Hierro);
            this.Controls.Add(this.lbDireccion_Proveedor);
            this.Controls.Add(this.lbCod_Proveedor);
            this.Controls.Add(this.lbNom_Proveedor);
            this.Controls.Add(this.checProveedor);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btRegistro);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.checEmpleado);
            this.Controls.Add(this.checkCliente);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Registro_Usuarios";
            this.Load += new System.EventHandler(this.Registro_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkCliente;
        private System.Windows.Forms.CheckBox checEmpleado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btRegistro;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.CheckBox checProveedor;
        private System.Windows.Forms.Label lbNom_Proveedor;
        private System.Windows.Forms.Label lbCod_Proveedor;
        private System.Windows.Forms.Label lbDireccion_Proveedor;
        private System.Windows.Forms.Label lbCod_Hierro;
        private System.Windows.Forms.TextBox txtNombre_Proveedor;
        private System.Windows.Forms.TextBox txtCod_Proveedor;
        private System.Windows.Forms.TextBox txtCod_Hierro;
        private System.Windows.Forms.TextBox txtBarrio_Proveedor;
        private System.Windows.Forms.TextBox txtZona_Proveedor;
        private System.Windows.Forms.TextBox txtCalle_proveedor;
        private System.Windows.Forms.TextBox txtManaza_proveedor;
        private System.Windows.Forms.Label lbBarrio_Prove;
        private System.Windows.Forms.Label lbZona_Proveedor;
        private System.Windows.Forms.Label lbManzana_Proveedor;
        private System.Windows.Forms.Label lbCalle_Provee;
    }
}