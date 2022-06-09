namespace BurnMedia
{
    partial class Gravar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gravar));
            this.devicesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.supportedMediaLabel = new System.Windows.Forms.Label();
            this.backgroundBurnWorker = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalSize = new System.Windows.Forms.Label();
            this.progressBarCapacity = new System.Windows.Forms.ProgressBar();
            this.buttonFormat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusProgressBar = new System.Windows.Forms.ProgressBar();
            this.labelStatusText = new System.Windows.Forms.Label();
            this.buttonBurn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelMediaType = new System.Windows.Forms.Label();
            this.buttonDetectMedia = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxVerification = new System.Windows.Forms.ComboBox();
            this.labelVerification = new System.Windows.Forms.Label();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRemoveFiles = new System.Windows.Forms.Button();
            this.checkBoxEject = new System.Windows.Forms.CheckBox();
            this.buttonAddFolders = new System.Windows.Forms.Button();
            this.checkBoxCloseMedia = new System.Windows.Forms.CheckBox();
            this.buttonAddFiles = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.checkBoxQuickFormat = new System.Windows.Forms.CheckBox();
            this.checkBoxEjectFormat = new System.Windows.Forms.CheckBox();
            this.formatProgressBar = new System.Windows.Forms.ProgressBar();
            this.labelFormatStatusText = new System.Windows.Forms.Label();
            this.backgroundFormatWorker = new System.ComponentModel.BackgroundWorker();
            this.PnlGravar = new System.Windows.Forms.Panel();
            this.PnlFormat = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateMidias = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnTabFormat = new System.Windows.Forms.Button();
            this.BtnTabGravar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PnlGravar.SuspendLayout();
            this.PnlFormat.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // devicesComboBox
            // 
            this.devicesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devicesComboBox.FormattingEnabled = true;
            this.devicesComboBox.Location = new System.Drawing.Point(15, 81);
            this.devicesComboBox.Name = "devicesComboBox";
            this.devicesComboBox.Size = new System.Drawing.Size(196, 26);
            this.devicesComboBox.TabIndex = 1;
            this.devicesComboBox.SelectedIndexChanged += new System.EventHandler(this.devicesComboBox_SelectedIndexChanged);
            this.devicesComboBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.devicesComboBox_Format);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(572, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Supported Media:";
            this.label1.Visible = false;
            // 
            // supportedMediaLabel
            // 
            this.supportedMediaLabel.Location = new System.Drawing.Point(669, 6);
            this.supportedMediaLabel.Name = "supportedMediaLabel";
            this.supportedMediaLabel.Size = new System.Drawing.Size(12, 16);
            this.supportedMediaLabel.TabIndex = 3;
            this.supportedMediaLabel.Visible = false;
            // 
            // backgroundBurnWorker
            // 
            this.backgroundBurnWorker.WorkerReportsProgress = true;
            this.backgroundBurnWorker.WorkerSupportsCancellation = true;
            this.backgroundBurnWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundBurnWorker_DoWork);
            this.backgroundBurnWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundBurnWorker_ProgressChanged);
            this.backgroundBurnWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundBurnWorker_RunWorkerCompleted);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All Files (*.*)|*.*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "0";
            // 
            // labelTotalSize
            // 
            this.labelTotalSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalSize.AutoSize = true;
            this.labelTotalSize.ForeColor = System.Drawing.Color.White;
            this.labelTotalSize.Location = new System.Drawing.Point(197, 73);
            this.labelTotalSize.Name = "labelTotalSize";
            this.labelTotalSize.Size = new System.Drawing.Size(31, 13);
            this.labelTotalSize.TabIndex = 7;
            this.labelTotalSize.Text = "Total";
            // 
            // progressBarCapacity
            // 
            this.progressBarCapacity.Location = new System.Drawing.Point(6, 92);
            this.progressBarCapacity.Name = "progressBarCapacity";
            this.progressBarCapacity.Size = new System.Drawing.Size(230, 12);
            this.progressBarCapacity.Step = 1;
            this.progressBarCapacity.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarCapacity.TabIndex = 8;
            // 
            // buttonFormat
            // 
            this.buttonFormat.FlatAppearance.BorderSize = 0;
            this.buttonFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFormat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFormat.ForeColor = System.Drawing.Color.White;
            this.buttonFormat.Location = new System.Drawing.Point(296, 118);
            this.buttonFormat.Name = "buttonFormat";
            this.buttonFormat.Size = new System.Drawing.Size(131, 29);
            this.buttonFormat.TabIndex = 10;
            this.buttonFormat.Text = "Formatar disco";
            this.buttonFormat.UseVisualStyleBackColor = true;
            this.buttonFormat.Click += new System.EventHandler(this.buttonFormat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.statusProgressBar);
            this.groupBox3.Controls.Add(this.labelStatusText);
            this.groupBox3.Controls.Add(this.buttonBurn);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(469, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 145);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Progresso";
            // 
            // statusProgressBar
            // 
            this.statusProgressBar.Location = new System.Drawing.Point(12, 64);
            this.statusProgressBar.Name = "statusProgressBar";
            this.statusProgressBar.Size = new System.Drawing.Size(224, 16);
            this.statusProgressBar.TabIndex = 8;
            // 
            // labelStatusText
            // 
            this.labelStatusText.ForeColor = System.Drawing.Color.White;
            this.labelStatusText.Location = new System.Drawing.Point(9, 16);
            this.labelStatusText.Name = "labelStatusText";
            this.labelStatusText.Size = new System.Drawing.Size(227, 45);
            this.labelStatusText.TabIndex = 7;
            this.labelStatusText.Text = "Status";
            this.labelStatusText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // buttonBurn
            // 
            this.buttonBurn.BackColor = System.Drawing.Color.Gray;
            this.buttonBurn.FlatAppearance.BorderSize = 0;
            this.buttonBurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBurn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.buttonBurn.Location = new System.Drawing.Point(73, 85);
            this.buttonBurn.Name = "buttonBurn";
            this.buttonBurn.Size = new System.Drawing.Size(106, 51);
            this.buttonBurn.TabIndex = 12;
            this.buttonBurn.Text = "Gravar\r\n(ENTER)";
            this.buttonBurn.UseVisualStyleBackColor = false;
            this.buttonBurn.Click += new System.EventHandler(this.buttonBurn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelMediaType);
            this.groupBox2.Controls.Add(this.buttonDetectMedia);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labelTotalSize);
            this.groupBox2.Controls.Add(this.progressBarCapacity);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(469, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 120);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selecionar Mídia";
            // 
            // labelMediaType
            // 
            this.labelMediaType.ForeColor = System.Drawing.Color.White;
            this.labelMediaType.Location = new System.Drawing.Point(133, 26);
            this.labelMediaType.Name = "labelMediaType";
            this.labelMediaType.Size = new System.Drawing.Size(102, 40);
            this.labelMediaType.TabIndex = 10;
            this.labelMediaType.Text = "0000000";
            // 
            // buttonDetectMedia
            // 
            this.buttonDetectMedia.BackColor = System.Drawing.Color.Gray;
            this.buttonDetectMedia.FlatAppearance.BorderSize = 0;
            this.buttonDetectMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetectMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetectMedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonDetectMedia.Location = new System.Drawing.Point(12, 20);
            this.buttonDetectMedia.Name = "buttonDetectMedia";
            this.buttonDetectMedia.Size = new System.Drawing.Size(118, 28);
            this.buttonDetectMedia.TabIndex = 11;
            this.buttonDetectMedia.Text = "Detectar Mídia";
            this.buttonDetectMedia.UseVisualStyleBackColor = false;
            this.buttonDetectMedia.Click += new System.EventHandler(this.buttonDetectMedia_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxVerification);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.labelVerification);
            this.groupBox1.Controls.Add(this.textBoxLabel);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonRemoveFiles);
            this.groupBox1.Controls.Add(this.checkBoxEject);
            this.groupBox1.Controls.Add(this.buttonAddFolders);
            this.groupBox1.Controls.Add(this.checkBoxCloseMedia);
            this.groupBox1.Controls.Add(this.buttonAddFiles);
            this.groupBox1.Controls.Add(this.listBoxFiles);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(7, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 296);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arquivos para gravar";
            // 
            // comboBoxVerification
            // 
            this.comboBoxVerification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVerification.FormattingEnabled = true;
            this.comboBoxVerification.Items.AddRange(new object[] {
            "Nenhum",
            "Rápido",
            "Completo"});
            this.comboBoxVerification.Location = new System.Drawing.Point(331, 192);
            this.comboBoxVerification.Name = "comboBoxVerification";
            this.comboBoxVerification.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVerification.TabIndex = 7;
            this.comboBoxVerification.SelectedIndexChanged += new System.EventHandler(this.comboBoxVerification_SelectedIndexChanged);
            // 
            // labelVerification
            // 
            this.labelVerification.AutoSize = true;
            this.labelVerification.ForeColor = System.Drawing.Color.White;
            this.labelVerification.Location = new System.Drawing.Point(328, 176);
            this.labelVerification.Name = "labelVerification";
            this.labelVerification.Size = new System.Drawing.Size(60, 13);
            this.labelVerification.TabIndex = 8;
            this.labelVerification.Text = "Verificação";
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Location = new System.Drawing.Point(10, 250);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(155, 20);
            this.textBoxLabel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome do Volume";
            // 
            // buttonRemoveFiles
            // 
            this.buttonRemoveFiles.BackColor = System.Drawing.Color.Gray;
            this.buttonRemoveFiles.FlatAppearance.BorderSize = 0;
            this.buttonRemoveFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonRemoveFiles.Location = new System.Drawing.Point(331, 111);
            this.buttonRemoveFiles.Name = "buttonRemoveFiles";
            this.buttonRemoveFiles.Size = new System.Drawing.Size(132, 46);
            this.buttonRemoveFiles.TabIndex = 6;
            this.buttonRemoveFiles.Text = "Remover Arquivo(s)";
            this.buttonRemoveFiles.UseVisualStyleBackColor = false;
            this.buttonRemoveFiles.Click += new System.EventHandler(this.buttonRemoveFiles_Click);
            // 
            // checkBoxEject
            // 
            this.checkBoxEject.AutoSize = true;
            this.checkBoxEject.Checked = true;
            this.checkBoxEject.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEject.ForeColor = System.Drawing.Color.White;
            this.checkBoxEject.Location = new System.Drawing.Point(199, 253);
            this.checkBoxEject.Name = "checkBoxEject";
            this.checkBoxEject.Size = new System.Drawing.Size(132, 17);
            this.checkBoxEject.TabIndex = 10;
            this.checkBoxEject.Text = "Ejetar quando terminar";
            this.checkBoxEject.UseVisualStyleBackColor = true;
            // 
            // buttonAddFolders
            // 
            this.buttonAddFolders.BackColor = System.Drawing.Color.Gray;
            this.buttonAddFolders.FlatAppearance.BorderSize = 0;
            this.buttonAddFolders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddFolders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAddFolders.Location = new System.Drawing.Point(331, 67);
            this.buttonAddFolders.Name = "buttonAddFolders";
            this.buttonAddFolders.Size = new System.Drawing.Size(132, 39);
            this.buttonAddFolders.TabIndex = 5;
            this.buttonAddFolders.Text = "Add Pasta(s)";
            this.buttonAddFolders.UseVisualStyleBackColor = false;
            this.buttonAddFolders.Click += new System.EventHandler(this.buttonAddFolders_Click);
            // 
            // checkBoxCloseMedia
            // 
            this.checkBoxCloseMedia.AutoSize = true;
            this.checkBoxCloseMedia.Checked = true;
            this.checkBoxCloseMedia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCloseMedia.ForeColor = System.Drawing.Color.White;
            this.checkBoxCloseMedia.Location = new System.Drawing.Point(199, 230);
            this.checkBoxCloseMedia.Name = "checkBoxCloseMedia";
            this.checkBoxCloseMedia.Size = new System.Drawing.Size(88, 17);
            this.checkBoxCloseMedia.TabIndex = 9;
            this.checkBoxCloseMedia.Text = "Fechar mídia";
            this.checkBoxCloseMedia.UseVisualStyleBackColor = true;
            // 
            // buttonAddFiles
            // 
            this.buttonAddFiles.BackColor = System.Drawing.Color.Gray;
            this.buttonAddFiles.FlatAppearance.BorderSize = 0;
            this.buttonAddFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAddFiles.Location = new System.Drawing.Point(331, 23);
            this.buttonAddFiles.Name = "buttonAddFiles";
            this.buttonAddFiles.Size = new System.Drawing.Size(132, 39);
            this.buttonAddFiles.TabIndex = 4;
            this.buttonAddFiles.Text = "Add Arquivo(s)";
            this.buttonAddFiles.UseVisualStyleBackColor = false;
            this.buttonAddFiles.Click += new System.EventHandler(this.buttonAddFiles_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 24;
            this.listBoxFiles.Location = new System.Drawing.Point(10, 19);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(315, 196);
            this.listBoxFiles.TabIndex = 0;
            this.listBoxFiles.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxFiles_DrawItem);
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
            // 
            // checkBoxQuickFormat
            // 
            this.checkBoxQuickFormat.AutoSize = true;
            this.checkBoxQuickFormat.Checked = true;
            this.checkBoxQuickFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxQuickFormat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxQuickFormat.ForeColor = System.Drawing.Color.White;
            this.checkBoxQuickFormat.Location = new System.Drawing.Point(276, 75);
            this.checkBoxQuickFormat.Name = "checkBoxQuickFormat";
            this.checkBoxQuickFormat.Size = new System.Drawing.Size(162, 22);
            this.checkBoxQuickFormat.TabIndex = 14;
            this.checkBoxQuickFormat.Text = "Formatação Rapida";
            this.checkBoxQuickFormat.UseVisualStyleBackColor = true;
            // 
            // checkBoxEjectFormat
            // 
            this.checkBoxEjectFormat.AutoSize = true;
            this.checkBoxEjectFormat.Checked = true;
            this.checkBoxEjectFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEjectFormat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEjectFormat.ForeColor = System.Drawing.Color.White;
            this.checkBoxEjectFormat.Location = new System.Drawing.Point(276, 51);
            this.checkBoxEjectFormat.Name = "checkBoxEjectFormat";
            this.checkBoxEjectFormat.Size = new System.Drawing.Size(189, 22);
            this.checkBoxEjectFormat.TabIndex = 12;
            this.checkBoxEjectFormat.Text = "Ejetar quando terminar";
            this.checkBoxEjectFormat.UseVisualStyleBackColor = true;
            // 
            // formatProgressBar
            // 
            this.formatProgressBar.Location = new System.Drawing.Point(204, 241);
            this.formatProgressBar.Name = "formatProgressBar";
            this.formatProgressBar.Size = new System.Drawing.Size(318, 16);
            this.formatProgressBar.TabIndex = 13;
            // 
            // labelFormatStatusText
            // 
            this.labelFormatStatusText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormatStatusText.ForeColor = System.Drawing.Color.White;
            this.labelFormatStatusText.Location = new System.Drawing.Point(203, 179);
            this.labelFormatStatusText.Name = "labelFormatStatusText";
            this.labelFormatStatusText.Size = new System.Drawing.Size(321, 55);
            this.labelFormatStatusText.TabIndex = 11;
            this.labelFormatStatusText.Text = "status";
            this.labelFormatStatusText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // backgroundFormatWorker
            // 
            this.backgroundFormatWorker.WorkerReportsProgress = true;
            this.backgroundFormatWorker.WorkerSupportsCancellation = true;
            this.backgroundFormatWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundFormatWorker_DoWork);
            this.backgroundFormatWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundFormatWorker_ProgressChanged);
            this.backgroundFormatWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundFormatWorker_RunWorkerCompleted);
            // 
            // PnlGravar
            // 
            this.PnlGravar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlGravar.Controls.Add(this.groupBox1);
            this.PnlGravar.Location = new System.Drawing.Point(15, 110);
            this.PnlGravar.Name = "PnlGravar";
            this.PnlGravar.Size = new System.Drawing.Size(743, 312);
            this.PnlGravar.TabIndex = 12;
            // 
            // PnlFormat
            // 
            this.PnlFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlFormat.Controls.Add(this.checkBoxQuickFormat);
            this.PnlFormat.Controls.Add(this.checkBoxEjectFormat);
            this.PnlFormat.Controls.Add(this.buttonFormat);
            this.PnlFormat.Controls.Add(this.formatProgressBar);
            this.PnlFormat.Controls.Add(this.labelFormatStatusText);
            this.PnlFormat.Location = new System.Drawing.Point(15, 110);
            this.PnlFormat.Name = "PnlFormat";
            this.PnlFormat.Size = new System.Drawing.Size(743, 312);
            this.PnlFormat.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mídia Selcionada";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.updateMidias);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.BtnTabFormat);
            this.panel1.Controls.Add(this.BtnTabGravar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.supportedMediaLabel);
            this.panel1.Controls.Add(this.devicesComboBox);
            this.panel1.Controls.Add(this.PnlGravar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PnlFormat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 432);
            this.panel1.TabIndex = 15;
            // 
            // updateMidias
            // 
            this.updateMidias.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateMidias.BackgroundImage")));
            this.updateMidias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.updateMidias.FlatAppearance.BorderSize = 0;
            this.updateMidias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateMidias.Location = new System.Drawing.Point(213, 81);
            this.updateMidias.Name = "updateMidias";
            this.updateMidias.Size = new System.Drawing.Size(27, 23);
            this.updateMidias.TabIndex = 1;
            this.updateMidias.UseVisualStyleBackColor = true;
            this.updateMidias.Click += new System.EventHandler(this.updateMidias_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 51);
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
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
            this.BtnClose.Location = new System.Drawing.Point(728, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.TabIndex = 59;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(316, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 34);
            this.label9.TabIndex = 60;
            this.label9.Text = "Gravador";
            // 
            // BtnTabFormat
            // 
            this.BtnTabFormat.BackColor = System.Drawing.Color.Gray;
            this.BtnTabFormat.FlatAppearance.BorderSize = 0;
            this.BtnTabFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTabFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTabFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnTabFormat.Location = new System.Drawing.Point(624, 73);
            this.BtnTabFormat.Name = "BtnTabFormat";
            this.BtnTabFormat.Size = new System.Drawing.Size(134, 31);
            this.BtnTabFormat.TabIndex = 3;
            this.BtnTabFormat.Text = "Formatar";
            this.BtnTabFormat.UseVisualStyleBackColor = false;
            this.BtnTabFormat.Click += new System.EventHandler(this.BtnTabFormat_Click);
            // 
            // BtnTabGravar
            // 
            this.BtnTabGravar.BackColor = System.Drawing.Color.Gray;
            this.BtnTabGravar.FlatAppearance.BorderSize = 0;
            this.BtnTabGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTabGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTabGravar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnTabGravar.Location = new System.Drawing.Point(484, 73);
            this.BtnTabGravar.Name = "BtnTabGravar";
            this.BtnTabGravar.Size = new System.Drawing.Size(134, 31);
            this.BtnTabGravar.TabIndex = 2;
            this.BtnTabGravar.Text = "Gravar";
            this.BtnTabGravar.UseVisualStyleBackColor = false;
            this.BtnTabGravar.Click += new System.EventHandler(this.BtnTabGravar_Click);
            // 
            // Gravar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(771, 432);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gravar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BurnMedia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gravar_KeyDown_1);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PnlGravar.ResumeLayout(false);
            this.PnlFormat.ResumeLayout(false);
            this.PnlFormat.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox devicesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label supportedMediaLabel;
        private System.ComponentModel.BackgroundWorker backgroundBurnWorker;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalSize;
        private System.Windows.Forms.ProgressBar progressBarCapacity;
        private System.Windows.Forms.Button buttonFormat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxEject;
        private System.Windows.Forms.CheckBox checkBoxCloseMedia;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRemoveFiles;
        private System.Windows.Forms.Button buttonAddFolders;
        private System.Windows.Forms.Button buttonAddFiles;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Button buttonBurn;
        private System.ComponentModel.BackgroundWorker backgroundFormatWorker;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelStatusText;
        private System.Windows.Forms.ProgressBar statusProgressBar;
        private System.Windows.Forms.CheckBox checkBoxEjectFormat;
        private System.Windows.Forms.ProgressBar formatProgressBar;
        private System.Windows.Forms.Label labelFormatStatusText;
        private System.Windows.Forms.CheckBox checkBoxQuickFormat;
        private System.Windows.Forms.Label labelMediaType;
        private System.Windows.Forms.Button buttonDetectMedia;
        private System.Windows.Forms.ComboBox comboBoxVerification;
        private System.Windows.Forms.Label labelVerification;
        private System.Windows.Forms.Panel PnlGravar;
        private System.Windows.Forms.Panel PnlFormat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnTabFormat;
        private System.Windows.Forms.Button BtnTabGravar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button updateMidias;
    }
}

