namespace Ferreto.Views
{
    partial class Venta
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
            this.label1 = new System.Windows.Forms.Label();
            this.UserLab = new System.Windows.Forms.Label();
            this.FechaLab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductosCB = new System.Windows.Forms.ComboBox();
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
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CantidadTxt = new AltoControls.AltoTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido de nuevo:";
            // 
            // UserLab
            // 
            this.UserLab.AutoSize = true;
            this.UserLab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.UserLab.Location = new System.Drawing.Point(222, 49);
            this.UserLab.Name = "UserLab";
            this.UserLab.Size = new System.Drawing.Size(40, 19);
            this.UserLab.TabIndex = 1;
            this.UserLab.Text = "User";
            // 
            // FechaLab
            // 
            this.FechaLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaLab.AutoSize = true;
            this.FechaLab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.FechaLab.Location = new System.Drawing.Point(490, 49);
            this.FechaLab.Name = "FechaLab";
            this.FechaLab.Size = new System.Drawing.Size(58, 19);
            this.FechaLab.TabIndex = 2;
            this.FechaLab.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(352, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad:";
            // 
            // ProductosCB
            // 
            this.ProductosCB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductosCB.FormattingEnabled = true;
            this.ProductosCB.Location = new System.Drawing.Point(27, 142);
            this.ProductosCB.Name = "ProductosCB";
            this.ProductosCB.Size = new System.Drawing.Size(266, 25);
            this.ProductosCB.TabIndex = 5;
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
            this.AgregarBo.Location = new System.Drawing.Point(593, 142);
            this.AgregarBo.Name = "AgregarBo";
            this.AgregarBo.Radius = 5;
            this.AgregarBo.Size = new System.Drawing.Size(80, 30);
            this.AgregarBo.Stroke = false;
            this.AgregarBo.StrokeColor = System.Drawing.Color.Gray;
            this.AgregarBo.TabIndex = 7;
            this.AgregarBo.Text = "Agregar";
            this.AgregarBo.Transparency = false;
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
            this.BorrarBo.Location = new System.Drawing.Point(707, 142);
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
            this.ImprimirBo.Location = new System.Drawing.Point(696, 397);
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
            this.label4.Location = new System.Drawing.Point(23, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Antes IVA:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label5.Location = new System.Drawing.Point(116, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "IVA:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(55, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Precio Neto:";
            // 
            // BaseLab
            // 
            this.BaseLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BaseLab.AutoSize = true;
            this.BaseLab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.BaseLab.Location = new System.Drawing.Point(184, 393);
            this.BaseLab.Name = "BaseLab";
            this.BaseLab.Size = new System.Drawing.Size(40, 21);
            this.BaseLab.TabIndex = 13;
            this.BaseLab.Text = "*****";
            // 
            // IvaLab
            // 
            this.IvaLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IvaLab.AutoSize = true;
            this.IvaLab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IvaLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.IvaLab.Location = new System.Drawing.Point(184, 414);
            this.IvaLab.Name = "IvaLab";
            this.IvaLab.Size = new System.Drawing.Size(40, 21);
            this.IvaLab.TabIndex = 14;
            this.IvaLab.Text = "*****";
            // 
            // NetoLab
            // 
            this.NetoLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NetoLab.AutoSize = true;
            this.NetoLab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetoLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.NetoLab.Location = new System.Drawing.Point(184, 435);
            this.NetoLab.Name = "NetoLab";
            this.NetoLab.Size = new System.Drawing.Size(40, 21);
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
            this.Precio,
            this.Total});
            this.ProductosLV.HideSelection = false;
            this.ProductosLV.Location = new System.Drawing.Point(27, 178);
            this.ProductosLV.Name = "ProductosLV";
            this.ProductosLV.Size = new System.Drawing.Size(760, 212);
            this.ProductosLV.TabIndex = 16;
            this.ProductosLV.UseCompatibleStateImageBehavior = false;
            // 
            // CantidadTxt
            // 
            this.CantidadTxt.BackColor = System.Drawing.Color.Transparent;
            this.CantidadTxt.Br = System.Drawing.Color.White;
            this.CantidadTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadTxt.ForeColor = System.Drawing.Color.Black;
            this.CantidadTxt.Location = new System.Drawing.Point(356, 137);
            this.CantidadTxt.Name = "CantidadTxt";
            this.CantidadTxt.Size = new System.Drawing.Size(87, 30);
            this.CantidadTxt.TabIndex = 17;
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 494);
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
            this.Controls.Add(this.ProductosCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FechaLab);
            this.Controls.Add(this.UserLab);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venta";
            this.Text = "Venta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserLab;
        private System.Windows.Forms.Label FechaLab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ProductosCB;
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
        private System.Windows.Forms.ColumnHeader Total;
        private AltoControls.AltoTextBox CantidadTxt;
    }
}