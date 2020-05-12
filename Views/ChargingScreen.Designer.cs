namespace Ferreto.Views
{
    partial class ChargingScreen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginPB = new AltoControls.CircularPB();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ferreto.Properties.Resources.Ferreto_de_lo_facilita_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(119, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginPB
            // 
            this.LoginPB.AllowText = true;
            this.LoginPB.AutomaticFontCalculation = true;
            this.LoginPB.BackColor = System.Drawing.Color.Transparent;
            this.LoginPB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.LoginPB.Location = new System.Drawing.Point(315, 240);
            this.LoginPB.MaxValue = 100;
            this.LoginPB.MinimumSize = new System.Drawing.Size(60, 60);
            this.LoginPB.MinValue = 0;
            this.LoginPB.Name = "LoginPB";
            this.LoginPB.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.LoginPB.Size = new System.Drawing.Size(118, 118);
            this.LoginPB.Stroke = 10;
            this.LoginPB.TabIndex = 1;
            this.LoginPB.Text = "Iniciando...";
            this.LoginPB.Transparency = true;
            this.LoginPB.Value = 0;
            // 
            // ChargingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 380);
            this.Controls.Add(this.LoginPB);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChargingScreen";
            this.Text = "ChargingScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private AltoControls.CircularPB LoginPB;
    }
}