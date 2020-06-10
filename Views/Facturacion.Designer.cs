namespace Ferreto.Views
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            this.label1 = new System.Windows.Forms.Label();
            this.UserLab = new System.Windows.Forms.Label();
            this.FechaLab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AgregarBo = new AltoControls.AltoButton();
            this.BorrarBo = new AltoControls.AltoButton();
            this.ImprimirBo = new AltoControls.AltoButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BaseLab = new System.Windows.Forms.Label();
            this.IvaLab = new System.Windows.Forms.Label();
            this.NetoLab = new System.Windows.Forms.Label();
            this.ProductosLV = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CantidadTxt = new AltoControls.AltoTextBox();
            this.errorProviderLetras = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCantidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.ProductosTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLetras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido de nuevo:";
            // 
            // UserLab
            // 
            this.UserLab.AutoSize = true;
            this.UserLab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.UserLab.Location = new System.Drawing.Point(310, 29);
            this.UserLab.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UserLab.Name = "UserLab";
            this.UserLab.Size = new System.Drawing.Size(51, 23);
            this.UserLab.TabIndex = 1;
            this.UserLab.Text = "User";
            // 
            // FechaLab
            // 
            this.FechaLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaLab.AutoSize = true;
            this.FechaLab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.FechaLab.Location = new System.Drawing.Point(453, 29);
            this.FechaLab.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FechaLab.Name = "FechaLab";
            this.FechaLab.Size = new System.Drawing.Size(71, 23);
            this.FechaLab.TabIndex = 2;
            this.FechaLab.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(30, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(453, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad:";
            // 
            // AgregarBo
            // 
            this.AgregarBo.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.AgregarBo.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.AgregarBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AgregarBo.BackColor = System.Drawing.Color.Transparent;
            this.AgregarBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarBo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AgregarBo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarBo.ForeColor = System.Drawing.Color.White;
            this.AgregarBo.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.AgregarBo.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.AgregarBo.Location = new System.Drawing.Point(614, 162);
            this.AgregarBo.Margin = new System.Windows.Forms.Padding(5);
            this.AgregarBo.Name = "AgregarBo";
            this.AgregarBo.Radius = 5;
            this.AgregarBo.Size = new System.Drawing.Size(80, 30);
            this.AgregarBo.Stroke = false;
            this.AgregarBo.StrokeColor = System.Drawing.Color.Gray;
            this.AgregarBo.TabIndex = 7;
            this.AgregarBo.Text = "Agregar";
            this.AgregarBo.Transparency = false;
            this.AgregarBo.Click += new System.EventHandler(this.AgregarBo_Click);
            // 
            // BorrarBo
            // 
            this.BorrarBo.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.BorrarBo.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.BorrarBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BorrarBo.BackColor = System.Drawing.Color.Transparent;
            this.BorrarBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarBo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BorrarBo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarBo.ForeColor = System.Drawing.Color.White;
            this.BorrarBo.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.BorrarBo.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.BorrarBo.Location = new System.Drawing.Point(726, 162);
            this.BorrarBo.Margin = new System.Windows.Forms.Padding(5);
            this.BorrarBo.Name = "BorrarBo";
            this.BorrarBo.Radius = 5;
            this.BorrarBo.Size = new System.Drawing.Size(80, 30);
            this.BorrarBo.Stroke = false;
            this.BorrarBo.StrokeColor = System.Drawing.Color.Gray;
            this.BorrarBo.TabIndex = 8;
            this.BorrarBo.Text = "Borrar";
            this.BorrarBo.Transparency = false;
            // 
            // ImprimirBo
            // 
            this.ImprimirBo.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.ImprimirBo.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.ImprimirBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImprimirBo.BackColor = System.Drawing.Color.Transparent;
            this.ImprimirBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImprimirBo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ImprimirBo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprimirBo.ForeColor = System.Drawing.Color.White;
            this.ImprimirBo.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.ImprimirBo.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.ImprimirBo.Location = new System.Drawing.Point(614, 365);
            this.ImprimirBo.Margin = new System.Windows.Forms.Padding(5);
            this.ImprimirBo.Name = "ImprimirBo";
            this.ImprimirBo.Radius = 5;
            this.ImprimirBo.Size = new System.Drawing.Size(91, 59);
            this.ImprimirBo.Stroke = false;
            this.ImprimirBo.StrokeColor = System.Drawing.Color.Gray;
            this.ImprimirBo.TabIndex = 9;
            this.ImprimirBo.Text = "Generar Factura";
            this.ImprimirBo.Transparency = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(39, 359);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Antes IVA:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label5.Location = new System.Drawing.Point(153, 392);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "IVA:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(91, 426);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Precio Neto:";
            // 
            // BaseLab
            // 
            this.BaseLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BaseLab.AutoSize = true;
            this.BaseLab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.BaseLab.Location = new System.Drawing.Point(306, 359);
            this.BaseLab.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BaseLab.Name = "BaseLab";
            this.BaseLab.Size = new System.Drawing.Size(55, 23);
            this.BaseLab.TabIndex = 13;
            this.BaseLab.Text = "*****";
            // 
            // IvaLab
            // 
            this.IvaLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IvaLab.AutoSize = true;
            this.IvaLab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IvaLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.IvaLab.Location = new System.Drawing.Point(306, 392);
            this.IvaLab.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.IvaLab.Name = "IvaLab";
            this.IvaLab.Size = new System.Drawing.Size(55, 23);
            this.IvaLab.TabIndex = 14;
            this.IvaLab.Text = "*****";
            // 
            // NetoLab
            // 
            this.NetoLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NetoLab.AutoSize = true;
            this.NetoLab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetoLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.NetoLab.Location = new System.Drawing.Point(306, 426);
            this.NetoLab.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NetoLab.Name = "NetoLab";
            this.NetoLab.Size = new System.Drawing.Size(55, 23);
            this.NetoLab.TabIndex = 15;
            this.NetoLab.Text = "*****";
            // 
            // ProductosLV
            // 
            this.ProductosLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductosLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nombre,
            this.Marca,
            this.Precio,
            this.Cantidad,
            this.Categoria,
            this.Subtotal});
            this.ProductosLV.HideSelection = false;
            this.ProductosLV.Location = new System.Drawing.Point(45, 215);
            this.ProductosLV.Margin = new System.Windows.Forms.Padding(5);
            this.ProductosLV.Name = "ProductosLV";
            this.ProductosLV.Size = new System.Drawing.Size(733, 108);
            this.ProductosLV.TabIndex = 16;
            this.ProductosLV.UseCompatibleStateImageBehavior = false;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 40;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 180;
            // 
            // Marca
            // 
            this.Marca.Text = "Marca";
            this.Marca.Width = 180;
            // 
            // Precio
            // 
            this.Precio.Text = "Precio (C$)";
            this.Precio.Width = 180;
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad (Q)";
            this.Cantidad.Width = 180;
            // 
            // Categoria
            // 
            this.Categoria.Text = "Categoria";
            // 
            // Subtotal
            // 
            this.Subtotal.Text = "Subtotal";
            // 
            // CantidadTxt
            // 
            this.CantidadTxt.BackColor = System.Drawing.Color.Transparent;
            this.CantidadTxt.Br = System.Drawing.Color.White;
            this.CantidadTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadTxt.ForeColor = System.Drawing.Color.Black;
            this.CantidadTxt.Location = new System.Drawing.Point(448, 153);
            this.CantidadTxt.Margin = new System.Windows.Forms.Padding(5);
            this.CantidadTxt.Name = "CantidadTxt";
            this.CantidadTxt.Size = new System.Drawing.Size(97, 37);
            this.CantidadTxt.TabIndex = 17;
            // 
            // errorProviderLetras
            // 
            this.errorProviderLetras.ContainerControl = this;
            this.errorProviderLetras.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderLetras.Icon")));
            // 
            // errorProviderCantidad
            // 
            this.errorProviderCantidad.ContainerControl = this;
            this.errorProviderCantidad.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderCantidad.Icon")));
            // 
            // ProductosTxt
            // 
            this.ProductosTxt.Location = new System.Drawing.Point(34, 162);
            this.ProductosTxt.Margin = new System.Windows.Forms.Padding(4);
            this.ProductosTxt.Name = "ProductosTxt";
            this.ProductosTxt.Size = new System.Drawing.Size(378, 28);
            this.ProductosTxt.TabIndex = 18;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 494);
            this.Controls.Add(this.ProductosTxt);
            this.Controls.Add(this.CantidadTxt);
            this.Controls.Add(this.ProductosLV);
            this.Controls.Add(this.NetoLab);
            this.Controls.Add(this.IvaLab);
            this.Controls.Add(this.BaseLab);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ImprimirBo);
            this.Controls.Add(this.BorrarBo);
            this.Controls.Add(this.AgregarBo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FechaLab);
            this.Controls.Add(this.UserLab);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Facturacion";
            this.Text = "Venta";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLetras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserLab;
        private System.Windows.Forms.Label FechaLab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private AltoControls.AltoButton AgregarBo;
        private AltoControls.AltoButton BorrarBo;
        private AltoControls.AltoButton ImprimirBo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label BaseLab;
        private System.Windows.Forms.Label IvaLab;
        private System.Windows.Forms.Label NetoLab;
        private System.Windows.Forms.ListView ProductosLV;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Precio;
        private AltoControls.AltoTextBox CantidadTxt;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ErrorProvider errorProviderLetras;
        private System.Windows.Forms.ErrorProvider errorProviderCantidad;
        private System.Windows.Forms.TextBox ProductosTxt;
        private System.Windows.Forms.ColumnHeader Marca;
        private System.Windows.Forms.ColumnHeader Categoria;
        private System.Windows.Forms.ColumnHeader Subtotal;
    }
}