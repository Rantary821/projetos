namespace WindowsFormsApplication2
{
    partial class Pagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagamento));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtRua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtRg = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GridPagamento = new System.Windows.Forms.DataGridView();
            this.GroupPaga = new System.Windows.Forms.GroupBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnPagar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtValorPago = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDividaTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridCompras = new System.Windows.Forms.DataGridView();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPagamento)).BeginInit();
            this.GroupPaga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.TxtCpf);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtRg);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 120);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtRua);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtBairro);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtNumero);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(358, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 106);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "Rua";
            // 
            // TxtRua
            // 
            this.TxtRua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtRua.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRua.Location = new System.Drawing.Point(7, 75);
            this.TxtRua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRua.MaxLength = 13;
            this.TxtRua.Name = "TxtRua";
            this.TxtRua.Size = new System.Drawing.Size(98, 29);
            this.TxtRua.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "Bairro";
            // 
            // TxtBairro
            // 
            this.TxtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBairro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBairro.Location = new System.Drawing.Point(7, 29);
            this.TxtBairro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBairro.MaxLength = 100;
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(282, 29);
            this.TxtBairro.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Numero";
            // 
            // TxtNumero
            // 
            this.TxtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNumero.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.Location = new System.Drawing.Point(136, 75);
            this.TxtNumero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNumero.MaxLength = 13;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(76, 29);
            this.TxtNumero.TabIndex = 32;
            // 
            // TxtCpf
            // 
            this.TxtCpf.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCpf.Location = new System.Drawing.Point(184, 84);
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(165, 29);
            this.TxtCpf.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Rg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cpf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nome ";
            // 
            // TxtRg
            // 
            this.TxtRg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtRg.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRg.Location = new System.Drawing.Point(8, 84);
            this.TxtRg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRg.MaxLength = 13;
            this.TxtRg.Name = "TxtRg";
            this.TxtRg.Size = new System.Drawing.Size(165, 29);
            this.TxtRg.TabIndex = 18;
            // 
            // TxtNome
            // 
            this.TxtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(8, 38);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNome.MaxLength = 100;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(342, 29);
            this.TxtNome.TabIndex = 19;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GridPagamento);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(658, 163);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clientes com dividas";
            // 
            // GridPagamento
            // 
            this.GridPagamento.AllowUserToAddRows = false;
            this.GridPagamento.AllowUserToResizeColumns = false;
            this.GridPagamento.AllowUserToResizeRows = false;
            this.GridPagamento.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPagamento.Location = new System.Drawing.Point(6, 15);
            this.GridPagamento.Name = "GridPagamento";
            this.GridPagamento.Size = new System.Drawing.Size(646, 143);
            this.GridPagamento.TabIndex = 1;
            this.GridPagamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPagamento_CellDoubleClick);
            // 
            // GroupPaga
            // 
            this.GroupPaga.Controls.Add(this.BtnCancel);
            this.GroupPaga.Controls.Add(this.BtnPagar);
            this.GroupPaga.Controls.Add(this.label9);
            this.GroupPaga.Controls.Add(this.txtResult);
            this.GroupPaga.Controls.Add(this.TxtValorPago);
            this.GroupPaga.Controls.Add(this.label10);
            this.GroupPaga.Controls.Add(this.label8);
            this.GroupPaga.Controls.Add(this.TxtDividaTotal);
            this.GroupPaga.Controls.Add(this.label1);
            this.GroupPaga.Controls.Add(this.GridCompras);
            this.GroupPaga.Enabled = false;
            this.GroupPaga.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupPaga.Location = new System.Drawing.Point(12, 297);
            this.GroupPaga.Name = "GroupPaga";
            this.GroupPaga.Size = new System.Drawing.Size(658, 119);
            this.GroupPaga.TabIndex = 5;
            this.GroupPaga.TabStop = false;
            this.GroupPaga.Text = "Pagamento";
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Red;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.Image")));
            this.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancel.Location = new System.Drawing.Point(157, 78);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(110, 35);
            this.BtnCancel.TabIndex = 24;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnPagar
            // 
            this.BtnPagar.BackColor = System.Drawing.Color.Silver;
            this.BtnPagar.Enabled = false;
            this.BtnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPagar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPagar.Image = ((System.Drawing.Image)(resources.GetObject("BtnPagar.Image")));
            this.BtnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPagar.Location = new System.Drawing.Point(26, 78);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(110, 35);
            this.BtnPagar.TabIndex = 24;
            this.BtnPagar.Text = "Pagar";
            this.BtnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPagar.UseVisualStyleBackColor = false;
            this.BtnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(428, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "Compras a Prazo";
            // 
            // TxtValorPago
            // 
            this.TxtValorPago.Location = new System.Drawing.Point(108, 39);
            this.TxtValorPago.MaxLength = 10;
            this.TxtValorPago.Name = "TxtValorPago";
            this.TxtValorPago.Size = new System.Drawing.Size(86, 29);
            this.TxtValorPago.TabIndex = 4;
            this.TxtValorPago.TextChanged += new System.EventHandler(this.TxtValorPago_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "Valor Pago";
            // 
            // TxtDividaTotal
            // 
            this.TxtDividaTotal.Enabled = false;
            this.TxtDividaTotal.Location = new System.Drawing.Point(6, 39);
            this.TxtDividaTotal.Name = "TxtDividaTotal";
            this.TxtDividaTotal.Size = new System.Drawing.Size(86, 29);
            this.TxtDividaTotal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Divida Total";
            // 
            // GridCompras
            // 
            this.GridCompras.AllowUserToAddRows = false;
            this.GridCompras.AllowUserToDeleteRows = false;
            this.GridCompras.AllowUserToResizeColumns = false;
            this.GridCompras.AllowUserToResizeRows = false;
            this.GridCompras.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCompras.Enabled = false;
            this.GridCompras.Location = new System.Drawing.Point(300, 22);
            this.GridCompras.Name = "GridCompras";
            this.GridCompras.Size = new System.Drawing.Size(355, 95);
            this.GridCompras.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(210, 39);
            this.txtResult.MaxLength = 10;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(86, 29);
            this.txtResult.TabIndex = 4;
            this.txtResult.TextChanged += new System.EventHandler(this.TxtValorPago_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(206, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 22);
            this.label10.TabIndex = 3;
            this.label10.Text = "Restante";
            // 
            // Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(679, 460);
            this.Controls.Add(this.GroupPaga);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pagamento";
            this.Text = "Pagamento";
            this.Load += new System.EventHandler(this.Pagamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridPagamento)).EndInit();
            this.GroupPaga.ResumeLayout(false);
            this.GroupPaga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtRua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.MaskedTextBox TxtCpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtRg;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView GridPagamento;
        private System.Windows.Forms.GroupBox GroupPaga;
        private System.Windows.Forms.DataGridView GridCompras;
        private System.Windows.Forms.TextBox TxtDividaTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtValorPago;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnPagar;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label10;
    }
}