namespace Menu_Principal
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ImageMini = new System.Windows.Forms.PictureBox();
            this.ImageMaxi = new System.Windows.Forms.PictureBox();
            this.CheckMenu = new System.Windows.Forms.CheckBox();
            this.LblMenu = new System.Windows.Forms.Label();
            this.LblVersion = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtncadAluno = new System.Windows.Forms.Button();
            this.btnPesq = new System.Windows.Forms.Button();
            this.BtnConfig = new System.Windows.Forms.Button();
            this.BtnSair2 = new System.Windows.Forms.Button();
            this.BtncadAluno2 = new System.Windows.Forms.Button();
            this.btnPesq2 = new System.Windows.Forms.Button();
            this.BtnConfig2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageMaxi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ImageMini);
            this.panel1.Controls.Add(this.ImageMaxi);
            this.panel1.Controls.Add(this.CheckMenu);
            this.panel1.Controls.Add(this.LblMenu);
            this.panel1.Controls.Add(this.LblVersion);
            this.panel1.Controls.Add(this.BtnSair);
            this.panel1.Controls.Add(this.BtncadAluno);
            this.panel1.Controls.Add(this.btnPesq);
            this.panel1.Controls.Add(this.BtnConfig);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(818, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 741);
            this.panel1.TabIndex = 0;
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(7, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Teste";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ImageMini
            // 
            this.ImageMini.BackColor = System.Drawing.Color.Transparent;
            this.ImageMini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImageMini.BackgroundImage")));
            this.ImageMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImageMini.Location = new System.Drawing.Point(25, 17);
            this.ImageMini.Name = "ImageMini";
            this.ImageMini.Size = new System.Drawing.Size(41, 41);
            this.ImageMini.TabIndex = 9;
            this.ImageMini.TabStop = false;
            this.ImageMini.Visible = false;
            this.ImageMini.Click += new System.EventHandler(this.ImageMini_Click);
            // 
            // ImageMaxi
            // 
            this.ImageMaxi.BackColor = System.Drawing.Color.Transparent;
            this.ImageMaxi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImageMaxi.BackgroundImage")));
            this.ImageMaxi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImageMaxi.Location = new System.Drawing.Point(25, 17);
            this.ImageMaxi.Name = "ImageMaxi";
            this.ImageMaxi.Size = new System.Drawing.Size(41, 41);
            this.ImageMaxi.TabIndex = 8;
            this.ImageMaxi.TabStop = false;
            this.ImageMaxi.Visible = false;
            this.ImageMaxi.Click += new System.EventHandler(this.ImageMaxi_Click);
            // 
            // CheckMenu
            // 
            this.CheckMenu.AutoSize = true;
            this.CheckMenu.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckMenu.Location = new System.Drawing.Point(38, 73);
            this.CheckMenu.Name = "CheckMenu";
            this.CheckMenu.Size = new System.Drawing.Size(15, 14);
            this.CheckMenu.TabIndex = 5;
            this.CheckMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckMenu.UseVisualStyleBackColor = true;
            this.CheckMenu.Visible = false;
            this.CheckMenu.CheckedChanged += new System.EventHandler(this.CheckMenu_CheckedChanged);
            // 
            // LblMenu
            // 
            this.LblMenu.BackColor = System.Drawing.Color.Transparent;
            this.LblMenu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMenu.Location = new System.Drawing.Point(3, 96);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.Size = new System.Drawing.Size(85, 15);
            this.LblMenu.TabIndex = 56;
            this.LblMenu.Text = "MODO";
            this.LblMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblMenu.Visible = false;
            // 
            // LblVersion
            // 
            this.LblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblVersion.AutoSize = true;
            this.LblVersion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblVersion.ForeColor = System.Drawing.Color.White;
            this.LblVersion.Location = new System.Drawing.Point(7, 714);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(71, 19);
            this.LblVersion.TabIndex = 1;
            this.LblVersion.Text = "V.0.0.0.0";
            // 
            // BtnSair
            // 
            this.BtnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSair.BackColor = System.Drawing.Color.Transparent;
            this.BtnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSair.BackgroundImage")));
            this.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSair.Location = new System.Drawing.Point(0, 459);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(85, 108);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair\r\n(Esc)";
            this.BtnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Visible = false;
            this.BtnSair.Click += new System.EventHandler(this.button4_Click);
            this.BtnSair.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.BtnSair.MouseHover += new System.EventHandler(this.BtnSair_MouseHover);
            // 
            // BtncadAluno
            // 
            this.BtncadAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtncadAluno.BackColor = System.Drawing.Color.Transparent;
            this.BtncadAluno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtncadAluno.BackgroundImage")));
            this.BtncadAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtncadAluno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BtncadAluno.FlatAppearance.BorderSize = 0;
            this.BtncadAluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtncadAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtncadAluno.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtncadAluno.ForeColor = System.Drawing.Color.White;
            this.BtncadAluno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtncadAluno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtncadAluno.Location = new System.Drawing.Point(0, 135);
            this.BtncadAluno.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtncadAluno.Name = "BtncadAluno";
            this.BtncadAluno.Size = new System.Drawing.Size(85, 108);
            this.BtncadAluno.TabIndex = 0;
            this.BtncadAluno.Text = "CADASTRO\r\n(F2)";
            this.BtncadAluno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtncadAluno.UseVisualStyleBackColor = false;
            this.BtncadAluno.Visible = false;
            this.BtncadAluno.Click += new System.EventHandler(this.BtncadAluno_Click);
            this.BtncadAluno.MouseLeave += new System.EventHandler(this.cadAluno_MouseLeave);
            this.BtncadAluno.MouseHover += new System.EventHandler(this.BtncadAluno_MouseHover);
            // 
            // btnPesq
            // 
            this.btnPesq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesq.BackColor = System.Drawing.Color.Transparent;
            this.btnPesq.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesq.BackgroundImage")));
            this.btnPesq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesq.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnPesq.FlatAppearance.BorderSize = 0;
            this.btnPesq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPesq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesq.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesq.ForeColor = System.Drawing.Color.White;
            this.btnPesq.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPesq.Location = new System.Drawing.Point(0, 243);
            this.btnPesq.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(85, 108);
            this.btnPesq.TabIndex = 1;
            this.btnPesq.Text = "PESQUISA\r\n(F3)";
            this.btnPesq.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesq.UseVisualStyleBackColor = false;
            this.btnPesq.Visible = false;
            this.btnPesq.Click += new System.EventHandler(this.btnPesq_Click);
            this.btnPesq.MouseLeave += new System.EventHandler(this.btnPesq_MouseLeave);
            this.btnPesq.MouseHover += new System.EventHandler(this.btnPesq_MouseHover);
            // 
            // BtnConfig
            // 
            this.BtnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConfig.BackColor = System.Drawing.Color.Transparent;
            this.BtnConfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnConfig.BackgroundImage")));
            this.BtnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BtnConfig.FlatAppearance.BorderSize = 0;
            this.BtnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfig.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfig.ForeColor = System.Drawing.Color.White;
            this.BtnConfig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnConfig.Location = new System.Drawing.Point(0, 351);
            this.BtnConfig.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Size = new System.Drawing.Size(85, 108);
            this.BtnConfig.TabIndex = 2;
            this.BtnConfig.Text = "Config.\r\n(F4)";
            this.BtnConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnConfig.UseVisualStyleBackColor = false;
            this.BtnConfig.Visible = false;
            this.BtnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
            this.BtnConfig.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.BtnConfig.MouseHover += new System.EventHandler(this.BtnConfig_MouseHover);
            // 
            // BtnSair2
            // 
            this.BtnSair2.BackColor = System.Drawing.Color.Transparent;
            this.BtnSair2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSair2.BackgroundImage")));
            this.BtnSair2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSair2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BtnSair2.FlatAppearance.BorderSize = 0;
            this.BtnSair2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnSair2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair2.ForeColor = System.Drawing.Color.White;
            this.BtnSair2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSair2.Location = new System.Drawing.Point(365, 13);
            this.BtnSair2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnSair2.Name = "BtnSair2";
            this.BtnSair2.Size = new System.Drawing.Size(85, 108);
            this.BtnSair2.TabIndex = 7;
            this.BtnSair2.Text = "Sair\r\n(Esc)";
            this.BtnSair2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSair2.UseVisualStyleBackColor = false;
            this.BtnSair2.Visible = false;
            this.BtnSair2.Click += new System.EventHandler(this.BtnSair2_Click);
            // 
            // BtncadAluno2
            // 
            this.BtncadAluno2.BackColor = System.Drawing.Color.Transparent;
            this.BtncadAluno2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtncadAluno2.BackgroundImage")));
            this.BtncadAluno2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtncadAluno2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BtncadAluno2.FlatAppearance.BorderSize = 0;
            this.BtncadAluno2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtncadAluno2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtncadAluno2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtncadAluno2.ForeColor = System.Drawing.Color.White;
            this.BtncadAluno2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtncadAluno2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtncadAluno2.Location = new System.Drawing.Point(14, 8);
            this.BtncadAluno2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtncadAluno2.Name = "BtncadAluno2";
            this.BtncadAluno2.Size = new System.Drawing.Size(85, 108);
            this.BtncadAluno2.TabIndex = 4;
            this.BtncadAluno2.Text = "CADASTRO\r\n(F2)";
            this.BtncadAluno2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtncadAluno2.UseVisualStyleBackColor = false;
            this.BtncadAluno2.Visible = false;
            this.BtncadAluno2.Click += new System.EventHandler(this.BtncadAluno2_Click);
            // 
            // btnPesq2
            // 
            this.btnPesq2.BackColor = System.Drawing.Color.Transparent;
            this.btnPesq2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesq2.BackgroundImage")));
            this.btnPesq2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesq2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnPesq2.FlatAppearance.BorderSize = 0;
            this.btnPesq2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPesq2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesq2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesq2.ForeColor = System.Drawing.Color.White;
            this.btnPesq2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPesq2.Location = new System.Drawing.Point(131, 13);
            this.btnPesq2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPesq2.Name = "btnPesq2";
            this.btnPesq2.Size = new System.Drawing.Size(85, 108);
            this.btnPesq2.TabIndex = 5;
            this.btnPesq2.Text = "PESQUISA\r\n(F3)";
            this.btnPesq2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesq2.UseVisualStyleBackColor = false;
            this.btnPesq2.Visible = false;
            this.btnPesq2.Click += new System.EventHandler(this.btnPesq2_Click);
            // 
            // BtnConfig2
            // 
            this.BtnConfig2.BackColor = System.Drawing.Color.Transparent;
            this.BtnConfig2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnConfig2.BackgroundImage")));
            this.BtnConfig2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnConfig2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BtnConfig2.FlatAppearance.BorderSize = 0;
            this.BtnConfig2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnConfig2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfig2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfig2.ForeColor = System.Drawing.Color.White;
            this.BtnConfig2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnConfig2.Location = new System.Drawing.Point(248, 13);
            this.BtnConfig2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnConfig2.Name = "BtnConfig2";
            this.BtnConfig2.Size = new System.Drawing.Size(85, 108);
            this.BtnConfig2.TabIndex = 6;
            this.BtnConfig2.Text = "Config.\r\n(F4)";
            this.BtnConfig2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnConfig2.UseVisualStyleBackColor = false;
            this.BtnConfig2.Visible = false;
            this.BtnConfig2.Click += new System.EventHandler(this.BtnConfig2_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(903, 741);
            this.Controls.Add(this.BtnSair2);
            this.Controls.Add(this.BtncadAluno2);
            this.Controls.Add(this.btnPesq2);
            this.Controls.Add(this.BtnConfig2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.menu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.menu_KeyDown);
            this.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageMaxi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtncadAluno;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnConfig;
        private System.Windows.Forms.Button btnPesq;
        private System.Windows.Forms.Label LblVersion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox CheckMenu;
        private System.Windows.Forms.Label LblMenu;
        private System.Windows.Forms.Button BtnSair2;
        private System.Windows.Forms.Button BtncadAluno2;
        private System.Windows.Forms.Button btnPesq2;
        private System.Windows.Forms.Button BtnConfig2;
        private System.Windows.Forms.PictureBox ImageMini;
        private System.Windows.Forms.PictureBox ImageMaxi;
    }
}

