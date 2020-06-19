namespace Ferreto.Views
{
    partial class AñadirProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AñadirProveedor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombretxt = new AltoControls.AltoTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.telefonotxt = new AltoControls.AltoTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.apellidotxt = new AltoControls.AltoTextBox();
            this.correotxt = new AltoControls.AltoTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Empresatxt = new AltoControls.AltoTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AñadirBo = new AltoControls.AltoButton();
            this.direcciontxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CedulaTxt = new AltoControls.AltoTextBox();
            this.ErrorProviderLetras = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCorreo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCedula = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEmpresa = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDireccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderLetras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCedula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDireccion)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(800, 77);
            this.panel1.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gotham", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.label12.Location = new System.Drawing.Point(457, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 31);
            this.label12.TabIndex = 37;
            this.label12.Text = "|\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gotham", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.label10.Location = new System.Drawing.Point(121, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 24);
            this.label10.TabIndex = 35;
            this.label10.Text = "Datos Personales";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gotham", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.label11.Location = new System.Drawing.Point(581, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 24);
            this.label11.TabIndex = 36;
            this.label11.Text = "Institucional";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nombres:";
            // 
            // nombretxt
            // 
            this.nombretxt.BackColor = System.Drawing.Color.Transparent;
            this.nombretxt.Br = System.Drawing.Color.White;
            this.nombretxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombretxt.ForeColor = System.Drawing.Color.Black;
            this.nombretxt.Location = new System.Drawing.Point(39, 173);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(169, 30);
            this.nombretxt.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(253, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "Teléfono:";
            // 
            // telefonotxt
            // 
            this.telefonotxt.BackColor = System.Drawing.Color.Transparent;
            this.telefonotxt.Br = System.Drawing.Color.White;
            this.telefonotxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonotxt.ForeColor = System.Drawing.Color.Black;
            this.telefonotxt.Location = new System.Drawing.Point(39, 270);
            this.telefonotxt.Name = "telefonotxt";
            this.telefonotxt.Size = new System.Drawing.Size(169, 30);
            this.telefonotxt.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(253, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 45;
            this.label4.Text = "Correo:";
            // 
            // apellidotxt
            // 
            this.apellidotxt.BackColor = System.Drawing.Color.Transparent;
            this.apellidotxt.Br = System.Drawing.Color.White;
            this.apellidotxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidotxt.ForeColor = System.Drawing.Color.Black;
            this.apellidotxt.Location = new System.Drawing.Point(246, 173);
            this.apellidotxt.Name = "apellidotxt";
            this.apellidotxt.Size = new System.Drawing.Size(169, 30);
            this.apellidotxt.TabIndex = 46;
            // 
            // correotxt
            // 
            this.correotxt.BackColor = System.Drawing.Color.Transparent;
            this.correotxt.Br = System.Drawing.Color.White;
            this.correotxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correotxt.ForeColor = System.Drawing.Color.Black;
            this.correotxt.Location = new System.Drawing.Point(246, 270);
            this.correotxt.Name = "correotxt";
            this.correotxt.Size = new System.Drawing.Size(194, 30);
            this.correotxt.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(525, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 48;
            this.label5.Text = "Empresa:";
            // 
            // Empresatxt
            // 
            this.Empresatxt.BackColor = System.Drawing.Color.Transparent;
            this.Empresatxt.Br = System.Drawing.Color.White;
            this.Empresatxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empresatxt.ForeColor = System.Drawing.Color.Black;
            this.Empresatxt.Location = new System.Drawing.Point(529, 173);
            this.Empresatxt.Name = "Empresatxt";
            this.Empresatxt.Size = new System.Drawing.Size(206, 30);
            this.Empresatxt.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(525, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 50;
            this.label6.Text = "Dirección:";
            // 
            // AñadirBo
            // 
            this.AñadirBo.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.AñadirBo.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.AñadirBo.BackColor = System.Drawing.Color.Transparent;
            this.AñadirBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AñadirBo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AñadirBo.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AñadirBo.ForeColor = System.Drawing.Color.White;
            this.AñadirBo.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.AñadirBo.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.AñadirBo.Location = new System.Drawing.Point(529, 383);
            this.AñadirBo.Name = "AñadirBo";
            this.AñadirBo.Radius = 5;
            this.AñadirBo.Size = new System.Drawing.Size(226, 42);
            this.AñadirBo.Stroke = false;
            this.AñadirBo.StrokeColor = System.Drawing.Color.Gray;
            this.AñadirBo.TabIndex = 52;
            this.AñadirBo.Text = "Añadir";
            this.AñadirBo.Transparency = false;
            this.AñadirBo.Click += new System.EventHandler(this.AñadirBo_Click);
            // 
            // direcciontxt
            // 
            this.direcciontxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direcciontxt.Location = new System.Drawing.Point(529, 255);
            this.direcciontxt.Multiline = true;
            this.direcciontxt.Name = "direcciontxt";
            this.direcciontxt.Size = new System.Drawing.Size(226, 105);
            this.direcciontxt.TabIndex = 53;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 32);
            this.panel2.TabIndex = 54;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Ferreto.Properties.Resources.error;
            this.pictureBox1.Location = new System.Drawing.Point(769, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Cerrar);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(40, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 55;
            this.label7.Text = "Cédula:";
            // 
            // CedulaTxt
            // 
            this.CedulaTxt.BackColor = System.Drawing.Color.Transparent;
            this.CedulaTxt.Br = System.Drawing.Color.White;
            this.CedulaTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CedulaTxt.ForeColor = System.Drawing.Color.Black;
            this.CedulaTxt.Location = new System.Drawing.Point(39, 362);
            this.CedulaTxt.Name = "CedulaTxt";
            this.CedulaTxt.Size = new System.Drawing.Size(169, 30);
            this.CedulaTxt.TabIndex = 56;
            // 
            // ErrorProviderLetras
            // 
            this.ErrorProviderLetras.ContainerControl = this;
            this.ErrorProviderLetras.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProviderLetras.Icon")));
            // 
            // errorProviderTelefono
            // 
            this.errorProviderTelefono.ContainerControl = this;
            this.errorProviderTelefono.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderTelefono.Icon")));
            // 
            // errorProviderCorreo
            // 
            this.errorProviderCorreo.ContainerControl = this;
            this.errorProviderCorreo.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderCorreo.Icon")));
            // 
            // errorProviderCedula
            // 
            this.errorProviderCedula.ContainerControl = this;
            this.errorProviderCedula.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderCedula.Icon")));
            // 
            // errorProviderEmpresa
            // 
            this.errorProviderEmpresa.ContainerControl = this;
            this.errorProviderEmpresa.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderEmpresa.Icon")));
            // 
            // errorProviderDireccion
            // 
            this.errorProviderDireccion.ContainerControl = this;
            this.errorProviderDireccion.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderDireccion.Icon")));
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // AñadirProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.CedulaTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.direcciontxt);
            this.Controls.Add(this.AñadirBo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Empresatxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.correotxt);
            this.Controls.Add(this.apellidotxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.telefonotxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AñadirProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AñadirProveedor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderLetras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCedula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDireccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private AltoControls.AltoTextBox nombretxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private AltoControls.AltoTextBox telefonotxt;
        private System.Windows.Forms.Label label4;
        private AltoControls.AltoTextBox apellidotxt;
        private AltoControls.AltoTextBox correotxt;
        private System.Windows.Forms.Label label5;
        private AltoControls.AltoTextBox Empresatxt;
        private System.Windows.Forms.Label label6;
        private AltoControls.AltoButton AñadirBo;
        private System.Windows.Forms.TextBox direcciontxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private AltoControls.AltoTextBox CedulaTxt;
        private System.Windows.Forms.ErrorProvider ErrorProviderLetras;
        private System.Windows.Forms.ErrorProvider errorProviderTelefono;
        private System.Windows.Forms.ErrorProvider errorProviderCorreo;
        private System.Windows.Forms.ErrorProvider errorProviderCedula;
        private System.Windows.Forms.ErrorProvider errorProviderEmpresa;
        private System.Windows.Forms.ErrorProvider errorProviderDireccion;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}