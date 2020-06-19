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
            this.EditarProveedoCont = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CambiarEstadoSlide = new AltoControls.SlideButton();
            this.CambiarEstadoBo = new AltoControls.AltoButton();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderletras)).BeginInit();
            this.EditarProveedoCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // FechaLab
            // 
            this.FechaLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaLab.AutoSize = true;
            this.FechaLab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.FechaLab.Location = new System.Drawing.Point(472, 9);
            this.FechaLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaLab.Name = "FechaLab";
            this.FechaLab.Size = new System.Drawing.Size(71, 23);
            this.FechaLab.TabIndex = 12;
            this.FechaLab.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(729, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "¿Proveedor Nuevo?";
            // 
            // AñadirBo
            // 
            this.AñadirBo.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.AñadirBo.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.AñadirBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AñadirBo.BackColor = System.Drawing.Color.Transparent;
            this.AñadirBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AñadirBo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AñadirBo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AñadirBo.ForeColor = System.Drawing.Color.White;
            this.AñadirBo.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.AñadirBo.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.AñadirBo.Location = new System.Drawing.Point(729, 158);
            this.AñadirBo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AñadirBo.Name = "AñadirBo";
            this.AñadirBo.Radius = 5;
            this.AñadirBo.Size = new System.Drawing.Size(215, 37);
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
            this.ProveedoresLV.FullRowSelect = true;
            this.ProveedoresLV.HideSelection = false;
            this.ProveedoresLV.Location = new System.Drawing.Point(12, 291);
            this.ProveedoresLV.Name = "ProveedoresLV";
            this.ProveedoresLV.Size = new System.Drawing.Size(1069, 277);
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
            // EditarProveedoCont
            // 
            this.EditarProveedoCont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditarProveedoCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.EditarProveedoCont.Controls.Add(this.CambiarEstadoBo);
            this.EditarProveedoCont.Controls.Add(this.CambiarEstadoSlide);
            this.EditarProveedoCont.Controls.Add(this.label4);
            this.EditarProveedoCont.Controls.Add(this.label1);
            this.EditarProveedoCont.Controls.Add(this.label15);
            this.EditarProveedoCont.Location = new System.Drawing.Point(23, 114);
            this.EditarProveedoCont.Margin = new System.Windows.Forms.Padding(4);
            this.EditarProveedoCont.Name = "EditarProveedoCont";
            this.EditarProveedoCont.Size = new System.Drawing.Size(332, 150);
            this.EditarProveedoCont.TabIndex = 22;
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
            // CambiarEstadoSlide
            // 
            this.CambiarEstadoSlide.BorderColor = System.Drawing.Color.LightGray;
            this.CambiarEstadoSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CambiarEstadoSlide.IsOn = true;
            this.CambiarEstadoSlide.Location = new System.Drawing.Point(27, 53);
            this.CambiarEstadoSlide.Margin = new System.Windows.Forms.Padding(4);
            this.CambiarEstadoSlide.Name = "CambiarEstadoSlide";
            this.CambiarEstadoSlide.Size = new System.Drawing.Size(82, 43);
            this.CambiarEstadoSlide.TabIndex = 29;
            this.CambiarEstadoSlide.Text = "slideButton1";
            this.CambiarEstadoSlide.TextEnabled = true;
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
            this.CambiarEstadoBo.Margin = new System.Windows.Forms.Padding(4);
            this.CambiarEstadoBo.Name = "CambiarEstadoBo";
            this.CambiarEstadoBo.Radius = 5;
            this.CambiarEstadoBo.Size = new System.Drawing.Size(215, 37);
            this.CambiarEstadoBo.Stroke = false;
            this.CambiarEstadoBo.StrokeColor = System.Drawing.Color.Gray;
            this.CambiarEstadoBo.TabIndex = 10;
            this.CambiarEstadoBo.Text = "Desactivar proveedor";
            this.CambiarEstadoBo.Transparency = false;
            this.CambiarEstadoBo.Click += new System.EventHandler(this.CambiarEstadoBo_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Estado";
            // 
            // ProveedoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1093, 608);
            this.Controls.Add(this.EditarProveedoCont);
            this.Controls.Add(this.ProveedoresLV);
            this.Controls.Add(this.AñadirBo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FechaLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProveedoresForm";
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderletras)).EndInit();
            this.EditarProveedoCont.ResumeLayout(false);
            this.EditarProveedoCont.PerformLayout();
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
        public System.Windows.Forms.Panel EditarProveedoCont;
        private AltoControls.AltoButton CambiarEstadoBo;
        private AltoControls.SlideButton CambiarEstadoSlide;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView ProveedoresLV;
    }
}