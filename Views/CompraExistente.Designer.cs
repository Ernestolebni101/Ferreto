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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompraExistente));
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
            this.errorProviderLetras = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNumero = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderdecimal = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.UserLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLetras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderdecimal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 96);
            this.panel1.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gotham", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.label12.Location = new System.Drawing.Point(515, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 38);
            this.label12.TabIndex = 37;
            this.label12.Text = "|\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gotham", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.label10.Location = new System.Drawing.Point(105, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(289, 31);
            this.label10.TabIndex = 35;
            this.label10.Text = "Detalle de Producto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gotham", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.label11.Location = new System.Drawing.Point(729, 37);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 31);
            this.label11.TabIndex = 36;
            this.label11.Text = "Monetario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "Producto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(268, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 23);
            this.label6.TabIndex = 40;
            this.label6.Text = "Proveedor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(35, 332);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 23);
            this.label8.TabIndex = 41;
            this.label8.Text = "Vencimiento:";
            // 
            // ProductoCB
            // 
            this.ProductoCB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoCB.FormattingEnabled = true;
            this.ProductoCB.Location = new System.Drawing.Point(40, 246);
            this.ProductoCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductoCB.Name = "ProductoCB";
            this.ProductoCB.Size = new System.Drawing.Size(193, 29);
            this.ProductoCB.TabIndex = 42;
            // 
            // ProveedorCB
            // 
            this.ProveedorCB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProveedorCB.FormattingEnabled = true;
            this.ProveedorCB.Location = new System.Drawing.Point(273, 246);
            this.ProveedorCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProveedorCB.Name = "ProveedorCB";
            this.ProveedorCB.Size = new System.Drawing.Size(193, 29);
            this.ProveedorCB.TabIndex = 43;
            // 
            // VencimientoTP
            // 
            this.VencimientoTP.CalendarFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VencimientoTP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VencimientoTP.Location = new System.Drawing.Point(40, 390);
            this.VencimientoTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VencimientoTP.Name = "VencimientoTP";
            this.VencimientoTP.Size = new System.Drawing.Size(193, 27);
            this.VencimientoTP.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(589, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 23);
            this.label3.TabIndex = 45;
            this.label3.Text = "Cantidad Actual:";
            // 
            // CantidadTxt
            // 
            this.CantidadTxt.BackColor = System.Drawing.Color.Transparent;
            this.CantidadTxt.Br = System.Drawing.Color.White;
            this.CantidadTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadTxt.ForeColor = System.Drawing.Color.Black;
            this.CantidadTxt.Location = new System.Drawing.Point(595, 246);
            this.CantidadTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CantidadTxt.Name = "CantidadTxt";
            this.CantidadTxt.Size = new System.Drawing.Size(195, 37);
            this.CantidadTxt.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(839, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 23);
            this.label4.TabIndex = 47;
            this.label4.Text = "Costo Unitario:";
            // 
            // CostoUnitarioTxt
            // 
            this.CostoUnitarioTxt.BackColor = System.Drawing.Color.Transparent;
            this.CostoUnitarioTxt.Br = System.Drawing.Color.White;
            this.CostoUnitarioTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostoUnitarioTxt.ForeColor = System.Drawing.Color.Black;
            this.CostoUnitarioTxt.Location = new System.Drawing.Point(844, 246);
            this.CostoUnitarioTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CostoUnitarioTxt.Name = "CostoUnitarioTxt";
            this.CostoUnitarioTxt.Size = new System.Drawing.Size(195, 37);
            this.CostoUnitarioTxt.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(589, 332);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 23);
            this.label5.TabIndex = 49;
            this.label5.Text = "Nuevo Precio de Venta:";
            // 
            // NuevoPrecioTxt
            // 
            this.NuevoPrecioTxt.BackColor = System.Drawing.Color.Transparent;
            this.NuevoPrecioTxt.Br = System.Drawing.Color.White;
            this.NuevoPrecioTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoPrecioTxt.ForeColor = System.Drawing.Color.Black;
            this.NuevoPrecioTxt.Location = new System.Drawing.Point(595, 390);
            this.NuevoPrecioTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NuevoPrecioTxt.Name = "NuevoPrecioTxt";
            this.NuevoPrecioTxt.Size = new System.Drawing.Size(195, 37);
            this.NuevoPrecioTxt.TabIndex = 50;
            // 
            // ActualizarBo
            // 
            this.ActualizarBo.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.ActualizarBo.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.ActualizarBo.BackColor = System.Drawing.Color.Transparent;
            this.ActualizarBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActualizarBo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ActualizarBo.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualizarBo.ForeColor = System.Drawing.Color.White;
            this.ActualizarBo.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.ActualizarBo.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.ActualizarBo.Location = new System.Drawing.Point(595, 457);
            this.ActualizarBo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ActualizarBo.Name = "ActualizarBo";
            this.ActualizarBo.Radius = 5;
            this.ActualizarBo.Size = new System.Drawing.Size(444, 52);
            this.ActualizarBo.Stroke = false;
            this.ActualizarBo.StrokeColor = System.Drawing.Color.Gray;
            this.ActualizarBo.TabIndex = 51;
            this.ActualizarBo.Text = "Actualizar";
            this.ActualizarBo.Transparency = false;
            this.ActualizarBo.Click += new System.EventHandler(this.Actualizar);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 39);
            this.panel2.TabIndex = 52;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Ferreto.Properties.Resources.error;
            this.pictureBox1.Location = new System.Drawing.Point(1024, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Cerrar);
            // 
            // errorProviderLetras
            // 
            this.errorProviderLetras.ContainerControl = this;
            this.errorProviderLetras.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderLetras.Icon")));
            // 
            // errorProviderNumero
            // 
            this.errorProviderNumero.ContainerControl = this;
            this.errorProviderNumero.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderNumero.Icon")));
            // 
            // errorProviderdecimal
            // 
            this.errorProviderdecimal.ContainerControl = this;
            this.errorProviderdecimal.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderdecimal.Icon")));
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // UserLabel
            // 
            this.UserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.UserLabel.Location = new System.Drawing.Point(501, 255);
            this.UserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(65, 23);
            this.UserLabel.TabIndex = 53;
            this.UserLabel.Text = "USER";
            this.UserLabel.Visible = false;
            // 
            // CompraExistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1067, 533);
            this.Controls.Add(this.UserLabel);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CompraExistente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Existencia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLetras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderdecimal)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorProviderLetras;
        private System.Windows.Forms.ErrorProvider errorProviderNumero;
        private System.Windows.Forms.ErrorProvider errorProviderdecimal;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.Label UserLabel;
    }
}