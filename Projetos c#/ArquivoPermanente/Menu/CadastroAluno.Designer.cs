namespace Menu
{
    partial class CadastroAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroAluno));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCanc = new System.Windows.Forms.Button();
            this.btnProx = new System.Windows.Forms.Button();
            this.btnAnt = new System.Windows.Forms.Button();
            this.btnCad = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtdescC = new System.Windows.Forms.ComboBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.txtPasta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCod = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radNc = new System.Windows.Forms.RadioButton();
            this.radC = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridPesq = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomeRg = new System.Windows.Forms.TextBox();
            this.comboNome = new System.Windows.Forms.TextBox();
            this.txtDataEnt = new System.Windows.Forms.TextBox();
            this.txtNumP = new System.Windows.Forms.TextBox();
            this.txtNomeA = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPesq)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1064, 457);
            this.tabControl1.TabIndex = 999;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.btnCanc);
            this.tabPage1.Controls.Add(this.btnProx);
            this.tabPage1.Controls.Add(this.btnAnt);
            this.tabPage1.Controls.Add(this.btnCad);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1056, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro Aluno";
            // 
            // btnCanc
            // 
            this.btnCanc.Image = global::Menu.Properties.Resources._1472617526_17;
            this.btnCanc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCanc.Location = new System.Drawing.Point(843, 175);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(207, 52);
            this.btnCanc.TabIndex = 9;
            this.btnCanc.Text = "CANCELAR";
            this.btnCanc.UseVisualStyleBackColor = true;
            this.btnCanc.Click += new System.EventHandler(this.btnCanc_Click);
            // 
            // btnProx
            // 
            this.btnProx.Enabled = false;
            this.btnProx.Image = ((System.Drawing.Image)(resources.GetObject("btnProx.Image")));
            this.btnProx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProx.Location = new System.Drawing.Point(843, 121);
            this.btnProx.Name = "btnProx";
            this.btnProx.Size = new System.Drawing.Size(207, 52);
            this.btnProx.TabIndex = 8;
            this.btnProx.Text = "PRÓXIMO";
            this.btnProx.UseVisualStyleBackColor = true;
            this.btnProx.Click += new System.EventHandler(this.btnProx_Click);
            // 
            // btnAnt
            // 
            this.btnAnt.Image = ((System.Drawing.Image)(resources.GetObject("btnAnt.Image")));
            this.btnAnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnt.Location = new System.Drawing.Point(843, 67);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(207, 52);
            this.btnAnt.TabIndex = 7;
            this.btnAnt.Text = "ANTERIOR";
            this.btnAnt.UseVisualStyleBackColor = true;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // btnCad
            // 
            this.btnCad.Image = global::Menu.Properties.Resources._1472617455_check;
            this.btnCad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCad.Location = new System.Drawing.Point(844, 14);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(207, 51);
            this.btnCad.TabIndex = 6;
            this.btnCad.Text = "CADASTRAR";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCod);
            this.groupBox2.Controls.Add(this.txtdescC);
            this.groupBox2.Controls.Add(this.txtRG);
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.txtPasta);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.txtData);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.labelCod);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(5, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(832, 253);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(9, 215);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(58, 22);
            this.txtCod.TabIndex = 11;
            // 
            // txtdescC
            // 
            this.txtdescC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtdescC.FormattingEnabled = true;
            this.txtdescC.Location = new System.Drawing.Point(71, 215);
            this.txtdescC.Name = "txtdescC";
            this.txtdescC.Size = new System.Drawing.Size(320, 24);
            this.txtdescC.TabIndex = 5;
            this.txtdescC.TextChanged += new System.EventHandler(this.txtdescC_TextChanged);
            this.txtdescC.Enter += new System.EventHandler(this.txtdescC_Enter);
            // 
            // txtRG
            // 
            this.txtRG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRG.Location = new System.Drawing.Point(9, 155);
            this.txtRG.MaxLength = 13;
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(284, 22);
            this.txtRG.TabIndex = 4;
            this.txtRG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRG_KeyPress);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(91, 332);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 9;
            // 
            // txtPasta
            // 
            this.txtPasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPasta.Enabled = false;
            this.txtPasta.Location = new System.Drawing.Point(9, 95);
            this.txtPasta.MaxLength = 99;
            this.txtPasta.Name = "txtPasta";
            this.txtPasta.Size = new System.Drawing.Size(284, 22);
            this.txtPasta.TabIndex = 2;
            this.txtPasta.TextChanged += new System.EventHandler(this.tabPage2_Click);
            this.txtPasta.Enter += new System.EventHandler(this.txtPasta_Enter_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nº da Pasta";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(9, 35);
            this.txtNome.MaxLength = 80;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(382, 22);
            this.txtNome.TabIndex = 1;
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(299, 95);
            this.txtData.Mask = "0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(47, 22);
            this.txtData.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ano";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Descrição do Curso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "RG";
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCod.Location = new System.Drawing.Point(407, 28);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(0, 24);
            this.labelCod.TabIndex = 999;
            this.labelCod.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radNc);
            this.groupBox1.Controls.Add(this.radC);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 87);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Situação do Aluno";
            // 
            // radNc
            // 
            this.radNc.AutoSize = true;
            this.radNc.Location = new System.Drawing.Point(9, 51);
            this.radNc.Name = "radNc";
            this.radNc.Size = new System.Drawing.Size(131, 20);
            this.radNc.TabIndex = 987;
            this.radNc.TabStop = true;
            this.radNc.Text = "Não Concluinte";
            this.radNc.UseVisualStyleBackColor = true;
            this.radNc.CheckedChanged += new System.EventHandler(this.radNc_CheckedChanged);
            // 
            // radC
            // 
            this.radC.AutoSize = true;
            this.radC.Location = new System.Drawing.Point(9, 23);
            this.radC.Name = "radC";
            this.radC.Size = new System.Drawing.Size(98, 20);
            this.radC.TabIndex = 98;
            this.radC.Text = "Concluinte";
            this.radC.UseVisualStyleBackColor = true;
            this.radC.CheckedChanged += new System.EventHandler(this.radC_CheckedChanged_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.dataGridPesq);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtNomeRg);
            this.tabPage2.Controls.Add(this.comboNome);
            this.tabPage2.Controls.Add(this.txtDataEnt);
            this.tabPage2.Controls.Add(this.txtNumP);
            this.tabPage2.Controls.Add(this.txtNomeA);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1056, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisa";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridPesq
            // 
            this.dataGridPesq.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridPesq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPesq.Location = new System.Drawing.Point(8, 115);
            this.dataGridPesq.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridPesq.Name = "dataGridPesq";
            this.dataGridPesq.Size = new System.Drawing.Size(1041, 306);
            this.dataGridPesq.TabIndex = 19;
            this.dataGridPesq.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPesq_CellContentClick);
            this.dataGridPesq.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPesq_CellDoubleClick);
            this.dataGridPesq.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridPesq_MouseDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "RG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nome do Curso";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(537, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Data de Entrada";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Número da Pasta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 7);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Nome do Aluno";
            // 
            // txtNomeRg
            // 
            this.txtNomeRg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeRg.Location = new System.Drawing.Point(8, 81);
            this.txtNomeRg.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeRg.MaxLength = 132;
            this.txtNomeRg.Name = "txtNomeRg";
            this.txtNomeRg.Size = new System.Drawing.Size(310, 22);
            this.txtNomeRg.TabIndex = 17;
            this.txtNomeRg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeRg_KeyDown);
            // 
            // comboNome
            // 
            this.comboNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.comboNome.Location = new System.Drawing.Point(326, 81);
            this.comboNome.Margin = new System.Windows.Forms.Padding(4);
            this.comboNome.Name = "comboNome";
            this.comboNome.Size = new System.Drawing.Size(203, 22);
            this.comboNome.TabIndex = 16;
            this.comboNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboNome_KeyDown);
            // 
            // txtDataEnt
            // 
            this.txtDataEnt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDataEnt.Location = new System.Drawing.Point(537, 30);
            this.txtDataEnt.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataEnt.Name = "txtDataEnt";
            this.txtDataEnt.Size = new System.Drawing.Size(203, 22);
            this.txtDataEnt.TabIndex = 16;
            this.txtDataEnt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDataEnt_KeyDown_1);
            // 
            // txtNumP
            // 
            this.txtNumP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumP.Location = new System.Drawing.Point(326, 30);
            this.txtNumP.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumP.Name = "txtNumP";
            this.txtNumP.Size = new System.Drawing.Size(203, 22);
            this.txtNumP.TabIndex = 16;
            this.txtNumP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumP_KeyDown);
            // 
            // txtNomeA
            // 
            this.txtNomeA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeA.Location = new System.Drawing.Point(8, 30);
            this.txtNomeA.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeA.MaxLength = 80;
            this.txtNomeA.Name = "txtNomeA";
            this.txtNomeA.Size = new System.Drawing.Size(310, 22);
            this.txtNomeA.TabIndex = 15;
            this.txtNomeA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeA_KeyDown_1);
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1068, 459);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroAluno";
            this.Load += new System.EventHandler(this.CadastroAluno_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPesq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCanc;
        private System.Windows.Forms.Button btnProx;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox txtPasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radNc;
        private System.Windows.Forms.RadioButton radC;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridPesq;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNumP;
        private System.Windows.Forms.TextBox txtNomeA;
        private System.Windows.Forms.TextBox txtNomeRg;
        private System.Windows.Forms.ComboBox txtdescC;
        private System.Windows.Forms.TextBox comboNome;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelCod;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDataEnt;
    }
}