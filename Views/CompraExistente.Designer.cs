namespace Ferreto.Views
{
    partial class CompraExistente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ProductoCB = new System.Windows.Forms.ComboBox();
            this.ProveedorCB = new System.Windows.Forms.ComboBox();
            this.VencimientoTP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.CantidadTxt = new AltoControls.AltoTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CostoUnitarioTxt = new AltoControls.AltoTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NuevoPrecioTxt = new AltoControls.AltoTextBox();
            this.ActualizarBo = new AltoControls.AltoButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 78);
            this.panel1.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(386, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 32);
            this.label12.TabIndex = 37;
            this.label12.Text = "|\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(79, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(213, 25);
            this.label10.TabIndex = 35;
            this.label10.Text = "Detalle de Producto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(547, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 25);
            this.label11.TabIndex = 36;
            this.label11.Text = "Monetario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(26, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Producto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(201, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 19);
            this.label6.TabIndex = 40;
            this.label6.Text = "Proveedor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label8.Location = new System.Drawing.Point(26, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 19);
            this.label8.TabIndex = 41;
            this.label8.Text = "Vencimiento:";
            // 
            // ProductoCB
            // 
            this.ProductoCB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoCB.FormattingEnabled = true;
            this.ProductoCB.Location = new System.Drawing.Point(30, 200);
            this.ProductoCB.Name = "ProductoCB";
            this.ProductoCB.Size = new System.Drawing.Size(146, 25);
            this.ProductoCB.TabIndex = 42;
            // 
            // ProveedorCB
            // 
            this.ProveedorCB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProveedorCB.FormattingEnabled = true;
            this.ProveedorCB.Location = new System.Drawing.Point(205, 200);
            this.ProveedorCB.Name = "ProveedorCB";
            this.ProveedorCB.Size = new System.Drawing.Size(146, 25);
            this.ProveedorCB.TabIndex = 43;
            // 
            // VencimientoTP
            // 
            this.VencimientoTP.CalendarFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VencimientoTP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VencimientoTP.Location = new System.Drawing.Point(30, 317);
            this.VencimientoTP.Name = "VencimientoTP";
            this.VencimientoTP.Size = new System.Drawing.Size(146, 23);
            this.VencimientoTP.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(442, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 45;
            this.label3.Text = "Cantidad Actual:";
            // 
            // CantidadTxt
            // 
            this.CantidadTxt.BackColor = System.Drawing.Color.Transparent;
            this.CantidadTxt.Br = System.Drawing.Color.White;
            this.CantidadTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadTxt.ForeColor = System.Drawing.Color.Black;
            this.CantidadTxt.Location = new System.Drawing.Point(446, 200);
            this.CantidadTxt.Name = "CantidadTxt";
            this.CantidadTxt.Size = new System.Drawing.Size(146, 30);
            this.CantidadTxt.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(629, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "Costo Unitario:";
            // 
            // CostoUnitarioTxt
            // 
            this.CostoUnitarioTxt.BackColor = System.Drawing.Color.Transparent;
            this.CostoUnitarioTxt.Br = System.Drawing.Color.White;
            this.CostoUnitarioTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostoUnitarioTxt.ForeColor = System.Drawing.Color.Black;
            this.CostoUnitarioTxt.Location = new System.Drawing.Point(633, 200);
            this.CostoUnitarioTxt.Name = "CostoUnitarioTxt";
            this.CostoUnitarioTxt.Size = new System.Drawing.Size(146, 30);
            this.CostoUnitarioTxt.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label5.Location = new System.Drawing.Point(442, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 19);
            this.label5.TabIndex = 49;
            this.label5.Text = "Nuevo Precio de Venta:";
            // 
            // NuevoPrecioTxt
            // 
            this.NuevoPrecioTxt.BackColor = System.Drawing.Color.Transparent;
            this.NuevoPrecioTxt.Br = System.Drawing.Color.White;
            this.NuevoPrecioTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoPrecioTxt.ForeColor = System.Drawing.Color.Black;
            this.NuevoPrecioTxt.Location = new System.Drawing.Point(446, 317);
            this.NuevoPrecioTxt.Name = "NuevoPrecioTxt";
            this.NuevoPrecioTxt.Size = new System.Drawing.Size(146, 30);
            this.NuevoPrecioTxt.TabIndex = 50;
            // 
            // ActualizarBo
            // 
            this.ActualizarBo.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.ActualizarBo.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.ActualizarBo.BackColor = System.Drawing.Color.Transparent;
            this.ActualizarBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActualizarBo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ActualizarBo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualizarBo.ForeColor = System.Drawing.Color.White;
            this.ActualizarBo.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.ActualizarBo.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.ActualizarBo.Location = new System.Drawing.Point(633, 371);
            this.ActualizarBo.Name = "ActualizarBo";
            this.ActualizarBo.Radius = 5;
            this.ActualizarBo.Size = new System.Drawing.Size(146, 42);
            this.ActualizarBo.Stroke = false;
            this.ActualizarBo.StrokeColor = System.Drawing.Color.Gray;
            this.ActualizarBo.TabIndex = 51;
            this.ActualizarBo.Text = "Actualizar";
            this.ActualizarBo.Transparency = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 32);
            this.panel2.TabIndex = 52;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Ferreto.Properties.Resources.error;
            this.pictureBox1.Location = new System.Drawing.Point(768, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Cerrar);
            // 
            // CompraExistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ActualizarBo);
            this.Controls.Add(this.NuevoPrecioTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CostoUnitarioTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CantidadTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VencimientoTP);
            this.Controls.Add(this.ProveedorCB);
            this.Controls.Add(this.ProductoCB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompraExistente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Existencia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ProductoCB;
        private System.Windows.Forms.ComboBox ProveedorCB;
        private System.Windows.Forms.DateTimePicker VencimientoTP;
        private System.Windows.Forms.Label label3;
        private AltoControls.AltoTextBox CantidadTxt;
        private System.Windows.Forms.Label label4;
        private AltoControls.AltoTextBox CostoUnitarioTxt;
        private System.Windows.Forms.Label label5;
        private AltoControls.AltoTextBox NuevoPrecioTxt;
        private AltoControls.AltoButton ActualizarBo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}