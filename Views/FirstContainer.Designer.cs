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
            this.panelCont = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelCont
            // 
            this.panelCont.Location = new System.Drawing.Point(-1, -1);
            this.panelCont.Name = "panelCont";
            this.panelCont.Size = new System.Drawing.Size(740, 380);
            this.panelCont.TabIndex = 0;
            // 
            // FirstContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 379);
            this.Controls.Add(this.panelCont);
            this.Name = "FirstContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstContainer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCont;
    }
}