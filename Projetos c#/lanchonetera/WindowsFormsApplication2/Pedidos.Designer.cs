namespace WindowsFormsApplication2
{
    partial class Pedidos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GridPedidos = new System.Windows.Forms.DataGridView();
            this.TxtQuant = new System.Windows.Forms.TextBox();
            this.TxtValorTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboProduto = new System.Windows.Forms.ComboBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPrecoUni = new System.Windows.Forms.TextBox();
            this.BtnAdicionarAoPedido = new System.Windows.Forms.Button();
            this.BtnNewPedido = new System.Windows.Forms.Button();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.GridPedidos);
            this.groupBox1.Controls.Add(this.TxtQuant);
            this.groupBox1.Controls.Add(this.TxtValorTotal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ComboProduto);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtPrecoUni);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 465);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anotar Pedido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "Pedidos abertos";
            // 
            // GridPedidos
            // 
            this.GridPedidos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPedidos.Location = new System.Drawing.Point(1, 104);
            this.GridPedidos.Name = "GridPedidos";
            this.GridPedidos.Size = new System.Drawing.Size(610, 359);
            this.GridPedidos.TabIndex = 27;
            this.GridPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPedidos_CellClick);
            // 
            // TxtQuant
            // 
            this.TxtQuant.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuant.Location = new System.Drawing.Point(499, 30);
            this.TxtQuant.Name = "TxtQuant";
            this.TxtQuant.Size = new System.Drawing.Size(96, 32);
            this.TxtQuant.TabIndex = 26;
            this.TxtQuant.Text = "1";
            this.TxtQuant.TextChanged += new System.EventHandler(this.TxtQuant_TextChanged);
            // 
            // TxtValorTotal
            // 
            this.TxtValorTotal.Enabled = false;
            this.TxtValorTotal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorTotal.Location = new System.Drawing.Point(499, 72);
            this.TxtValorTotal.Name = "TxtValorTotal";
            this.TxtValorTotal.Size = new System.Drawing.Size(96, 32);
            this.TxtValorTotal.TabIndex = 24;
            this.TxtValorTotal.Text = "0,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(500, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Valor Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nome Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(501, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Quantidade";
            // 
            // ComboProduto
            // 
            this.ComboProduto.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboProduto.FormattingEnabled = true;
            this.ComboProduto.Location = new System.Drawing.Point(12, 43);
            this.ComboProduto.Name = "ComboProduto";
            this.ComboProduto.Size = new System.Drawing.Size(175, 32);
            this.ComboProduto.TabIndex = 18;
            this.ComboProduto.TextChanged += new System.EventHandler(this.ComboProduto_TextChanged);
            this.ComboProduto.Enter += new System.EventHandler(this.ComboProduto_Enter);
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(215, 43);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(136, 32);
            this.TxtNome.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Preço Uni.";
            // 
            // TxtPrecoUni
            // 
            this.TxtPrecoUni.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecoUni.Location = new System.Drawing.Point(381, 43);
            this.TxtPrecoUni.Name = "TxtPrecoUni";
            this.TxtPrecoUni.Size = new System.Drawing.Size(96, 32);
            this.TxtPrecoUni.TabIndex = 22;
            this.TxtPrecoUni.TextChanged += new System.EventHandler(this.TxtPrecoUni_TextChanged);
            // 
            // BtnAdicionarAoPedido
            // 
            this.BtnAdicionarAoPedido.BackColor = System.Drawing.Color.Gray;
            this.BtnAdicionarAoPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAdicionarAoPedido.Enabled = false;
            this.BtnAdicionarAoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionarAoPedido.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionarAoPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdicionarAoPedido.Location = new System.Drawing.Point(639, 191);
            this.BtnAdicionarAoPedido.Name = "BtnAdicionarAoPedido";
            this.BtnAdicionarAoPedido.Size = new System.Drawing.Size(153, 51);
            this.BtnAdicionarAoPedido.TabIndex = 27;
            this.BtnAdicionarAoPedido.Text = "Acrescentar á pedido";
            this.BtnAdicionarAoPedido.UseVisualStyleBackColor = false;
            this.BtnAdicionarAoPedido.Click += new System.EventHandler(this.BtnAdicionarAoPedido_Click);
            // 
            // BtnNewPedido
            // 
            this.BtnNewPedido.BackColor = System.Drawing.Color.Gray;
            this.BtnNewPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnNewPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewPedido.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNewPedido.Location = new System.Drawing.Point(639, 134);
            this.BtnNewPedido.Name = "BtnNewPedido";
            this.BtnNewPedido.Size = new System.Drawing.Size(153, 51);
            this.BtnNewPedido.TabIndex = 27;
            this.BtnNewPedido.Text = "Novo Pedido";
            this.BtnNewPedido.UseVisualStyleBackColor = false;
            this.BtnNewPedido.Click += new System.EventHandler(this.BtnNewPedido_Click);
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.BackColor = System.Drawing.Color.Gray;
            this.BtnFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnFinalizar.Enabled = false;
            this.BtnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFinalizar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFinalizar.Location = new System.Drawing.Point(639, 248);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(153, 51);
            this.BtnFinalizar.TabIndex = 27;
            this.BtnFinalizar.Text = "Finalizar Pedido";
            this.BtnFinalizar.UseVisualStyleBackColor = false;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(842, 518);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnNewPedido);
            this.Controls.Add(this.BtnFinalizar);
            this.Controls.Add(this.BtnAdicionarAoPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView GridPedidos;
        private System.Windows.Forms.TextBox TxtQuant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtValorTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPrecoUni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboProduto;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Button BtnAdicionarAoPedido;
        private System.Windows.Forms.Button BtnNewPedido;
        private System.Windows.Forms.Button BtnFinalizar;
    }
}