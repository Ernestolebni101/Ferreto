namespace Ferreto.Views
{
    partial class FirstContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstContainer));
            this.panelCont = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pctOcultar = new System.Windows.Forms.PictureBox();
            this.InicioBo = new AltoControls.AltoButton();
            this.RegistroBo = new AltoControls.AltoButton();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctOcultar)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCont
            // 
            this.panelCont.BackColor = System.Drawing.Color.White;
            this.panelCont.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelCont.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCont.Location = new System.Drawing.Point(0, 57);
            this.panelCont.Name = "panelCont";
            this.panelCont.Size = new System.Drawing.Size(740, 341);
            this.panelCont.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pctOcultar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 31);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ferreto.Properties.Resources.padlock_78356;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mover_d);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mover_f);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Ferreto.Properties.Resources.error;
            this.pictureBox3.Location = new System.Drawing.Point(712, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.Cerrar);
            // 
            // pctOcultar
            // 
            this.pctOcultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctOcultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctOcultar.Image = global::Ferreto.Properties.Resources.minimize__2_;
            this.pctOcultar.Location = new System.Drawing.Point(681, 3);
            this.pctOcultar.Name = "pctOcultar";
            this.pctOcultar.Size = new System.Drawing.Size(25, 25);
            this.pctOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctOcultar.TabIndex = 3;
            this.pctOcultar.TabStop = false;
            this.pctOcultar.Click += new System.EventHandler(this.Minimizar);
            // 
            // InicioBo
            // 
            this.InicioBo.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.InicioBo.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.InicioBo.BackColor = System.Drawing.Color.Transparent;
            this.InicioBo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.InicioBo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InicioBo.ForeColor = System.Drawing.Color.White;
            this.InicioBo.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.InicioBo.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.InicioBo.Location = new System.Drawing.Point(28, 3);
            this.InicioBo.Name = "InicioBo";
            this.InicioBo.Radius = 3;
            this.InicioBo.Size = new System.Drawing.Size(145, 19);
            this.InicioBo.Stroke = false;
            this.InicioBo.StrokeColor = System.Drawing.Color.Gray;
            this.InicioBo.TabIndex = 2;
            this.InicioBo.Text = "Inicia Sesión";
            this.InicioBo.Transparency = false;
            this.InicioBo.Click += new System.EventHandler(this.InicioBo_Click);
            // 
            // RegistroBo
            // 
            this.RegistroBo.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.RegistroBo.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.RegistroBo.BackColor = System.Drawing.Color.Transparent;
            this.RegistroBo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.RegistroBo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistroBo.ForeColor = System.Drawing.Color.White;
            this.RegistroBo.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.RegistroBo.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.RegistroBo.Location = new System.Drawing.Point(198, 3);
            this.RegistroBo.Name = "RegistroBo";
            this.RegistroBo.Radius = 5;
            this.RegistroBo.Size = new System.Drawing.Size(145, 19);
            this.RegistroBo.Stroke = false;
            this.RegistroBo.StrokeColor = System.Drawing.Color.Gray;
            this.RegistroBo.TabIndex = 3;
            this.RegistroBo.Text = "Regístrate";
            this.RegistroBo.Transparency = false;
            this.RegistroBo.Click += new System.EventHandler(this.RegistroBo_Click);
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.panelBotones.Controls.Add(this.RegistroBo);
            this.panelBotones.Controls.Add(this.InicioBo);
            this.panelBotones.Location = new System.Drawing.Point(0, 29);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(377, 28);
            this.panelBotones.TabIndex = 0;
            // 
            // FirstContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 398);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCont);
            this.Controls.Add(this.panelBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstContainer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctOcultar)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCont;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pctOcultar;
        private AltoControls.AltoButton InicioBo;
        private AltoControls.AltoButton RegistroBo;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}