namespace Ferreto.Views
{
    partial class Inventario
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
            this.label2 = new System.Windows.Forms.Label();
            this.UserLab = new System.Windows.Forms.Label();
            this.FechaLab = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BuscarProductoTxt = new AltoControls.AltoTextBox();
            this.InventarioDG = new System.Windows.Forms.DataGridView();
            this.BuscarBo = new AltoControls.AltoButton();
            this.ProductoVeijoCont = new System.Windows.Forms.Panel();
            this.CambiarEstadoBo = new AltoControls.AltoButton();
            this.CambiarEstadoSlide = new AltoControls.SlideButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioDG)).BeginInit();
            this.ProductoVeijoCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(31, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bienvenido de nuevo:";
            // 
            // UserLab
            // 
            this.UserLab.AutoSize = true;
            this.UserLab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.UserLab.Location = new System.Drawing.Point(215, 41);
            this.UserLab.Name = "UserLab";
            this.UserLab.Size = new System.Drawing.Size(40, 19);
            this.UserLab.TabIndex = 3;
            this.UserLab.Text = "User";
            // 
            // FechaLab
            // 
            this.FechaLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaLab.AutoSize = true;
            this.FechaLab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.FechaLab.Location = new System.Drawing.Point(392, 41);
            this.FechaLab.Name = "FechaLab";
            this.FechaLab.Size = new System.Drawing.Size(58, 19);
            this.FechaLab.TabIndex = 4;
            this.FechaLab.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(31, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Buscar Producto:";
            // 
            // BuscarProductoTxt
            // 
            this.BuscarProductoTxt.BackColor = System.Drawing.Color.Transparent;
            this.BuscarProductoTxt.Br = System.Drawing.Color.White;
            this.BuscarProductoTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarProductoTxt.ForeColor = System.Drawing.Color.Black;
            this.BuscarProductoTxt.Location = new System.Drawing.Point(35, 125);
            this.BuscarProductoTxt.Name = "BuscarProductoTxt";
            this.BuscarProductoTxt.Size = new System.Drawing.Size(220, 30);
            this.BuscarProductoTxt.TabIndex = 6;
            // 
            // InventarioDG
            // 
            this.InventarioDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InventarioDG.BackgroundColor = System.Drawing.Color.White;
            this.InventarioDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventarioDG.Location = new System.Drawing.Point(35, 190);
            this.InventarioDG.Name = "InventarioDG";
            this.InventarioDG.Size = new System.Drawing.Size(752, 274);
            this.InventarioDG.TabIndex = 7;
            // 
            // BuscarBo
            // 
            this.BuscarBo.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.BuscarBo.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.BuscarBo.BackColor = System.Drawing.Color.Transparent;
            this.BuscarBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuscarBo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BuscarBo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarBo.ForeColor = System.Drawing.Color.White;
            this.BuscarBo.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.BuscarBo.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.BuscarBo.Location = new System.Drawing.Point(294, 125);
            this.BuscarBo.Name = "BuscarBo";
            this.BuscarBo.Radius = 5;
            this.BuscarBo.Size = new System.Drawing.Size(80, 30);
            this.BuscarBo.Stroke = false;
            this.BuscarBo.StrokeColor = System.Drawing.Color.Gray;
            this.BuscarBo.TabIndex = 8;
            this.BuscarBo.Text = "Buscar";
            this.BuscarBo.Transparency = false;
            // 
            // ProductoVeijoCont
            // 
            this.ProductoVeijoCont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductoVeijoCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.ProductoVeijoCont.Controls.Add(this.CambiarEstadoBo);
            this.ProductoVeijoCont.Controls.Add(this.CambiarEstadoSlide);
            this.ProductoVeijoCont.Controls.Add(this.label4);
            this.ProductoVeijoCont.Controls.Add(this.label1);
            this.ProductoVeijoCont.Controls.Add(this.label15);
            this.ProductoVeijoCont.Location = new System.Drawing.Point(538, 62);
            this.ProductoVeijoCont.Name = "ProductoVeijoCont";
            this.ProductoVeijoCont.Size = new System.Drawing.Size(249, 122);
            this.ProductoVeijoCont.TabIndex = 9;
            // 
            // CambiarEstadoBo
            // 
            this.CambiarEstadoBo.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.CambiarEstadoBo.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.CambiarEstadoBo.BackColor = System.Drawing.Color.Transparent;
            this.CambiarEstadoBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CambiarEstadoBo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CambiarEstadoBo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CambiarEstadoBo.ForeColor = System.Drawing.Color.White;
            this.CambiarEstadoBo.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.CambiarEstadoBo.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.CambiarEstadoBo.Location = new System.Drawing.Point(74, 84);
            this.CambiarEstadoBo.Name = "CambiarEstadoBo";
            this.CambiarEstadoBo.Radius = 5;
            this.CambiarEstadoBo.Size = new System.Drawing.Size(161, 30);
            this.CambiarEstadoBo.Stroke = false;
            this.CambiarEstadoBo.StrokeColor = System.Drawing.Color.Gray;
            this.CambiarEstadoBo.TabIndex = 10;
            this.CambiarEstadoBo.Text = "Aplicar Cambios";
            this.CambiarEstadoBo.Transparency = false;
            // 
            // CambiarEstadoSlide
            // 
            this.CambiarEstadoSlide.BorderColor = System.Drawing.Color.LightGray;
            this.CambiarEstadoSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CambiarEstadoSlide.IsOn = true;
            this.CambiarEstadoSlide.Location = new System.Drawing.Point(20, 43);
            this.CambiarEstadoSlide.Name = "CambiarEstadoSlide";
            this.CambiarEstadoSlide.Size = new System.Drawing.Size(60, 35);
            this.CambiarEstadoSlide.TabIndex = 29;
            this.CambiarEstadoSlide.Text = "slideButton1";
            this.CambiarEstadoSlide.TextEnabled = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(117, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Inactivo = OFF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(134, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Activo = ON";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(16, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 19);
            this.label15.TabIndex = 26;
            this.label15.Text = "Estado:";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 494);
            this.Controls.Add(this.ProductoVeijoCont);
            this.Controls.Add(this.BuscarBo);
            this.Controls.Add(this.InventarioDG);
            this.Controls.Add(this.BuscarProductoTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechaLab);
            this.Controls.Add(this.UserLab);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventario";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.InventarioDG)).EndInit();
            this.ProductoVeijoCont.ResumeLayout(false);
            this.ProductoVeijoCont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UserLab;
        private System.Windows.Forms.Label FechaLab;
        private System.Windows.Forms.Label label3;
        private AltoControls.AltoTextBox BuscarProductoTxt;
        private System.Windows.Forms.DataGridView InventarioDG;
        private AltoControls.AltoButton BuscarBo;
        private System.Windows.Forms.Panel ProductoVeijoCont;
        private AltoControls.AltoButton CambiarEstadoBo;
        private AltoControls.SlideButton CambiarEstadoSlide;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
    }
}