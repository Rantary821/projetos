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
            this.picWebCam = new System.Windows.Forms.PictureBox();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.btnCaptura = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.BtnVolta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picWebCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picWebCam
            // 
            this.picWebCam.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picWebCam.Location = new System.Drawing.Point(6, 65);
            this.picWebCam.Margin = new System.Windows.Forms.Padding(4);
            this.picWebCam.Name = "picWebCam";
            this.picWebCam.Size = new System.Drawing.Size(581, 429);
            this.picWebCam.TabIndex = 0;
            this.picWebCam.TabStop = false;
            // 
            // picImagem
            // 
            this.picImagem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picImagem.Location = new System.Drawing.Point(6, 65);
            this.picImagem.Margin = new System.Windows.Forms.Padding(4);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(581, 429);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 1;
            this.picImagem.TabStop = false;
            this.picImagem.Visible = false;
            // 
            // btnCaptura
            // 
            this.btnCaptura.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCaptura.FlatAppearance.BorderSize = 0;
            this.btnCaptura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaptura.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaptura.Location = new System.Drawing.Point(7, 504);
            this.btnCaptura.Margin = new System.Windows.Forms.Padding(4);
            this.btnCaptura.Name = "btnCaptura";
            this.btnCaptura.Size = new System.Drawing.Size(175, 55);
            this.btnCaptura.TabIndex = 2;
            this.btnCaptura.Text = "Foto";
            this.btnCaptura.UseVisualStyleBackColor = false;
            this.btnCaptura.Click += new System.EventHandler(this.btnCaptura_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(405, 502);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(182, 55);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar ";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // BtnVolta
            // 
            this.BtnVolta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnVolta.Enabled = false;
            this.BtnVolta.FlatAppearance.BorderSize = 0;
            this.BtnVolta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolta.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolta.Location = new System.Drawing.Point(206, 504);
            this.BtnVolta.Name = "BtnVolta";
            this.BtnVolta.Size = new System.Drawing.Size(175, 55);
            this.BtnVolta.TabIndex = 4;
            this.BtnVolta.Text = "Voltar";
            this.BtnVolta.UseVisualStyleBackColor = false;
            this.BtnVolta.Click += new System.EventHandler(this.BtnVolta_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 58);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Web Cam";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(541, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(595, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnVolta);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCaptura);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.picWebCam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WebCam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capturando Imagem da WebCam";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWebCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button button1;
    }
}

