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
            this.label2 = new System.Windows.Forms.Label();
            this.UserLab = new System.Windows.Forms.Label();
            this.FechaLab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SerieCB = new System.Windows.Forms.ComboBox();
            this.CajeroCB = new System.Windows.Forms.ComboBox();
            this.FechaTP = new System.Windows.Forms.DateTimePicker();
            this.BuscarBo = new AltoControls.AltoButton();
            this.ReBo = new AltoControls.AltoButton();
            this.FacturaLV = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(26, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bienvenido de nuevo:";
            // 
            // UserLab
            // 
            this.UserLab.AutoSize = true;
            this.UserLab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.UserLab.Location = new System.Drawing.Point(210, 48);
            this.UserLab.Name = "UserLab";
            this.UserLab.Size = new System.Drawing.Size(40, 19);
            this.UserLab.TabIndex = 4;
            this.UserLab.Text = "User";
            // 
            // FechaLab
            // 
            this.FechaLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaLab.AutoSize = true;
            this.FechaLab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.FechaLab.Location = new System.Drawing.Point(404, 48);
            this.FechaLab.Name = "FechaLab";
            this.FechaLab.Size = new System.Drawing.Size(58, 19);
            this.FechaLab.TabIndex = 5;
            this.FechaLab.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(34, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Serie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(141, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(404, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cajero:";
            // 
            // SerieCB
            // 
            this.SerieCB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerieCB.FormattingEnabled = true;
            this.SerieCB.Location = new System.Drawing.Point(30, 141);
            this.SerieCB.Name = "SerieCB";
            this.SerieCB.Size = new System.Drawing.Size(54, 25);
            this.SerieCB.TabIndex = 9;
            // 
            // CajeroCB
            // 
            this.CajeroCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CajeroCB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajeroCB.FormattingEnabled = true;
            this.CajeroCB.Location = new System.Drawing.Point(398, 139);
            this.CajeroCB.Name = "CajeroCB";
            this.CajeroCB.Size = new System.Drawing.Size(188, 25);
            this.CajeroCB.TabIndex = 10;
            // 
            // FechaTP
            // 
            this.FechaTP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaTP.Location = new System.Drawing.Point(139, 141);
            this.FechaTP.Name = "FechaTP";
            this.FechaTP.Size = new System.Drawing.Size(200, 23);
            this.FechaTP.TabIndex = 11;
            // 
            // BuscarBo
            // 
            this.BuscarBo.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.BuscarBo.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.BuscarBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarBo.BackColor = System.Drawing.Color.Transparent;
            this.BuscarBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuscarBo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BuscarBo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarBo.ForeColor = System.Drawing.Color.White;
            this.BuscarBo.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.BuscarBo.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.BuscarBo.Location = new System.Drawing.Point(657, 134);
            this.BuscarBo.Name = "BuscarBo";
            this.BuscarBo.Radius = 5;
            this.BuscarBo.Size = new System.Drawing.Size(102, 30);
            this.BuscarBo.Stroke = false;
            this.BuscarBo.StrokeColor = System.Drawing.Color.Gray;
            this.BuscarBo.TabIndex = 12;
            this.BuscarBo.Text = "Buscar";
            this.BuscarBo.Transparency = false;
            // 
            // ReBo
            // 
            this.ReBo.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.ReBo.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.ReBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReBo.BackColor = System.Drawing.Color.Transparent;
            this.ReBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReBo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ReBo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReBo.ForeColor = System.Drawing.Color.White;
            this.ReBo.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.ReBo.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(84)))));
            this.ReBo.Location = new System.Drawing.Point(657, 430);
            this.ReBo.Name = "ReBo";
            this.ReBo.Radius = 5;
            this.ReBo.Size = new System.Drawing.Size(102, 42);
            this.ReBo.Stroke = false;
            this.ReBo.StrokeColor = System.Drawing.Color.Gray;
            this.ReBo.TabIndex = 13;
            this.ReBo.Text = "Reimprimir";
            this.ReBo.Transparency = false;
            // 
            // FacturaLV
            // 
            this.FacturaLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FacturaLV.HideSelection = false;
            this.FacturaLV.Location = new System.Drawing.Point(30, 190);
            this.FacturaLV.Name = "FacturaLV";
            this.FacturaLV.Size = new System.Drawing.Size(729, 218);
            this.FacturaLV.TabIndex = 14;
            this.FacturaLV.UseCompatibleStateImageBehavior = false;
            // 
            // ReimprimirBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 494);
            this.Controls.Add(this.FacturaLV);
            this.Controls.Add(this.ReBo);
            this.Controls.Add(this.BuscarBo);
            this.Controls.Add(this.FechaTP);
            this.Controls.Add(this.CajeroCB);
            this.Controls.Add(this.SerieCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaLab);
            this.Controls.Add(this.UserLab);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReimprimirBo";
            this.Text = "Facturas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UserLab;
        private System.Windows.Forms.Label FechaLab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SerieCB;
        private System.Windows.Forms.ComboBox CajeroCB;
        private System.Windows.Forms.DateTimePicker FechaTP;
        private AltoControls.AltoButton BuscarBo;
        private AltoControls.AltoButton ReBo;
        private System.Windows.Forms.ListView FacturaLV;
    }
}