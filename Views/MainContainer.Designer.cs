namespace Ferreto.Views
{
    partial class MainContainer
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
            this.MenuCont = new System.Windows.Forms.Panel();
            this.panelCont = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.VentaBo = new System.Windows.Forms.Button();
            this.InventarioBo = new System.Windows.Forms.Button();
            this.FacturaBo = new System.Windows.Forms.Button();
            this.SalirBo = new System.Windows.Forms.Button();
            this.MenuCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuCont
            // 
            this.MenuCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.MenuCont.Controls.Add(this.SalirBo);
            this.MenuCont.Controls.Add(this.FacturaBo);
            this.MenuCont.Controls.Add(this.InventarioBo);
            this.MenuCont.Controls.Add(this.VentaBo);
            this.MenuCont.Controls.Add(this.pictureBox1);
            this.MenuCont.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuCont.Location = new System.Drawing.Point(0, 0);
            this.MenuCont.Name = "MenuCont";
            this.MenuCont.Size = new System.Drawing.Size(155, 494);
            this.MenuCont.TabIndex = 0;
            // 
            // panelCont
            // 
            this.panelCont.BackColor = System.Drawing.Color.White;
            this.panelCont.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCont.Location = new System.Drawing.Point(155, 0);
            this.panelCont.Name = "panelCont";
            this.panelCont.Size = new System.Drawing.Size(680, 494);
            this.panelCont.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ferreto.Properties.Resources.Ferreto_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(-25, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // VentaBo
            // 
            this.VentaBo.FlatAppearance.BorderSize = 0;
            this.VentaBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VentaBo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentaBo.ForeColor = System.Drawing.Color.White;
            this.VentaBo.Location = new System.Drawing.Point(0, 141);
            this.VentaBo.Name = "VentaBo";
            this.VentaBo.Size = new System.Drawing.Size(155, 66);
            this.VentaBo.TabIndex = 1;
            this.VentaBo.Text = "Venta";
            this.VentaBo.UseVisualStyleBackColor = true;
            this.VentaBo.Click += new System.EventHandler(this.VentaBo_Click);
            // 
            // InventarioBo
            // 
            this.InventarioBo.FlatAppearance.BorderSize = 0;
            this.InventarioBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InventarioBo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventarioBo.ForeColor = System.Drawing.Color.White;
            this.InventarioBo.Location = new System.Drawing.Point(0, 213);
            this.InventarioBo.Name = "InventarioBo";
            this.InventarioBo.Size = new System.Drawing.Size(155, 66);
            this.InventarioBo.TabIndex = 2;
            this.InventarioBo.Text = "Inventario";
            this.InventarioBo.UseVisualStyleBackColor = true;
            this.InventarioBo.Click += new System.EventHandler(this.InventarioBo_Click);
            // 
            // FacturaBo
            // 
            this.FacturaBo.FlatAppearance.BorderSize = 0;
            this.FacturaBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FacturaBo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacturaBo.ForeColor = System.Drawing.Color.White;
            this.FacturaBo.Location = new System.Drawing.Point(0, 285);
            this.FacturaBo.Name = "FacturaBo";
            this.FacturaBo.Size = new System.Drawing.Size(155, 66);
            this.FacturaBo.TabIndex = 3;
            this.FacturaBo.Text = "Factura";
            this.FacturaBo.UseVisualStyleBackColor = true;
            this.FacturaBo.Click += new System.EventHandler(this.FacturaBo_Click);
            // 
            // SalirBo
            // 
            this.SalirBo.FlatAppearance.BorderSize = 0;
            this.SalirBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalirBo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirBo.ForeColor = System.Drawing.Color.White;
            this.SalirBo.Location = new System.Drawing.Point(3, 357);
            this.SalirBo.Name = "SalirBo";
            this.SalirBo.Size = new System.Drawing.Size(155, 66);
            this.SalirBo.TabIndex = 4;
            this.SalirBo.Text = "Salir";
            this.SalirBo.UseVisualStyleBackColor = true;
            this.SalirBo.Click += new System.EventHandler(this.SalirBo_Click);
            // 
            // MainContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 494);
            this.Controls.Add(this.panelCont);
            this.Controls.Add(this.MenuCont);
            this.Name = "MainContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainContainer";
            this.MenuCont.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuCont;
        private System.Windows.Forms.Panel panelCont;
        private System.Windows.Forms.Button SalirBo;
        private System.Windows.Forms.Button FacturaBo;
        private System.Windows.Forms.Button InventarioBo;
        private System.Windows.Forms.Button VentaBo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}