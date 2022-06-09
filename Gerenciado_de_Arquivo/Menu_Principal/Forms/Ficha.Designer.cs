namespace Menu_Principal
{
    partial class Ficha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ficha));
            this.TxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.BtnAtualiza = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtNasc = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CCanc = new System.Windows.Forms.Button();
            this.TCanc = new System.Windows.Forms.Button();
            this.ECanc = new System.Windows.Forms.Button();
            this.Mcel = new System.Windows.Forms.Button();
            this.Mtel = new System.Windows.Forms.Button();
            this.MEmail = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlArq = new System.Windows.Forms.Panel();
            this.LayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PicPerfil = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCam = new System.Windows.Forms.Button();
            this.BuscaFoto = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtRa = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.ComboBox();
            this.txtCel = new System.Windows.Forms.ComboBox();
            this.TxtSexo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtRg = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnApaga = new System.Windows.Forms.Button();
            this.BuscarImagens = new System.Windows.Forms.Button();
            this.btnImagens = new System.Windows.Forms.Button();
            this.BtnScam = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BuscaImagem = new System.Windows.Forms.OpenFileDialog();
            this.tipPicture = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.pnlArq.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPerfil)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtCpf
            // 
            this.TxtCpf.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCpf.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCpf.Location = new System.Drawing.Point(406, 169);
            this.TxtCpf.Mask = "000,000,000-00";
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(174, 25);
            this.TxtCpf.TabIndex = 8;
            this.TxtCpf.TextChanged += new System.EventHandler(this.TxtCpf_TextChanged);
            // 
            // BtnAtualiza
            // 
            this.BtnAtualiza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.BtnAtualiza.Enabled = false;
            this.BtnAtualiza.FlatAppearance.BorderSize = 0;
            this.BtnAtualiza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.BtnAtualiza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.BtnAtualiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualiza.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualiza.Location = new System.Drawing.Point(815, 218);
            this.BtnAtualiza.Name = "BtnAtualiza";
            this.BtnAtualiza.Size = new System.Drawing.Size(145, 32);
            this.BtnAtualiza.TabIndex = 12;
            this.BtnAtualiza.Text = "Atualizar Dados";
            this.BtnAtualiza.UseVisualStyleBackColor = false;
            this.BtnAtualiza.Click += new System.EventHandler(this.BtnAtualiza_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(606, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 19);
            this.label16.TabIndex = 25;
            this.label16.Text = "Celular";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(605, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 19);
            this.label15.TabIndex = 25;
            this.label15.Text = "Telefone";
            // 
            // TxtNasc
            // 
            this.TxtNasc.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtNasc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNasc.Location = new System.Drawing.Point(792, 57);
            this.TxtNasc.Mask = "00/00/0000";
            this.TxtNasc.Name = "TxtNasc";
            this.TxtNasc.Size = new System.Drawing.Size(153, 32);
            this.TxtNasc.TabIndex = 3;
            this.TxtNasc.TextChanged += new System.EventHandler(this.TxtNasc_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(788, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Nascimento";
            // 
            // CCanc
            // 
            this.CCanc.BackColor = System.Drawing.Color.Red;
            this.CCanc.FlatAppearance.BorderSize = 0;
            this.CCanc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CCanc.Location = new System.Drawing.Point(764, 71);
            this.CCanc.Name = "CCanc";
            this.CCanc.Size = new System.Drawing.Size(18, 15);
            this.CCanc.TabIndex = 95;
            this.CCanc.UseVisualStyleBackColor = false;
            this.CCanc.Visible = false;
            // 
            // TCanc
            // 
            this.TCanc.BackColor = System.Drawing.Color.Red;
            this.TCanc.FlatAppearance.BorderSize = 0;
            this.TCanc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TCanc.Location = new System.Drawing.Point(764, 126);
            this.TCanc.Name = "TCanc";
            this.TCanc.Size = new System.Drawing.Size(18, 15);
            this.TCanc.TabIndex = 94;
            this.TCanc.UseVisualStyleBackColor = false;
            this.TCanc.Visible = false;
            // 
            // ECanc
            // 
            this.ECanc.BackColor = System.Drawing.Color.Red;
            this.ECanc.FlatAppearance.BorderSize = 0;
            this.ECanc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ECanc.Location = new System.Drawing.Point(582, 126);
            this.ECanc.Name = "ECanc";
            this.ECanc.Size = new System.Drawing.Size(18, 15);
            this.ECanc.TabIndex = 93;
            this.ECanc.UseVisualStyleBackColor = false;
            this.ECanc.Visible = false;
            // 
            // Mcel
            // 
            this.Mcel.BackColor = System.Drawing.Color.Gray;
            this.Mcel.FlatAppearance.BorderSize = 0;
            this.Mcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mcel.Location = new System.Drawing.Point(764, 55);
            this.Mcel.Name = "Mcel";
            this.Mcel.Size = new System.Drawing.Size(18, 15);
            this.Mcel.TabIndex = 14;
            this.Mcel.UseVisualStyleBackColor = false;
            this.Mcel.Click += new System.EventHandler(this.Mcel_Click);
            // 
            // Mtel
            // 
            this.Mtel.BackColor = System.Drawing.Color.Gray;
            this.Mtel.FlatAppearance.BorderSize = 0;
            this.Mtel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mtel.Location = new System.Drawing.Point(764, 110);
            this.Mtel.Name = "Mtel";
            this.Mtel.Size = new System.Drawing.Size(18, 15);
            this.Mtel.TabIndex = 15;
            this.Mtel.UseVisualStyleBackColor = false;
            this.Mtel.Click += new System.EventHandler(this.Mtel_Click);
            // 
            // MEmail
            // 
            this.MEmail.BackColor = System.Drawing.Color.Gray;
            this.MEmail.FlatAppearance.BorderSize = 0;
            this.MEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MEmail.Location = new System.Drawing.Point(582, 110);
            this.MEmail.Name = "MEmail";
            this.MEmail.Size = new System.Drawing.Size(18, 15);
            this.MEmail.TabIndex = 13;
            this.MEmail.UseVisualStyleBackColor = false;
            this.MEmail.Click += new System.EventHandler(this.MEmail_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pnlArq);
            this.panel3.Location = new System.Drawing.Point(15, 288);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(910, 299);
            this.panel3.TabIndex = 60;
            // 
            // pnlArq
            // 
            this.pnlArq.BackColor = System.Drawing.Color.Transparent;
            this.pnlArq.Controls.Add(this.LayoutPanel);
            this.pnlArq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlArq.Location = new System.Drawing.Point(0, 0);
            this.pnlArq.Name = "pnlArq";
            this.pnlArq.Size = new System.Drawing.Size(908, 297);
            this.pnlArq.TabIndex = 58;
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.AutoScroll = true;
            this.LayoutPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.Size = new System.Drawing.Size(908, 297);
            this.LayoutPanel.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(405, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 34);
            this.label9.TabIndex = 57;
            this.label9.Text = "Ficha Pessoal";
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label9_MouseDown);
            this.label9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label9_MouseMove);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.PicPerfil);
            this.groupBox3.Location = new System.Drawing.Point(11, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 183);
            this.groupBox3.TabIndex = 89;
            this.groupBox3.TabStop = false;
            // 
            // PicPerfil
            // 
            this.PicPerfil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PicPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicPerfil.BackgroundImage")));
            this.PicPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicPerfil.Location = new System.Drawing.Point(2, 11);
            this.PicPerfil.Name = "PicPerfil";
            this.PicPerfil.Size = new System.Drawing.Size(170, 170);
            this.PicPerfil.TabIndex = 23;
            this.PicPerfil.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(190, 90);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 19);
            this.label17.TabIndex = 9;
            this.label17.Text = "E-Mail";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CCanc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TCanc);
            this.groupBox1.Controls.Add(this.ECanc);
            this.groupBox1.Controls.Add(this.Mcel);
            this.groupBox1.Controls.Add(this.Mtel);
            this.groupBox1.Controls.Add(this.MEmail);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.TxtCpf);
            this.groupBox1.Controls.Add(this.BtnAtualiza);
            this.groupBox1.Controls.Add(this.btnCam);
            this.groupBox1.Controls.Add(this.BuscaFoto);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.TxtNasc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.TxtRa);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.txtCel);
            this.groupBox1.Controls.Add(this.TxtSexo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtRg);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(15, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(966, 256);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // btnCam
            // 
            this.btnCam.BackColor = System.Drawing.Color.Transparent;
            this.btnCam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCam.BackgroundImage")));
            this.btnCam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCam.FlatAppearance.BorderSize = 0;
            this.btnCam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCam.Location = new System.Drawing.Point(103, 198);
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(54, 52);
            this.btnCam.TabIndex = 11;
            this.btnCam.UseVisualStyleBackColor = false;
            this.btnCam.Click += new System.EventHandler(this.btnCam_Click);
            // 
            // BuscaFoto
            // 
            this.BuscaFoto.BackColor = System.Drawing.Color.Transparent;
            this.BuscaFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuscaFoto.BackgroundImage")));
            this.BuscaFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BuscaFoto.FlatAppearance.BorderSize = 0;
            this.BuscaFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscaFoto.Location = new System.Drawing.Point(34, 198);
            this.BuscaFoto.Name = "BuscaFoto";
            this.BuscaFoto.Size = new System.Drawing.Size(54, 54);
            this.BuscaFoto.TabIndex = 10;
            this.BuscaFoto.UseVisualStyleBackColor = false;
            this.BuscaFoto.Click += new System.EventHandler(this.BuscaFoto_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(191, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 19);
            this.label14.TabIndex = 9;
            this.label14.Text = "Nome";
            // 
            // TxtRa
            // 
            this.TxtRa.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtRa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtRa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtRa.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRa.Location = new System.Drawing.Point(609, 169);
            this.TxtRa.Name = "TxtRa";
            this.TxtRa.Size = new System.Drawing.Size(154, 25);
            this.TxtRa.TabIndex = 9;
            this.TxtRa.TextChanged += new System.EventHandler(this.TxtRa_TextChanged);
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(194, 57);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(386, 25);
            this.TxtName.TabIndex = 1;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(605, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "RA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(191, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 19);
            this.label13.TabIndex = 15;
            this.label13.Text = "Rg";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.FormattingEnabled = true;
            this.txtEmail.Location = new System.Drawing.Point(194, 112);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(386, 32);
            this.txtEmail.TabIndex = 4;
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtTel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.FormattingEnabled = true;
            this.txtTel.Location = new System.Drawing.Point(609, 112);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(153, 32);
            this.txtTel.TabIndex = 5;
            // 
            // txtCel
            // 
            this.txtCel.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCel.FormattingEnabled = true;
            this.txtCel.Location = new System.Drawing.Point(609, 57);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(153, 32);
            this.txtCel.TabIndex = 2;
            // 
            // TxtSexo
            // 
            this.TxtSexo.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtSexo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSexo.FormattingEnabled = true;
            this.TxtSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outros"});
            this.TxtSexo.Location = new System.Drawing.Point(792, 112);
            this.TxtSexo.Name = "TxtSexo";
            this.TxtSexo.Size = new System.Drawing.Size(153, 32);
            this.TxtSexo.TabIndex = 6;
            this.TxtSexo.SelectedIndexChanged += new System.EventHandler(this.TxtSexo_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(403, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 19);
            this.label11.TabIndex = 13;
            this.label11.Text = "Cpf";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(788, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Sexo";
            // 
            // TxtRg
            // 
            this.TxtRg.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtRg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtRg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtRg.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRg.Location = new System.Drawing.Point(194, 169);
            this.TxtRg.Name = "TxtRg";
            this.TxtRg.Size = new System.Drawing.Size(174, 25);
            this.TxtRg.TabIndex = 7;
            this.TxtRg.TextChanged += new System.EventHandler(this.TxtRg_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 659);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label9_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label9_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 51);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label9_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label9_MouseMove);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnApaga);
            this.groupBox2.Controls.Add(this.BuscarImagens);
            this.groupBox2.Controls.Add(this.btnImagens);
            this.groupBox2.Controls.Add(this.BtnScam);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Location = new System.Drawing.Point(9, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(995, 599);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            // 
            // btnApaga
            // 
            this.btnApaga.BackColor = System.Drawing.Color.Transparent;
            this.btnApaga.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApaga.BackgroundImage")));
            this.btnApaga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnApaga.FlatAppearance.BorderSize = 0;
            this.btnApaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApaga.Location = new System.Drawing.Point(934, 467);
            this.btnApaga.Name = "btnApaga";
            this.btnApaga.Size = new System.Drawing.Size(51, 50);
            this.btnApaga.TabIndex = 18;
            this.btnApaga.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnApaga.UseVisualStyleBackColor = false;
            this.btnApaga.Click += new System.EventHandler(this.btnApaga_Click);
            // 
            // BuscarImagens
            // 
            this.BuscarImagens.BackColor = System.Drawing.Color.Transparent;
            this.BuscarImagens.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuscarImagens.BackgroundImage")));
            this.BuscarImagens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BuscarImagens.FlatAppearance.BorderSize = 0;
            this.BuscarImagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarImagens.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarImagens.ForeColor = System.Drawing.Color.White;
            this.BuscarImagens.Location = new System.Drawing.Point(934, 304);
            this.BuscarImagens.Name = "BuscarImagens";
            this.BuscarImagens.Size = new System.Drawing.Size(51, 49);
            this.BuscarImagens.TabIndex = 16;
            this.BuscarImagens.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarImagens.UseVisualStyleBackColor = false;
            this.BuscarImagens.Click += new System.EventHandler(this.BuscarImagens_Click);
            // 
            // btnImagens
            // 
            this.btnImagens.BackColor = System.Drawing.Color.Transparent;
            this.btnImagens.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImagens.BackgroundImage")));
            this.btnImagens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImagens.FlatAppearance.BorderSize = 0;
            this.btnImagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagens.Location = new System.Drawing.Point(935, 543);
            this.btnImagens.Name = "btnImagens";
            this.btnImagens.Size = new System.Drawing.Size(50, 43);
            this.btnImagens.TabIndex = 19;
            this.btnImagens.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImagens.UseVisualStyleBackColor = false;
            this.btnImagens.Click += new System.EventHandler(this.btnImagens_Click);
            // 
            // BtnScam
            // 
            this.BtnScam.BackColor = System.Drawing.Color.Transparent;
            this.BtnScam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnScam.BackgroundImage")));
            this.BtnScam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnScam.FlatAppearance.BorderSize = 0;
            this.BtnScam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScam.Location = new System.Drawing.Point(934, 382);
            this.BtnScam.Name = "BtnScam";
            this.BtnScam.Size = new System.Drawing.Size(51, 48);
            this.BtnScam.TabIndex = 17;
            this.BtnScam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnScam.UseVisualStyleBackColor = false;
            this.BtnScam.Click += new System.EventHandler(this.BtnScam_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Transparent;
            this.BtnClose.Location = new System.Drawing.Point(960, 11);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.TabIndex = 53;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BuscaImagem
            // 
            this.BuscaImagem.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(282, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "ctrl + c = Webcam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(181, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "ctrl + F = Add Foto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(891, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 96;
            this.label3.Text = "F5 = Atualiza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(937, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 97;
            this.label4.Text = "ctrl + a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(937, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 98;
            this.label5.Text = "ctrl + p";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(937, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 99;
            this.label6.Text = "delete";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(946, 521);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 20);
            this.label12.TabIndex = 100;
            this.label12.Text = "→";
            // 
            // Ficha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 659);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Ficha";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ficha";
            this.Load += new System.EventHandler(this.Ficha_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ficha_KeyDown);
            this.panel3.ResumeLayout(false);
            this.pnlArq.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicPerfil)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApaga;
        private System.Windows.Forms.Button btnImagens;
        private System.Windows.Forms.MaskedTextBox TxtCpf;
        private System.Windows.Forms.Button BtnAtualiza;
        private System.Windows.Forms.Button btnCam;
        private System.Windows.Forms.Button BuscaFoto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox TxtNasc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BuscarImagens;
        private System.Windows.Forms.Button BtnScam;
        private System.Windows.Forms.Button CCanc;
        private System.Windows.Forms.Button TCanc;
        private System.Windows.Forms.Button ECanc;
        private System.Windows.Forms.Button Mcel;
        private System.Windows.Forms.Button Mtel;
        private System.Windows.Forms.Button MEmail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlArq;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox PicPerfil;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtRa;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox txtEmail;
        private System.Windows.Forms.ComboBox txtTel;
        private System.Windows.Forms.ComboBox txtCel;
        private System.Windows.Forms.ComboBox TxtSexo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtRg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog BuscaImagem;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanel;
        private System.Windows.Forms.ToolTip tipPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}