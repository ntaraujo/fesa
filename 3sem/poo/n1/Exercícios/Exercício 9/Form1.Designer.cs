namespace Exercício_9
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
            this.lblExibir = new System.Windows.Forms.Label();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnSalário = new System.Windows.Forms.Button();
            this.btnRG = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.btnCódigo = new System.Windows.Forms.Button();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblExibir
            // 
            this.lblExibir.AutoSize = true;
            this.lblExibir.Location = new System.Drawing.Point(103, 225);
            this.lblExibir.Name = "lblExibir";
            this.lblExibir.Size = new System.Drawing.Size(0, 16);
            this.lblExibir.TabIndex = 27;
            // 
            // btnExibir
            // 
            this.btnExibir.Enabled = false;
            this.btnExibir.Location = new System.Drawing.Point(106, 180);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(98, 23);
            this.btnExibir.TabIndex = 26;
            this.btnExibir.Text = "Adicionar";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnSalário
            // 
            this.btnSalário.Enabled = false;
            this.btnSalário.Location = new System.Drawing.Point(227, 135);
            this.btnSalário.Name = "btnSalário";
            this.btnSalário.Size = new System.Drawing.Size(98, 23);
            this.btnSalário.TabIndex = 25;
            this.btnSalário.Text = "Avançar";
            this.btnSalário.UseVisualStyleBackColor = true;
            this.btnSalário.Click += new System.EventHandler(this.btnSalário_Click);
            // 
            // btnRG
            // 
            this.btnRG.Enabled = false;
            this.btnRG.Location = new System.Drawing.Point(227, 107);
            this.btnRG.Name = "btnRG";
            this.btnRG.Size = new System.Drawing.Size(98, 23);
            this.btnRG.TabIndex = 24;
            this.btnRG.Text = "Avançar";
            this.btnRG.UseVisualStyleBackColor = true;
            this.btnRG.Click += new System.EventHandler(this.btnRG_Click);
            // 
            // btnName
            // 
            this.btnName.Enabled = false;
            this.btnName.Location = new System.Drawing.Point(227, 79);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(98, 23);
            this.btnName.TabIndex = 23;
            this.btnName.Text = "Avançar";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnCódigo
            // 
            this.btnCódigo.Location = new System.Drawing.Point(227, 47);
            this.btnCódigo.Name = "btnCódigo";
            this.btnCódigo.Size = new System.Drawing.Size(98, 23);
            this.btnCódigo.TabIndex = 22;
            this.btnCódigo.Text = "Avançar";
            this.btnCódigo.UseVisualStyleBackColor = true;
            this.btnCódigo.Click += new System.EventHandler(this.btnCódigo_Click);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(43, 138);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(53, 16);
            this.lblSalario.TabIndex = 21;
            this.lblSalario.Text = "Salário:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(43, 110);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(30, 16);
            this.lblRG.TabIndex = 20;
            this.lblRG.Text = "RG:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(43, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Name:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(43, 51);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 18;
            this.lblCodigo.Text = "Código:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(104, 132);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 22);
            this.txtSalario.TabIndex = 17;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(104, 104);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 22);
            this.txtRG.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 15;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(104, 48);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblExibir);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnSalário);
            this.Controls.Add(this.btnRG);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.btnCódigo);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExibir;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnSalário;
        private System.Windows.Forms.Button btnRG;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnCódigo;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}

