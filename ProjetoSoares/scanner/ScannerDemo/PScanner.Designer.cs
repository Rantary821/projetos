namespace ScannerDemo
{
    partial class PScanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PScanner));
            this.lblConfirm = new System.Windows.Forms.Label();
            this.BtnNao = new System.Windows.Forms.Button();
            this.BtnSim = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnDigitaliza = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescri = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Scanners = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RadioBaixa = new System.Windows.Forms.RadioButton();
            this.RadioMedia = new System.Windows.Forms.RadioButton();
            this.RadioAlta = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.Location = new System.Drawing.Point(36, 311);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(174, 24);
            this.lblConfirm.TabIndex = 11;
            this.lblConfirm.Text = "Confirmar Imagem?";
            this.lblConfirm.Visible = false;
            // 
            // BtnNao
            // 
            this.BtnNao.BackColor = System.Drawing.Color.Silver;
            this.BtnNao.FlatAppearance.BorderSize = 0;
            this.BtnNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNao.Location = new System.Drawing.Point(122, 338);
            this.BtnNao.Name = "BtnNao";
            this.BtnNao.Size = new System.Drawing.Size(75, 43);
            this.BtnNao.TabIndex = 10;
            this.BtnNao.Text = "Não";
            this.BtnNao.UseVisualStyleBackColor = false;
            this.BtnNao.Visible = false;
            this.BtnNao.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnSim
            // 
            this.BtnSim.BackColor = System.Drawing.Color.Silver;
            this.BtnSim.FlatAppearance.BorderSize = 0;
            this.BtnSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSim.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSim.Location = new System.Drawing.Point(40, 338);
            this.BtnSim.Name = "BtnSim";
            this.BtnSim.Size = new System.Drawing.Size(76, 43);
            this.BtnSim.TabIndex = 10;
            this.BtnSim.Text = "Sim";
            this.BtnSim.UseVisualStyleBackColor = false;
            this.BtnSim.Visible = false;
            this.BtnSim.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(14, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Atualizar lista";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnDigitaliza
            // 
            this.BtnDigitaliza.BackColor = System.Drawing.Color.Silver;
            this.BtnDigitaliza.Enabled = false;
            this.BtnDigitaliza.FlatAppearance.BorderSize = 0;
            this.BtnDigitaliza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDigitaliza.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDigitaliza.Location = new System.Drawing.Point(13, 231);
            this.BtnDigitaliza.Name = "BtnDigitaliza";
            this.BtnDigitaliza.Size = new System.Drawing.Size(212, 44);
            this.BtnDigitaliza.TabIndex = 0;
            this.BtnDigitaliza.Text = "Digitalizar";
            this.BtnDigitaliza.UseVisualStyleBackColor = false;
            this.BtnDigitaliza.Click += new System.EventHandler(this.BtnDigitaliza_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Scanners";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // txtDescri
            // 
            this.txtDescri.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescri.Location = new System.Drawing.Point(10, 512);
            this.txtDescri.Name = "txtDescri";
            this.txtDescri.Size = new System.Drawing.Size(215, 25);
            this.txtDescri.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(10, 450);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(215, 25);
            this.txtNome.TabIndex = 4;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // Scanners
            // 
            this.Scanners.BackColor = System.Drawing.Color.DarkGray;
            this.Scanners.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scanners.FormattingEnabled = true;
            this.Scanners.ItemHeight = 19;
            this.Scanners.Location = new System.Drawing.Point(13, 33);
            this.Scanners.Name = "Scanners";
            this.Scanners.Size = new System.Drawing.Size(215, 156);
            this.Scanners.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 47);
            this.panel1.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(288, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 34);
            this.label9.TabIndex = 58;
            this.label9.Text = "Scanner";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(719, 8);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.TabIndex = 54;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.RadioBaixa);
            this.panel2.Controls.Add(this.RadioMedia);
            this.panel2.Controls.Add(this.RadioAlta);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblConfirm);
            this.panel2.Controls.Add(this.Scanners);
            this.panel2.Controls.Add(this.BtnNao);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.BtnSim);
            this.panel2.Controls.Add(this.txtDescri);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BtnDigitaliza);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 640);
            this.panel2.TabIndex = 7;
            // 
            // RadioBaixa
            // 
            this.RadioBaixa.AutoSize = true;
            this.RadioBaixa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBaixa.Location = new System.Drawing.Point(10, 611);
            this.RadioBaixa.Name = "RadioBaixa";
            this.RadioBaixa.Size = new System.Drawing.Size(133, 20);
            this.RadioBaixa.TabIndex = 13;
            this.RadioBaixa.TabStop = true;
            this.RadioBaixa.Text = "Qualidade Baixa";
            this.RadioBaixa.UseVisualStyleBackColor = true;
            this.RadioBaixa.CheckedChanged += new System.EventHandler(this.RadioBaixa_CheckedChanged);
            // 
            // RadioMedia
            // 
            this.RadioMedia.AutoSize = true;
            this.RadioMedia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioMedia.Location = new System.Drawing.Point(10, 585);
            this.RadioMedia.Name = "RadioMedia";
            this.RadioMedia.Size = new System.Drawing.Size(136, 20);
            this.RadioMedia.TabIndex = 12;
            this.RadioMedia.TabStop = true;
            this.RadioMedia.Text = "Qualidade media";
            this.RadioMedia.UseVisualStyleBackColor = true;
            this.RadioMedia.CheckedChanged += new System.EventHandler(this.RadioMedia_CheckedChanged);
            // 
            // RadioAlta
            // 
            this.RadioAlta.AutoSize = true;
            this.RadioAlta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioAlta.Location = new System.Drawing.Point(10, 559);
            this.RadioAlta.Name = "RadioAlta";
            this.RadioAlta.Size = new System.Drawing.Size(120, 20);
            this.RadioAlta.TabIndex = 12;
            this.RadioAlta.TabStop = true;
            this.RadioAlta.Text = "Qualidade alta";
            this.RadioAlta.UseVisualStyleBackColor = true;
            this.RadioAlta.CheckedChanged += new System.EventHandler(this.RadioAlta_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(245, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(516, 640);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 638);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // PScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(761, 687);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(400, 60);
            this.Name = "PScanner";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Button BtnNao;
        private System.Windows.Forms.Button BtnSim;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnDigitaliza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescri;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ListBox Scanners;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton RadioMedia;
        private System.Windows.Forms.RadioButton RadioAlta;
        private System.Windows.Forms.RadioButton RadioBaixa;
    }
}

