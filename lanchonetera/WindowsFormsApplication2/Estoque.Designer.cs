namespace WindowsFormsApplication2
{
    partial class Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque));
            this.dataProduto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQntEstoque = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.precoTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPuni = new System.Windows.Forms.TextBox();
            this.txtQntMax = new System.Windows.Forms.TextBox();
            this.txtQntMin = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataForn = new System.Windows.Forms.DataGridView();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.comboFornecedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataProduto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataForn)).BeginInit();
            this.SuspendLayout();
            // 
            // dataProduto
            // 
            this.dataProduto.AllowUserToAddRows = false;
            this.dataProduto.AllowUserToDeleteRows = false;
            this.dataProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProduto.Location = new System.Drawing.Point(0, 511);
            this.dataProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataProduto.Name = "dataProduto";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataProduto.Size = new System.Drawing.Size(1367, 501);
            this.dataProduto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Produto";
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeProd.Location = new System.Drawing.Point(11, 52);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(391, 29);
            this.txtNomeProd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quantidade em Estoque";
            // 
            // txtQntEstoque
            // 
            this.txtQntEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQntEstoque.Location = new System.Drawing.Point(11, 125);
            this.txtQntEstoque.Name = "txtQntEstoque";
            this.txtQntEstoque.Size = new System.Drawing.Size(168, 29);
            this.txtQntEstoque.TabIndex = 2;
            this.txtQntEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.precoTotal);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPuni);
            this.groupBox1.Controls.Add(this.txtQntMax);
            this.groupBox1.Controls.Add(this.txtQntMin);
            this.groupBox1.Controls.Add(this.txtQntEstoque);
            this.groupBox1.Controls.Add(this.txtNomeProd);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1367, 183);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUTO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Preço Unitario";
            // 
            // precoTotal
            // 
            this.precoTotal.AutoSize = true;
            this.precoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precoTotal.Location = new System.Drawing.Point(711, 52);
            this.precoTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.precoTotal.Name = "precoTotal";
            this.precoTotal.Size = new System.Drawing.Size(62, 29);
            this.precoTotal.TabIndex = 1;
            this.precoTotal.Text = "1,50";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(687, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Preço Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quantidade Maxima";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Quantidade Minima";
            // 
            // txtPuni
            // 
            this.txtPuni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPuni.Location = new System.Drawing.Point(464, 52);
            this.txtPuni.Name = "txtPuni";
            this.txtPuni.Size = new System.Drawing.Size(168, 29);
            this.txtPuni.TabIndex = 2;
            this.txtPuni.TextChanged += new System.EventHandler(this.txtPuni_TextChanged);
            this.txtPuni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQntMax_KeyPress);
            // 
            // txtQntMax
            // 
            this.txtQntMax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQntMax.Location = new System.Drawing.Point(464, 125);
            this.txtQntMax.Name = "txtQntMax";
            this.txtQntMax.Size = new System.Drawing.Size(168, 29);
            this.txtQntMax.TabIndex = 2;
            this.txtQntMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQntMax_KeyPress);
            // 
            // txtQntMin
            // 
            this.txtQntMin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQntMin.Location = new System.Drawing.Point(241, 125);
            this.txtQntMin.Name = "txtQntMin";
            this.txtQntMin.Size = new System.Drawing.Size(168, 29);
            this.txtQntMin.TabIndex = 2;
            this.txtQntMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQntMin_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.dataForn);
            this.groupBox2.Controls.Add(this.txtCnpj);
            this.groupBox2.Controls.Add(this.comboFornecedor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(0, 217);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1367, 220);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FORNECEDOR";
            // 
            // dataForn
            // 
            this.dataForn.BackgroundColor = System.Drawing.Color.Silver;
            this.dataForn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataForn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataForn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataForn.Location = new System.Drawing.Point(529, 13);
            this.dataForn.Name = "dataForn";
            this.dataForn.Size = new System.Drawing.Size(691, 205);
            this.dataForn.TabIndex = 3;
            this.dataForn.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataForn_CellDoubleClick);
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(11, 150);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(258, 29);
            this.txtCnpj.TabIndex = 3;
            // 
            // comboFornecedor
            // 
            this.comboFornecedor.FormattingEnabled = true;
            this.comboFornecedor.Location = new System.Drawing.Point(11, 66);
            this.comboFornecedor.Name = "comboFornecedor";
            this.comboFornecedor.Size = new System.Drawing.Size(395, 32);
            this.comboFornecedor.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "CPF/CNPJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Fornecedor";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(181, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 63);
            this.button2.TabIndex = 7;
            this.button2.Text = "Excluir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.BtnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCadastrar.Image")));
            this.BtnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCadastrar.Location = new System.Drawing.Point(1, 443);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(174, 63);
            this.BtnCadastrar.TabIndex = 5;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Red;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.Image")));
            this.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancel.Location = new System.Drawing.Point(340, 443);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(153, 63);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1296, 558);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.dataProduto);
            this.Controls.Add(this.BtnCancel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Estoque";
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dataProduto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataForn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQntEstoque;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.ComboBox comboFornecedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataForn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQntMax;
        private System.Windows.Forms.TextBox txtQntMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label precoTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPuni;
    }
}