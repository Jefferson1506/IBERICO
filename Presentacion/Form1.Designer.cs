
namespace Proyecto_IBERICO.Presentacion
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Mn1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MnAdios = new System.Windows.Forms.ToolStripMenuItem();
            this.Mn4 = new System.Windows.Forms.ToolStripMenuItem();
            this.Mn2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mn1,
            this.Mn2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Mn1
            // 
            this.Mn1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnAdios});
            this.Mn1.Name = "Mn1";
            this.Mn1.Size = new System.Drawing.Size(58, 20);
            this.Mn1.Text = "&Saludar";
            // 
            // MnAdios
            // 
            this.MnAdios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mn4});
            this.MnAdios.Name = "MnAdios";
            this.MnAdios.Size = new System.Drawing.Size(104, 22);
            this.MnAdios.Text = "&Adios";
            // 
            // Mn4
            // 
            this.Mn4.Name = "Mn4";
            this.Mn4.Size = new System.Drawing.Size(105, 22);
            this.Mn4.Text = "Hola2";
            this.Mn4.Click += new System.EventHandler(this.MostrarMensaje);
            // 
            // Mn2
            // 
            this.Mn2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.Mn2.Name = "Mn2";
            this.Mn2.Size = new System.Drawing.Size(74, 20);
            this.Mn2.Text = "&Operacion";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Mn1;
        private System.Windows.Forms.ToolStripMenuItem Mn2;
        private System.Windows.Forms.ToolStripMenuItem MnAdios;
        private System.Windows.Forms.ToolStripMenuItem Mn4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}