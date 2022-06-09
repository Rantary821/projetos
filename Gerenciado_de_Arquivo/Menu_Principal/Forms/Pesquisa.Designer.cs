namespace Menu_Principal
{
    partial class Pesquisa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisa));
            this.dataPesq = new System.Windows.Forms.DataGridView();
            this.btnPesq = new System.Windows.Forms.Button();
            this.cpf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pesqQnt = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataPesq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesqQnt)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPesq
            // 
            this.dataPesq.AllowUserToAddRows = false;
            this.dataPesq.AllowUserToDeleteRows = false;
            this.dataPesq.AllowUserToResizeColumns = false;
            this.dataPesq.AllowUserToResizeRows = false;
            this.dataPesq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataPesq.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataPesq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPesq.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataPesq.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataPesq.Location = new System.Drawing.Point(8, 115);
            this.dataPesq.Name = "dataPesq";
            this.dataPesq.ReadOnly = true;
            this.dataPesq.Size = new System.Drawing.Size(981, 255);
            this.dataPesq.TabIndex = 0;
            this.dataPesq.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPesq_CellDoubleClick);
            // 
            // btnPesq
            // 
            this.btnPesq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesq.BackColor = System.Drawing.Color.Transparent;
            this.btnPesq.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesq.BackgroundImage")));
            this.btnPesq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesq.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnPesq.FlatAppearance.BorderSize = 0;
            this.btnPesq.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPesq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPesq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesq.Location = new System.Drawing.Point(888, 23);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(75, 56);
            this.btnPesq.TabIndex = 4;
            this.btnPesq.UseVisualStyleBackColor = false;
            this.btnPesq.Click += new System.EventHandler(this.btnPesq_Click);
            // 
            // cpf
            // 
            this.cpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cpf.Location = new System.Drawing.Point(449, 50);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(210, 26);
            this.cpf.TabIndex = 2;
            this.cpf.TextChanged += new System.EventHandler(this.cpf_TextChanged);
            this.cpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cpf_KeyDown);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(446, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "CPF :";
            // 
            // ra
            // 
            this.ra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ra.Location = new System.Drawing.Point(669, 50);
            this.ra.Name = "ra";
            this.ra.Size = new System.Drawing.Size(200, 26);
            this.ra.TabIndex = 3;
            this.ra.TextChanged += new System.EventHandler(this.ra_TextChanged);
            this.ra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ra_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(667, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "RA :";
            // 
            // nome
            // 
            this.nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nome.Location = new System.Drawing.Point(37, 50);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(402, 26);
            this.nome.TabIndex = 1;
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            this.nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Menu_Principal.Properties.Resources.search;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 51);
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label9_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label9_MouseMove);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(965, 18);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.TabIndex = 80;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pesqQnt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataPesq);
            this.groupBox1.Controls.Add(this.nome);
            this.groupBox1.Controls.Add(this.btnPesq);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cpf);
            this.groupBox1.Controls.Add(this.ra);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(8, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(997, 380);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            // 
            // pesqQnt
            // 
            this.pesqQnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pesqQnt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pesqQnt.Location = new System.Drawing.Point(923, 85);
            this.pesqQnt.Name = "pesqQnt";
            this.pesqQnt.Size = new System.Drawing.Size(64, 22);
            this.pesqQnt.TabIndex = 5;
            this.pesqQnt.Visible = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(406, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 34);
            this.label9.TabIndex = 84;
            this.label9.Text = "Pesquisa";
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label9_MouseDown);
            this.label9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label9_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 446);
            this.panel1.TabIndex = 85;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label9_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label9_MouseMove);
            // 
            // Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1014, 446);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Pesquisa";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.Pesquisa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pesquisa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataPesq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesqQnt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button btnPesq;
        private System.Windows.Forms.TextBox cpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataPesq;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown pesqQnt;
    }
}