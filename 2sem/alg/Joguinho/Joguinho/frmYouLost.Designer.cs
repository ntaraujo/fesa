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
            this.lblYouLostLoser.Location = new System.Drawing.Point(75, 170);
            this.lblYouLostLoser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYouLostLoser.Name = "lblYouLostLoser";
            this.lblYouLostLoser.Size = new System.Drawing.Size(243, 16);
            this.lblYouLostLoser.TabIndex = 0;
            this.lblYouLostLoser.Text = "You entered the wrong color, so you lost";
            this.lblYouLostLoser.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmYouLost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 366);
            this.Controls.Add(this.lblYouLostLoser);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmYouLost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmYouLost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYouLostLoser;
    }
}