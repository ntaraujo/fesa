namespace Exercise3
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
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.btnCode = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.btnRg = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(88, 50);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 22);
            this.txtCode.TabIndex = 0;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(88, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(88, 106);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(100, 22);
            this.txtRg.TabIndex = 2;
            this.txtRg.TextChanged += new System.EventHandler(this.txtRg_TextChanged);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(88, 134);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 22);
            this.txtSalary.TabIndex = 3;
            this.txtSalary.TextChanged += new System.EventHandler(this.txtSalary_TextChanged);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(27, 53);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(54, 16);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Code:";
            this.lblCode.Click += new System.EventHandler(this.lblCode_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(27, 112);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(30, 16);
            this.lblRg.TabIndex = 6;
            this.lblRg.Text = "Rg:";
            this.lblRg.Click += new System.EventHandler(this.lblRg_Click);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(27, 140);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(53, 16);
            this.lblSalary.TabIndex = 7;
            this.lblSalary.Text = "Salary:";
            this.lblSalary.Click += new System.EventHandler(this.lblSalary_Click);
            // 
            // btnCode
            // 
            this.btnCode.Location = new System.Drawing.Point(211, 49);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(98, 23);
            this.btnCode.TabIndex = 8;
            this.btnCode.Text = "Go foward";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // btnName
            // 
            this.btnName.Enabled = false;
            this.btnName.Location = new System.Drawing.Point(211, 81);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(98, 23);
            this.btnName.TabIndex = 9;
            this.btnName.Text = "Go foward";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnRg
            // 
            this.btnRg.Enabled = false;
            this.btnRg.Location = new System.Drawing.Point(211, 109);
            this.btnRg.Name = "btnRg";
            this.btnRg.Size = new System.Drawing.Size(98, 23);
            this.btnRg.TabIndex = 10;
            this.btnRg.Text = "Go foward";
            this.btnRg.UseVisualStyleBackColor = true;
            this.btnRg.Click += new System.EventHandler(this.btnRg_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.Enabled = false;
            this.btnSalary.Location = new System.Drawing.Point(211, 137);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(98, 23);
            this.btnSalary.TabIndex = 11;
            this.btnSalary.Text = "Go foward";
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnShow
            // 
            this.btnShow.Enabled = false;
            this.btnShow.Location = new System.Drawing.Point(90, 182);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(98, 23);
            this.btnShow.TabIndex = 12;
            this.btnShow.Text = "Add";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(87, 227);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(0, 16);
            this.lblShow.TabIndex = 13;
            this.lblShow.Click += new System.EventHandler(this.lblShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.btnRg);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnRg;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblShow;
    }
}

