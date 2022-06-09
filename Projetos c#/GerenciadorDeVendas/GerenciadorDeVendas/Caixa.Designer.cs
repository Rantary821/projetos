namespace GerenciadorDeVendas
{
    partial class Caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caixa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.GridCaixa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnConfirma = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridCaixa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(302, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 29);
            this.label5.TabIndex = 57;
            this.label5.Text = "Caixa";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Location = new System.Drawing.Point(654, 4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(29, 23);
            this.BtnClose.TabIndex = 56;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // GridCaixa
            // 
            this.GridCaixa.AllowUserToAddRows = false;
            this.GridCaixa.AllowUserToDeleteRows = false;
            this.GridCaixa.AllowUserToResizeColumns = false;
            this.GridCaixa.AllowUserToResizeRows = false;
            this.GridCaixa.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCaixa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GridCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridCaixa.DefaultCellStyle = dataGridViewCellStyle8;
            this.GridCaixa.Enabled = false;
            this.GridCaixa.Location = new System.Drawing.Point(8, 40);
            this.GridCaixa.Name = "GridCaixa";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCaixa.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GridCaixa.Size = new System.Drawing.Size(674, 254);
            this.GridCaixa.TabIndex = 61;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Data";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Entrada";
            this.Column2.Name = "Column2";
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Saida";
            this.Column3.Name = "Column3";
            this.Column3.Width = 140;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Caixa Final";
            this.Column4.Name = "Column4";
            this.Column4.Width = 160;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.BtnConfirma);
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 298);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 56);
            this.panel1.TabIndex = 62;
            // 
            // BtnConfirma
            // 
            this.BtnConfirma.Enabled = false;
            this.BtnConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirma.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirma.ForeColor = System.Drawing.Color.White;
            this.BtnConfirma.Image = ((System.Drawing.Image)(resources.GetObject("BtnConfirma.Image")));
            this.BtnConfirma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirma.Location = new System.Drawing.Point(8, 5);
            this.BtnConfirma.Name = "BtnConfirma";
            this.BtnConfirma.Size = new System.Drawing.Size(226, 45);
            this.BtnConfirma.TabIndex = 37;
            this.BtnConfirma.Text = " Valor Inicial Hoje";
            this.BtnConfirma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConfirma.UseVisualStyleBackColor = true;
            this.BtnConfirma.Visible = false;
            this.BtnConfirma.Click += new System.EventHandler(this.BtnConfirma_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.Image")));
            this.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancel.Location = new System.Drawing.Point(484, 5);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(197, 45);
            this.BtnCancel.TabIndex = 37;
            this.BtnCancel.Text = "Cancelar (F1)";
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(691, 354);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GridCaixa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.Caixa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Caixa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GridCaixa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridView GridCaixa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnConfirma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}