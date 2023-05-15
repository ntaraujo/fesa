namespace Trabalho_N2
{
    partial class Form1
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
            this.Aviao = new System.Windows.Forms.Button();
            this.AviaoDeGuerra = new System.Windows.Forms.Button();
            this.Caminhao = new System.Windows.Forms.Button();
            this.Carro = new System.Windows.Forms.Button();
            this.Moto = new System.Windows.Forms.Button();
            this.Navio = new System.Windows.Forms.Button();
            this.NavioDeGuerra = new System.Windows.Forms.Button();
            this.Onibus = new System.Windows.Forms.Button();
            this.Trem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Aviao
            // 
            this.Aviao.BackColor = System.Drawing.SystemColors.Control;
            this.Aviao.Location = new System.Drawing.Point(175, 109);
            this.Aviao.Name = "Aviao";
            this.Aviao.Size = new System.Drawing.Size(100, 50);
            this.Aviao.TabIndex = 0;
            this.Aviao.Text = "Avião";
            this.Aviao.UseVisualStyleBackColor = false;
            this.Aviao.Click += new System.EventHandler(this.Aviao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NavioDeGuerra);
            this.Controls.Add(this.Onibus);
            this.Controls.Add(this.Trem);
            this.Controls.Add(this.Carro);
            this.Controls.Add(this.Moto);
            this.Controls.Add(this.Navio);
            this.Controls.Add(this.Caminhao);
            this.Controls.Add(this.AviaoDeGuerra);
            this.Controls.Add(this.Aviao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Aviao;
        private System.Windows.Forms.Button AviaoDeGuerra;
        private System.Windows.Forms.Button Caminhao;
        private System.Windows.Forms.Button Carro;
        private System.Windows.Forms.Button Moto;
        private System.Windows.Forms.Button Navio;
        private System.Windows.Forms.Button NavioDeGuerra;
        private System.Windows.Forms.Button Onibus;
        private System.Windows.Forms.Button Trem;
    }
}

