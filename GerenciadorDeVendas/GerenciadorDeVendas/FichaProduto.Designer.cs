namespace GerenciadorDeVendas
{
    partial class FichaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FichaProduto));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtUniVenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPrecoVenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtFornecedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPrecoCusto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtObser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtCodBusca = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtUniVenda);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TxtPrecoVenda);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TxtFornecedor);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.TxtPrecoCusto);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(358, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 250);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalhes";
            // 
            // TxtUniVenda
            // 
            this.TxtUniVenda.BackColor = System.Drawing.Color.White;
            this.TxtUniVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUniVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtUniVenda.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUniVenda.Location = new System.Drawing.Point(12, 199);
            this.TxtUniVenda.Name = "TxtUniVenda";
            this.TxtUniVenda.Size = new System.Drawing.Size(200, 28);
            this.TxtUniVenda.TabIndex = 20;
            this.TxtUniVenda.Text = "EX: KILO, LITRO";
            this.TxtUniVenda.TextChanged += new System.EventHandler(this.TxtUniVenda_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço de Venda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Unidade de Venda";
            // 
            // TxtPrecoVenda
            // 
            this.TxtPrecoVenda.BackColor = System.Drawing.Color.White;
            this.TxtPrecoVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPrecoVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPrecoVenda.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecoVenda.Location = new System.Drawing.Point(13, 122);
            this.TxtPrecoVenda.Name = "TxtPrecoVenda";
            this.TxtPrecoVenda.Size = new System.Drawing.Size(159, 28);
            this.TxtPrecoVenda.TabIndex = 3;
            this.TxtPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPrecoVenda.TextChanged += new System.EventHandler(this.TxtPrecoVenda_TextChanged);
            this.TxtPrecoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecoVenda_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Fornecedor";
            // 
            // TxtFornecedor
            // 
            this.TxtFornecedor.BackColor = System.Drawing.Color.White;
            this.TxtFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFornecedor.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFornecedor.Location = new System.Drawing.Point(13, 53);
            this.TxtFornecedor.Name = "TxtFornecedor";
            this.TxtFornecedor.Size = new System.Drawing.Size(377, 28);
            this.TxtFornecedor.TabIndex = 22;
            this.TxtFornecedor.TextChanged += new System.EventHandler(this.TxtFornecedor_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(208, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preço de Custo";
            // 
            // TxtPrecoCusto
            // 
            this.TxtPrecoCusto.BackColor = System.Drawing.Color.White;
            this.TxtPrecoCusto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPrecoCusto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPrecoCusto.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecoCusto.Location = new System.Drawing.Point(212, 122);
            this.TxtPrecoCusto.Name = "TxtPrecoCusto";
            this.TxtPrecoCusto.Size = new System.Drawing.Size(158, 28);
            this.TxtPrecoCusto.TabIndex = 8;
            this.TxtPrecoCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPrecoCusto.TextChanged += new System.EventHandler(this.TxtPrecoCusto_TextChanged);
            this.TxtPrecoCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecoCusto_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TxtObser);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtCategoria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(10, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 250);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
            // 
            // TxtObser
            // 
            this.TxtObser.BackColor = System.Drawing.Color.White;
            this.TxtObser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtObser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtObser.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObser.Location = new System.Drawing.Point(12, 122);
            this.TxtObser.Multiline = true;
            this.TxtObser.Name = "TxtObser";
            this.TxtObser.Size = new System.Drawing.Size(294, 35);
            this.TxtObser.TabIndex = 26;
            this.TxtObser.TextChanged += new System.EventHandler(this.TxtObser_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(8, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 22);
            this.label8.TabIndex = 25;
            this.label8.Text = "Observações";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(8, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 22);
            this.label9.TabIndex = 24;
            this.label9.Text = "Categoria";
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.BackColor = System.Drawing.Color.White;
            this.TxtCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtCategoria.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCategoria.FormattingEnabled = true;
            this.TxtCategoria.Location = new System.Drawing.Point(12, 199);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(294, 37);
            this.TxtCategoria.TabIndex = 23;
            this.TxtCategoria.SelectedIndexChanged += new System.EventHandler(this.TxtCategoria_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome ";
            // 
            // TxtNome
            // 
            this.TxtNome.BackColor = System.Drawing.Color.White;
            this.TxtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNome.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(12, 53);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(294, 28);
            this.TxtNome.TabIndex = 1;
            this.TxtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // TxtCodBusca
            // 
            this.TxtCodBusca.AutoSize = true;
            this.TxtCodBusca.BackColor = System.Drawing.Color.Transparent;
            this.TxtCodBusca.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodBusca.Location = new System.Drawing.Point(84, 76);
            this.TxtCodBusca.Name = "TxtCodBusca";
            this.TxtCodBusca.Size = new System.Drawing.Size(30, 32);
            this.TxtCodBusca.TabIndex = 24;
            this.TxtCodBusca.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Código de Busca";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(279, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 29);
            this.label10.TabIndex = 33;
            this.label10.Text = "Editar Produto";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Location = new System.Drawing.Point(735, 11);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(31, 25);
            this.BtnClose.TabIndex = 34;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Controls.Add(this.BtnAtualizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 65);
            this.panel1.TabIndex = 35;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.Image")));
            this.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancel.Location = new System.Drawing.Point(565, 7);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(198, 53);
            this.BtnCancel.TabIndex = 25;
            this.BtnCancel.Text = "Cancelar (F2)";
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.BtnAtualizar.Enabled = false;
            this.BtnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualizar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.ForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAtualizar.Image")));
            this.BtnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAtualizar.Location = new System.Drawing.Point(12, 7);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(198, 53);
            this.BtnAtualizar.TabIndex = 27;
            this.BtnAtualizar.Text = "Atualizar (F1)";
            this.BtnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // FichaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtCodBusca);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FichaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FichaProduto";
            this.Load += new System.EventHandler(this.FichaProduto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FichaProduto_KeyDown);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtUniVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPrecoVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtFornecedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPrecoCusto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox TxtCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label TxtCodBusca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.TextBox TxtObser;
        private System.Windows.Forms.Label label8;
    }
}