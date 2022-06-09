namespace GerenciadorDeVendas
{
    partial class pagamenteRapido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pagamenteRapido));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnOK = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.TxtValorRecebido = new System.Windows.Forms.TextBox();
            this.TxtValorTotal = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtTroco = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.BtnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 62);
            this.panel1.TabIndex = 0;
            // 
            // BtnOK
            // 
            this.BtnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnOK.Enabled = false;
            this.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOK.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOK.ForeColor = System.Drawing.Color.White;
            this.BtnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOK.Location = new System.Drawing.Point(745, 6);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(100, 53);
            this.BtnOK.TabIndex = 41;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = false;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(149, 232);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(260, 41);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Valor Entregue";
            // 
            // TxtValorRecebido
            // 
            this.TxtValorRecebido.BackColor = System.Drawing.Color.White;
            this.TxtValorRecebido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtValorRecebido.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorRecebido.Location = new System.Drawing.Point(136, 276);
            this.TxtValorRecebido.Name = "TxtValorRecebido";
            this.TxtValorRecebido.Size = new System.Drawing.Size(290, 56);
            this.TxtValorRecebido.TabIndex = 2;
            this.TxtValorRecebido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtValorRecebido.TextChanged += new System.EventHandler(this.TxtValorRecebido_TextChanged);
            // 
            // TxtValorTotal
            // 
            this.TxtValorTotal.BackColor = System.Drawing.Color.White;
            this.TxtValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtValorTotal.Enabled = false;
            this.TxtValorTotal.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorTotal.Location = new System.Drawing.Point(501, 276);
            this.TxtValorTotal.Name = "TxtValorTotal";
            this.TxtValorTotal.Size = new System.Drawing.Size(290, 56);
            this.TxtValorTotal.TabIndex = 4;
            this.TxtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(547, 232);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(191, 41);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Valor Total";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TxtTroco);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(8, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(908, 162);
            this.panel2.TabIndex = 5;
            // 
            // TxtTroco
            // 
            this.TxtTroco.BackColor = System.Drawing.Color.Silver;
            this.TxtTroco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTroco.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTroco.ForeColor = System.Drawing.Color.Black;
            this.TxtTroco.Location = new System.Drawing.Point(3, 72);
            this.TxtTroco.Name = "TxtTroco";
            this.TxtTroco.Size = new System.Drawing.Size(902, 56);
            this.TxtTroco.TabIndex = 5;
            this.TxtTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pagamenteRapido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(926, 398);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtValorTotal);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.TxtValorRecebido);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "pagamenteRapido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pagamenteRapido";
            this.Load += new System.EventHandler(this.pagamenteRapido_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox TxtValorRecebido;
        private System.Windows.Forms.TextBox TxtValorTotal;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtTroco;
    }
}