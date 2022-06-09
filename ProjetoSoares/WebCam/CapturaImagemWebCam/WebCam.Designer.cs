namespace WindowsFormsApplication1
{
    partial class WebCam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebCam));
            this.picWebCam = new System.Windows.Forms.PictureBox();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.btnCaptura = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.BtnVolta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picWebCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picWebCam
            // 
            this.picWebCam.BackColor = System.Drawing.Color.DarkGray;
            this.picWebCam.Location = new System.Drawing.Point(5, 54);
            this.picWebCam.Margin = new System.Windows.Forms.Padding(4);
            this.picWebCam.Name = "picWebCam";
            this.picWebCam.Size = new System.Drawing.Size(530, 530);
            this.picWebCam.TabIndex = 0;
            this.picWebCam.TabStop = false;
            // 
            // picImagem
            // 
            this.picImagem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picImagem.Location = new System.Drawing.Point(5, 54);
            this.picImagem.Margin = new System.Windows.Forms.Padding(4);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(530, 530);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 1;
            this.picImagem.TabStop = false;
            this.picImagem.Visible = false;
            // 
            // btnCaptura
            // 
            this.btnCaptura.BackColor = System.Drawing.Color.Silver;
            this.btnCaptura.FlatAppearance.BorderSize = 0;
            this.btnCaptura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaptura.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaptura.Location = new System.Drawing.Point(4, 587);
            this.btnCaptura.Margin = new System.Windows.Forms.Padding(4);
            this.btnCaptura.Name = "btnCaptura";
            this.btnCaptura.Size = new System.Drawing.Size(157, 41);
            this.btnCaptura.TabIndex = 2;
            this.btnCaptura.Text = "Foto";
            this.btnCaptura.UseVisualStyleBackColor = false;
            this.btnCaptura.Click += new System.EventHandler(this.btnCaptura_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Silver;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(370, 587);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(164, 41);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar ";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // BtnVolta
            // 
            this.BtnVolta.BackColor = System.Drawing.Color.Silver;
            this.BtnVolta.Enabled = false;
            this.BtnVolta.FlatAppearance.BorderSize = 0;
            this.BtnVolta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolta.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolta.Location = new System.Drawing.Point(187, 587);
            this.BtnVolta.Name = "BtnVolta";
            this.BtnVolta.Size = new System.Drawing.Size(157, 41);
            this.BtnVolta.TabIndex = 4;
            this.BtnVolta.Text = "Voltar";
            this.BtnVolta.UseVisualStyleBackColor = false;
            this.BtnVolta.Click += new System.EventHandler(this.BtnVolta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 48);
            this.panel1.TabIndex = 5;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(499, 10);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.TabIndex = 54;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Web Cam";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.picWebCam);
            this.panel2.Controls.Add(this.BtnVolta);
            this.panel2.Controls.Add(this.picImagem);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.btnCaptura);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 634);
            this.panel2.TabIndex = 6;
            // 
            // WebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(543, 634);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WebCam";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capturando Imagem da WebCam";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WebCam_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picWebCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picWebCam;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.Button btnCaptura;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button BtnVolta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel panel2;
    }
}

