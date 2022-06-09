namespace ArquivoEtec
{
    partial class Pesquisa
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
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckDeletados = new System.Windows.Forms.CheckBox();
            this.TxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LblDel = new System.Windows.Forms.Label();
            this.LblNConclu = new System.Windows.Forms.Label();
            this.PicNConclu = new System.Windows.Forms.PictureBox();
            this.PicDel = new System.Windows.Forms.PictureBox();
            this.GridDisplay = new System.Windows.Forms.DataGridView();
            this.BtnClose = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicNConclu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridDisplay)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ano";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckDeletados);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(520, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 68);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostrar Deletados";
            // 
            // CheckDeletados
            // 
            this.CheckDeletados.AutoSize = true;
            this.CheckDeletados.Location = new System.Drawing.Point(22, 43);
            this.CheckDeletados.Name = "CheckDeletados";
            this.CheckDeletados.Size = new System.Drawing.Size(53, 22);
            this.CheckDeletados.TabIndex = 0;
            this.CheckDeletados.Text = "Sim";
            this.CheckDeletados.UseVisualStyleBackColor = true;
            this.CheckDeletados.CheckedChanged += new System.EventHandler(this.CheckDeletados_CheckedChanged);
            // 
            // TxtCpf
            // 
            this.TxtCpf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCpf.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCpf.Location = new System.Drawing.Point(11, 85);
            this.TxtCpf.Mask = "000,000,000-00";
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(116, 19);
            this.TxtCpf.TabIndex = 16;
            this.TxtCpf.Click += new System.EventHandler(this.TxtCpf_Click);
            this.TxtCpf.Enter += new System.EventHandler(this.MaskedTextFocado_Enter);
            this.TxtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCpf_KeyPress);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(633, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "PESQUISA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label5_MouseDown);
            this.lblTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label5_MouseMove);
            this.lblTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label5_MouseUp);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1023, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 31);
            this.button3.TabIndex = 1;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(980, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 31);
            this.button4.TabIndex = 1;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(139, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cpf";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(142, 85);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(281, 19);
            this.txtNome.TabIndex = 14;
            this.txtNome.Enter += new System.EventHandler(this.TextBoxFocado_Enter);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtAno
            // 
            this.txtAno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAno.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.Location = new System.Drawing.Point(438, 85);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(67, 19);
            this.txtAno.TabIndex = 15;
            this.txtAno.TextChanged += new System.EventHandler(this.txtAno_TextChanged);
            this.txtAno.Enter += new System.EventHandler(this.TextBoxFocado_Enter);
            this.txtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAno_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.LblDel);
            this.panel4.Controls.Add(this.LblNConclu);
            this.panel4.Controls.Add(this.PicNConclu);
            this.panel4.Controls.Add(this.PicDel);
            this.panel4.Controls.Add(this.GridDisplay);
            this.panel4.Controls.Add(this.BtnClose);
            this.panel4.Controls.Add(this.button14);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.button15);
            this.panel4.Controls.Add(this.maskedTextBox5);
            this.panel4.Controls.Add(this.txtAno);
            this.panel4.Controls.Add(this.button16);
            this.panel4.Controls.Add(this.TxtCpf);
            this.panel4.Controls.Add(this.txtNome);
            this.panel4.Controls.Add(this.textBox11);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.textBox12);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.groupBox6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.lblTitulo);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(635, 447);
            this.panel4.TabIndex = 18;
            // 
            // LblDel
            // 
            this.LblDel.AutoSize = true;
            this.LblDel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDel.Location = new System.Drawing.Point(140, 38);
            this.LblDel.Name = "LblDel";
            this.LblDel.Size = new System.Drawing.Size(80, 18);
            this.LblDel.TabIndex = 24;
            this.LblDel.Text = "Deletados";
            this.LblDel.Visible = false;
            // 
            // LblNConclu
            // 
            this.LblNConclu.AutoSize = true;
            this.LblNConclu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNConclu.Location = new System.Drawing.Point(1, 38);
            this.LblNConclu.Name = "LblNConclu";
            this.LblNConclu.Size = new System.Drawing.Size(113, 18);
            this.LblNConclu.TabIndex = 23;
            this.LblNConclu.Text = "Não Concuinte";
            // 
            // PicNConclu
            // 
            this.PicNConclu.Location = new System.Drawing.Point(114, 37);
            this.PicNConclu.Name = "PicNConclu";
            this.PicNConclu.Size = new System.Drawing.Size(20, 19);
            this.PicNConclu.TabIndex = 22;
            this.PicNConclu.TabStop = false;
            // 
            // PicDel
            // 
            this.PicDel.Location = new System.Drawing.Point(220, 37);
            this.PicDel.Name = "PicDel";
            this.PicDel.Size = new System.Drawing.Size(20, 19);
            this.PicDel.TabIndex = 21;
            this.PicDel.TabStop = false;
            this.PicDel.Visible = false;
            // 
            // GridDisplay
            // 
            this.GridDisplay.AllowUserToAddRows = false;
            this.GridDisplay.AllowUserToDeleteRows = false;
            this.GridDisplay.AllowUserToResizeColumns = false;
            this.GridDisplay.AllowUserToResizeRows = false;
            this.GridDisplay.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.GridDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridDisplay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridDisplay.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.GridDisplay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GridDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridDisplay.Location = new System.Drawing.Point(0, 110);
            this.GridDisplay.MultiSelect = false;
            this.GridDisplay.Name = "GridDisplay";
            this.GridDisplay.ReadOnly = true;
            this.GridDisplay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GridDisplay.RowHeadersVisible = false;
            this.GridDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridDisplay.Size = new System.Drawing.Size(633, 335);
            this.GridDisplay.TabIndex = 20;
            this.GridDisplay.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDisplay_CellContentDoubleClick);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnClose.BackgroundImage = global::ArquivoEtec.Properties.Resources.cancel2;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(597, 5);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(34, 23);
            this.BtnClose.TabIndex = 18;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.button1_Click);
            this.BtnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.BtnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Transparent;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(-66, -165);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(112, 47);
            this.button14.TabIndex = 17;
            this.button14.Text = "Pesquisar";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label21.Location = new System.Drawing.Point(-462, -287);
            this.label21.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(635, 41);
            this.label21.TabIndex = 0;
            this.label21.Text = "Pesquisa";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(561, -283);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(38, 31);
            this.button15.TabIndex = 1;
            this.button15.Text = "X";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox5.Location = new System.Drawing.Point(-448, -129);
            this.maskedTextBox5.Mask = "000,000,000-00";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(106, 25);
            this.maskedTextBox5.TabIndex = 16;
            // 
            // button16
            // 
            this.button16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(518, -283);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(38, 31);
            this.button16.TabIndex = 1;
            this.button16.Text = "-";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(-66, -201);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(112, 22);
            this.textBox11.TabIndex = 15;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(-451, -220);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 18);
            this.label22.TabIndex = 11;
            this.label22.Text = "Nome";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(-451, -150);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 18);
            this.label23.TabIndex = 11;
            this.label23.Text = "CPF";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(-448, -198);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(321, 22);
            this.textBox12.TabIndex = 14;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(-69, -223);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 18);
            this.label24.TabIndex = 11;
            this.label24.Text = "ANO";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButton9);
            this.groupBox6.Controls.Add(this.radioButton10);
            this.groupBox6.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(52, -220);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(109, 115);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Mostrar Deletados";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Checked = true;
            this.radioButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton9.Location = new System.Drawing.Point(5, 82);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(55, 20);
            this.radioButton9.TabIndex = 12;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Não";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton10.Location = new System.Drawing.Point(5, 53);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(52, 20);
            this.radioButton10.TabIndex = 12;
            this.radioButton10.Text = "Sim";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(635, 447);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Pesquisa";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.Pesquisa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pesquisa_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pesquisa_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pesquisa_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicNConclu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridDisplay)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox TxtCpf;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.CheckBox CheckDeletados;
        private System.Windows.Forms.DataGridView GridDisplay;
        private System.Windows.Forms.Label LblDel;
        private System.Windows.Forms.Label LblNConclu;
        private System.Windows.Forms.PictureBox PicNConclu;
        private System.Windows.Forms.PictureBox PicDel;
    }
}