namespace Ferreto.Views
{
    partial class Compras
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
            this.label2 = new System.Windows.Forms.Label();
            this.MARGEN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ActualizarBo = new AltoControls.AltoButton();
            this.AñadirBo = new AltoControls.AltoButton();
            this.FechaLab = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ComprasLV = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Costo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Proveedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(155, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "¿Producto Existente?";
            // 
            // MARGEN
            // 
            this.MARGEN.AutoSize = true;
            this.MARGEN.Location = new System.Drawing.Point(13, 766);
            this.MARGEN.Name = "MARGEN";
            this.MARGEN.Size = new System.Drawing.Size(22, 13);
            this.MARGEN.TabIndex = 8;
            this.MARGEN.Text = "-----";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(496, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "¿Producto Nuevo?";
            // 
            // ActualizarBo
            // 
            this.ActualizarBo.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.ActualizarBo.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.ActualizarBo.BackColor = System.Drawing.Color.Transparent;
            this.ActualizarBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActualizarBo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ActualizarBo.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualizarBo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.ActualizarBo.Inactive1 = System.Drawing.Color.White;
            this.ActualizarBo.Inactive2 = System.Drawing.Color.White;
            this.ActualizarBo.Location = new System.Drawing.Point(158, 71);
            this.ActualizarBo.Name = "ActualizarBo";
            this.ActualizarBo.Radius = 5;
            this.ActualizarBo.Size = new System.Drawing.Size(182, 30);
            this.ActualizarBo.Stroke = false;
            this.ActualizarBo.StrokeColor = System.Drawing.Color.Gray;
            this.ActualizarBo.TabIndex = 13;
            this.ActualizarBo.Text = "Actualizar";
            this.ActualizarBo.Transparency = false;
            this.ActualizarBo.Click += new System.EventHandler(this.ActualizarBo_Click);
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
            this.AñadirBo.Location = new System.Drawing.Point(499, 71);
            this.AñadirBo.Name = "AñadirBo";
            this.AñadirBo.Radius = 5;
            this.AñadirBo.Size = new System.Drawing.Size(173, 30);
            this.AñadirBo.Stroke = false;
            this.AñadirBo.StrokeColor = System.Drawing.Color.Gray;
            this.AñadirBo.TabIndex = 14;
            this.AñadirBo.Text = "Añadir";
            this.AñadirBo.Transparency = false;
            this.AñadirBo.Click += new System.EventHandler(this.AñadirBo_Click);
            // 
            // FechaLab
            // 
            this.FechaLab.AutoSize = true;
            this.FechaLab.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.FechaLab.Location = new System.Drawing.Point(19, 9);
            this.FechaLab.Name = "FechaLab";
            this.FechaLab.Size = new System.Drawing.Size(57, 18);
            this.FechaLab.TabIndex = 11;
            this.FechaLab.Text = "Fecha";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.UserLabel.Location = new System.Drawing.Point(20, 55);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(53, 18);
            this.UserLabel.TabIndex = 16;
            this.UserLabel.Text = "USER";
            this.UserLabel.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ComprasLV
            // 
            this.ComprasLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nombre,
            this.Cantidad,
            this.Costo,
            this.Total,
            this.Precio,
            this.Proveedor,
            this.Fecha});
            this.ComprasLV.HideSelection = false;
            this.ComprasLV.Location = new System.Drawing.Point(22, 141);
            this.ComprasLV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComprasLV.Name = "ComprasLV";
            this.ComprasLV.Size = new System.Drawing.Size(765, 301);
            this.ComprasLV.TabIndex = 17;
            this.ComprasLV.UseCompatibleStateImageBehavior = false;
            this.ComprasLV.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "Id";
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Width = 70;
            // 
            // Costo
            // 
            this.Costo.Text = "Costo";
            this.Costo.Width = 70;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.Width = 70;
            // 
            // Precio
            // 
            this.Precio.Text = "Precio de venta";
            this.Precio.Width = 100;
            // 
            // Proveedor
            // 
            this.Proveedor.Text = "Proveedor";
            this.Proveedor.Width = 150;
            // 
            // Fecha
            // 
            this.Fecha.Text = "Fecha de compra";
            this.Fecha.Width = 100;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 467);
            this.Controls.Add(this.ComprasLV);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.AñadirBo);
            this.Controls.Add(this.ActualizarBo);
            this.Controls.Add(this.FechaLab);
            this.Controls.Add(this.MARGEN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Compras";
            this.Text = "Compras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MARGEN;
        private System.Windows.Forms.Label label3;
        private AltoControls.AltoButton ActualizarBo;
        private AltoControls.AltoButton AñadirBo;
        private System.Windows.Forms.Label FechaLab;
        public System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView ComprasLV;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader Costo;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.ColumnHeader Proveedor;
        private System.Windows.Forms.ColumnHeader Fecha;
        private System.Windows.Forms.Timer timer2;
    }
}