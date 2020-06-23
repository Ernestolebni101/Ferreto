namespace Ferreto.Views
{
    partial class EditarItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MarcaTxt = new AltoControls.AltoTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MarcaCB = new System.Windows.Forms.ComboBox();
            this.estadomarcasl = new AltoControls.SlideButton();
            this.label8 = new System.Windows.Forms.Label();
            this.MedidaTxt = new AltoControls.AltoTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CategoriaTxt = new AltoControls.AltoTextBox();
            this.RolCB = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.estadorolsl = new AltoControls.SlideButton();
            this.label14 = new System.Windows.Forms.Label();
            this.RolTxt = new AltoControls.AltoTextBox();
            this.ActualizarBo = new AltoControls.AltoButton();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProviderMarca = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCategoria = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuSlider1 = new Bunifu.Framework.UI.BunifuSlider();
            this.Slidermarca = new AltoControls.SlideButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Sliderol = new AltoControls.SlideButton();
            this.marcanueva = new AltoControls.SlideButton();
            this.nuevorol = new AltoControls.SlideButton();
            this.categorianueva = new AltoControls.SlideButton();
            this.nuevamedida = new AltoControls.SlideButton();
            this.errorProviderRol = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMEDIDA = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMEDIDA)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 56);
            this.panel1.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gotham", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.label12.Location = new System.Drawing.Point(21, 10);
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
            this.label10.Location = new System.Drawing.Point(58, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 24);
            this.label10.TabIndex = 35;
            this.label10.Text = "Panel de Control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 43;
            this.label2.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(330, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 46;
            this.label4.Text = "Rol:";
            // 
            // MarcaTxt
            // 
            this.MarcaTxt.BackColor = System.Drawing.Color.Transparent;
            this.MarcaTxt.Br = System.Drawing.Color.White;
            this.MarcaTxt.Enabled = false;
            this.MarcaTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarcaTxt.ForeColor = System.Drawing.Color.Black;
            this.MarcaTxt.Location = new System.Drawing.Point(26, 227);
            this.MarcaTxt.Name = "MarcaTxt";
            this.MarcaTxt.Size = new System.Drawing.Size(166, 30);
            this.MarcaTxt.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(220, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 48;
            this.label5.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(35, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 18);
            this.label6.TabIndex = 49;
            this.label6.Text = "Nueva Marca:";
            // 
            // MarcaCB
            // 
            this.MarcaCB.Enabled = false;
            this.MarcaCB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarcaCB.FormattingEnabled = true;
            this.MarcaCB.Location = new System.Drawing.Point(38, 151);
            this.MarcaCB.Name = "MarcaCB";
            this.MarcaCB.Size = new System.Drawing.Size(155, 25);
            this.MarcaCB.TabIndex = 50;
            // 
            // estadomarcasl
            // 
            this.estadomarcasl.BorderColor = System.Drawing.Color.LightGray;
            this.estadomarcasl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estadomarcasl.Enabled = false;
            this.estadomarcasl.IsOn = false;
            this.estadomarcasl.Location = new System.Drawing.Point(222, 141);
            this.estadomarcasl.Name = "estadomarcasl";
            this.estadomarcasl.Size = new System.Drawing.Size(66, 35);
            this.estadomarcasl.TabIndex = 51;
            this.estadomarcasl.Text = "slideButton1";
            this.estadomarcasl.TextEnabled = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(331, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 18);
            this.label8.TabIndex = 55;
            this.label8.Text = "Nueva Medida:";
            // 
            // MedidaTxt
            // 
            this.MedidaTxt.BackColor = System.Drawing.Color.Transparent;
            this.MedidaTxt.Br = System.Drawing.Color.White;
            this.MedidaTxt.Enabled = false;
            this.MedidaTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedidaTxt.ForeColor = System.Drawing.Color.Black;
            this.MedidaTxt.Location = new System.Drawing.Point(334, 358);
            this.MedidaTxt.Name = "MedidaTxt";
            this.MedidaTxt.Size = new System.Drawing.Size(166, 30);
            this.MedidaTxt.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(23, 314);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 18);
            this.label11.TabIndex = 60;
            this.label11.Text = "Nueva Categoria:";
            // 
            // CategoriaTxt
            // 
            this.CategoriaTxt.BackColor = System.Drawing.Color.Transparent;
            this.CategoriaTxt.Br = System.Drawing.Color.White;
            this.CategoriaTxt.Enabled = false;
            this.CategoriaTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaTxt.ForeColor = System.Drawing.Color.Black;
            this.CategoriaTxt.Location = new System.Drawing.Point(26, 353);
            this.CategoriaTxt.Name = "CategoriaTxt";
            this.CategoriaTxt.Size = new System.Drawing.Size(166, 30);
            this.CategoriaTxt.TabIndex = 61;
            // 
            // RolCB
            // 
            this.RolCB.Enabled = false;
            this.RolCB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RolCB.FormattingEnabled = true;
            this.RolCB.Location = new System.Drawing.Point(334, 141);
            this.RolCB.Name = "RolCB";
            this.RolCB.Size = new System.Drawing.Size(155, 25);
            this.RolCB.TabIndex = 62;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(517, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 18);
            this.label13.TabIndex = 63;
            this.label13.Text = "Estado:";
            // 
            // estadorolsl
            // 
            this.estadorolsl.BorderColor = System.Drawing.Color.LightGray;
            this.estadorolsl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estadorolsl.Enabled = false;
            this.estadorolsl.IsOn = false;
            this.estadorolsl.Location = new System.Drawing.Point(520, 142);
            this.estadorolsl.Name = "estadorolsl";
            this.estadorolsl.Size = new System.Drawing.Size(66, 35);
            this.estadorolsl.TabIndex = 64;
            this.estadorolsl.Text = "slideButton1";
            this.estadorolsl.TextEnabled = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(330, 193);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 18);
            this.label14.TabIndex = 65;
            this.label14.Text = "Nuevo Rol:";
            // 
            // RolTxt
            // 
            this.RolTxt.BackColor = System.Drawing.Color.Transparent;
            this.RolTxt.Br = System.Drawing.Color.White;
            this.RolTxt.Enabled = false;
            this.RolTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RolTxt.ForeColor = System.Drawing.Color.Black;
            this.RolTxt.Location = new System.Drawing.Point(333, 227);
            this.RolTxt.Name = "RolTxt";
            this.RolTxt.Size = new System.Drawing.Size(166, 30);
            this.RolTxt.TabIndex = 66;
            // 
            // ActualizarBo
            // 
            this.ActualizarBo.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.ActualizarBo.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.ActualizarBo.BackColor = System.Drawing.Color.Transparent;
            this.ActualizarBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActualizarBo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ActualizarBo.Enabled = false;
            this.ActualizarBo.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualizarBo.ForeColor = System.Drawing.Color.White;
            this.ActualizarBo.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.ActualizarBo.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.ActualizarBo.Location = new System.Drawing.Point(334, 426);
            this.ActualizarBo.Name = "ActualizarBo";
            this.ActualizarBo.Radius = 5;
            this.ActualizarBo.Size = new System.Drawing.Size(197, 54);
            this.ActualizarBo.Stroke = false;
            this.ActualizarBo.StrokeColor = System.Drawing.Color.Gray;
            this.ActualizarBo.TabIndex = 67;
            this.ActualizarBo.Text = "Actualizar";
            this.ActualizarBo.Transparency = false;
            this.ActualizarBo.Click += new System.EventHandler(this.Actualizar);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.label17.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.label17.Location = new System.Drawing.Point(1281, -137);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 32);
            this.label17.TabIndex = 70;
            this.label17.Text = "_";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 32);
            this.panel2.TabIndex = 72;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ferreto.Properties.Resources.error;
            this.pictureBox1.Location = new System.Drawing.Point(562, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Cerrar);
            // 
            // errorProviderMarca
            // 
            this.errorProviderMarca.ContainerControl = this;
            this.errorProviderMarca.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderMarca.Icon")));
            // 
            // errorProviderCategoria
            // 
            this.errorProviderCategoria.ContainerControl = this;
            this.errorProviderCategoria.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderCategoria.Icon")));
            // 
            // bunifuSlider1
            // 
            this.bunifuSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider1.BorderRadius = 0;
            this.bunifuSlider1.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.bunifuSlider1.Location = new System.Drawing.Point(-14, -15);
            this.bunifuSlider1.MaximumValue = 100;
            this.bunifuSlider1.Name = "bunifuSlider1";
            this.bunifuSlider1.Size = new System.Drawing.Size(415, 30);
            this.bunifuSlider1.TabIndex = 73;
            this.bunifuSlider1.Value = 0;
            // 
            // Slidermarca
            // 
            this.Slidermarca.BorderColor = System.Drawing.Color.LightGray;
            this.Slidermarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Slidermarca.IsOn = false;
            this.Slidermarca.Location = new System.Drawing.Point(98, 113);
            this.Slidermarca.Name = "Slidermarca";
            this.Slidermarca.Size = new System.Drawing.Size(40, 22);
            this.Slidermarca.TabIndex = 74;
            this.Slidermarca.Text = "slideButton1";
            this.Slidermarca.TextEnabled = true;
            this.Slidermarca.Click += new System.EventHandler(this.MarcoCheck);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Sliderol
            // 
            this.Sliderol.BorderColor = System.Drawing.Color.LightGray;
            this.Sliderol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sliderol.IsOn = false;
            this.Sliderol.Location = new System.Drawing.Point(381, 113);
            this.Sliderol.Name = "Sliderol";
            this.Sliderol.Size = new System.Drawing.Size(40, 22);
            this.Sliderol.TabIndex = 77;
            this.Sliderol.Text = "slideButton4";
            this.Sliderol.TextEnabled = true;
            this.Sliderol.Click += new System.EventHandler(this.Rol);
            // 
            // marcanueva
            // 
            this.marcanueva.BorderColor = System.Drawing.Color.LightGray;
            this.marcanueva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.marcanueva.IsOn = false;
            this.marcanueva.Location = new System.Drawing.Point(154, 193);
            this.marcanueva.Name = "marcanueva";
            this.marcanueva.Size = new System.Drawing.Size(40, 22);
            this.marcanueva.TabIndex = 78;
            this.marcanueva.Text = "slideButton2";
            this.marcanueva.TextEnabled = true;
            this.marcanueva.Click += new System.EventHandler(this.NewMarca);
            // 
            // nuevorol
            // 
            this.nuevorol.BorderColor = System.Drawing.Color.LightGray;
            this.nuevorol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nuevorol.IsOn = false;
            this.nuevorol.Location = new System.Drawing.Point(424, 193);
            this.nuevorol.Name = "nuevorol";
            this.nuevorol.Size = new System.Drawing.Size(40, 22);
            this.nuevorol.TabIndex = 79;
            this.nuevorol.Text = "slideButton3";
            this.nuevorol.TextEnabled = true;
            this.nuevorol.Click += new System.EventHandler(this.NewRol);
            // 
            // categorianueva
            // 
            this.categorianueva.BorderColor = System.Drawing.Color.LightGray;
            this.categorianueva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categorianueva.IsOn = false;
            this.categorianueva.Location = new System.Drawing.Point(166, 314);
            this.categorianueva.Name = "categorianueva";
            this.categorianueva.Size = new System.Drawing.Size(40, 22);
            this.categorianueva.TabIndex = 80;
            this.categorianueva.Text = "slideButton5";
            this.categorianueva.TextEnabled = true;
            this.categorianueva.Click += new System.EventHandler(this.NewCat);
            // 
            // nuevamedida
            // 
            this.nuevamedida.BorderColor = System.Drawing.Color.LightGray;
            this.nuevamedida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nuevamedida.IsOn = false;
            this.nuevamedida.Location = new System.Drawing.Point(461, 314);
            this.nuevamedida.Name = "nuevamedida";
            this.nuevamedida.Size = new System.Drawing.Size(40, 22);
            this.nuevamedida.TabIndex = 81;
            this.nuevamedida.Text = "slideButton6";
            this.nuevamedida.TextEnabled = true;
            this.nuevamedida.Click += new System.EventHandler(this.NewMedida);
            // 
            // errorProviderRol
            // 
            this.errorProviderRol.ContainerControl = this;
            this.errorProviderRol.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderRol.Icon")));
            // 
            // errorProviderMEDIDA
            // 
            this.errorProviderMEDIDA.ContainerControl = this;
            this.errorProviderMEDIDA.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderMEDIDA.Icon")));
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EditarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(600, 490);
            this.Controls.Add(this.nuevamedida);
            this.Controls.Add(this.categorianueva);
            this.Controls.Add(this.nuevorol);
            this.Controls.Add(this.marcanueva);
            this.Controls.Add(this.Sliderol);
            this.Controls.Add(this.Slidermarca);
            this.Controls.Add(this.bunifuSlider1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.ActualizarBo);
            this.Controls.Add(this.RolTxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.estadorolsl);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.RolCB);
            this.Controls.Add(this.CategoriaTxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.MedidaTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.estadomarcasl);
            this.Controls.Add(this.MarcaCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MarcaTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarItem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMEDIDA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private AltoControls.AltoTextBox MarcaTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox MarcaCB;
        private AltoControls.SlideButton estadomarcasl;
        private System.Windows.Forms.Label label8;
        private AltoControls.AltoTextBox MedidaTxt;
        private System.Windows.Forms.Label label11;
        private AltoControls.AltoTextBox CategoriaTxt;
        private System.Windows.Forms.ComboBox RolCB;
        private System.Windows.Forms.Label label13;
        private AltoControls.SlideButton estadorolsl;
        private System.Windows.Forms.Label label14;
        private AltoControls.AltoTextBox RolTxt;
        private AltoControls.AltoButton ActualizarBo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProviderMarca;
        private System.Windows.Forms.ErrorProvider errorProviderCategoria;
        private AltoControls.SlideButton Slidermarca;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider1;
        private AltoControls.SlideButton Sliderol;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private AltoControls.SlideButton nuevamedida;
        private AltoControls.SlideButton categorianueva;
        private AltoControls.SlideButton nuevorol;
        private AltoControls.SlideButton marcanueva;
        private System.Windows.Forms.ErrorProvider errorProviderRol;
        private System.Windows.Forms.ErrorProvider errorProviderMEDIDA;
        private System.Windows.Forms.Timer timer1;
    }
}