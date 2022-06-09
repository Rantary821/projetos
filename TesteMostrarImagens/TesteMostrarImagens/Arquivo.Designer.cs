namespace TesteMostrarImagens
{
    partial class Arquivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arquivo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuStripImagens = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuStripAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripRecortar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripRenomear = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripResetar = new System.Windows.Forms.ToolStripMenuItem();
            this.tipPicture = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MenuStripGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuStripColar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripNovaPasta = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripRenomearG = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripExcluirG = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BackGroundWorker = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuStripImagens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MenuStripGrid.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.AutoScroll = true;
            this.LayoutPanel.BackColor = System.Drawing.Color.DarkGray;
            this.LayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LayoutPanel.ContextMenuStrip = this.MenuStripImagens;
            this.LayoutPanel.Location = new System.Drawing.Point(202, 22);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.Size = new System.Drawing.Size(658, 236);
            this.LayoutPanel.TabIndex = 45;
            // 
            // MenuStripImagens
            // 
            this.MenuStripImagens.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MenuStripImagens.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripAbrir,
            this.MenuStripRecortar,
            this.MenuStripCopiar,
            this.MenuStripRenomear,
            this.MenuStripExcluir,
            this.MenuStripResetar});
            this.MenuStripImagens.Name = "MenuStripImagens";
            this.MenuStripImagens.Size = new System.Drawing.Size(129, 136);
            // 
            // MenuStripAbrir
            // 
            this.MenuStripAbrir.Image = ((System.Drawing.Image)(resources.GetObject("MenuStripAbrir.Image")));
            this.MenuStripAbrir.Name = "MenuStripAbrir";
            this.MenuStripAbrir.Size = new System.Drawing.Size(128, 22);
            this.MenuStripAbrir.Text = "Abrir";
            this.MenuStripAbrir.Click += new System.EventHandler(this.MenuStripAbrir_Click);
            // 
            // MenuStripRecortar
            // 
            this.MenuStripRecortar.Image = ((System.Drawing.Image)(resources.GetObject("MenuStripRecortar.Image")));
            this.MenuStripRecortar.Name = "MenuStripRecortar";
            this.MenuStripRecortar.Size = new System.Drawing.Size(128, 22);
            this.MenuStripRecortar.Text = "Recortar";
            this.MenuStripRecortar.Click += new System.EventHandler(this.MenuStripRecortar_Click);
            // 
            // MenuStripCopiar
            // 
            this.MenuStripCopiar.Image = ((System.Drawing.Image)(resources.GetObject("MenuStripCopiar.Image")));
            this.MenuStripCopiar.Name = "MenuStripCopiar";
            this.MenuStripCopiar.Size = new System.Drawing.Size(128, 22);
            this.MenuStripCopiar.Text = "Copiar";
            this.MenuStripCopiar.Click += new System.EventHandler(this.MenuStripCopiar_Click);
            // 
            // MenuStripRenomear
            // 
            this.MenuStripRenomear.Image = ((System.Drawing.Image)(resources.GetObject("MenuStripRenomear.Image")));
            this.MenuStripRenomear.Name = "MenuStripRenomear";
            this.MenuStripRenomear.Size = new System.Drawing.Size(128, 22);
            this.MenuStripRenomear.Text = "Renomear";
            this.MenuStripRenomear.Click += new System.EventHandler(this.MenuStripRenomear_Click);
            // 
            // MenuStripExcluir
            // 
            this.MenuStripExcluir.Image = ((System.Drawing.Image)(resources.GetObject("MenuStripExcluir.Image")));
            this.MenuStripExcluir.Name = "MenuStripExcluir";
            this.MenuStripExcluir.Size = new System.Drawing.Size(128, 22);
            this.MenuStripExcluir.Text = "Excluir";
            this.MenuStripExcluir.Click += new System.EventHandler(this.MenuStripExcluir_Click);
            // 
            // MenuStripResetar
            // 
            this.MenuStripResetar.Image = ((System.Drawing.Image)(resources.GetObject("MenuStripResetar.Image")));
            this.MenuStripResetar.Name = "MenuStripResetar";
            this.MenuStripResetar.Size = new System.Drawing.Size(128, 22);
            this.MenuStripResetar.Text = "Resetar";
            this.MenuStripResetar.Click += new System.EventHandler(this.MenuStripResetar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumBlue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(203, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(653, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "Arquivos do aluno";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AName,
            this.Link});
            this.dataGridView1.ContextMenuStrip = this.MenuStripGrid;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle31;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.Location = new System.Drawing.Point(1, 23);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle33;
            this.dataGridView1.Size = new System.Drawing.Size(200, 93);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MenuStripGrid
            // 
            this.MenuStripGrid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MenuStripGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripColar,
            this.MenuStripNovaPasta,
            this.MenuStripRenomearG,
            this.MenuStripExcluirG});
            this.MenuStripGrid.Name = "MenuStripGrid";
            this.MenuStripGrid.Size = new System.Drawing.Size(134, 92);
            this.MenuStripGrid.Opening += new System.ComponentModel.CancelEventHandler(this.MenuStripGrid_Opening);
            // 
            // MenuStripColar
            // 
            this.MenuStripColar.Image = ((System.Drawing.Image)(resources.GetObject("MenuStripColar.Image")));
            this.MenuStripColar.Name = "MenuStripColar";
            this.MenuStripColar.Size = new System.Drawing.Size(133, 22);
            this.MenuStripColar.Text = "Colar";
            this.MenuStripColar.Click += new System.EventHandler(this.MenuStripColar_Click);
            // 
            // MenuStripNovaPasta
            // 
            this.MenuStripNovaPasta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MenuStripNovaPasta.Image = ((System.Drawing.Image)(resources.GetObject("MenuStripNovaPasta.Image")));
            this.MenuStripNovaPasta.Name = "MenuStripNovaPasta";
            this.MenuStripNovaPasta.Size = new System.Drawing.Size(133, 22);
            this.MenuStripNovaPasta.Text = "Nova Pasta";
            this.MenuStripNovaPasta.Click += new System.EventHandler(this.MenuStripNovaPasta_Click);
            // 
            // MenuStripRenomearG
            // 
            this.MenuStripRenomearG.Image = ((System.Drawing.Image)(resources.GetObject("MenuStripRenomearG.Image")));
            this.MenuStripRenomearG.Name = "MenuStripRenomearG";
            this.MenuStripRenomearG.Size = new System.Drawing.Size(133, 22);
            this.MenuStripRenomearG.Text = "Renomear";
            this.MenuStripRenomearG.Click += new System.EventHandler(this.MenuStripRenomearG_Click);
            // 
            // MenuStripExcluirG
            // 
            this.MenuStripExcluirG.Image = ((System.Drawing.Image)(resources.GetObject("MenuStripExcluirG.Image")));
            this.MenuStripExcluirG.Name = "MenuStripExcluirG";
            this.MenuStripExcluirG.Size = new System.Drawing.Size(133, 22);
            this.MenuStripExcluirG.Text = "Excluir";
            this.MenuStripExcluirG.Click += new System.EventHandler(this.MenuStripExcluirG_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LayoutPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 261);
            this.panel1.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(835, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 21);
            this.button1.TabIndex = 52;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView2.Location = new System.Drawing.Point(1, 141);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle34;
            this.dataGridView2.Size = new System.Drawing.Size(200, 116);
            this.dataGridView2.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MediumBlue;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(-3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 22);
            this.label2.TabIndex = 50;
            this.label2.Text = "Pastas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.MediumBlue;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(-3, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 22);
            this.label3.TabIndex = 53;
            this.label3.Text = "Selecionados";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AName
            // 
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AName.DefaultCellStyle = dataGridViewCellStyle30;
            this.AName.HeaderText = "Pastas ";
            this.AName.Name = "AName";
            this.AName.ReadOnly = true;
            this.AName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AName.Width = 200;
            // 
            // Link
            // 
            this.Link.HeaderText = "Caminho";
            this.Link.Name = "Link";
            this.Link.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewTextBoxColumn1.HeaderText = "Selecionados";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // Arquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(863, 261);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Arquivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStripImagens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MenuStripGrid.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel LayoutPanel;
        private System.Windows.Forms.ToolTip tipPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.ComponentModel.BackgroundWorker BackGroundWorker;
        private System.Windows.Forms.ContextMenuStrip MenuStripImagens;
        private System.Windows.Forms.ToolStripMenuItem MenuStripCopiar;
        private System.Windows.Forms.ToolStripMenuItem MenuStripRecortar;
        private System.Windows.Forms.ToolStripMenuItem MenuStripRenomear;
        private System.Windows.Forms.ToolStripMenuItem MenuStripExcluir;
        private System.Windows.Forms.ContextMenuStrip MenuStripGrid;
        private System.Windows.Forms.ToolStripMenuItem MenuStripResetar;
        private System.Windows.Forms.ToolStripMenuItem MenuStripAbrir;
        private System.Windows.Forms.ToolStripMenuItem MenuStripNovaPasta;
        private System.Windows.Forms.ToolStripMenuItem MenuStripColar;
        private System.Windows.Forms.ToolStripMenuItem MenuStripExcluirG;
        private System.Windows.Forms.ToolStripMenuItem MenuStripRenomearG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn AName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Link;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

