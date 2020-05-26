namespace Ferreto.Views
{
    partial class Proveedores
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
            this.label17 = new System.Windows.Forms.Label();
            this.UserLab = new System.Windows.Forms.Label();
            this.FechaLab = new System.Windows.Forms.Label();
            this.ProveedoresDG = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.BuscarProveedorTxt = new AltoControls.AltoTextBox();
            this.BuscarBo = new AltoControls.AltoButton();
            this.EliminarBo = new AltoControls.AltoButton();
            this.label2 = new System.Windows.Forms.Label();
            this.AñadirBo = new AltoControls.AltoButton();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label17.Location = new System.Drawing.Point(27, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(178, 19);
            this.label17.TabIndex = 10;
            this.label17.Text = "Bienvenido de nuevo:";
            // 
            // UserLab
            // 
            this.UserLab.AutoSize = true;
            this.UserLab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.UserLab.Location = new System.Drawing.Point(221, 37);
            this.UserLab.Name = "UserLab";
            this.UserLab.Size = new System.Drawing.Size(40, 19);
            this.UserLab.TabIndex = 11;
            this.UserLab.Text = "User";
            // 
            // FechaLab
            // 
            this.FechaLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaLab.AutoSize = true;
            this.FechaLab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.FechaLab.Location = new System.Drawing.Point(478, 37);
            this.FechaLab.Name = "FechaLab";
            this.FechaLab.Size = new System.Drawing.Size(58, 19);
            this.FechaLab.TabIndex = 12;
            this.FechaLab.Text = "Fecha";
            // 
            // ProveedoresDG
            // 
            this.ProveedoresDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProveedoresDG.BackgroundColor = System.Drawing.Color.White;
            this.ProveedoresDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProveedoresDG.Location = new System.Drawing.Point(31, 175);
            this.ProveedoresDG.Name = "ProveedoresDG";
            this.ProveedoresDG.Size = new System.Drawing.Size(761, 264);
            this.ProveedoresDG.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(27, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Buscar Proveedor:";
            // 
            // BuscarProveedorTxt
            // 
            this.BuscarProveedorTxt.BackColor = System.Drawing.Color.Transparent;
            this.BuscarProveedorTxt.Br = System.Drawing.Color.White;
            this.BuscarProveedorTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarProveedorTxt.ForeColor = System.Drawing.Color.Black;
            this.BuscarProveedorTxt.Location = new System.Drawing.Point(31, 128);
            this.BuscarProveedorTxt.Name = "BuscarProveedorTxt";
            this.BuscarProveedorTxt.Size = new System.Drawing.Size(220, 30);
            this.BuscarProveedorTxt.TabIndex = 16;
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
            this.BuscarBo.Location = new System.Drawing.Point(313, 128);
            this.BuscarBo.Name = "BuscarBo";
            this.BuscarBo.Radius = 5;
            this.BuscarBo.Size = new System.Drawing.Size(80, 30);
            this.BuscarBo.Stroke = false;
            this.BuscarBo.StrokeColor = System.Drawing.Color.Gray;
            this.BuscarBo.TabIndex = 17;
            this.BuscarBo.Text = "Buscar";
            this.BuscarBo.Transparency = false;
            // 
            // EliminarBo
            // 
            this.EliminarBo.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.EliminarBo.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.EliminarBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EliminarBo.BackColor = System.Drawing.Color.Transparent;
            this.EliminarBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliminarBo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.EliminarBo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBo.ForeColor = System.Drawing.Color.White;
            this.EliminarBo.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.EliminarBo.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.EliminarBo.Location = new System.Drawing.Point(31, 449);
            this.EliminarBo.Name = "EliminarBo";
            this.EliminarBo.Radius = 5;
            this.EliminarBo.Size = new System.Drawing.Size(145, 30);
            this.EliminarBo.Stroke = false;
            this.EliminarBo.StrokeColor = System.Drawing.Color.Gray;
            this.EliminarBo.TabIndex = 18;
            this.EliminarBo.Text = "Eliminar Proveedor";
            this.EliminarBo.Transparency = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(547, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 19);
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
            this.AñadirBo.Location = new System.Drawing.Point(547, 128);
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
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 494);
            this.Controls.Add(this.AñadirBo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EliminarBo);
            this.Controls.Add(this.BuscarBo);
            this.Controls.Add(this.BuscarProveedorTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProveedoresDG);
            this.Controls.Add(this.FechaLab);
            this.Controls.Add(this.UserLab);
            this.Controls.Add(this.label17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label UserLab;
        private System.Windows.Forms.Label FechaLab;
        private System.Windows.Forms.DataGridView ProveedoresDG;
        private System.Windows.Forms.Label label3;
        private AltoControls.AltoTextBox BuscarProveedorTxt;
        private AltoControls.AltoButton BuscarBo;
        private AltoControls.AltoButton EliminarBo;
        private System.Windows.Forms.Label label2;
        private AltoControls.AltoButton AñadirBo;
    }
}