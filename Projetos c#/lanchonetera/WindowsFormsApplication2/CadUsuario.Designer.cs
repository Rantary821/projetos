namespace WindowsFormsApplication2
{
    partial class CadUsuario
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
            this.Panelcad = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.lblPassWrong = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnCad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckUpdateCliente = new System.Windows.Forms.CheckBox();
            this.CheckGoFichas = new System.Windows.Forms.CheckBox();
            this.CheckCadFornecedores = new System.Windows.Forms.CheckBox();
            this.CheckPagamentos = new System.Windows.Forms.CheckBox();
            this.CheckVender = new System.Windows.Forms.CheckBox();
            this.CheckDelCliente = new System.Windows.Forms.CheckBox();
            this.CheckGoEstoq = new System.Windows.Forms.CheckBox();
            this.CheckGoProdutos = new System.Windows.Forms.CheckBox();
            this.CheckCadCliente = new System.Windows.Forms.CheckBox();
            this.CheckSelectAll = new System.Windows.Forms.CheckBox();
            this.CheckCadFuncio = new System.Windows.Forms.CheckBox();
            this.CheckDelFuncio = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.PanelPerms = new System.Windows.Forms.Panel();
            this.Panelcad.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PanelPerms.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panelcad
            // 
            this.Panelcad.Controls.Add(this.label2);
            this.Panelcad.Controls.Add(this.label1);
            this.Panelcad.Controls.Add(this.TxtUsuario);
            this.Panelcad.Controls.Add(this.TxtSenha);
            this.Panelcad.Controls.Add(this.lblPassWrong);
            this.Panelcad.Controls.Add(this.BtnCancel);
            this.Panelcad.Controls.Add(this.BtnCad);
            this.Panelcad.Location = new System.Drawing.Point(12, 15);
            this.Panelcad.Name = "Panelcad";
            this.Panelcad.Size = new System.Drawing.Size(379, 75);
            this.Panelcad.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(31, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(31, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Usuario";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.TxtUsuario.Font = new System.Drawing.Font("Arial", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.Color.Black;
            this.TxtUsuario.Location = new System.Drawing.Point(35, 86);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(323, 52);
            this.TxtUsuario.TabIndex = 28;
            this.TxtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSenha_KeyDown);
            this.TxtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSenha_KeyPress);
            // 
            // TxtSenha
            // 
            this.TxtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.TxtSenha.Font = new System.Drawing.Font("Arial", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.ForeColor = System.Drawing.Color.Black;
            this.TxtSenha.Location = new System.Drawing.Point(35, 189);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(323, 52);
            this.TxtSenha.TabIndex = 29;
            this.TxtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSenha_KeyDown);
            this.TxtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSenha_KeyPress);
            // 
            // lblPassWrong
            // 
            this.lblPassWrong.AutoSize = true;
            this.lblPassWrong.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassWrong.ForeColor = System.Drawing.Color.Red;
            this.lblPassWrong.Location = new System.Drawing.Point(37, 251);
            this.lblPassWrong.Name = "lblPassWrong";
            this.lblPassWrong.Size = new System.Drawing.Size(215, 24);
            this.lblPassWrong.TabIndex = 32;
            this.lblPassWrong.Text = "Usuario já cadastrado";
            this.lblPassWrong.Visible = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Arial", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(217, 292);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(174, 52);
            this.BtnCancel.TabIndex = 30;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnCad
            // 
            this.BtnCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.BtnCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCad.Font = new System.Drawing.Font("Arial", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCad.ForeColor = System.Drawing.Color.White;
            this.BtnCad.Location = new System.Drawing.Point(12, 292);
            this.BtnCad.Name = "BtnCad";
            this.BtnCad.Size = new System.Drawing.Size(174, 52);
            this.BtnCad.TabIndex = 31;
            this.BtnCad.Text = "Cadastrar";
            this.BtnCad.UseVisualStyleBackColor = false;
            this.BtnCad.Click += new System.EventHandler(this.BtnCad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckCadFuncio);
            this.groupBox1.Controls.Add(this.CheckUpdateCliente);
            this.groupBox1.Controls.Add(this.CheckGoFichas);
            this.groupBox1.Controls.Add(this.CheckCadFornecedores);
            this.groupBox1.Controls.Add(this.CheckPagamentos);
            this.groupBox1.Controls.Add(this.CheckVender);
            this.groupBox1.Controls.Add(this.CheckDelCliente);
            this.groupBox1.Controls.Add(this.CheckGoEstoq);
            this.groupBox1.Controls.Add(this.CheckGoProdutos);
            this.groupBox1.Controls.Add(this.CheckCadCliente);
            this.groupBox1.Controls.Add(this.CheckSelectAll);
            this.groupBox1.Controls.Add(this.CheckDelFuncio);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.BtnFinalizar);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 385);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissões do Usuario";
            // 
            // CheckUpdateCliente
            // 
            this.CheckUpdateCliente.AutoSize = true;
            this.CheckUpdateCliente.Location = new System.Drawing.Point(12, 216);
            this.CheckUpdateCliente.Name = "CheckUpdateCliente";
            this.CheckUpdateCliente.Size = new System.Drawing.Size(238, 23);
            this.CheckUpdateCliente.TabIndex = 34;
            this.CheckUpdateCliente.Text = "Atualizar Dados de Clientes";
            this.CheckUpdateCliente.UseVisualStyleBackColor = true;
            this.CheckUpdateCliente.CheckedChanged += new System.EventHandler(this.CheckUpdateCliente_CheckedChanged);
            // 
            // CheckGoFichas
            // 
            this.CheckGoFichas.AutoSize = true;
            this.CheckGoFichas.Location = new System.Drawing.Point(12, 124);
            this.CheckGoFichas.Name = "CheckGoFichas";
            this.CheckGoFichas.Size = new System.Drawing.Size(162, 23);
            this.CheckGoFichas.TabIndex = 34;
            this.CheckGoFichas.Text = "Acesso as Fichas";
            this.CheckGoFichas.UseVisualStyleBackColor = true;
            this.CheckGoFichas.CheckedChanged += new System.EventHandler(this.CheckGoFichas_CheckedChanged);
            // 
            // CheckCadFornecedores
            // 
            this.CheckCadFornecedores.AutoSize = true;
            this.CheckCadFornecedores.Location = new System.Drawing.Point(12, 78);
            this.CheckCadFornecedores.Name = "CheckCadFornecedores";
            this.CheckCadFornecedores.Size = new System.Drawing.Size(214, 23);
            this.CheckCadFornecedores.TabIndex = 34;
            this.CheckCadFornecedores.Text = "Cadastrar Fornecedores";
            this.CheckCadFornecedores.UseVisualStyleBackColor = true;
            this.CheckCadFornecedores.CheckedChanged += new System.EventHandler(this.CheckCadFornecedores_CheckedChanged);
            // 
            // CheckPagamentos
            // 
            this.CheckPagamentos.AutoSize = true;
            this.CheckPagamentos.Location = new System.Drawing.Point(12, 285);
            this.CheckPagamentos.Name = "CheckPagamentos";
            this.CheckPagamentos.Size = new System.Drawing.Size(192, 23);
            this.CheckPagamentos.TabIndex = 34;
            this.CheckPagamentos.Text = "Receber Pagamentos";
            this.CheckPagamentos.UseVisualStyleBackColor = true;
            this.CheckPagamentos.CheckedChanged += new System.EventHandler(this.CheckPagamentos_CheckedChanged);
            // 
            // CheckVender
            // 
            this.CheckVender.AutoSize = true;
            this.CheckVender.Location = new System.Drawing.Point(12, 262);
            this.CheckVender.Name = "CheckVender";
            this.CheckVender.Size = new System.Drawing.Size(132, 23);
            this.CheckVender.TabIndex = 34;
            this.CheckVender.Text = "Fazer Vendas";
            this.CheckVender.UseVisualStyleBackColor = true;
            this.CheckVender.CheckedChanged += new System.EventHandler(this.CheckVender_CheckedChanged);
            // 
            // CheckDelCliente
            // 
            this.CheckDelCliente.AutoSize = true;
            this.CheckDelCliente.Location = new System.Drawing.Point(12, 239);
            this.CheckDelCliente.Name = "CheckDelCliente";
            this.CheckDelCliente.Size = new System.Drawing.Size(147, 23);
            this.CheckDelCliente.TabIndex = 34;
            this.CheckDelCliente.Text = "Excluir Clientes";
            this.CheckDelCliente.UseVisualStyleBackColor = true;
            this.CheckDelCliente.CheckedChanged += new System.EventHandler(this.CheckDelCliente_CheckedChanged);
            // 
            // CheckGoEstoq
            // 
            this.CheckGoEstoq.AutoSize = true;
            this.CheckGoEstoq.Location = new System.Drawing.Point(12, 147);
            this.CheckGoEstoq.Name = "CheckGoEstoq";
            this.CheckGoEstoq.Size = new System.Drawing.Size(174, 23);
            this.CheckGoEstoq.TabIndex = 34;
            this.CheckGoEstoq.Text = "Acesso ao estoque";
            this.CheckGoEstoq.UseVisualStyleBackColor = true;
            this.CheckGoEstoq.CheckedChanged += new System.EventHandler(this.CheckGoEstoq_CheckedChanged);
            // 
            // CheckGoProdutos
            // 
            this.CheckGoProdutos.AutoSize = true;
            this.CheckGoProdutos.Location = new System.Drawing.Point(12, 170);
            this.CheckGoProdutos.Name = "CheckGoProdutos";
            this.CheckGoProdutos.Size = new System.Drawing.Size(256, 23);
            this.CheckGoProdutos.TabIndex = 34;
            this.CheckGoProdutos.Text = "Utilizar a Entrada de Produtos";
            this.CheckGoProdutos.UseVisualStyleBackColor = true;
            this.CheckGoProdutos.CheckedChanged += new System.EventHandler(this.CheckGoProdutos_CheckedChanged);
            // 
            // CheckCadCliente
            // 
            this.CheckCadCliente.AutoSize = true;
            this.CheckCadCliente.Location = new System.Drawing.Point(12, 193);
            this.CheckCadCliente.Name = "CheckCadCliente";
            this.CheckCadCliente.Size = new System.Drawing.Size(169, 23);
            this.CheckCadCliente.TabIndex = 34;
            this.CheckCadCliente.Text = "Cadastrar Clientes";
            this.CheckCadCliente.UseVisualStyleBackColor = true;
            this.CheckCadCliente.CheckedChanged += new System.EventHandler(this.CheckCadCliente_CheckedChanged);
            // 
            // CheckSelectAll
            // 
            this.CheckSelectAll.AutoSize = true;
            this.CheckSelectAll.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckSelectAll.ForeColor = System.Drawing.Color.DimGray;
            this.CheckSelectAll.Location = new System.Drawing.Point(12, 18);
            this.CheckSelectAll.Name = "CheckSelectAll";
            this.CheckSelectAll.Size = new System.Drawing.Size(186, 26);
            this.CheckSelectAll.TabIndex = 34;
            this.CheckSelectAll.Text = "Selecionar todos";
            this.CheckSelectAll.UseVisualStyleBackColor = true;
            this.CheckSelectAll.CheckedChanged += new System.EventHandler(this.CheckSelectAll_CheckedChanged);
            // 
            // CheckCadFuncio
            // 
            this.CheckCadFuncio.AutoSize = true;
            this.CheckCadFuncio.Location = new System.Drawing.Point(12, 55);
            this.CheckCadFuncio.Name = "CheckCadFuncio";
            this.CheckCadFuncio.Size = new System.Drawing.Size(208, 23);
            this.CheckCadFuncio.TabIndex = 34;
            this.CheckCadFuncio.Text = "Cadastrar Funcionarios";
            this.CheckCadFuncio.UseVisualStyleBackColor = true;
            this.CheckCadFuncio.CheckedChanged += new System.EventHandler(this.CheckCadFuncio_CheckedChanged);
            // 
            // CheckDelFuncio
            // 
            this.CheckDelFuncio.AutoSize = true;
            this.CheckDelFuncio.Location = new System.Drawing.Point(12, 101);
            this.CheckDelFuncio.Name = "CheckDelFuncio";
            this.CheckDelFuncio.Size = new System.Drawing.Size(186, 23);
            this.CheckDelFuncio.TabIndex = 34;
            this.CheckDelFuncio.Text = "Excluir Funcionarios";
            this.CheckDelFuncio.UseVisualStyleBackColor = true;
            this.CheckDelFuncio.CheckedChanged += new System.EventHandler(this.CheckDelFuncio_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(202, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 52);
            this.button1.TabIndex = 32;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.BtnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFinalizar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinalizar.ForeColor = System.Drawing.Color.White;
            this.BtnFinalizar.Location = new System.Drawing.Point(8, 318);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(151, 52);
            this.BtnFinalizar.TabIndex = 33;
            this.BtnFinalizar.Text = "Finalizar ";
            this.BtnFinalizar.UseVisualStyleBackColor = false;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // PanelPerms
            // 
            this.PanelPerms.Controls.Add(this.groupBox1);
            this.PanelPerms.Location = new System.Drawing.Point(13, 12);
            this.PanelPerms.Name = "PanelPerms";
            this.PanelPerms.Size = new System.Drawing.Size(379, 389);
            this.PanelPerms.TabIndex = 35;
            // 
            // CadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(404, 398);
            this.Controls.Add(this.PanelPerms);
            this.Controls.Add(this.Panelcad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadUsuario";
            this.Load += new System.EventHandler(this.CadUsuario_Load);
            this.Panelcad.ResumeLayout(false);
            this.Panelcad.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PanelPerms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panelcad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label lblPassWrong;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnCad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel PanelPerms;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnFinalizar;
        private System.Windows.Forms.CheckBox CheckUpdateCliente;
        private System.Windows.Forms.CheckBox CheckGoFichas;
        private System.Windows.Forms.CheckBox CheckVender;
        private System.Windows.Forms.CheckBox CheckDelCliente;
        private System.Windows.Forms.CheckBox CheckGoEstoq;
        private System.Windows.Forms.CheckBox CheckGoProdutos;
        private System.Windows.Forms.CheckBox CheckCadCliente;
        private System.Windows.Forms.CheckBox CheckCadFuncio;
        private System.Windows.Forms.CheckBox CheckDelFuncio;
        private System.Windows.Forms.CheckBox CheckSelectAll;
        private System.Windows.Forms.CheckBox CheckCadFornecedores;
        private System.Windows.Forms.CheckBox CheckPagamentos;
    }
}