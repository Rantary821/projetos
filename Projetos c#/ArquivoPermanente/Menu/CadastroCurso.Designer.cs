namespace Menu
{
    partial class CadastroCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCurso));
            this.txtNomeCurso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rsp1 = new System.Windows.Forms.Label();
            this.btnExc = new System.Windows.Forms.Button();
            this.btnCad = new System.Windows.Forms.Button();
            this.btnCanc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridPesq = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPesq)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeCurso
            // 
            this.txtNomeCurso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCurso.Location = new System.Drawing.Point(6, 39);
            this.txtNomeCurso.MaxLength = 80;
            this.txtNomeCurso.Name = "txtNomeCurso";
            this.txtNomeCurso.Size = new System.Drawing.Size(287, 22);
            this.txtNomeCurso.TabIndex = 1;
            this.txtNomeCurso.Click += new System.EventHandler(this.txtNomeCurso_Click);
            this.txtNomeCurso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeCurso_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nome do Curso";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rsp1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNomeCurso);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Curso";
            // 
            // rsp1
            // 
            this.rsp1.AutoSize = true;
            this.rsp1.Location = new System.Drawing.Point(6, 73);
            this.rsp1.Name = "rsp1";
            this.rsp1.Size = new System.Drawing.Size(0, 16);
            this.rsp1.TabIndex = 9;
            // 
            // btnExc
            // 
            this.btnExc.Image = ((System.Drawing.Image)(resources.GetObject("btnExc.Image")));
            this.btnExc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExc.Location = new System.Drawing.Point(12, 116);
            this.btnExc.Name = "btnExc";
            this.btnExc.Size = new System.Drawing.Size(149, 49);
            this.btnExc.TabIndex = 6;
            this.btnExc.Text = "EXCLUIR";
            this.btnExc.UseVisualStyleBackColor = true;
            this.btnExc.Click += new System.EventHandler(this.btnExc_Click);
            // 
            // btnCad
            // 
            this.btnCad.Image = global::Menu.Properties.Resources._1472617455_check;
            this.btnCad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCad.Location = new System.Drawing.Point(167, 116);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(149, 104);
            this.btnCad.TabIndex = 3;
            this.btnCad.Text = "CADASTRAR";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // btnCanc
            // 
            this.btnCanc.Image = global::Menu.Properties.Resources._1472617526_17;
            this.btnCanc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCanc.Location = new System.Drawing.Point(12, 171);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(149, 49);
            this.btnCanc.TabIndex = 5;
            this.btnCanc.Text = "CANCELAR";
            this.btnCanc.UseVisualStyleBackColor = true;
            this.btnCanc.Click += new System.EventHandler(this.btnCanc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridPesq);
            this.groupBox2.Location = new System.Drawing.Point(322, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 214);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisar Curso";
            // 
            // dataGridPesq
            // 
            this.dataGridPesq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPesq.Location = new System.Drawing.Point(6, 21);
            this.dataGridPesq.Name = "dataGridPesq";
            this.dataGridPesq.Size = new System.Drawing.Size(453, 187);
            this.dataGridPesq.TabIndex = 0;
            this.dataGridPesq.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPesq_CellClick);
            // 
            // CadastroCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 227);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.btnCanc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CadastroCurso";
            this.Load += new System.EventHandler(this.CadastroCurso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPesq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCanc;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.TextBox txtNomeCurso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExc;
        private System.Windows.Forms.Label rsp1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridPesq;
    }
}