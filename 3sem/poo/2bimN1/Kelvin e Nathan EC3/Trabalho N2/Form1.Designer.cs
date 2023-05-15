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
            // AviaoDeGuerra
            // 
            this.AviaoDeGuerra.BackColor = System.Drawing.SystemColors.Control;
            this.AviaoDeGuerra.Location = new System.Drawing.Point(281, 109);
            this.AviaoDeGuerra.Name = "AviaoDeGuerra";
            this.AviaoDeGuerra.Size = new System.Drawing.Size(100, 50);
            this.AviaoDeGuerra.TabIndex = 1;
            this.AviaoDeGuerra.Text = "Caça";
            this.AviaoDeGuerra.UseVisualStyleBackColor = false;
            // 
            // Caminhao
            // 
            this.Caminhao.BackColor = System.Drawing.SystemColors.Control;
            this.Caminhao.Location = new System.Drawing.Point(387, 109);
            this.Caminhao.Name = "Caminhao";
            this.Caminhao.Size = new System.Drawing.Size(100, 50);
            this.Caminhao.TabIndex = 2;
            this.Caminhao.Text = "Caminhão";
            this.Caminhao.UseVisualStyleBackColor = false;
            // 
            // Carro
            // 
            this.Carro.BackColor = System.Drawing.SystemColors.Control;
            this.Carro.Location = new System.Drawing.Point(175, 165);
            this.Carro.Name = "Carro";
            this.Carro.Size = new System.Drawing.Size(100, 50);
            this.Carro.TabIndex = 5;
            this.Carro.Text = "Carro";
            this.Carro.UseVisualStyleBackColor = false;
            // 
            // Moto
            // 
            this.Moto.BackColor = System.Drawing.SystemColors.Control;
            this.Moto.Location = new System.Drawing.Point(281, 165);
            this.Moto.Name = "Moto";
            this.Moto.Size = new System.Drawing.Size(100, 50);
            this.Moto.TabIndex = 4;
            this.Moto.Text = "Moto";
            this.Moto.UseVisualStyleBackColor = false;
            // 
            // Navio
            // 
            this.Navio.BackColor = System.Drawing.SystemColors.Control;
            this.Navio.Location = new System.Drawing.Point(387, 165);
            this.Navio.Name = "Navio";
            this.Navio.Size = new System.Drawing.Size(100, 50);
            this.Navio.TabIndex = 3;
            this.Navio.Text = "Navio";
            this.Navio.UseVisualStyleBackColor = false;
            // 
            // NavioDeGuerra
            // 
            this.NavioDeGuerra.BackColor = System.Drawing.SystemColors.Control;
            this.NavioDeGuerra.Location = new System.Drawing.Point(175, 221);
            this.NavioDeGuerra.Name = "NavioDeGuerra";
            this.NavioDeGuerra.Size = new System.Drawing.Size(100, 50);
            this.NavioDeGuerra.TabIndex = 8;
            this.NavioDeGuerra.Text = "Cruzador";
            this.NavioDeGuerra.UseVisualStyleBackColor = false;
            // 
            // Onibus
            // 
            this.Onibus.BackColor = System.Drawing.SystemColors.Control;
            this.Onibus.Location = new System.Drawing.Point(281, 221);
            this.Onibus.Name = "Onibus";
            this.Onibus.Size = new System.Drawing.Size(100, 50);
            this.Onibus.TabIndex = 7;
            this.Onibus.Text = "Ônibus";
            this.Onibus.UseVisualStyleBackColor = false;
            // 
            // Trem
            // 
            this.Trem.BackColor = System.Drawing.SystemColors.Control;
            this.Trem.Location = new System.Drawing.Point(387, 221);
            this.Trem.Name = "Trem";
            this.Trem.Size = new System.Drawing.Size(100, 50);
            this.Trem.TabIndex = 6;
            this.Trem.Text = "Trem";
            this.Trem.UseVisualStyleBackColor = false;
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

