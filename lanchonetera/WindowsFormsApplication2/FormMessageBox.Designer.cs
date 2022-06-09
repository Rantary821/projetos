namespace WindowsFormsApplication2
{
    partial class FormMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMessageBox));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblMenssagem = new System.Windows.Forms.Label();
            this.PictureInterrogacao = new System.Windows.Forms.PictureBox();
            this.BtnSim = new System.Windows.Forms.Button();
            this.BtnNao = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.PictureAlerta = new System.Windows.Forms.PictureBox();
            this.PictureError = new System.Windows.Forms.PictureBox();
            this.PictureVendaOK = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureInterrogacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAlerta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureVendaOK)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 46);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LblMenssagem
            // 
            this.LblMenssagem.AutoSize = true;
            this.LblMenssagem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMenssagem.Location = new System.Drawing.Point(111, 136);
            this.LblMenssagem.Name = "LblMenssagem";
            this.LblMenssagem.Size = new System.Drawing.Size(112, 22);
            this.LblMenssagem.TabIndex = 8;
            this.LblMenssagem.Text = "Mensagem";
            this.LblMenssagem.Visible = false;
            // 
            // PictureInterrogacao
            // 
            this.PictureInterrogacao.BackColor = System.Drawing.Color.Transparent;
            this.PictureInterrogacao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureInterrogacao.BackgroundImage")));
            this.PictureInterrogacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureInterrogacao.Location = new System.Drawing.Point(11, 100);
            this.PictureInterrogacao.Name = "PictureInterrogacao";
            this.PictureInterrogacao.Size = new System.Drawing.Size(100, 92);
            this.PictureInterrogacao.TabIndex = 9;
            this.PictureInterrogacao.TabStop = false;
            this.PictureInterrogacao.Visible = false;
            // 
            // BtnSim
            // 
            this.BtnSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSim.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSim.Location = new System.Drawing.Point(319, 218);
            this.BtnSim.Name = "BtnSim";
            this.BtnSim.Size = new System.Drawing.Size(91, 40);
            this.BtnSim.TabIndex = 10;
            this.BtnSim.Text = "SIM";
            this.BtnSim.UseVisualStyleBackColor = true;
            this.BtnSim.Visible = false;
            this.BtnSim.Click += new System.EventHandler(this.BtnSim_Click);
            // 
            // BtnNao
            // 
            this.BtnNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNao.Location = new System.Drawing.Point(416, 218);
            this.BtnNao.Name = "BtnNao";
            this.BtnNao.Size = new System.Drawing.Size(91, 40);
            this.BtnNao.TabIndex = 10;
            this.BtnNao.Text = "NÃO";
            this.BtnNao.UseVisualStyleBackColor = true;
            this.BtnNao.Visible = false;
            this.BtnNao.Click += new System.EventHandler(this.BtnNao_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.Location = new System.Drawing.Point(416, 218);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(91, 40);
            this.BtnOk.TabIndex = 10;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Visible = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // PictureAlerta
            // 
            this.PictureAlerta.BackColor = System.Drawing.Color.Transparent;
            this.PictureAlerta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureAlerta.BackgroundImage")));
            this.PictureAlerta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureAlerta.Location = new System.Drawing.Point(12, 100);
            this.PictureAlerta.Name = "PictureAlerta";
            this.PictureAlerta.Size = new System.Drawing.Size(100, 92);
            this.PictureAlerta.TabIndex = 11;
            this.PictureAlerta.TabStop = false;
            this.PictureAlerta.Visible = false;
            // 
            // PictureError
            // 
            this.PictureError.BackColor = System.Drawing.Color.Transparent;
            this.PictureError.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureError.BackgroundImage")));
            this.PictureError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureError.Location = new System.Drawing.Point(11, 100);
            this.PictureError.Name = "PictureError";
            this.PictureError.Size = new System.Drawing.Size(100, 92);
            this.PictureError.TabIndex = 11;
            this.PictureError.TabStop = false;
            this.PictureError.Visible = false;
            // 
            // PictureVendaOK
            // 
            this.PictureVendaOK.BackColor = System.Drawing.Color.Transparent;
            this.PictureVendaOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureVendaOK.BackgroundImage")));
            this.PictureVendaOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureVendaOK.Location = new System.Drawing.Point(12, 100);
            this.PictureVendaOK.Name = "PictureVendaOK";
            this.PictureVendaOK.Size = new System.Drawing.Size(100, 92);
            this.PictureVendaOK.TabIndex = 12;
            this.PictureVendaOK.TabStop = false;
            this.PictureVendaOK.Visible = false;
            // 
            // FormMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(520, 270);
            this.Controls.Add(this.PictureVendaOK);
            this.Controls.Add(this.PictureError);
            this.Controls.Add(this.PictureAlerta);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.BtnNao);
            this.Controls.Add(this.BtnSim);
            this.Controls.Add(this.PictureInterrogacao);
            this.Controls.Add(this.LblMenssagem);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureInterrogacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAlerta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureVendaOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblMenssagem;
        private System.Windows.Forms.PictureBox PictureInterrogacao;
        private System.Windows.Forms.Button BtnSim;
        private System.Windows.Forms.Button BtnNao;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.PictureBox PictureAlerta;
        private System.Windows.Forms.PictureBox PictureError;
        private System.Windows.Forms.PictureBox PictureVendaOK;
    }
}