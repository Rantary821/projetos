namespace ArquivoEtec
{
    partial class Menu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtTesteCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnTesteCpf = new System.Windows.Forms.Button();
            this.txtQuant = new System.Windows.Forms.MaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridUp = new System.Windows.Forms.DataGridView();
            this.Updates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNome = new System.Windows.Forms.Label();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.ResetBanco = new System.Windows.Forms.Button();
            this.lblRegistros = new System.Windows.Forms.LinkLabel();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnMini = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picLoad = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnCursos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCad = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnPesq = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.atualiza = new System.Windows.Forms.Timer(this.components);
            this.backGroundWoker = new System.ComponentModel.BackgroundWorker();
            this.WorkerTesteCpf = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUp)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TxtTesteCpf);
            this.panel1.Controls.Add(this.btnTesteCpf);
            this.panel1.Controls.Add(this.txtQuant);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.BtnInsert);
            this.panel1.Controls.Add(this.ResetBanco);
            this.panel1.Controls.Add(this.lblRegistros);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 714);
            this.panel1.TabIndex = 0;
            // 
            // TxtTesteCpf
            // 
            this.TxtTesteCpf.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTesteCpf.Location = new System.Drawing.Point(334, 97);
            this.TxtTesteCpf.Mask = "0000000000";
            this.TxtTesteCpf.Name = "TxtTesteCpf";
            this.TxtTesteCpf.Size = new System.Drawing.Size(118, 29);
            this.TxtTesteCpf.TabIndex = 16;
            this.TxtTesteCpf.Visible = false;
            // 
            // btnTesteCpf
            // 
            this.btnTesteCpf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTesteCpf.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTesteCpf.ForeColor = System.Drawing.Color.Black;
            this.btnTesteCpf.Location = new System.Drawing.Point(172, 71);
            this.btnTesteCpf.Name = "btnTesteCpf";
            this.btnTesteCpf.Size = new System.Drawing.Size(156, 55);
            this.btnTesteCpf.TabIndex = 15;
            this.btnTesteCpf.Text = "Test Validação Cpf";
            this.btnTesteCpf.UseVisualStyleBackColor = true;
            this.btnTesteCpf.Visible = false;
            this.btnTesteCpf.Click += new System.EventHandler(this.btnTesteCpf_Click);
            // 
            // txtQuant
            // 
            this.txtQuant.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuant.Location = new System.Drawing.Point(334, 36);
            this.txtQuant.Mask = "0000000";
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(83, 29);
            this.txtQuant.TabIndex = 14;
            this.txtQuant.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.gridUp);
            this.panel3.Location = new System.Drawing.Point(610, 479);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 232);
            this.panel3.TabIndex = 11;
            // 
            // gridUp
            // 
            this.gridUp.AllowUserToAddRows = false;
            this.gridUp.AllowUserToDeleteRows = false;
            this.gridUp.AllowUserToResizeColumns = false;
            this.gridUp.AllowUserToResizeRows = false;
            this.gridUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridUp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Updates});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridUp.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUp.Location = new System.Drawing.Point(0, 0);
            this.gridUp.Name = "gridUp";
            this.gridUp.ReadOnly = true;
            this.gridUp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUp.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridUp.RowHeadersVisible = false;
            this.gridUp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridUp.Size = new System.Drawing.Size(181, 230);
            this.gridUp.TabIndex = 10;
            this.gridUp.Visible = false;
            // 
            // Updates
            // 
            this.Updates.HeaderText = "Updates";
            this.Updates.Name = "Updates";
            this.Updates.ReadOnly = true;
            this.Updates.Width = 181;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(174, 674);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(111, 22);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "User - Data";
            // 
            // BtnInsert
            // 
            this.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsert.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsert.ForeColor = System.Drawing.Color.Black;
            this.BtnInsert.Location = new System.Drawing.Point(172, 30);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(156, 35);
            this.BtnInsert.TabIndex = 7;
            this.BtnInsert.Text = "Inserir Alunos";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Visible = false;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // ResetBanco
            // 
            this.ResetBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBanco.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBanco.ForeColor = System.Drawing.Color.Black;
            this.ResetBanco.Location = new System.Drawing.Point(171, 132);
            this.ResetBanco.Name = "ResetBanco";
            this.ResetBanco.Size = new System.Drawing.Size(156, 35);
            this.ResetBanco.TabIndex = 7;
            this.ResetBanco.Text = "Resetar Banco";
            this.ResetBanco.UseVisualStyleBackColor = true;
            this.ResetBanco.Visible = false;
            this.ResetBanco.Click += new System.EventHandler(this.ResetBanco_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRegistros.Location = new System.Drawing.Point(174, 649);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(90, 18);
            this.lblRegistros.TabIndex = 5;
            this.lblRegistros.TabStop = true;
            this.lblRegistros.Text = "Registros - ";
            this.lblRegistros.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(174, 625);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(69, 24);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "Horas";
            // 
            // btnMini
            // 
            this.btnMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMini.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMini.BackgroundImage = global::ArquivoEtec.Properties.Resources.mini;
            this.btnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMini.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMini.Location = new System.Drawing.Point(727, 1);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(34, 23);
            this.btnMini.TabIndex = 3;
            this.btnMini.Text = " ";
            this.btnMini.UseVisualStyleBackColor = false;
            this.btnMini.Click += new System.EventHandler(this.button3_Click);
            this.btnMini.MouseEnter += new System.EventHandler(this.btnMini_MouseEnter);
            this.btnMini.MouseLeave += new System.EventHandler(this.btnMini_MouseLeave);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnClose.BackgroundImage = global::ArquivoEtec.Properties.Resources.cancel2;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnClose.Location = new System.Drawing.Point(761, 1);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(34, 23);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = " ";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.button2_Click);
            this.BtnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.BtnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulo.Location = new System.Drawing.Point(168, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(626, 27);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "MENU";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.picLoad);
            this.panel2.Controls.Add(this.lblVersion);
            this.panel2.Controls.Add(this.btnCursos);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnCad);
            this.panel2.Controls.Add(this.btnConfig);
            this.panel2.Controls.Add(this.btnPesq);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 712);
            this.panel2.TabIndex = 1;
            // 
            // picLoad
            // 
            this.picLoad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picLoad.BackColor = System.Drawing.Color.Transparent;
            this.picLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLoad.BackgroundImage")));
            this.picLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLoad.Enabled = false;
            this.picLoad.FlatAppearance.BorderSize = 0;
            this.picLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.picLoad.ForeColor = System.Drawing.Color.White;
            this.picLoad.Location = new System.Drawing.Point(17, 352);
            this.picLoad.Name = "picLoad";
            this.picLoad.Size = new System.Drawing.Size(132, 135);
            this.picLoad.TabIndex = 15;
            this.picLoad.UseVisualStyleBackColor = false;
            this.picLoad.Visible = false;
            // 
            // lblVersion
            // 
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblVersion.Location = new System.Drawing.Point(0, 684);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(168, 28);
            this.lblVersion.TabIndex = 13;
            this.lblVersion.Text = "Version 1.0.0.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCursos
            // 
            this.btnCursos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCursos.FlatAppearance.BorderSize = 0;
            this.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCursos.Location = new System.Drawing.Point(1, 197);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(158, 63);
            this.btnCursos.TabIndex = 3;
            this.btnCursos.Text = "F3        Cursos";
            this.btnCursos.UseVisualStyleBackColor = false;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.BackgroundImage = global::ArquivoEtec.Properties.Resources.Logo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 532);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 154);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnCad
            // 
            this.btnCad.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCad.FlatAppearance.BorderSize = 0;
            this.btnCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCad.Location = new System.Drawing.Point(1, 43);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(158, 63);
            this.btnCad.TabIndex = 1;
            this.btnCad.Text = "F1     Cadastro";
            this.btnCad.UseVisualStyleBackColor = false;
            this.btnCad.Click += new System.EventHandler(this.btnCadd_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfig.Location = new System.Drawing.Point(1, 274);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(158, 63);
            this.btnConfig.TabIndex = 4;
            this.btnConfig.Text = "F4      Opções";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnPesq
            // 
            this.btnPesq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(78)))), ((int)(((byte)(139)))));
            this.btnPesq.FlatAppearance.BorderSize = 0;
            this.btnPesq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesq.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesq.Location = new System.Drawing.Point(1, 120);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(165, 63);
            this.btnPesq.TabIndex = 2;
            this.btnPesq.Text = "F2      Pesquisa";
            this.btnPesq.UseVisualStyleBackColor = false;
            this.btnPesq.Click += new System.EventHandler(this.btnPesq_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // atualiza
            // 
            this.atualiza.Enabled = true;
            this.atualiza.Interval = 60000;
            this.atualiza.Tick += new System.EventHandler(this.atualiza_Tick);
            // 
            // backGroundWoker
            // 
            this.backGroundWoker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backGroundWoker_DoWork);
            // 
            // WorkerTesteCpf
            // 
            this.WorkerTesteCpf.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerTesteCpf_DoWork);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(796, 714);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Arquivo Permanente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUp)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel lblRegistros;
        private System.Windows.Forms.Timer atualiza;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnPesq;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ResetBanco;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.DataGridView gridUp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Updates;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.MaskedTextBox txtQuant;
        private System.Windows.Forms.Button picLoad;
        private System.Windows.Forms.MaskedTextBox TxtTesteCpf;
        private System.Windows.Forms.Button btnTesteCpf;
        private System.ComponentModel.BackgroundWorker backGroundWoker;
        private System.ComponentModel.BackgroundWorker WorkerTesteCpf;
    }
}

