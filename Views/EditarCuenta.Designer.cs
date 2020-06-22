namespace Ferreto.Views
{
    partial class EditarCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarCuenta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UsuarioCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nombreUsuarioTxt = new AltoControls.AltoTextBox();
            this.contraselaNuevatxt = new AltoControls.AltoTextBox();
            this.statusSlide = new AltoControls.SlideButton();
            this.label4 = new System.Windows.Forms.Label();
            this.ActualizarBo = new AltoControls.AltoButton();
            this.PanelEditarCuenta = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProviderVacios = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLetras = new System.Windows.Forms.ErrorProvider(this.components);
            this.nuevorolCB = new System.Windows.Forms.ComboBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Nombrecheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.ContraseñaCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Rolcheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.EstadoCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Estadolabel = new System.Windows.Forms.Label();
            this.timerselect = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.PanelEditarCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVacios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLetras)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 95);
            this.panel1.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gotham", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.label12.Location = new System.Drawing.Point(28, 28);
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
            this.label10.Location = new System.Drawing.Point(77, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 31);
            this.label10.TabIndex = 35;
            this.label10.Text = "Panel de Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Seleccione Usuario:";
            // 
            // UsuarioCB
            // 
            this.UsuarioCB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioCB.FormattingEnabled = true;
            this.UsuarioCB.Location = new System.Drawing.Point(51, 223);
            this.UsuarioCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsuarioCB.Name = "UsuarioCB";
            this.UsuarioCB.Size = new System.Drawing.Size(205, 29);
            this.UsuarioCB.TabIndex = 41;
            this.UsuarioCB.SelectedIndexChanged += new System.EventHandler(this.UsuarioCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(416, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nuevo Nombre de Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(416, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 23);
            this.label3.TabIndex = 43;
            this.label3.Text = "Nueva Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(45, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 45;
            this.label5.Text = "Estado:";
            // 
            // nombreUsuarioTxt
            // 
            this.nombreUsuarioTxt.BackColor = System.Drawing.Color.Transparent;
            this.nombreUsuarioTxt.Br = System.Drawing.Color.White;
            this.nombreUsuarioTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUsuarioTxt.ForeColor = System.Drawing.Color.Black;
            this.nombreUsuarioTxt.Location = new System.Drawing.Point(421, 217);
            this.nombreUsuarioTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombreUsuarioTxt.Name = "nombreUsuarioTxt";
            this.nombreUsuarioTxt.Size = new System.Drawing.Size(272, 37);
            this.nombreUsuarioTxt.TabIndex = 46;
            // 
            // contraselaNuevatxt
            // 
            this.contraselaNuevatxt.BackColor = System.Drawing.Color.Transparent;
            this.contraselaNuevatxt.Br = System.Drawing.Color.White;
            this.contraselaNuevatxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraselaNuevatxt.ForeColor = System.Drawing.Color.Black;
            this.contraselaNuevatxt.Location = new System.Drawing.Point(421, 303);
            this.contraselaNuevatxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contraselaNuevatxt.Name = "contraselaNuevatxt";
            this.contraselaNuevatxt.Size = new System.Drawing.Size(272, 37);
            this.contraselaNuevatxt.TabIndex = 47;
            // 
            // statusSlide
            // 
            this.statusSlide.BorderColor = System.Drawing.Color.LightGray;
            this.statusSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statusSlide.IsOn = true;
            this.statusSlide.Location = new System.Drawing.Point(38, 342);
            this.statusSlide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusSlide.Name = "statusSlide";
            this.statusSlide.Size = new System.Drawing.Size(82, 43);
            this.statusSlide.TabIndex = 49;
            this.statusSlide.Text = "slideButton1";
            this.statusSlide.TextEnabled = true;
            this.statusSlide.Click += new System.EventHandler(this.statusSlide_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(416, 369);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 50;
            this.label4.Text = "Nuevo Rol:";
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
            this.ActualizarBo.Location = new System.Drawing.Point(51, 414);
            this.ActualizarBo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ActualizarBo.Name = "ActualizarBo";
            this.ActualizarBo.Radius = 5;
            this.ActualizarBo.Size = new System.Drawing.Size(220, 43);
            this.ActualizarBo.Stroke = false;
            this.ActualizarBo.StrokeColor = System.Drawing.Color.Gray;
            this.ActualizarBo.TabIndex = 52;
            this.ActualizarBo.Text = "Actualizar";
            this.ActualizarBo.Transparency = false;
            this.ActualizarBo.Click += new System.EventHandler(this.Actualizar);
            // 
            // PanelEditarCuenta
            // 
            this.PanelEditarCuenta.Controls.Add(this.pictureBox1);
            this.PanelEditarCuenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEditarCuenta.Location = new System.Drawing.Point(0, 0);
            this.PanelEditarCuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelEditarCuenta.Name = "PanelEditarCuenta";
            this.PanelEditarCuenta.Size = new System.Drawing.Size(780, 39);
            this.PanelEditarCuenta.TabIndex = 53;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ferreto.Properties.Resources.error;
            this.pictureBox1.Location = new System.Drawing.Point(737, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Cerrar);
            // 
            // errorProviderVacios
            // 
            this.errorProviderVacios.ContainerControl = this;
            this.errorProviderVacios.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderVacios.Icon")));
            // 
            // errorProviderLetras
            // 
            this.errorProviderLetras.ContainerControl = this;
            this.errorProviderLetras.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderLetras.Icon")));
            // 
            // nuevorolCB
            // 
            this.nuevorolCB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevorolCB.FormattingEnabled = true;
            this.nuevorolCB.Location = new System.Drawing.Point(421, 414);
            this.nuevorolCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nuevorolCB.Name = "nuevorolCB";
            this.nuevorolCB.Size = new System.Drawing.Size(271, 29);
            this.nuevorolCB.TabIndex = 51;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Nombrecheck
            // 
            this.Nombrecheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Nombrecheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Nombrecheck.Checked = false;
            this.Nombrecheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Nombrecheck.ForeColor = System.Drawing.Color.White;
            this.Nombrecheck.Location = new System.Drawing.Point(388, 164);
            this.Nombrecheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nombrecheck.Name = "Nombrecheck";
            this.Nombrecheck.Size = new System.Drawing.Size(20, 20);
            this.Nombrecheck.TabIndex = 54;
            this.Nombrecheck.Click += new System.EventHandler(this.Nombrecheck_Click);
            // 
            // ContraseñaCheck
            // 
            this.ContraseñaCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ContraseñaCheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ContraseñaCheck.Checked = false;
            this.ContraseñaCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ContraseñaCheck.ForeColor = System.Drawing.Color.White;
            this.ContraseñaCheck.Location = new System.Drawing.Point(388, 262);
            this.ContraseñaCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContraseñaCheck.Name = "ContraseñaCheck";
            this.ContraseñaCheck.Size = new System.Drawing.Size(20, 20);
            this.ContraseñaCheck.TabIndex = 54;
            this.ContraseñaCheck.Click += new System.EventHandler(this.ContraseñaCheck_Click);
            // 
            // Rolcheck
            // 
            this.Rolcheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Rolcheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Rolcheck.Checked = false;
            this.Rolcheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Rolcheck.ForeColor = System.Drawing.Color.White;
            this.Rolcheck.Location = new System.Drawing.Point(388, 369);
            this.Rolcheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rolcheck.Name = "Rolcheck";
            this.Rolcheck.Size = new System.Drawing.Size(20, 20);
            this.Rolcheck.TabIndex = 54;
            this.Rolcheck.Click += new System.EventHandler(this.Rolcheck_Click);
            // 
            // EstadoCheck
            // 
            this.EstadoCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.EstadoCheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.EstadoCheck.Checked = false;
            this.EstadoCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.EstadoCheck.ForeColor = System.Drawing.Color.White;
            this.EstadoCheck.Location = new System.Drawing.Point(17, 306);
            this.EstadoCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EstadoCheck.Name = "EstadoCheck";
            this.EstadoCheck.Size = new System.Drawing.Size(20, 20);
            this.EstadoCheck.TabIndex = 54;
            // 
            // Estadolabel
            // 
            this.Estadolabel.AutoSize = true;
            this.Estadolabel.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estadolabel.ForeColor = System.Drawing.Color.White;
            this.Estadolabel.Location = new System.Drawing.Point(137, 303);
            this.Estadolabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Estadolabel.Name = "Estadolabel";
            this.Estadolabel.Size = new System.Drawing.Size(27, 23);
            this.Estadolabel.TabIndex = 45;
            this.Estadolabel.Text = "O";
 
            // 
            // timerselect
            // 
            this.timerselect.Tick += new System.EventHandler(this.timerselect_Tick);
            // 
            // EditarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(780, 503);
            this.Controls.Add(this.EstadoCheck);
            this.Controls.Add(this.Rolcheck);
            this.Controls.Add(this.ContraseñaCheck);
            this.Controls.Add(this.Nombrecheck);
            this.Controls.Add(this.PanelEditarCuenta);
            this.Controls.Add(this.ActualizarBo);
            this.Controls.Add(this.nuevorolCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusSlide);
            this.Controls.Add(this.contraselaNuevatxt);
            this.Controls.Add(this.nombreUsuarioTxt);
            this.Controls.Add(this.Estadolabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsuarioCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditarCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarCuenta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelEditarCuenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVacios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLetras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox UsuarioCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private AltoControls.AltoTextBox nombreUsuarioTxt;
        private AltoControls.AltoTextBox contraselaNuevatxt;
        private AltoControls.SlideButton statusSlide;
        private System.Windows.Forms.Label label4;
        private AltoControls.AltoButton ActualizarBo;
        private System.Windows.Forms.Panel PanelEditarCuenta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProviderVacios;
        private System.Windows.Forms.ErrorProvider errorProviderLetras;
        private System.Windows.Forms.ComboBox nuevorolCB;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCheckbox EstadoCheck;
        private Bunifu.Framework.UI.BunifuCheckbox Rolcheck;
        private Bunifu.Framework.UI.BunifuCheckbox ContraseñaCheck;
        private Bunifu.Framework.UI.BunifuCheckbox Nombrecheck;
        private System.Windows.Forms.Label Estadolabel;
        private System.Windows.Forms.Timer timerselect;
    }
}