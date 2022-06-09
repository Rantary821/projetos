namespace ValidaCPF
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
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.TxtDigito1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnConver = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.Label();
            this.TxtDigito2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtValidado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtCpf
            // 
            this.TxtCpf.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCpf.Location = new System.Drawing.Point(20, 51);
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(321, 38);
            this.TxtCpf.TabIndex = 0;
            // 
            // TxtDigito1
            // 
            this.TxtDigito1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDigito1.Location = new System.Drawing.Point(20, 243);
            this.TxtDigito1.Name = "TxtDigito1";
            this.TxtDigito1.Size = new System.Drawing.Size(82, 38);
            this.TxtDigito1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digito 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cpf";
            // 
            // BtnConver
            // 
            this.BtnConver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnConver.FlatAppearance.BorderSize = 0;
            this.BtnConver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConver.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConver.Location = new System.Drawing.Point(228, 231);
            this.BtnConver.Name = "BtnConver";
            this.BtnConver.Size = new System.Drawing.Size(113, 50);
            this.BtnConver.TabIndex = 2;
            this.BtnConver.Text = "Validar";
            this.BtnConver.UseVisualStyleBackColor = false;
            this.BtnConver.Click += new System.EventHandler(this.BtnConver_Click);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(120, 209);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(88, 31);
            this.txt.TabIndex = 4;
            this.txt.Text = "Digito 2";
            // 
            // TxtDigito2
            // 
            this.TxtDigito2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDigito2.Location = new System.Drawing.Point(126, 243);
            this.TxtDigito2.Name = "TxtDigito2";
            this.TxtDigito2.Size = new System.Drawing.Size(82, 38);
            this.TxtDigito2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cpf Validado";
            // 
            // TxtValidado
            // 
            this.TxtValidado.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValidado.Location = new System.Drawing.Point(20, 137);
            this.TxtValidado.Name = "TxtValidado";
            this.TxtValidado.Size = new System.Drawing.Size(321, 38);
            this.TxtValidado.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(317, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.TxtCpf);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtDigito1);
            this.panel1.Controls.Add(this.TxtValidado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt);
            this.panel1.Controls.Add(this.BtnConver);
            this.panel1.Controls.Add(this.TxtDigito2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 303);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 303);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCpf;
        private System.Windows.Forms.TextBox TxtDigito1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnConver;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.TextBox TxtDigito2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtValidado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

