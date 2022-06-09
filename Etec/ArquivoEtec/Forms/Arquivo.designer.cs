namespace ArquivoEtec
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuStripImagens = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuStripAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripRecortar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripRenomear = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripResetar = new System.Windows.Forms.ToolStripMenuItem();
            this.tipPicture = new System.Windows.Forms.ToolTip(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuStripGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuStripColar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripNovaPasta = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripRenomearG = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripExcluirG = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSelec = new System.Windows.Forms.Label();
            this.lblPasta = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackGroundWorker = new System.ComponentModel.BackgroundWorker();
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
            this.LayoutPanel.BackColor = System.Drawing.Color.Silver;
            this.LayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LayoutPanel.ContextMenuStrip = this.MenuStripImagens;
            this.LayoutPanel.Location = new System.Drawing.Point(109, 22);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.Size = new System.Drawing.Size(305, 128);
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
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(106, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(308, 21);
            this.lblTitulo.TabIndex = 49;
            this.lblTitulo.Text = "Arquivos do aluno";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AName,
            this.Link});
            this.dataGridView1.ContextMenuStrip = this.MenuStripGrid;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 23);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(110, 47);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // AName
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AName.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblSelec);
            this.panel1.Controls.Add(this.lblPasta);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.LayoutPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 151);
            this.panel1.TabIndex = 50;
            // 
            // lblSelec
            // 
            this.lblSelec.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblSelec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSelec.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelec.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSelec.Location = new System.Drawing.Point(-2, 70);
            this.lblSelec.Name = "lblSelec";
            this.lblSelec.Size = new System.Drawing.Size(112, 22);
            this.lblSelec.TabIndex = 53;
            this.lblSelec.Text = "Selecionados";
            this.lblSelec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPasta
            // 
            this.lblPasta.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblPasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPasta.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPasta.Location = new System.Drawing.Point(-3, 1);
            this.lblPasta.Name = "lblPasta";
            this.lblPasta.Size = new System.Drawing.Size(112, 22);
            this.lblPasta.TabIndex = 50;
            this.lblPasta.Text = "Pastas";
            this.lblPasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView2.Location = new System.Drawing.Point(-1, 91);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.Size = new System.Drawing.Size(110, 59);
            this.dataGridView2.TabIndex = 51;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
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
            this.ClientSize = new System.Drawing.Size(415, 151);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Arquivo";
            this.ShowInTaskbar = false;
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
        private System.Windows.Forms.Label lblTitulo;
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
        private System.Windows.Forms.Label lblPasta;
        private System.Windows.Forms.Label lblSelec;
        private System.Windows.Forms.DataGridViewTextBoxColumn AName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Link;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

