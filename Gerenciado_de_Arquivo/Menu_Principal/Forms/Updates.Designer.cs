namespace Menu_Principal
{
    partial class Updates
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updates));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQntAluno = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblDiaMes = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.lblQntAluno);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblMes);
            this.panel1.Controls.Add(this.lblDiaMes);
            this.panel1.Controls.Add(this.lblDia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 160);
            this.panel1.TabIndex = 1;
            // 
            // lblQntAluno
            // 
            this.lblQntAluno.AutoSize = true;
            this.lblQntAluno.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQntAluno.ForeColor = System.Drawing.Color.White;
            this.lblQntAluno.Location = new System.Drawing.Point(12, 124);
            this.lblQntAluno.Name = "lblQntAluno";
            this.lblQntAluno.Size = new System.Drawing.Size(308, 27);
            this.lblQntAluno.TabIndex = 81;
            this.lblQntAluno.Text = "600000 Alunos cadastrados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 37);
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.ForeColor = System.Drawing.Color.White;
            this.lblMes.Location = new System.Drawing.Point(363, 59);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(25, 27);
            this.lblMes.TabIndex = 1;
            this.lblMes.Text = "2";
            // 
            // lblDiaMes
            // 
            this.lblDiaMes.AutoSize = true;
            this.lblDiaMes.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaMes.ForeColor = System.Drawing.Color.White;
            this.lblDiaMes.Location = new System.Drawing.Point(332, 59);
            this.lblDiaMes.Name = "lblDiaMes";
            this.lblDiaMes.Size = new System.Drawing.Size(25, 27);
            this.lblDiaMes.TabIndex = 1;
            this.lblDiaMes.Text = "2";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.Color.White;
            this.lblDia.Location = new System.Drawing.Point(332, 32);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(25, 27);
            this.lblDia.TabIndex = 1;
            this.lblDia.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 107);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Updates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(532, 160);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Updates";
            this.Opacity = 0.75D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updates";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDiaMes;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblQntAluno;
    }
}