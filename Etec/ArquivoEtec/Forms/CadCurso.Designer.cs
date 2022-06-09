namespace ArquivoEtec
{
    partial class cadCurso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadCurso));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.GridCursos = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtNomeCurso = new System.Windows.Forms.TextBox();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnCad = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.LblErro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridCursos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(510, 30);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "    CURSOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.lblTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.lblTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // GridCursos
            // 
            this.GridCursos.AllowUserToAddRows = false;
            this.GridCursos.AllowUserToDeleteRows = false;
            this.GridCursos.AllowUserToResizeColumns = false;
            this.GridCursos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.GridCursos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridCursos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridCursos.Location = new System.Drawing.Point(13, 33);
            this.GridCursos.MultiSelect = false;
            this.GridCursos.Name = "GridCursos";
            this.GridCursos.ReadOnly = true;
            this.GridCursos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridCursos.RowHeadersVisible = false;
            this.GridCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCursos.Size = new System.Drawing.Size(482, 190);
            this.GridCursos.TabIndex = 3;
            this.GridCursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCursos_CellClick);
            this.GridCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCursos_CellContentClick);
            this.GridCursos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCursos_CellContentDoubleClick);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(226, 229);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 22);
            this.label19.TabIndex = 24;
            this.label19.Text = "Curso";
            // 
            // TxtNomeCurso
            // 
            this.TxtNomeCurso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtNomeCurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNomeCurso.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeCurso.Location = new System.Drawing.Point(61, 254);
            this.TxtNomeCurso.Name = "TxtNomeCurso";
            this.TxtNomeCurso.Size = new System.Drawing.Size(393, 25);
            this.TxtNomeCurso.TabIndex = 25;
            this.TxtNomeCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNomeCurso.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            this.TxtNomeCurso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNomeCurso_KeyDown);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.Red;
            this.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.FlatAppearance.BorderSize = 0;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.Color.Black;
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcluir.Location = new System.Drawing.Point(260, 284);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(194, 41);
            this.BtnExcluir.TabIndex = 28;
            this.BtnExcluir.Text = "DELETAR";
            this.BtnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LblErro);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.BtnCad);
            this.panel1.Controls.Add(this.GridCursos);
            this.panel1.Controls.Add(this.BtnExcluir);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.BtnUpdate);
            this.panel1.Controls.Add(this.TxtNomeCurso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 330);
            this.panel1.TabIndex = 30;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnClose.BackgroundImage = global::ArquivoEtec.Properties.Resources.cancel2;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnClose.Location = new System.Drawing.Point(474, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(34, 23);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.BtnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.BtnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // BtnCad
            // 
            this.BtnCad.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnCad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCad.FlatAppearance.BorderSize = 0;
            this.BtnCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCad.ForeColor = System.Drawing.Color.Black;
            this.BtnCad.Image = ((System.Drawing.Image)(resources.GetObject("BtnCad.Image")));
            this.BtnCad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCad.Location = new System.Drawing.Point(61, 284);
            this.BtnCad.Name = "BtnCad";
            this.BtnCad.Size = new System.Drawing.Size(193, 41);
            this.BtnCad.TabIndex = 29;
            this.BtnCad.Text = "CADASTRAR";
            this.BtnCad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCad.UseVisualStyleBackColor = false;
            this.BtnCad.Click += new System.EventHandler(this.BtnCad_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.Image")));
            this.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdate.Location = new System.Drawing.Point(61, 287);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(193, 38);
            this.BtnUpdate.TabIndex = 27;
            this.BtnUpdate.Text = "ATUALIZAR DADOS";
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Visible = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // LblErro
            // 
            this.LblErro.AutoSize = true;
            this.LblErro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErro.ForeColor = System.Drawing.Color.Red;
            this.LblErro.Location = new System.Drawing.Point(58, 232);
            this.LblErro.Name = "LblErro";
            this.LblErro.Size = new System.Drawing.Size(0, 15);
            this.LblErro.TabIndex = 30;
            // 
            // cadCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 330);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cadCurso";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadCurso";
            this.Load += new System.EventHandler(this.cadCurso_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cadCurso_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GridCursos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView GridCursos;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TxtNomeCurso;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnCad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblErro;
    }
}