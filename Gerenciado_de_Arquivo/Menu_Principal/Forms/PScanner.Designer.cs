namespace Menu_Principal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblExists = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RadioColorido = new System.Windows.Forms.RadioButton();
            this.RadioPB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RadioAlta = new System.Windows.Forms.RadioButton();
            this.RadioBaixa = new System.Windows.Forms.RadioButton();
            this.RadioMedia = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.Scanners = new System.Windows.Forms.ListBox();
            this.BtnNao = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.BtnSim = new System.Windows.Forms.Button();
            this.BtnAtualiza = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDigitaliza = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 730);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 51);
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Transparent;
            this.BtnClose.Location = new System.Drawing.Point(698, 14);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.TabIndex = 59;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(294, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 34);
            this.label9.TabIndex = 60;
            this.label9.Text = "Scanner";
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.label9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 664);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(726, 645);
            this.panel3.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblExists);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblConfirm);
            this.panel2.Controls.Add(this.Scanners);
            this.panel2.Controls.Add(this.BtnNao);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.BtnSim);
            this.panel2.Controls.Add(this.BtnAtualiza);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BtnDigitaliza);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 645);
            this.panel2.TabIndex = 10;
            // 
            // lblExists
            // 
            this.lblExists.AutoSize = true;
            this.lblExists.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExists.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblExists.Location = new System.Drawing.Point(13, 497);
            this.lblExists.Name = "lblExists";
            this.lblExists.Size = new System.Drawing.Size(0, 15);
            this.lblExists.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RadioColorido);
            this.groupBox3.Controls.Add(this.RadioPB);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(104, 528);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(134, 113);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cor";
            // 
            // RadioColorido
            // 
            this.RadioColorido.AutoSize = true;
            this.RadioColorido.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioColorido.ForeColor = System.Drawing.Color.White;
            this.RadioColorido.Location = new System.Drawing.Point(12, 26);
            this.RadioColorido.Name = "RadioColorido";
            this.RadioColorido.Size = new System.Drawing.Size(87, 22);
            this.RadioColorido.TabIndex = 11;
            this.RadioColorido.TabStop = true;
            this.RadioColorido.Text = "Colorido";
            this.RadioColorido.UseVisualStyleBackColor = true;
            this.RadioColorido.CheckedChanged += new System.EventHandler(this.RadioColorido_CheckedChanged);
            // 
            // RadioPB
            // 
            this.RadioPB.AutoSize = true;
            this.RadioPB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioPB.ForeColor = System.Drawing.Color.White;
            this.RadioPB.Location = new System.Drawing.Point(12, 52);
            this.RadioPB.Name = "RadioPB";
            this.RadioPB.Size = new System.Drawing.Size(120, 22);
            this.RadioPB.TabIndex = 12;
            this.RadioPB.TabStop = true;
            this.RadioPB.Text = "Preto/Branco";
            this.RadioPB.UseVisualStyleBackColor = true;
            this.RadioPB.CheckedChanged += new System.EventHandler(this.RadioPB_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadioAlta);
            this.groupBox2.Controls.Add(this.RadioBaixa);
            this.groupBox2.Controls.Add(this.RadioMedia);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 527);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(95, 113);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Qualidade";
            // 
            // RadioAlta
            // 
            this.RadioAlta.AutoSize = true;
            this.RadioAlta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioAlta.ForeColor = System.Drawing.Color.White;
            this.RadioAlta.Location = new System.Drawing.Point(11, 27);
            this.RadioAlta.Name = "RadioAlta";
            this.RadioAlta.Size = new System.Drawing.Size(52, 22);
            this.RadioAlta.TabIndex = 8;
            this.RadioAlta.TabStop = true;
            this.RadioAlta.Text = "Alta";
            this.RadioAlta.UseVisualStyleBackColor = true;
            this.RadioAlta.CheckedChanged += new System.EventHandler(this.RadioAlta_CheckedChanged);
            // 
            // RadioBaixa
            // 
            this.RadioBaixa.AutoSize = true;
            this.RadioBaixa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBaixa.ForeColor = System.Drawing.Color.White;
            this.RadioBaixa.Location = new System.Drawing.Point(11, 79);
            this.RadioBaixa.Name = "RadioBaixa";
            this.RadioBaixa.Size = new System.Drawing.Size(65, 22);
            this.RadioBaixa.TabIndex = 10;
            this.RadioBaixa.TabStop = true;
            this.RadioBaixa.Text = "Baixa";
            this.RadioBaixa.UseVisualStyleBackColor = true;
            this.RadioBaixa.CheckedChanged += new System.EventHandler(this.RadioBaixa_CheckedChanged);
            // 
            // RadioMedia
            // 
            this.RadioMedia.AutoSize = true;
            this.RadioMedia.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioMedia.ForeColor = System.Drawing.Color.White;
            this.RadioMedia.Location = new System.Drawing.Point(11, 53);
            this.RadioMedia.Name = "RadioMedia";
            this.RadioMedia.Size = new System.Drawing.Size(69, 22);
            this.RadioMedia.TabIndex = 9;
            this.RadioMedia.TabStop = true;
            this.RadioMedia.Text = "Media";
            this.RadioMedia.UseVisualStyleBackColor = true;
            this.RadioMedia.CheckedChanged += new System.EventHandler(this.RadioMedia_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Scanners";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.ForeColor = System.Drawing.Color.White;
            this.lblConfirm.Location = new System.Drawing.Point(19, 322);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(209, 24);
            this.lblConfirm.TabIndex = 11;
            this.lblConfirm.Text = "Confirmar Imagem?";
            this.lblConfirm.Visible = false;
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
            // BtnNao
            // 
            this.BtnNao.BackColor = System.Drawing.Color.Red;
            this.BtnNao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNao.BackgroundImage")));
            this.BtnNao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNao.FlatAppearance.BorderSize = 0;
            this.BtnNao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNao.Location = new System.Drawing.Point(122, 349);
            this.BtnNao.Name = "BtnNao";
            this.BtnNao.Size = new System.Drawing.Size(76, 57);
            this.BtnNao.TabIndex = 6;
            this.BtnNao.UseVisualStyleBackColor = false;
            this.BtnNao.Visible = false;
            this.BtnNao.Click += new System.EventHandler(this.BtnNao_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(11, 465);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(215, 25);
            this.txtNome.TabIndex = 7;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // BtnSim
            // 
            this.BtnSim.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnSim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSim.BackgroundImage")));
            this.BtnSim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSim.FlatAppearance.BorderSize = 0;
            this.BtnSim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSim.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSim.Location = new System.Drawing.Point(40, 349);
            this.BtnSim.Name = "BtnSim";
            this.BtnSim.Size = new System.Drawing.Size(76, 57);
            this.BtnSim.TabIndex = 5;
            this.BtnSim.UseVisualStyleBackColor = false;
            this.BtnSim.Visible = false;
            this.BtnSim.Click += new System.EventHandler(this.BtnSim_Click);
            // 
            // BtnAtualiza
            // 
            this.BtnAtualiza.FlatAppearance.BorderSize = 0;
            this.BtnAtualiza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.BtnAtualiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualiza.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualiza.ForeColor = System.Drawing.Color.White;
            this.BtnAtualiza.Location = new System.Drawing.Point(14, 195);
            this.BtnAtualiza.Name = "BtnAtualiza";
            this.BtnAtualiza.Size = new System.Drawing.Size(108, 30);
            this.BtnAtualiza.TabIndex = 1;
            this.BtnAtualiza.Text = "Atualizar lista";
            this.BtnAtualiza.UseVisualStyleBackColor = true;
            this.BtnAtualiza.Click += new System.EventHandler(this.BtnAtualiza_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // BtnDigitaliza
            // 
            this.BtnDigitaliza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.BtnDigitaliza.Enabled = false;
            this.BtnDigitaliza.FlatAppearance.BorderSize = 0;
            this.BtnDigitaliza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.BtnDigitaliza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDigitaliza.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDigitaliza.Location = new System.Drawing.Point(13, 241);
            this.BtnDigitaliza.Name = "BtnDigitaliza";
            this.BtnDigitaliza.Size = new System.Drawing.Size(212, 44);
            this.BtnDigitaliza.TabIndex = 2;
            this.BtnDigitaliza.Text = "Digitalizar";
            this.BtnDigitaliza.UseVisualStyleBackColor = false;
            this.BtnDigitaliza.Click += new System.EventHandler(this.BtnDigitaliza_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(245, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(481, 645);
            this.panel4.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 643);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // PScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 730);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "PScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PScanner";
            this.Load += new System.EventHandler(this.PScanner_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PScanner_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RadioBaixa;
        private System.Windows.Forms.RadioButton RadioMedia;
        private System.Windows.Forms.RadioButton RadioAlta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.ListBox Scanners;
        private System.Windows.Forms.Button BtnNao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button BtnSim;
        private System.Windows.Forms.Button BtnAtualiza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDigitaliza;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RadioColorido;
        private System.Windows.Forms.RadioButton RadioPB;
        private System.Windows.Forms.Label lblExists;
    }
}