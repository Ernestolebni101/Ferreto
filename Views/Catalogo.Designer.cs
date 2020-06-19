namespace Ferreto.Views
{
    partial class Catalogo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogo));
            this.FechaLab = new System.Windows.Forms.Label();
            this.ProductoVeijoCont = new System.Windows.Forms.Panel();
            this.CambiarEstadoBo = new AltoControls.AltoButton();
            this.CambiarEstadoSlide = new AltoControls.SlideButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.errorProviderletras = new System.Windows.Forms.ErrorProvider(this.components);
            this.Inventariolv = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrecioUnitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CostoUnitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Existencia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FechaRegistro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FechaVencimiento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tamaño = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Peso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductoVeijoCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderletras)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaLab
            // 
            this.FechaLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaLab.AutoSize = true;
            this.FechaLab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.FechaLab.Location = new System.Drawing.Point(41, 44);
            this.FechaLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaLab.Name = "FechaLab";
            this.FechaLab.Size = new System.Drawing.Size(71, 23);
            this.FechaLab.TabIndex = 4;
            this.FechaLab.Text = "Fecha";
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
            this.ProductoVeijoCont.Location = new System.Drawing.Point(717, 76);
            this.ProductoVeijoCont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductoVeijoCont.Name = "ProductoVeijoCont";
            this.ProductoVeijoCont.Size = new System.Drawing.Size(332, 150);
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
            this.CambiarEstadoBo.Location = new System.Drawing.Point(99, 103);
            this.CambiarEstadoBo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CambiarEstadoBo.Name = "CambiarEstadoBo";
            this.CambiarEstadoBo.Radius = 5;
            this.CambiarEstadoBo.Size = new System.Drawing.Size(215, 37);
            this.CambiarEstadoBo.Stroke = false;
            this.CambiarEstadoBo.StrokeColor = System.Drawing.Color.Gray;
            this.CambiarEstadoBo.TabIndex = 10;
            this.CambiarEstadoBo.Text = "Aplicar Cambios";
            this.CambiarEstadoBo.Transparency = false;
            this.CambiarEstadoBo.Click += new System.EventHandler(this.CambiarEstadoBo_Click);
            // 
            // CambiarEstadoSlide
            // 
            this.CambiarEstadoSlide.BorderColor = System.Drawing.Color.LightGray;
            this.CambiarEstadoSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CambiarEstadoSlide.IsOn = true;
            this.CambiarEstadoSlide.Location = new System.Drawing.Point(27, 53);
            this.CambiarEstadoSlide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CambiarEstadoSlide.Name = "CambiarEstadoSlide";
            this.CambiarEstadoSlide.Size = new System.Drawing.Size(82, 43);
            this.CambiarEstadoSlide.TabIndex = 29;
            this.CambiarEstadoSlide.Text = "slideButton1";
            this.CambiarEstadoSlide.TextEnabled = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(156, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Inactivo = OFF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Activo = ON";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(21, 14);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 23);
            this.label15.TabIndex = 26;
            this.label15.Text = "Estado:";
            // 
            // errorProviderletras
            // 
            this.errorProviderletras.ContainerControl = this;
            this.errorProviderletras.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderletras.Icon")));
            // 
            // Inventariolv
            // 
            this.Inventariolv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Inventariolv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.PrecioUnitario,
            this.CostoUnitario,
            this.Categoria,
            this.NombreProd,
            this.Marca,
            this.Existencia,
            this.Peso,
            this.Tamaño,
            this.FechaRegistro,
            this.FechaVencimiento,
            this.columnHeader1});
            this.Inventariolv.FullRowSelect = true;
            this.Inventariolv.HideSelection = false;
            this.Inventariolv.Location = new System.Drawing.Point(17, 234);
            this.Inventariolv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Inventariolv.Name = "Inventariolv";
            this.Inventariolv.Size = new System.Drawing.Size(1059, 358);
            this.Inventariolv.TabIndex = 10;
            this.Inventariolv.UseCompatibleStateImageBehavior = false;
            this.Inventariolv.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 40;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.Text = "Precio unitario";
            this.PrecioUnitario.Width = 80;
            // 
            // CostoUnitario
            // 
            this.CostoUnitario.Text = "Costo unitario";
            this.CostoUnitario.Width = 80;
            // 
            // Categoria
            // 
            this.Categoria.Text = "Categoria";
            this.Categoria.Width = 110;
            // 
            // NombreProd
            // 
            this.NombreProd.Text = "Nombre";
            this.NombreProd.Width = 150;
            // 
            // Marca
            // 
            this.Marca.Text = "Marca";
            this.Marca.Width = 110;
            // 
            // Existencia
            // 
            this.Existencia.Text = "Existencia";
            this.Existencia.Width = 65;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.Text = "Fecha de registro";
            this.FechaRegistro.Width = 100;
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.Text = "Fecha vencimiento";
            this.FechaVencimiento.Width = 100;
            // 
            // Tamaño
            // 
            this.Tamaño.Text = "Tamaño";
            // 
            // Peso
            // 
            this.Peso.Text = "Peso";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Estado";
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1093, 608);
            this.Controls.Add(this.Inventariolv);
            this.Controls.Add(this.ProductoVeijoCont);
            this.Controls.Add(this.FechaLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Catalogo";
            this.Text = "Inventario";
            this.ProductoVeijoCont.ResumeLayout(false);
            this.ProductoVeijoCont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderletras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FechaLab;
        private AltoControls.AltoButton CambiarEstadoBo;
        private AltoControls.SlideButton CambiarEstadoSlide;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ErrorProvider errorProviderletras;
        public System.Windows.Forms.Panel ProductoVeijoCont;
        private System.Windows.Forms.ListView Inventariolv;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader PrecioUnitario;
        private System.Windows.Forms.ColumnHeader CostoUnitario;
        private System.Windows.Forms.ColumnHeader Categoria;
        private System.Windows.Forms.ColumnHeader NombreProd;
        private System.Windows.Forms.ColumnHeader Marca;
        private System.Windows.Forms.ColumnHeader Existencia;
        private System.Windows.Forms.ColumnHeader FechaRegistro;
        private System.Windows.Forms.ColumnHeader FechaVencimiento;
        private System.Windows.Forms.ColumnHeader Peso;
        private System.Windows.Forms.ColumnHeader Tamaño;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}