namespace GerenciadorDeVendas
{
    partial class Venda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSubTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtObserv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTotalUni = new System.Windows.Forms.TextBox();
            this.TxtProduto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtValorUni = new System.Windows.Forms.TextBox();
            this.TxtQuant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GridItensCompra = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotalUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnObser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSelectCliente = new System.Windows.Forms.Button();
            this.BtnFinaliza = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtValorParcelas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtQuantParcelas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtFormaPaga = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridItensCompra)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Location = new System.Drawing.Point(1081, 9);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(31, 25);
            this.BtnClose.TabIndex = 36;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtSubTotal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtObserv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtTotalUni);
            this.groupBox1.Controls.Add(this.TxtProduto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtValorUni);
            this.groupBox1.Controls.Add(this.TxtQuant);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 341);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Compra";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(252, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "Sub Total";
            // 
            // TxtSubTotal
            // 
            this.TxtSubTotal.BackColor = System.Drawing.Color.White;
            this.TxtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSubTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtSubTotal.Enabled = false;
            this.TxtSubTotal.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubTotal.Location = new System.Drawing.Point(257, 210);
            this.TxtSubTotal.Name = "TxtSubTotal";
            this.TxtSubTotal.Size = new System.Drawing.Size(227, 37);
            this.TxtSubTotal.TabIndex = 30;
            this.TxtSubTotal.Text = "0";
            this.TxtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSubTotal.TextChanged += new System.EventHandler(this.TxtSubTotal_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 22);
            this.label5.TabIndex = 31;
            this.label5.Text = "Observações";
            // 
            // TxtObserv
            // 
            this.TxtObserv.BackColor = System.Drawing.Color.White;
            this.TxtObserv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtObserv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtObserv.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObserv.Location = new System.Drawing.Point(11, 289);
            this.TxtObserv.Multiline = true;
            this.TxtObserv.Name = "TxtObserv";
            this.TxtObserv.Size = new System.Drawing.Size(473, 41);
            this.TxtObserv.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Total do Item";
            // 
            // TxtTotalUni
            // 
            this.TxtTotalUni.BackColor = System.Drawing.Color.White;
            this.TxtTotalUni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTotalUni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTotalUni.Enabled = false;
            this.TxtTotalUni.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalUni.Location = new System.Drawing.Point(11, 210);
            this.TxtTotalUni.Name = "TxtTotalUni";
            this.TxtTotalUni.Size = new System.Drawing.Size(226, 37);
            this.TxtTotalUni.TabIndex = 30;
            this.TxtTotalUni.Text = "0";
            this.TxtTotalUni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtTotalUni.TextChanged += new System.EventHandler(this.TxtTotalUni_TextChanged);
            // 
            // TxtProduto
            // 
            this.TxtProduto.BackColor = System.Drawing.Color.White;
            this.TxtProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtProduto.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProduto.FormattingEnabled = true;
            this.TxtProduto.Location = new System.Drawing.Point(11, 54);
            this.TxtProduto.Name = "TxtProduto";
            this.TxtProduto.Size = new System.Drawing.Size(473, 42);
            this.TxtProduto.TabIndex = 29;
            this.TxtProduto.SelectedValueChanged += new System.EventHandler(this.TxtProduto_SelectedValueChanged);
            this.TxtProduto.TextChanged += new System.EventHandler(this.TxtProduto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(252, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Valor Uni";
            // 
            // TxtValorUni
            // 
            this.TxtValorUni.BackColor = System.Drawing.Color.White;
            this.TxtValorUni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtValorUni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtValorUni.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorUni.Location = new System.Drawing.Point(256, 131);
            this.TxtValorUni.Name = "TxtValorUni";
            this.TxtValorUni.Size = new System.Drawing.Size(227, 37);
            this.TxtValorUni.TabIndex = 24;
            this.TxtValorUni.Text = "0";
            this.TxtValorUni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtValorUni.TextChanged += new System.EventHandler(this.TxtValorUni_TextChanged);
            this.TxtValorUni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorUni_KeyPress);
            // 
            // TxtQuant
            // 
            this.TxtQuant.BackColor = System.Drawing.Color.White;
            this.TxtQuant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtQuant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtQuant.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuant.Location = new System.Drawing.Point(11, 131);
            this.TxtQuant.Name = "TxtQuant";
            this.TxtQuant.Size = new System.Drawing.Size(227, 37);
            this.TxtQuant.TabIndex = 24;
            this.TxtQuant.Text = "1";
            this.TxtQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtQuant.TextChanged += new System.EventHandler(this.TxtQuant_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 22);
            this.label8.TabIndex = 23;
            this.label8.Text = "Quantidade";
            // 
            // GridItensCompra
            // 
            this.GridItensCompra.AllowUserToAddRows = false;
            this.GridItensCompra.AllowUserToDeleteRows = false;
            this.GridItensCompra.AllowUserToResizeColumns = false;
            this.GridItensCompra.AllowUserToResizeRows = false;
            this.GridItensCompra.BackgroundColor = System.Drawing.Color.White;
            this.GridItensCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridItensCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridItensCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridItensCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnProd,
            this.ColumnQuant,
            this.ColumnValUni,
            this.ColumnTotalUni,
            this.ColumnObser});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridItensCompra.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridItensCompra.Location = new System.Drawing.Point(516, 58);
            this.GridItensCompra.Name = "GridItensCompra";
            this.GridItensCompra.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridItensCompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridItensCompra.Size = new System.Drawing.Size(596, 537);
            this.GridItensCompra.TabIndex = 39;
            this.GridItensCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridItensCompra_CellClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "IDProd";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 5;
            // 
            // ColumnProd
            // 
            this.ColumnProd.HeaderText = "Produto";
            this.ColumnProd.Name = "ColumnProd";
            this.ColumnProd.ReadOnly = true;
            this.ColumnProd.Width = 220;
            // 
            // ColumnQuant
            // 
            this.ColumnQuant.HeaderText = "Quant";
            this.ColumnQuant.Name = "ColumnQuant";
            this.ColumnQuant.ReadOnly = true;
            this.ColumnQuant.Width = 90;
            // 
            // ColumnValUni
            // 
            this.ColumnValUni.HeaderText = "Valor Uni";
            this.ColumnValUni.Name = "ColumnValUni";
            this.ColumnValUni.ReadOnly = true;
            this.ColumnValUni.Width = 120;
            // 
            // ColumnTotalUni
            // 
            this.ColumnTotalUni.HeaderText = "Total Uni";
            this.ColumnTotalUni.Name = "ColumnTotalUni";
            this.ColumnTotalUni.ReadOnly = true;
            this.ColumnTotalUni.Width = 115;
            // 
            // ColumnObser
            // 
            this.ColumnObser.HeaderText = "Obs";
            this.ColumnObser.Name = "ColumnObser";
            this.ColumnObser.ReadOnly = true;
            this.ColumnObser.Width = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(501, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 29);
            this.label6.TabIndex = 40;
            this.label6.Text = "Venda";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Controls.Add(this.BtnSelectCliente);
            this.panel1.Controls.Add(this.BtnFinaliza);
            this.panel1.Controls.Add(this.BtnExcluir);
            this.panel1.Controls.Add(this.BtnIncluir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 601);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 61);
            this.panel1.TabIndex = 41;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnCancel
            // 
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.Image")));
            this.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancel.Location = new System.Drawing.Point(916, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(197, 55);
            this.BtnCancel.TabIndex = 36;
            this.BtnCancel.Text = "Cancelar (F5)";
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSelectCliente
            // 
            this.BtnSelectCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelectCliente.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelectCliente.ForeColor = System.Drawing.Color.White;
            this.BtnSelectCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnSelectCliente.Image")));
            this.BtnSelectCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSelectCliente.Location = new System.Drawing.Point(220, 3);
            this.BtnSelectCliente.Name = "BtnSelectCliente";
            this.BtnSelectCliente.Size = new System.Drawing.Size(250, 55);
            this.BtnSelectCliente.TabIndex = 37;
            this.BtnSelectCliente.Text = "Select. Cliente (F2)";
            this.BtnSelectCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSelectCliente.UseVisualStyleBackColor = true;
            this.BtnSelectCliente.Click += new System.EventHandler(this.BtnSelectCliente_Click);
            // 
            // BtnFinaliza
            // 
            this.BtnFinaliza.Enabled = false;
            this.BtnFinaliza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFinaliza.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinaliza.ForeColor = System.Drawing.Color.White;
            this.BtnFinaliza.Image = ((System.Drawing.Image)(resources.GetObject("BtnFinaliza.Image")));
            this.BtnFinaliza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFinaliza.Location = new System.Drawing.Point(12, 3);
            this.BtnFinaliza.Name = "BtnFinaliza";
            this.BtnFinaliza.Size = new System.Drawing.Size(191, 55);
            this.BtnFinaliza.TabIndex = 37;
            this.BtnFinaliza.Text = "Finalizar (F1)";
            this.BtnFinaliza.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFinaliza.UseVisualStyleBackColor = true;
            this.BtnFinaliza.Click += new System.EventHandler(this.BtnFinaliza_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.Color.White;
            this.BtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcluir.Image")));
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcluir.Location = new System.Drawing.Point(722, 3);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(176, 55);
            this.BtnExcluir.TabIndex = 38;
            this.BtnExcluir.Text = "Excluir (F4)";
            this.BtnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Enabled = false;
            this.BtnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIncluir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIncluir.ForeColor = System.Drawing.Color.White;
            this.BtnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("BtnIncluir.Image")));
            this.BtnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIncluir.Location = new System.Drawing.Point(535, 3);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(169, 55);
            this.BtnIncluir.TabIndex = 38;
            this.BtnIncluir.Text = "Incluir (F3)";
            this.BtnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.TxtValorParcelas);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TxtQuantParcelas);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtFormaPaga);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 403);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 192);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pagamento";
            // 
            // TxtValorParcelas
            // 
            this.TxtValorParcelas.BackColor = System.Drawing.Color.White;
            this.TxtValorParcelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtValorParcelas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtValorParcelas.Enabled = false;
            this.TxtValorParcelas.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorParcelas.Location = new System.Drawing.Point(256, 136);
            this.TxtValorParcelas.Name = "TxtValorParcelas";
            this.TxtValorParcelas.Size = new System.Drawing.Size(227, 34);
            this.TxtValorParcelas.TabIndex = 34;
            this.TxtValorParcelas.Text = "0";
            this.TxtValorParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(252, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 22);
            this.label10.TabIndex = 33;
            this.label10.Text = "Valor Parcelas";
            // 
            // TxtQuantParcelas
            // 
            this.TxtQuantParcelas.BackColor = System.Drawing.Color.White;
            this.TxtQuantParcelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtQuantParcelas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtQuantParcelas.Enabled = false;
            this.TxtQuantParcelas.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuantParcelas.Location = new System.Drawing.Point(11, 136);
            this.TxtQuantParcelas.Name = "TxtQuantParcelas";
            this.TxtQuantParcelas.Size = new System.Drawing.Size(226, 34);
            this.TxtQuantParcelas.TabIndex = 32;
            this.TxtQuantParcelas.Text = "1";
            this.TxtQuantParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtQuantParcelas.Click += new System.EventHandler(this.TxtQuantParcelas_Click);
            this.TxtQuantParcelas.TextChanged += new System.EventHandler(this.TxtQuantParcelas_TextChanged);
            this.TxtQuantParcelas.Enter += new System.EventHandler(this.TxtQuantParcelas_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 22);
            this.label9.TabIndex = 30;
            this.label9.Text = "Quant Parcelas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Forma de Pagamento";
            // 
            // TxtFormaPaga
            // 
            this.TxtFormaPaga.BackColor = System.Drawing.Color.White;
            this.TxtFormaPaga.Enabled = false;
            this.TxtFormaPaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtFormaPaga.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFormaPaga.FormattingEnabled = true;
            this.TxtFormaPaga.Items.AddRange(new object[] {
            "À Vista",
            "Parcelado",
            "Indefinido"});
            this.TxtFormaPaga.Location = new System.Drawing.Point(11, 60);
            this.TxtFormaPaga.Name = "TxtFormaPaga";
            this.TxtFormaPaga.Size = new System.Drawing.Size(471, 42);
            this.TxtFormaPaga.TabIndex = 29;
            this.TxtFormaPaga.TextChanged += new System.EventHandler(this.TxtFormaPaga_TextChanged);
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1124, 662);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GridItensCompra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.Venda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Venda_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridItensCompra)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSubTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtObserv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTotalUni;
        private System.Windows.Forms.ComboBox TxtProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtValorUni;
        private System.Windows.Forms.TextBox TxtQuant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView GridItensCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtValorParcelas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtQuantParcelas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox TxtFormaPaga;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnFinaliza;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.Button BtnSelectCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotalUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnObser;
    }
}