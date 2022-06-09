namespace Menu_Principal
{
    partial class Email
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Email));
            this.TxtSubject = new System.Windows.Forms.TextBox();
            this.TxtReceiver = new System.Windows.Forms.TextBox();
            this.TxtMensagem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PassWord = new System.Windows.Forms.CheckBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmailID = new System.Windows.Forms.TextBox();
            this.lblErro2 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlEmailPadrao = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnChanceEmail = new System.Windows.Forms.Button();
            this.pnlPrincipal.SuspendLayout();
            this.pnlEmailPadrao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtSubject
            // 
            this.TxtSubject.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtSubject.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubject.Location = new System.Drawing.Point(14, 115);
            this.TxtSubject.Name = "TxtSubject";
            this.TxtSubject.Size = new System.Drawing.Size(446, 32);
            this.TxtSubject.TabIndex = 21;
            // 
            // TxtReceiver
            // 
            this.TxtReceiver.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtReceiver.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReceiver.Location = new System.Drawing.Point(14, 36);
            this.TxtReceiver.Name = "TxtReceiver";
            this.TxtReceiver.Size = new System.Drawing.Size(446, 32);
            this.TxtReceiver.TabIndex = 22;
            // 
            // TxtMensagem
            // 
            this.TxtMensagem.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtMensagem.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMensagem.Location = new System.Drawing.Point(14, 195);
            this.TxtMensagem.Multiline = true;
            this.TxtMensagem.Name = "TxtMensagem";
            this.TxtMensagem.Size = new System.Drawing.Size(446, 104);
            this.TxtMensagem.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Adicionar uma mensagem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Para";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(10, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 14);
            this.label8.TabIndex = 24;
            this.label8.Text = "Utilize uma conta Gmail para o email padrão!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 14);
            this.label7.TabIndex = 24;
            this.label7.Text = "Verifique seu email e senha para evitar erros.";
            // 
            // PassWord
            // 
            this.PassWord.AutoSize = true;
            this.PassWord.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWord.ForeColor = System.Drawing.Color.White;
            this.PassWord.Location = new System.Drawing.Point(345, 153);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(116, 20);
            this.PassWord.TabIndex = 3;
            this.PassWord.Text = "Mostrar senha";
            this.PassWord.UseVisualStyleBackColor = true;
            this.PassWord.CheckedChanged += new System.EventHandler(this.PassWord_CheckedChanged);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(14, 148);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(207, 18);
            this.lblErro.TabIndex = 22;
            this.lblErro.Text = "Preencha todos os campos!!";
            this.lblErro.Visible = false;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnConfirm.FlatAppearance.BorderSize = 0;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirm.ForeColor = System.Drawing.Color.White;
            this.BtnConfirm.Location = new System.Drawing.Point(13, 188);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(122, 45);
            this.BtnConfirm.TabIndex = 4;
            this.BtnConfirm.Text = "Confirmar";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSenha.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(13, 112);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(447, 29);
            this.txtSenha.TabIndex = 2;
            // 
            // txtEmailID
            // 
            this.txtEmailID.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEmailID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailID.Location = new System.Drawing.Point(13, 40);
            this.txtEmailID.Name = "txtEmailID";
            this.txtEmailID.Size = new System.Drawing.Size(447, 29);
            this.txtEmailID.TabIndex = 1;
            // 
            // lblErro2
            // 
            this.lblErro2.AutoSize = true;
            this.lblErro2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro2.ForeColor = System.Drawing.Color.Red;
            this.lblErro2.Location = new System.Drawing.Point(6, 339);
            this.lblErro2.Name = "lblErro2";
            this.lblErro2.Size = new System.Drawing.Size(207, 18);
            this.lblErro2.TabIndex = 23;
            this.lblErro2.Text = "Preencha todos os campos!!";
            this.lblErro2.Visible = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(236, 351);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(122, 45);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(63)))), ((int)(((byte)(39)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(364, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 45);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrincipal.Controls.Add(this.TxtSubject);
            this.pnlPrincipal.Controls.Add(this.TxtReceiver);
            this.pnlPrincipal.Controls.Add(this.TxtMensagem);
            this.pnlPrincipal.Controls.Add(this.label3);
            this.pnlPrincipal.Controls.Add(this.label2);
            this.pnlPrincipal.Controls.Add(this.label1);
            this.pnlPrincipal.Location = new System.Drawing.Point(6, 19);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(481, 317);
            this.pnlPrincipal.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Adicionar um assunto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Senha";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(488, 289);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(19, 14);
            this.lbl1.TabIndex = 25;
            this.lbl1.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Email ID";
            // 
            // pnlEmailPadrao
            // 
            this.pnlEmailPadrao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmailPadrao.Controls.Add(this.label8);
            this.pnlEmailPadrao.Controls.Add(this.label7);
            this.pnlEmailPadrao.Controls.Add(this.PassWord);
            this.pnlEmailPadrao.Controls.Add(this.lblErro);
            this.pnlEmailPadrao.Controls.Add(this.BtnConfirm);
            this.pnlEmailPadrao.Controls.Add(this.txtSenha);
            this.pnlEmailPadrao.Controls.Add(this.txtEmailID);
            this.pnlEmailPadrao.Controls.Add(this.label5);
            this.pnlEmailPadrao.Controls.Add(this.label6);
            this.pnlEmailPadrao.Location = new System.Drawing.Point(6, 19);
            this.pnlEmailPadrao.Name = "pnlEmailPadrao";
            this.pnlEmailPadrao.Size = new System.Drawing.Size(480, 317);
            this.pnlEmailPadrao.TabIndex = 13;
            this.pnlEmailPadrao.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 51);
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label9_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label9_MouseMove);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(289, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 34);
            this.label9.TabIndex = 81;
            this.label9.Text = "E-mail";
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label9_MouseDown);
            this.label9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label9_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 470);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label9_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label9_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlEmailPadrao);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.BtnChanceEmail);
            this.groupBox1.Controls.Add(this.lblErro2);
            this.groupBox1.Controls.Add(this.btnEnviar);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.pnlPrincipal);
            this.groupBox1.Location = new System.Drawing.Point(9, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 406);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // BtnChanceEmail
            // 
            this.BtnChanceEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(5)))));
            this.BtnChanceEmail.FlatAppearance.BorderSize = 0;
            this.BtnChanceEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChanceEmail.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChanceEmail.ForeColor = System.Drawing.Color.White;
            this.BtnChanceEmail.Location = new System.Drawing.Point(496, 44);
            this.BtnChanceEmail.Name = "BtnChanceEmail";
            this.BtnChanceEmail.Size = new System.Drawing.Size(140, 45);
            this.BtnChanceEmail.TabIndex = 5;
            this.BtnChanceEmail.Text = "Email padrão";
            this.BtnChanceEmail.UseVisualStyleBackColor = false;
            this.BtnChanceEmail.Click += new System.EventHandler(this.BtnChanceEmail_Click);
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 470);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Email";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email";
            this.Load += new System.EventHandler(this.Email_Load);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlEmailPadrao.ResumeLayout(false);
            this.pnlEmailPadrao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSubject;
        private System.Windows.Forms.TextBox TxtReceiver;
        private System.Windows.Forms.TextBox TxtMensagem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox PassWord;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmailID;
        private System.Windows.Forms.Label lblErro2;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlEmailPadrao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnChanceEmail;
    }
}