namespace Ferreto.Views
{
    partial class ReimprimirBo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReimprimirBo));
            this.FechaLab = new System.Windows.Forms.Label();
            this.BuscarBo = new AltoControls.AltoButton();
            this.ReBo = new AltoControls.AltoButton();
            this.errorProviderNum = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.idtxt = new AltoControls.AltoTextBox();
            this.DetallesLv = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Limpiarbttn = new AltoControls.AltoButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNum)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaLab
            // 
            this.FechaLab.AutoSize = true;
            this.FechaLab.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.FechaLab.Location = new System.Drawing.Point(20, 20);
            this.FechaLab.Name = "FechaLab";
            this.FechaLab.Size = new System.Drawing.Size(57, 18);
            this.FechaLab.TabIndex = 5;
            this.FechaLab.Text = "Fecha";
            // 
            // BuscarBo
            // 
            this.BuscarBo.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.BuscarBo.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.BuscarBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarBo.BackColor = System.Drawing.Color.Transparent;
            this.BuscarBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuscarBo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BuscarBo.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarBo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.BuscarBo.Inactive1 = System.Drawing.Color.White;
            this.BuscarBo.Inactive2 = System.Drawing.Color.White;
            this.BuscarBo.Location = new System.Drawing.Point(694, 90);
            this.BuscarBo.Name = "BuscarBo";
            this.BuscarBo.Radius = 5;
            this.BuscarBo.Size = new System.Drawing.Size(102, 30);
            this.BuscarBo.Stroke = false;
            this.BuscarBo.StrokeColor = System.Drawing.Color.Gray;
            this.BuscarBo.TabIndex = 12;
            this.BuscarBo.Text = "Buscar";
            this.BuscarBo.Transparency = false;
            this.BuscarBo.Click += new System.EventHandler(this.Buscar);
            // 
            // ReBo
            // 
            this.ReBo.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.ReBo.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.ReBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReBo.BackColor = System.Drawing.Color.Transparent;
            this.ReBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReBo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ReBo.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReBo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.ReBo.Inactive1 = System.Drawing.Color.White;
            this.ReBo.Inactive2 = System.Drawing.Color.White;
            this.ReBo.Location = new System.Drawing.Point(694, 413);
            this.ReBo.Name = "ReBo";
            this.ReBo.Radius = 5;
            this.ReBo.Size = new System.Drawing.Size(102, 42);
            this.ReBo.Stroke = false;
            this.ReBo.StrokeColor = System.Drawing.Color.Gray;
            this.ReBo.TabIndex = 13;
            this.ReBo.Text = "Reimprimir";
            this.ReBo.Transparency = false;
            this.ReBo.Click += new System.EventHandler(this.ReBo_Click);
            // 
            // errorProviderNum
            // 
            this.errorProviderNum.ContainerControl = this;
            this.errorProviderNum.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderNum.Icon")));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(20, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "N° Factura";
            // 
            // idtxt
            // 
            this.idtxt.BackColor = System.Drawing.Color.Transparent;
            this.idtxt.Br = System.Drawing.Color.White;
            this.idtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtxt.ForeColor = System.Drawing.Color.Black;
            this.idtxt.Location = new System.Drawing.Point(24, 90);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(169, 30);
            this.idtxt.TabIndex = 41;
            // 
            // DetallesLv
            // 
            this.DetallesLv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetallesLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nombre,
            this.Marca,
            this.Precio,
            this.Cantidad,
            this.Categoria,
            this.Subtotal});
            this.DetallesLv.Font = new System.Drawing.Font("Gotham", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetallesLv.FullRowSelect = true;
            this.DetallesLv.HideSelection = false;
            this.DetallesLv.Location = new System.Drawing.Point(24, 127);
            this.DetallesLv.Margin = new System.Windows.Forms.Padding(4);
            this.DetallesLv.Name = "DetallesLv";
            this.DetallesLv.Size = new System.Drawing.Size(772, 269);
            this.DetallesLv.TabIndex = 42;
            this.DetallesLv.UseCompatibleStateImageBehavior = false;
            this.DetallesLv.View = System.Windows.Forms.View.Details;
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
            this.Categoria.Width = 200;
            // 
            // Subtotal
            // 
            this.Subtotal.Text = "Subtotal";
            this.Subtotal.Width = 150;
            // 
            // Limpiarbttn
            // 
            this.Limpiarbttn.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.Limpiarbttn.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.Limpiarbttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Limpiarbttn.BackColor = System.Drawing.Color.Transparent;
            this.Limpiarbttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Limpiarbttn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Limpiarbttn.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiarbttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.Limpiarbttn.Inactive1 = System.Drawing.Color.White;
            this.Limpiarbttn.Inactive2 = System.Drawing.Color.White;
            this.Limpiarbttn.Location = new System.Drawing.Point(694, 90);
            this.Limpiarbttn.Name = "Limpiarbttn";
            this.Limpiarbttn.Radius = 5;
            this.Limpiarbttn.Size = new System.Drawing.Size(102, 30);
            this.Limpiarbttn.Stroke = false;
            this.Limpiarbttn.StrokeColor = System.Drawing.Color.Gray;
            this.Limpiarbttn.TabIndex = 12;
            this.Limpiarbttn.Text = "Limpiar";
            this.Limpiarbttn.Transparency = false;
            this.Limpiarbttn.Visible = false;
            this.Limpiarbttn.Click += new System.EventHandler(this.limpiar);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ReimprimirBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 467);
            this.Controls.Add(this.DetallesLv);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.ReBo);
            this.Controls.Add(this.Limpiarbttn);
            this.Controls.Add(this.BuscarBo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReimprimirBo";
            this.Text = "Facturas";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FechaLab;
        private AltoControls.AltoButton BuscarBo;
        private AltoControls.AltoButton ReBo;
        private System.Windows.Forms.ErrorProvider errorProviderNum;
        private System.Windows.Forms.Label label1;
        private AltoControls.AltoTextBox idtxt;
        private System.Windows.Forms.ListView DetallesLv;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Marca;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader Categoria;
        private System.Windows.Forms.ColumnHeader Subtotal;
        private AltoControls.AltoButton Limpiarbttn;
        private System.Windows.Forms.Timer timer1;
    }
}