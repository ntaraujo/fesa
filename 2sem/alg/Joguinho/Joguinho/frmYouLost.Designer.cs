namespace Joguinho
{
    partial class frmYouLost
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
            this.lblYouLostLoser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblYouLostLoser
            // 
            this.lblYouLostLoser.AutoSize = true;
            this.lblYouLostLoser.Location = new System.Drawing.Point(323, 222);
            this.lblYouLostLoser.Name = "lblYouLostLoser";
            this.lblYouLostLoser.Size = new System.Drawing.Size(116, 13);
            this.lblYouLostLoser.TabIndex = 0;
            this.lblYouLostLoser.Text = "cor errada huashausha";
            this.lblYouLostLoser.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmYouLost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblYouLostLoser);
            this.Name = "frmYouLost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bobão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYouLostLoser;
    }
}