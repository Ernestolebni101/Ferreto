namespace Ferreto.Views
{
    partial class ProveedoresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProveedoresForm));
            this.FechaLab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AñadirBo = new AltoControls.AltoButton();
            this.errorProviderletras = new System.Windows.Forms.ErrorProvider(this.components);
            this.ProveedoresLV = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Empresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apelldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cedula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Correo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Direccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductoVeijoCont = new System.Windows.Forms.Panel();
            this.CambiarEstadoBo = new AltoControls.AltoButton();
            this.CambiarEstadoSlide = new AltoControls.SlideButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderletras)).BeginInit();
            this.ProductoVeijoCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // FechaLab
            // 
            this.FechaLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaLab.AutoSize = true;
            this.FechaLab.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.FechaLab.Location = new System.Drawing.Point(22, 9);
            this.FechaLab.Name = "FechaLab";
            this.FechaLab.Size = new System.Drawing.Size(57, 18);
            this.FechaLab.TabIndex = 12;
            this.FechaLab.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(544, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "¿Proveedor Nuevo?";
            // 
            // AñadirBo
            // 
            this.AñadirBo.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.AñadirBo.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.AñadirBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AñadirBo.BackColor = System.Drawing.Color.Transparent;
            this.AñadirBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AñadirBo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AñadirBo.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AñadirBo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.AñadirBo.Inactive1 = System.Drawing.Color.White;
            this.AñadirBo.Inactive2 = System.Drawing.Color.White;
            this.AñadirBo.Location = new System.Drawing.Point(547, 83);
            this.AñadirBo.Name = "AñadirBo";
            this.AñadirBo.Radius = 5;
            this.AñadirBo.Size = new System.Drawing.Size(161, 30);
            this.AñadirBo.Stroke = false;
            this.AñadirBo.StrokeColor = System.Drawing.Color.Gray;
            this.AñadirBo.TabIndex = 20;
            this.AñadirBo.Text = "Añadir";
            this.AñadirBo.Transparency = false;
            this.AñadirBo.Click += new System.EventHandler(this.AñadirBo_Click);
            // 
            // errorProviderletras
            // 
            this.errorProviderletras.ContainerControl = this;
            this.errorProviderletras.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderletras.Icon")));
            // 
            // ProveedoresLV
            // 
            this.ProveedoresLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Empresa,
            this.Nombre,
            this.Apelldo,
            this.Cedula,
            this.Telefono,
            this.Correo,
            this.Direccion,
            this.columnHeader1});
            this.ProveedoresLV.Font = new System.Drawing.Font("Gotham", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProveedoresLV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.ProveedoresLV.FullRowSelect = true;
            this.ProveedoresLV.HideSelection = false;
            this.ProveedoresLV.Location = new System.Drawing.Point(25, 147);
            this.ProveedoresLV.Margin = new System.Windows.Forms.Padding(2);
            this.ProveedoresLV.Name = "ProveedoresLV";
            this.ProveedoresLV.Size = new System.Drawing.Size(764, 309);
            this.ProveedoresLV.TabIndex = 21;
            this.ProveedoresLV.UseCompatibleStateImageBehavior = false;
            this.ProveedoresLV.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 39;
            // 
            // Empresa
            // 
            this.Empresa.Text = "Empresa";
            this.Empresa.Width = 143;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 114;
            // 
            // Apelldo
            // 
            this.Apelldo.Text = "Apellido";
            this.Apelldo.Width = 134;
            // 
            // Cedula
            // 
            this.Cedula.Text = "Cedula";
            this.Cedula.Width = 119;
            // 
            // Telefono
            // 
            this.Telefono.Text = "Telefono";
            this.Telefono.Width = 151;
            // 
            // Correo
            // 
            this.Correo.Text = "Correo";
            this.Correo.Width = 93;
            // 
            // Direccion
            // 
            this.Direccion.Text = "Direccion";
            this.Direccion.Width = 209;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Estado";
            // 
            // ProductoVeijoCont
            // 
            this.ProductoVeijoCont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductoVeijoCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.ProductoVeijoCont.Controls.Add(this.CambiarEstadoBo);
            this.ProductoVeijoCont.Controls.Add(this.CambiarEstadoSlide);
            this.ProductoVeijoCont.Controls.Add(this.label3);
            this.ProductoVeijoCont.Controls.Add(this.label5);
            this.ProductoVeijoCont.Controls.Add(this.label6);
            this.ProductoVeijoCont.Location = new System.Drawing.Point(25, 42);
            this.ProductoVeijoCont.Name = "ProductoVeijoCont";
            this.ProductoVeijoCont.Size = new System.Drawing.Size(332, 87);
            this.ProductoVeijoCont.TabIndex = 23;
            // 
            // CambiarEstadoBo
            // 
            this.CambiarEstadoBo.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.CambiarEstadoBo.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.CambiarEstadoBo.BackColor = System.Drawing.Color.Transparent;
            this.CambiarEstadoBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CambiarEstadoBo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CambiarEstadoBo.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CambiarEstadoBo.ForeColor = System.Drawing.Color.White;
            this.CambiarEstadoBo.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.CambiarEstadoBo.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.CambiarEstadoBo.Location = new System.Drawing.Point(216, 14);
            this.CambiarEstadoBo.Name = "CambiarEstadoBo";
            this.CambiarEstadoBo.Radius = 5;
            this.CambiarEstadoBo.Size = new System.Drawing.Size(103, 57);
            this.CambiarEstadoBo.Stroke = false;
            this.CambiarEstadoBo.StrokeColor = System.Drawing.Color.Gray;
            this.CambiarEstadoBo.TabIndex = 10;
            this.CambiarEstadoBo.Text = "Desactivar";
            this.CambiarEstadoBo.Transparency = false;
            this.CambiarEstadoBo.Click += new System.EventHandler(this.CambiarEstadoBo_Click_1);
            // 
            // CambiarEstadoSlide
            // 
            this.CambiarEstadoSlide.BorderColor = System.Drawing.Color.LightGray;
            this.CambiarEstadoSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CambiarEstadoSlide.IsOn = true;
            this.CambiarEstadoSlide.Location = new System.Drawing.Point(143, 39);
            this.CambiarEstadoSlide.Name = "CambiarEstadoSlide";
            this.CambiarEstadoSlide.Size = new System.Drawing.Size(60, 32);
            this.CambiarEstadoSlide.TabIndex = 29;
            this.CambiarEstadoSlide.Text = "slideButton1";
            this.CambiarEstadoSlide.TextEnabled = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Inactivo = OFF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Activo = ON";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(140, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Estado:";
            // 
            // ProveedoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 467);
            this.Controls.Add(this.ProductoVeijoCont);
            this.Controls.Add(this.ProveedoresLV);
            this.Controls.Add(this.AñadirBo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FechaLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProveedoresForm";
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderletras)).EndInit();
            this.ProductoVeijoCont.ResumeLayout(false);
            this.ProductoVeijoCont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FechaLab;
        private System.Windows.Forms.Label label2;
        private AltoControls.AltoButton AñadirBo;
        private System.Windows.Forms.ErrorProvider errorProviderletras;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Empresa;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Apelldo;
        private System.Windows.Forms.ColumnHeader Cedula;
        private System.Windows.Forms.ColumnHeader Telefono;
        private System.Windows.Forms.ColumnHeader Correo;
        private System.Windows.Forms.ColumnHeader Direccion;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView ProveedoresLV;
        public System.Windows.Forms.Panel ProductoVeijoCont;
        private AltoControls.AltoButton CambiarEstadoBo;
        private AltoControls.SlideButton CambiarEstadoSlide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}