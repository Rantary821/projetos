namespace ArquivoEtec
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Scanners = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RadioBaixa = new System.Windows.Forms.RadioButton();
            this.RadioMedia = new System.Windows.Forms.RadioButton();
            this.RadioAlta = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.BtnNao.BackColor = System.Drawing.Color.DarkGray;
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
            this.BtnSim.BackColor = System.Drawing.Color.DarkGray;
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
            this.BtnDigitaliza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
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
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BtnDigitaliza);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 588);
            this.panel2.TabIndex = 7;
            // 
            // RadioBaixa
            // 
            this.RadioBaixa.AutoSize = true;
            this.RadioBaixa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBaixa.Location = new System.Drawing.Point(17, 557);
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
            this.RadioMedia.Location = new System.Drawing.Point(17, 531);
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
            this.RadioAlta.Location = new System.Drawing.Point(17, 505);
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
            this.panel3.Location = new System.Drawing.Point(245, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 588);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 586);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.LblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 31);
            this.panel1.TabIndex = 6;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.AutoSize = true;
            this.BtnClose.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnClose.BackgroundImage = global::ArquivoEtec.Properties.Resources.cancel2;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Location = new System.Drawing.Point(658, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(34, 23);
            this.BtnClose.TabIndex = 25;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click_1);
            this.BtnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.BtnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // LblTitle
            // 
            this.LblTitle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(694, 30);
            this.LblTitle.TabIndex = 24;
            this.LblTitle.Text = "SCANNER";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            this.LblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label3_MouseMove);
            this.LblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label3_MouseUp);
            // 
            // PScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(696, 619);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(400, 60);
            this.Name = "PScanner";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PScanner_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PScanner_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PScanner_MouseMove);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Button BtnNao;
        private System.Windows.Forms.Button BtnSim;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnDigitaliza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ListBox Scanners;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton RadioMedia;
        private System.Windows.Forms.RadioButton RadioAlta;
        private System.Windows.Forms.RadioButton RadioBaixa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblTitle;
    }
}

