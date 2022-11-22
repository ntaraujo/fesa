
namespace Joguinho
{
    partial class FrmClass
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
            this.boxTop10 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // boxTop10
            // 
            this.boxTop10.FormattingEnabled = true;
            this.boxTop10.Location = new System.Drawing.Point(313, 133);
            this.boxTop10.Name = "boxTop10";
            this.boxTop10.Size = new System.Drawing.Size(120, 160);
            this.boxTop10.TabIndex = 1;
            // 
            // FrmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.boxTop10);
            this.Name = "FrmClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "top 10 não daltônicos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox boxTop10;
    }
}