namespace WindowsFormsApplication2
{
    partial class Fornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fornecedor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.txtuf = new System.Windows.Forms.ComboBox();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataFornecedor = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.BtnAtualizar);
            this.groupBox1.Controls.Add(this.txtuf);
            this.groupBox1.Controls.Add(this.BtnExcluir);
            this.groupBox1.Controls.Add(this.BtnCadastrar);
            this.groupBox1.Controls.Add(this.BtnCancel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEnd);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCpf);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1098, 316);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.BackColor = System.Drawing.Color.Silver;
            this.BtnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualizar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAtualizar.Image")));
            this.BtnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAtualizar.Location = new System.Drawing.Point(889, 98);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(194, 60);
            this.BtnAtualizar.TabIndex = 12;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            // 
            // txtuf
            // 
            this.txtuf.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuf.FormattingEnabled = true;
            this.txtuf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PR",
            "PB",
            "PA",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.txtuf.Location = new System.Drawing.Point(460, 120);
            this.txtuf.Name = "txtuf";
            this.txtuf.Size = new System.Drawing.Size(55, 30);
            this.txtuf.TabIndex = 15;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.Silver;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcluir.Image")));
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcluir.Location = new System.Drawing.Point(889, 165);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(194, 60);
            this.BtnExcluir.TabIndex = 11;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcluir.UseVisualStyleBackColor = false;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.Silver;
            this.BtnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCadastrar.Image")));
            this.BtnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCadastrar.Location = new System.Drawing.Point(889, 31);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(194, 60);
            this.BtnCadastrar.TabIndex = 9;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Red;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.Image")));
            this.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancel.Location = new System.Drawing.Point(889, 232);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(194, 60);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(460, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "UF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(460, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Telefone";
            // 
            // txtEnd
            // 
            this.txtEnd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnd.Location = new System.Drawing.Point(460, 188);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(325, 32);
            this.txtEnd.TabIndex = 13;
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(13, 120);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(383, 32);
            this.txtCidade.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "CPF/CNPJ";
            // 
            // txtTel
            // 
            this.txtTel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(13, 188);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(383, 32);
            this.txtTel.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome";
            // 
            // txtCpf
            // 
            this.txtCpf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCpf.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(13, 256);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(383, 32);
            this.txtCpf.TabIndex = 13;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(13, 52);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(772, 32);
            this.txtNome.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataFornecedor);
            this.groupBox2.Location = new System.Drawing.Point(28, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1098, 257);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // dataFornecedor
            // 
            this.dataFornecedor.AllowUserToAddRows = false;
            this.dataFornecedor.AllowUserToDeleteRows = false;
            this.dataFornecedor.BackgroundColor = System.Drawing.Color.Gray;
            this.dataFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataFornecedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataFornecedor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataFornecedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFornecedor.Location = new System.Drawing.Point(3, 16);
            this.dataFornecedor.Name = "dataFornecedor";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataFornecedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.dataFornecedor.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataFornecedor.Size = new System.Drawing.Size(1092, 238);
            this.dataFornecedor.TabIndex = 0;
            // 
            // Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1304, 707);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fornecedor";
            this.Text = "Fornecedor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFornecedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.DataGridView dataFornecedor;
        private System.Windows.Forms.ComboBox txtuf;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnCancel;
    }
}