namespace WindowsFormsApplication2
{
    partial class Vendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtCpfPesq = new System.Windows.Forms.MaskedTextBox();
            this.LblSelecione = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CheckSemCadastro = new System.Windows.Forms.CheckBox();
            this.CheckComCadastro = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GridClientes = new System.Windows.Forms.DataGridView();
            this.TxtNomePesq = new System.Windows.Forms.TextBox();
            this.GroupCompra2 = new System.Windows.Forms.GroupBox();
            this.BtnRemover = new System.Windows.Forms.Button();
            this.TxtValorFinal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtQuantTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GridVendas = new System.Windows.Forms.DataGridView();
            this.ColumnProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDetalhes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupCompra1 = new System.Windows.Forms.GroupBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.TxtQuant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtValorTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPrecoUni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboProduto = new System.Windows.Forms.ComboBox();
            this.TxtDetalhes = new System.Windows.Forms.TextBox();
            this.GroupFormaPagemento = new System.Windows.Forms.GroupBox();
            this.CheckPrazo = new System.Windows.Forms.CheckBox();
            this.CheckVista = new System.Windows.Forms.CheckBox();
            this.BtnFinalizarCompra = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridClientes)).BeginInit();
            this.GroupCompra2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridVendas)).BeginInit();
            this.GroupCompra1.SuspendLayout();
            this.GroupFormaPagemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtCpfPesq);
            this.panel1.Controls.Add(this.LblSelecione);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.GridClientes);
            this.panel1.Controls.Add(this.TxtNomePesq);
            this.panel1.Controls.Add(this.GroupCompra2);
            this.panel1.Controls.Add(this.GroupCompra1);
            this.panel1.Controls.Add(this.GroupFormaPagemento);
            this.panel1.Controls.Add(this.BtnFinalizarCompra);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 451);
            this.panel1.TabIndex = 49;
            // 
            // TxtCpfPesq
            // 
            this.TxtCpfPesq.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCpfPesq.Location = new System.Drawing.Point(158, 396);
            this.TxtCpfPesq.Name = "TxtCpfPesq";
            this.TxtCpfPesq.Size = new System.Drawing.Size(98, 22);
            this.TxtCpfPesq.TabIndex = 59;
            this.TxtCpfPesq.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TxtCpfPesq_MaskInputRejected);
            // 
            // LblSelecione
            // 
            this.LblSelecione.AutoSize = true;
            this.LblSelecione.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSelecione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.LblSelecione.Location = new System.Drawing.Point(4, 118);
            this.LblSelecione.Name = "LblSelecione";
            this.LblSelecione.Size = new System.Drawing.Size(88, 41);
            this.LblSelecione.TabIndex = 56;
            this.LblSelecione.Text = "Sele";
            this.LblSelecione.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CheckSemCadastro);
            this.groupBox2.Controls.Add(this.CheckComCadastro);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 90);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // CheckSemCadastro
            // 
            this.CheckSemCadastro.AutoSize = true;
            this.CheckSemCadastro.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckSemCadastro.Location = new System.Drawing.Point(8, 46);
            this.CheckSemCadastro.Name = "CheckSemCadastro";
            this.CheckSemCadastro.Size = new System.Drawing.Size(192, 33);
            this.CheckSemCadastro.TabIndex = 1;
            this.CheckSemCadastro.Text = "Sem Cadastro";
            this.CheckSemCadastro.UseVisualStyleBackColor = true;
            this.CheckSemCadastro.CheckedChanged += new System.EventHandler(this.CheckSemCadastro_CheckedChanged);
            // 
            // CheckComCadastro
            // 
            this.CheckComCadastro.AutoSize = true;
            this.CheckComCadastro.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckComCadastro.Location = new System.Drawing.Point(8, 19);
            this.CheckComCadastro.Name = "CheckComCadastro";
            this.CheckComCadastro.Size = new System.Drawing.Size(195, 33);
            this.CheckComCadastro.TabIndex = 0;
            this.CheckComCadastro.Text = "Com Cadastro";
            this.CheckComCadastro.UseVisualStyleBackColor = true;
            this.CheckComCadastro.CheckedChanged += new System.EventHandler(this.CheckComCadastro_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 386);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 60;
            this.label9.Text = "Nome ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 24);
            this.label8.TabIndex = 54;
            this.label8.Text = "Clientes Cadastrados";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(157, 386);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 16);
            this.label10.TabIndex = 57;
            this.label10.Text = "Cpf";
            // 
            // GridClientes
            // 
            this.GridClientes.AllowUserToAddRows = false;
            this.GridClientes.AllowUserToDeleteRows = false;
            this.GridClientes.AllowUserToResizeColumns = false;
            this.GridClientes.AllowUserToResizeRows = false;
            this.GridClientes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridClientes.Enabled = false;
            this.GridClientes.Location = new System.Drawing.Point(-7, 180);
            this.GridClientes.Name = "GridClientes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridClientes.Size = new System.Drawing.Size(263, 205);
            this.GridClientes.TabIndex = 53;
            this.GridClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridClientes_CellClick);
            // 
            // TxtNomePesq
            // 
            this.TxtNomePesq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNomePesq.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomePesq.Location = new System.Drawing.Point(1, 396);
            this.TxtNomePesq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNomePesq.MaxLength = 100;
            this.TxtNomePesq.Name = "TxtNomePesq";
            this.TxtNomePesq.Size = new System.Drawing.Size(150, 22);
            this.TxtNomePesq.TabIndex = 58;
            this.TxtNomePesq.TextChanged += new System.EventHandler(this.TxtNomePesq_TextChanged);
            // 
            // GroupCompra2
            // 
            this.GroupCompra2.Controls.Add(this.BtnRemover);
            this.GroupCompra2.Controls.Add(this.TxtValorFinal);
            this.GroupCompra2.Controls.Add(this.label7);
            this.GroupCompra2.Controls.Add(this.TxtQuantTotal);
            this.GroupCompra2.Controls.Add(this.label6);
            this.GroupCompra2.Controls.Add(this.GridVendas);
            this.GroupCompra2.Enabled = false;
            this.GroupCompra2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupCompra2.Location = new System.Drawing.Point(257, 230);
            this.GroupCompra2.Name = "GroupCompra2";
            this.GroupCompra2.Size = new System.Drawing.Size(484, 181);
            this.GroupCompra2.TabIndex = 51;
            this.GroupCompra2.TabStop = false;
            // 
            // BtnRemover
            // 
            this.BtnRemover.BackColor = System.Drawing.Color.Gray;
            this.BtnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnRemover.Enabled = false;
            this.BtnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemover.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRemover.Location = new System.Drawing.Point(375, 131);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(103, 44);
            this.BtnRemover.TabIndex = 36;
            this.BtnRemover.Text = "Remover";
            this.BtnRemover.UseVisualStyleBackColor = false;
            this.BtnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // TxtValorFinal
            // 
            this.TxtValorFinal.Enabled = false;
            this.TxtValorFinal.Location = new System.Drawing.Point(62, 148);
            this.TxtValorFinal.Name = "TxtValorFinal";
            this.TxtValorFinal.Size = new System.Drawing.Size(107, 32);
            this.TxtValorFinal.TabIndex = 35;
            this.TxtValorFinal.Text = "0,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 24);
            this.label7.TabIndex = 34;
            this.label7.Text = "Valor Final";
            // 
            // TxtQuantTotal
            // 
            this.TxtQuantTotal.Enabled = false;
            this.TxtQuantTotal.Location = new System.Drawing.Point(204, 148);
            this.TxtQuantTotal.Name = "TxtQuantTotal";
            this.TxtQuantTotal.Size = new System.Drawing.Size(107, 32);
            this.TxtQuantTotal.TabIndex = 33;
            this.TxtQuantTotal.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 24);
            this.label6.TabIndex = 32;
            this.label6.Text = "Qaunt. Total";
            // 
            // GridVendas
            // 
            this.GridVendas.AllowUserToAddRows = false;
            this.GridVendas.AllowUserToDeleteRows = false;
            this.GridVendas.AllowUserToResizeColumns = false;
            this.GridVendas.AllowUserToResizeRows = false;
            this.GridVendas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridVendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProd,
            this.ColumnPreco,
            this.ColumnQuant,
            this.ColumnValTotal,
            this.ColumnDetalhes});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridVendas.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridVendas.Location = new System.Drawing.Point(3, 10);
            this.GridVendas.Name = "GridVendas";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridVendas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridVendas.Size = new System.Drawing.Size(479, 116);
            this.GridVendas.TabIndex = 30;
            this.GridVendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVendas_CellClick);
            // 
            // ColumnProd
            // 
            this.ColumnProd.HeaderText = "Produtos";
            this.ColumnProd.Name = "ColumnProd";
            this.ColumnProd.Width = 265;
            // 
            // ColumnPreco
            // 
            this.ColumnPreco.HeaderText = "Preço Uni";
            this.ColumnPreco.Name = "ColumnPreco";
            this.ColumnPreco.Width = 80;
            // 
            // ColumnQuant
            // 
            this.ColumnQuant.HeaderText = "Qaunt";
            this.ColumnQuant.Name = "ColumnQuant";
            this.ColumnQuant.Width = 78;
            // 
            // ColumnValTotal
            // 
            this.ColumnValTotal.HeaderText = "Valor Total";
            this.ColumnValTotal.Name = "ColumnValTotal";
            this.ColumnValTotal.Width = 80;
            // 
            // ColumnDetalhes
            // 
            this.ColumnDetalhes.HeaderText = "Detalhes";
            this.ColumnDetalhes.Name = "ColumnDetalhes";
            this.ColumnDetalhes.Width = 172;
            // 
            // GroupCompra1
            // 
            this.GroupCompra1.Controls.Add(this.BtnLimpar);
            this.GroupCompra1.Controls.Add(this.BtnAdicionar);
            this.GroupCompra1.Controls.Add(this.TxtQuant);
            this.GroupCompra1.Controls.Add(this.label3);
            this.GroupCompra1.Controls.Add(this.TxtValorTotal);
            this.GroupCompra1.Controls.Add(this.label5);
            this.GroupCompra1.Controls.Add(this.TxtPrecoUni);
            this.GroupCompra1.Controls.Add(this.label4);
            this.GroupCompra1.Controls.Add(this.label2);
            this.GroupCompra1.Controls.Add(this.label1);
            this.GroupCompra1.Controls.Add(this.ComboProduto);
            this.GroupCompra1.Controls.Add(this.TxtDetalhes);
            this.GroupCompra1.Enabled = false;
            this.GroupCompra1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupCompra1.Location = new System.Drawing.Point(257, 59);
            this.GroupCompra1.Name = "GroupCompra1";
            this.GroupCompra1.Size = new System.Drawing.Size(351, 170);
            this.GroupCompra1.TabIndex = 49;
            this.GroupCompra1.TabStop = false;
            this.GroupCompra1.Text = "Compras";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.Gray;
            this.BtnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpar.Location = new System.Drawing.Point(13, 120);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(135, 38);
            this.BtnLimpar.TabIndex = 16;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.BackColor = System.Drawing.Color.Gray;
            this.BtnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdicionar.Location = new System.Drawing.Point(192, 120);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(135, 38);
            this.BtnAdicionar.TabIndex = 15;
            this.BtnAdicionar.Text = "Adicionar Produto";
            this.BtnAdicionar.UseVisualStyleBackColor = false;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // TxtQuant
            // 
            this.TxtQuant.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuant.Location = new System.Drawing.Point(121, 84);
            this.TxtQuant.Name = "TxtQuant";
            this.TxtQuant.Size = new System.Drawing.Size(96, 32);
            this.TxtQuant.TabIndex = 14;
            this.TxtQuant.Text = "1";
            this.TxtQuant.TextChanged += new System.EventHandler(this.TxtQuant_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quantidade";
            // 
            // TxtValorTotal
            // 
            this.TxtValorTotal.Enabled = false;
            this.TxtValorTotal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorTotal.Location = new System.Drawing.Point(237, 84);
            this.TxtValorTotal.Name = "TxtValorTotal";
            this.TxtValorTotal.Size = new System.Drawing.Size(96, 32);
            this.TxtValorTotal.TabIndex = 12;
            this.TxtValorTotal.Text = "0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(237, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor Total";
            // 
            // TxtPrecoUni
            // 
            this.TxtPrecoUni.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecoUni.Location = new System.Drawing.Point(5, 84);
            this.TxtPrecoUni.Name = "TxtPrecoUni";
            this.TxtPrecoUni.Size = new System.Drawing.Size(96, 32);
            this.TxtPrecoUni.TabIndex = 10;
            this.TxtPrecoUni.TextChanged += new System.EventHandler(this.TxtPrecoUni_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Preço Uni.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Detalhes";
            // 
            // ComboProduto
            // 
            this.ComboProduto.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboProduto.FormattingEnabled = true;
            this.ComboProduto.Location = new System.Drawing.Point(5, 39);
            this.ComboProduto.Name = "ComboProduto";
            this.ComboProduto.Size = new System.Drawing.Size(175, 32);
            this.ComboProduto.TabIndex = 3;
            this.ComboProduto.TextChanged += new System.EventHandler(this.ComboProduto_TextChanged);
            this.ComboProduto.Enter += new System.EventHandler(this.ComboProduto_Enter);
            // 
            // TxtDetalhes
            // 
            this.TxtDetalhes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDetalhes.Location = new System.Drawing.Point(197, 38);
            this.TxtDetalhes.Name = "TxtDetalhes";
            this.TxtDetalhes.Size = new System.Drawing.Size(136, 32);
            this.TxtDetalhes.TabIndex = 2;
            // 
            // GroupFormaPagemento
            // 
            this.GroupFormaPagemento.Controls.Add(this.CheckPrazo);
            this.GroupFormaPagemento.Controls.Add(this.CheckVista);
            this.GroupFormaPagemento.Enabled = false;
            this.GroupFormaPagemento.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupFormaPagemento.Location = new System.Drawing.Point(257, 2);
            this.GroupFormaPagemento.Name = "GroupFormaPagemento";
            this.GroupFormaPagemento.Size = new System.Drawing.Size(351, 56);
            this.GroupFormaPagemento.TabIndex = 48;
            this.GroupFormaPagemento.TabStop = false;
            this.GroupFormaPagemento.Text = "Forma de Pagamento";
            // 
            // CheckPrazo
            // 
            this.CheckPrazo.AutoSize = true;
            this.CheckPrazo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckPrazo.Location = new System.Drawing.Point(169, 16);
            this.CheckPrazo.Name = "CheckPrazo";
            this.CheckPrazo.Size = new System.Drawing.Size(120, 33);
            this.CheckPrazo.TabIndex = 1;
            this.CheckPrazo.Text = "A Prazo";
            this.CheckPrazo.UseVisualStyleBackColor = true;
            this.CheckPrazo.CheckedChanged += new System.EventHandler(this.CheckPrazo_CheckedChanged);
            // 
            // CheckVista
            // 
            this.CheckVista.AutoSize = true;
            this.CheckVista.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckVista.Location = new System.Drawing.Point(51, 16);
            this.CheckVista.Name = "CheckVista";
            this.CheckVista.Size = new System.Drawing.Size(113, 33);
            this.CheckVista.TabIndex = 0;
            this.CheckVista.Text = "À Vista";
            this.CheckVista.UseVisualStyleBackColor = true;
            this.CheckVista.CheckedChanged += new System.EventHandler(this.CheckVista_CheckedChanged);
            // 
            // BtnFinalizarCompra
            // 
            this.BtnFinalizarCompra.BackColor = System.Drawing.Color.Gray;
            this.BtnFinalizarCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnFinalizarCompra.Enabled = false;
            this.BtnFinalizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFinalizarCompra.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinalizarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFinalizarCompra.Location = new System.Drawing.Point(614, 153);
            this.BtnFinalizarCompra.Name = "BtnFinalizarCompra";
            this.BtnFinalizarCompra.Size = new System.Drawing.Size(127, 70);
            this.BtnFinalizarCompra.TabIndex = 52;
            this.BtnFinalizarCompra.Text = "Finalizar Compra";
            this.BtnFinalizarCompra.UseVisualStyleBackColor = false;
            this.BtnFinalizarCompra.Click += new System.EventHandler(this.BtnFinalizarCompra_Click);
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1071, 604);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vendas";
            this.Text = "Vendas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridClientes)).EndInit();
            this.GroupCompra2.ResumeLayout(false);
            this.GroupCompra2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridVendas)).EndInit();
            this.GroupCompra1.ResumeLayout(false);
            this.GroupCompra1.PerformLayout();
            this.GroupFormaPagemento.ResumeLayout(false);
            this.GroupFormaPagemento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblSelecione;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox CheckSemCadastro;
        private System.Windows.Forms.CheckBox CheckComCadastro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView GridClientes;
        private System.Windows.Forms.GroupBox GroupCompra2;
        private System.Windows.Forms.Button BtnRemover;
        private System.Windows.Forms.TextBox TxtValorFinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtQuantTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView GridVendas;
        private System.Windows.Forms.GroupBox GroupCompra1;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.TextBox TxtQuant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtValorTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPrecoUni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboProduto;
        private System.Windows.Forms.TextBox TxtDetalhes;
        private System.Windows.Forms.GroupBox GroupFormaPagemento;
        private System.Windows.Forms.CheckBox CheckPrazo;
        private System.Windows.Forms.CheckBox CheckVista;
        private System.Windows.Forms.Button BtnFinalizarCompra;
        private System.Windows.Forms.MaskedTextBox TxtCpfPesq;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtNomePesq;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDetalhes;
    }
}