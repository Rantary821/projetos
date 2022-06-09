namespace Menu
{
    partial class configuracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(configuracao));
            this.BtnPasta1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnPasta2 = new System.Windows.Forms.Button();
            this.CheckConf1 = new System.Windows.Forms.CheckBox();
            this.CheckConf2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnManterSeq = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckNovaSeq = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnNovaSeq = new System.Windows.Forms.Button();
            this.CheckMantSeq = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnPasta1
            // 
            this.BtnPasta1.Image = ((System.Drawing.Image)(resources.GetObject("BtnPasta1.Image")));
            this.BtnPasta1.Location = new System.Drawing.Point(6, 19);
            this.BtnPasta1.Name = "BtnPasta1";
            this.BtnPasta1.Size = new System.Drawing.Size(41, 34);
            this.BtnPasta1.TabIndex = 0;
            this.BtnPasta1.UseVisualStyleBackColor = true;
            this.BtnPasta1.Click += new System.EventHandler(this.BtnPasta1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usar numero da pasta em sequencia junto com o ano";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usar apenas o numero da pasta em sequencia";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnPasta2
            // 
            this.BtnPasta2.Image = ((System.Drawing.Image)(resources.GetObject("BtnPasta2.Image")));
            this.BtnPasta2.Location = new System.Drawing.Point(6, 59);
            this.BtnPasta2.Name = "BtnPasta2";
            this.BtnPasta2.Size = new System.Drawing.Size(41, 34);
            this.BtnPasta2.TabIndex = 0;
            this.BtnPasta2.UseVisualStyleBackColor = true;
            this.BtnPasta2.Click += new System.EventHandler(this.BtnPasta2_Click);
            // 
            // CheckConf1
            // 
            this.CheckConf1.AutoSize = true;
            this.CheckConf1.Enabled = false;
            this.CheckConf1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckConf1.Location = new System.Drawing.Point(53, 29);
            this.CheckConf1.Name = "CheckConf1";
            this.CheckConf1.Size = new System.Drawing.Size(15, 14);
            this.CheckConf1.TabIndex = 2;
            this.CheckConf1.UseVisualStyleBackColor = true;
            this.CheckConf1.CheckedChanged += new System.EventHandler(this.CheckConf1_CheckedChanged);
            // 
            // CheckConf2
            // 
            this.CheckConf2.AutoSize = true;
            this.CheckConf2.Enabled = false;
            this.CheckConf2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckConf2.Location = new System.Drawing.Point(53, 70);
            this.CheckConf2.Name = "CheckConf2";
            this.CheckConf2.Size = new System.Drawing.Size(15, 14);
            this.CheckConf2.TabIndex = 2;
            this.CheckConf2.UseVisualStyleBackColor = true;
            this.CheckConf2.CheckedChanged += new System.EventHandler(this.CheckConf2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnPasta1);
            this.groupBox1.Controls.Add(this.CheckConf2);
            this.groupBox1.Controls.Add(this.BtnPasta2);
            this.groupBox1.Controls.Add(this.CheckConf1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 106);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "";
            this.groupBox1.Text = "Sobre o Numero da Pasta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnManterSeq);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.CheckNovaSeq);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.BtnNovaSeq);
            this.groupBox2.Controls.Add(this.CheckMantSeq);
            this.groupBox2.Location = new System.Drawing.Point(6, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 104);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sequencia da Pasta";
            // 
            // BtnManterSeq
            // 
            this.BtnManterSeq.Image = ((System.Drawing.Image)(resources.GetObject("BtnManterSeq.Image")));
            this.BtnManterSeq.Location = new System.Drawing.Point(7, 18);
            this.BtnManterSeq.Name = "BtnManterSeq";
            this.BtnManterSeq.Size = new System.Drawing.Size(41, 34);
            this.BtnManterSeq.TabIndex = 3;
            this.BtnManterSeq.UseVisualStyleBackColor = true;
            this.BtnManterSeq.Click += new System.EventHandler(this.BtnManterSeq_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Manter a sequencia das pastas ao passar dos anos";
            // 
            // CheckNovaSeq
            // 
            this.CheckNovaSeq.AutoSize = true;
            this.CheckNovaSeq.Enabled = false;
            this.CheckNovaSeq.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckNovaSeq.Location = new System.Drawing.Point(54, 69);
            this.CheckNovaSeq.Name = "CheckNovaSeq";
            this.CheckNovaSeq.Size = new System.Drawing.Size(15, 14);
            this.CheckNovaSeq.TabIndex = 7;
            this.CheckNovaSeq.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reiniciar sequencia das pastas no troca de ano";
            // 
            // BtnNovaSeq
            // 
            this.BtnNovaSeq.Image = ((System.Drawing.Image)(resources.GetObject("BtnNovaSeq.Image")));
            this.BtnNovaSeq.Location = new System.Drawing.Point(7, 58);
            this.BtnNovaSeq.Name = "BtnNovaSeq";
            this.BtnNovaSeq.Size = new System.Drawing.Size(41, 34);
            this.BtnNovaSeq.TabIndex = 4;
            this.BtnNovaSeq.UseVisualStyleBackColor = true;
            this.BtnNovaSeq.Click += new System.EventHandler(this.BtnNovaSeq_Click);
            // 
            // CheckMantSeq
            // 
            this.CheckMantSeq.AutoSize = true;
            this.CheckMantSeq.Enabled = false;
            this.CheckMantSeq.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckMantSeq.Location = new System.Drawing.Point(54, 28);
            this.CheckMantSeq.Name = "CheckMantSeq";
            this.CheckMantSeq.Size = new System.Drawing.Size(15, 14);
            this.CheckMantSeq.TabIndex = 8;
            this.CheckMantSeq.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(6, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 26);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(6, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 26);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(6, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 26);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(6, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 26);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(426, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(37, 106);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Location = new System.Drawing.Point(426, 126);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(37, 104);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // configuracao
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(469, 235);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "configuracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "configuracao";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.configuracao_FormClosing);
            this.Load += new System.EventHandler(this.configuracao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPasta1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnPasta2;
        private System.Windows.Forms.CheckBox CheckConf1;
        private System.Windows.Forms.CheckBox CheckConf2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnManterSeq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CheckNovaSeq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnNovaSeq;
        private System.Windows.Forms.CheckBox CheckMantSeq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}