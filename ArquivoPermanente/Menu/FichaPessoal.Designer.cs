namespace Menu
{
    partial class FichaPessoal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FichaPessoal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdescC = new System.Windows.Forms.ComboBox();
            this.dataArqu = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItens = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPasta = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Comboconcluinte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExc = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnProx = new System.Windows.Forms.Button();
            this.btnAnt = new System.Windows.Forms.Button();
            this.btnCanc = new System.Windows.Forms.Button();
            this.btnAdc = new System.Windows.Forms.Button();
            this.idaluno = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.Label();
            this.BtnExcAluno = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataArqu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdescC);
            this.groupBox1.Controls.Add(this.dataArqu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtItens);
            this.groupBox1.Controls.Add(this.txtRg);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPasta);
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 441);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtdescC
            // 
            this.txtdescC.FormattingEnabled = true;
            this.txtdescC.Location = new System.Drawing.Point(264, 132);
            this.txtdescC.Name = "txtdescC";
            this.txtdescC.Size = new System.Drawing.Size(217, 24);
            this.txtdescC.TabIndex = 10;
            this.txtdescC.SelectedValueChanged += new System.EventHandler(this.txtdescC_SelectedValueChanged);
            this.txtdescC.TabIndexChanged += new System.EventHandler(this.txtdescC_TabIndexChanged);
            this.txtdescC.Click += new System.EventHandler(this.txtdescC_Click);
            this.txtdescC.Enter += new System.EventHandler(this.txtdescC_Enter);
            // 
            // dataArqu
            // 
            this.dataArqu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataArqu.Location = new System.Drawing.Point(6, 210);
            this.dataArqu.Name = "dataArqu";
            this.dataArqu.Size = new System.Drawing.Size(475, 169);
            this.dataArqu.TabIndex = 9;
            this.dataArqu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataArqu_CellClick);
            this.dataArqu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataArqu_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Entrada e saida de arquivos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Curso";
            // 
            // txtItens
            // 
            this.txtItens.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItens.Location = new System.Drawing.Point(6, 181);
            this.txtItens.MaxLength = 900;
            this.txtItens.Name = "txtItens";
            this.txtItens.Size = new System.Drawing.Size(475, 22);
            this.txtItens.TabIndex = 7;
            this.txtItens.TabStop = false;
            this.txtItens.Enter += new System.EventHandler(this.txtItens_Enter);
            this.txtItens.Leave += new System.EventHandler(this.txtItens_Leave);
            // 
            // txtRg
            // 
            this.txtRg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRg.Location = new System.Drawing.Point(10, 87);
            this.txtRg.MaxLength = 13;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(160, 22);
            this.txtRg.TabIndex = 2;
            this.txtRg.TextChanged += new System.EventHandler(this.txtRg_TextChanged);
            this.txtRg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRg_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nº da Pasta";
            // 
            // txtPasta
            // 
            this.txtPasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPasta.Location = new System.Drawing.Point(322, 87);
            this.txtPasta.MaxLength = 7;
            this.txtPasta.Name = "txtPasta";
            this.txtPasta.Size = new System.Drawing.Size(159, 22);
            this.txtPasta.TabIndex = 3;
            this.txtPasta.TextChanged += new System.EventHandler(this.txtPasta_TextChanged);
            this.txtPasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPasta_KeyPress);
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(10, 132);
            this.txtData.Mask = "0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(46, 22);
            this.txtData.TabIndex = 4;
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Comboconcluinte);
            this.groupBox2.Location = new System.Drawing.Point(6, 385);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 48);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Concluinte";
            // 
            // Comboconcluinte
            // 
            this.Comboconcluinte.FormattingEnabled = true;
            this.Comboconcluinte.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.Comboconcluinte.Location = new System.Drawing.Point(3, 18);
            this.Comboconcluinte.Name = "Comboconcluinte";
            this.Comboconcluinte.Size = new System.Drawing.Size(198, 24);
            this.Comboconcluinte.TabIndex = 8;
            this.Comboconcluinte.TextChanged += new System.EventHandler(this.Comboconcluinte_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "RG";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(10, 42);
            this.txtNome.MaxLength = 80;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(471, 22);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // btnExc
            // 
            this.btnExc.Enabled = false;
            this.btnExc.Image = ((System.Drawing.Image)(resources.GetObject("btnExc.Image")));
            this.btnExc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExc.Location = new System.Drawing.Point(506, 285);
            this.btnExc.Name = "btnExc";
            this.btnExc.Size = new System.Drawing.Size(155, 47);
            this.btnExc.TabIndex = 14;
            this.btnExc.Text = "ARQUIVO";
            this.btnExc.UseVisualStyleBackColor = true;
            this.btnExc.Click += new System.EventHandler(this.btnExc_Click);
            // 
            // btnAlt
            // 
            this.btnAlt.Enabled = false;
            this.btnAlt.Image = ((System.Drawing.Image)(resources.GetObject("btnAlt.Image")));
            this.btnAlt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlt.Location = new System.Drawing.Point(506, 20);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(155, 47);
            this.btnAlt.TabIndex = 10;
            this.btnAlt.Text = "ALTERAR";
            this.btnAlt.UseVisualStyleBackColor = true;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // btnProx
            // 
            this.btnProx.Image = ((System.Drawing.Image)(resources.GetObject("btnProx.Image")));
            this.btnProx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProx.Location = new System.Drawing.Point(506, 126);
            this.btnProx.Name = "btnProx";
            this.btnProx.Size = new System.Drawing.Size(155, 47);
            this.btnProx.TabIndex = 11;
            this.btnProx.Text = "PRÓXIMO";
            this.btnProx.UseVisualStyleBackColor = true;
            this.btnProx.Click += new System.EventHandler(this.btnProx_Click);
            // 
            // btnAnt
            // 
            this.btnAnt.Image = ((System.Drawing.Image)(resources.GetObject("btnAnt.Image")));
            this.btnAnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnt.Location = new System.Drawing.Point(506, 179);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(155, 47);
            this.btnAnt.TabIndex = 12;
            this.btnAnt.Text = "ANTERIOR";
            this.btnAnt.UseVisualStyleBackColor = true;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // btnCanc
            // 
            this.btnCanc.Image = global::Menu.Properties.Resources._1472617526_17;
            this.btnCanc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCanc.Location = new System.Drawing.Point(506, 338);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(155, 47);
            this.btnCanc.TabIndex = 15;
            this.btnCanc.Text = "CANCELAR";
            this.btnCanc.UseVisualStyleBackColor = true;
            this.btnCanc.Click += new System.EventHandler(this.btnCanc_Click);
            // 
            // btnAdc
            // 
            this.btnAdc.Enabled = false;
            this.btnAdc.Image = global::Menu.Properties.Resources._1472617455_check;
            this.btnAdc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdc.Location = new System.Drawing.Point(506, 232);
            this.btnAdc.Name = "btnAdc";
            this.btnAdc.Size = new System.Drawing.Size(155, 47);
            this.btnAdc.TabIndex = 13;
            this.btnAdc.Text = "ADCIONAR";
            this.btnAdc.UseVisualStyleBackColor = true;
            this.btnAdc.Click += new System.EventHandler(this.btnAdc_Click);
            // 
            // idaluno
            // 
            this.idaluno.AutoSize = true;
            this.idaluno.Location = new System.Drawing.Point(602, 438);
            this.idaluno.Name = "idaluno";
            this.idaluno.Size = new System.Drawing.Size(59, 16);
            this.idaluno.TabIndex = 19;
            this.idaluno.Text = "idaluno";
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Location = new System.Drawing.Point(525, 438);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(71, 16);
            this.codigo.TabIndex = 18;
            this.codigo.Text = "matricula";
            // 
            // BtnExcAluno
            // 
            this.BtnExcAluno.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcAluno.Image")));
            this.BtnExcAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcAluno.Location = new System.Drawing.Point(506, 73);
            this.BtnExcAluno.Name = "BtnExcAluno";
            this.BtnExcAluno.Size = new System.Drawing.Size(155, 47);
            this.BtnExcAluno.TabIndex = 20;
            this.BtnExcAluno.Text = "ALUNO";
            this.BtnExcAluno.UseVisualStyleBackColor = true;
            this.BtnExcAluno.Click += new System.EventHandler(this.BtnExcAluno_Click);
            // 
            // FichaPessoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(673, 463);
            this.Controls.Add(this.BtnExcAluno);
            this.Controls.Add(this.idaluno);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.btnCanc);
            this.Controls.Add(this.btnAdc);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.btnExc);
            this.Controls.Add(this.btnAlt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnProx);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FichaPessoal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ficha Pessoal";
            this.Load += new System.EventHandler(this.FichaPessoal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataArqu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPasta;
        private System.Windows.Forms.Button btnExc;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnProx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Button btnCanc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItens;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Button btnAdc;
        private System.Windows.Forms.DataGridView dataArqu;
        private System.Windows.Forms.ComboBox Comboconcluinte;
        private System.Windows.Forms.Label idaluno;
        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.ComboBox txtdescC;
        private System.Windows.Forms.Button BtnExcAluno;
    }
}