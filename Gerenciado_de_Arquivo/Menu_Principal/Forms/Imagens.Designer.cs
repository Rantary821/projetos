namespace Menu_Principal
{
    partial class Imagens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imagens));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LayPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnEmail = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tipPicture = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 679);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 51);
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
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
            this.BtnClose.Location = new System.Drawing.Point(598, 15);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.TabIndex = 54;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Location = new System.Drawing.Point(9, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 611);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.LayPanel);
            this.panel3.Location = new System.Drawing.Point(8, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 585);
            this.panel3.TabIndex = 3;
            // 
            // LayPanel
            // 
            this.LayPanel.BackColor = System.Drawing.Color.Gray;
            this.LayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayPanel.Location = new System.Drawing.Point(0, 0);
            this.LayPanel.Name = "LayPanel";
            this.LayPanel.Size = new System.Drawing.Size(498, 583);
            this.LayPanel.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.BtnImprimir);
            this.panel4.Controls.Add(this.BtnEmail);
            this.panel4.Controls.Add(this.BtnGravar);
            this.panel4.Location = new System.Drawing.Point(509, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(106, 585);
            this.panel4.TabIndex = 4;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnImprimir.BackgroundImage")));
            this.BtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnImprimir.FlatAppearance.BorderSize = 0;
            this.BtnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimir.Location = new System.Drawing.Point(7, 27);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnImprimir.Size = new System.Drawing.Size(92, 72);
            this.BtnImprimir.TabIndex = 1;
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // BtnEmail
            // 
            this.BtnEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEmail.BackgroundImage")));
            this.BtnEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEmail.FlatAppearance.BorderSize = 0;
            this.BtnEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.BtnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmail.Location = new System.Drawing.Point(7, 114);
            this.BtnEmail.Name = "BtnEmail";
            this.BtnEmail.Size = new System.Drawing.Size(92, 92);
            this.BtnEmail.TabIndex = 1;
            this.BtnEmail.UseVisualStyleBackColor = true;
            this.BtnEmail.Click += new System.EventHandler(this.BtnEmail_Click);
            // 
            // BtnGravar
            // 
            this.BtnGravar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGravar.BackgroundImage")));
            this.BtnGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGravar.FlatAppearance.BorderSize = 0;
            this.BtnGravar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.BtnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGravar.Location = new System.Drawing.Point(9, 221);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(92, 83);
            this.BtnGravar.TabIndex = 1;
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(779, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Imagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 679);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Imagens";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imagens";
            this.Load += new System.EventHandler(this.Imagens_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Button BtnEmail;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.FlowLayoutPanel LayPanel;
        private System.Windows.Forms.ToolTip tipPicture;
    }
}