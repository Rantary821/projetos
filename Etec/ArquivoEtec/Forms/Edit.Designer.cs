namespace ArquivoEtec
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TabConfig = new System.Windows.Forms.TabControl();
            this.tabGeral = new System.Windows.Forms.TabPage();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.MostraCont = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ComboTema = new System.Windows.Forms.ComboBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.TabConfig.SuspendLayout();
            this.tabGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TabConfig);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 282);
            this.panel1.TabIndex = 0;
            // 
            // TabConfig
            // 
            this.TabConfig.Controls.Add(this.tabGeral);
            this.TabConfig.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabConfig.Location = new System.Drawing.Point(0, 34);
            this.TabConfig.Multiline = true;
            this.TabConfig.Name = "TabConfig";
            this.TabConfig.SelectedIndex = 0;
            this.TabConfig.Size = new System.Drawing.Size(271, 246);
            this.TabConfig.TabIndex = 3;
            // 
            // tabGeral
            // 
            this.tabGeral.BackColor = System.Drawing.Color.Gray;
            this.tabGeral.Controls.Add(this.BtnUpdate);
            this.tabGeral.Controls.Add(this.MostraCont);
            this.tabGeral.Controls.Add(this.label19);
            this.tabGeral.Controls.Add(this.ComboTema);
            this.tabGeral.Location = new System.Drawing.Point(4, 22);
            this.tabGeral.Name = "tabGeral";
            this.tabGeral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeral.Size = new System.Drawing.Size(263, 220);
            this.tabGeral.TabIndex = 0;
            this.tabGeral.Text = "Geral";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(101)))), ((int)(((byte)(203)))));
            this.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.Black;
            this.BtnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.Image")));
            this.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdate.Location = new System.Drawing.Point(87, 180);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(122, 38);
            this.BtnUpdate.TabIndex = 26;
            this.BtnUpdate.Text = "SALVAR";
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // MostraCont
            // 
            this.MostraCont.AutoSize = true;
            this.MostraCont.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.MostraCont.Location = new System.Drawing.Point(54, 95);
            this.MostraCont.Name = "MostraCont";
            this.MostraCont.Size = new System.Drawing.Size(156, 22);
            this.MostraCont.TabIndex = 25;
            this.MostraCont.Text = "Mostrar contatos?";
            this.MostraCont.UseVisualStyleBackColor = true;
            this.MostraCont.CheckedChanged += new System.EventHandler(this.MostraCont_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(51, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 18);
            this.label19.TabIndex = 24;
            this.label19.Text = "Temas";
            // 
            // ComboTema
            // 
            this.ComboTema.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ComboTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTema.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboTema.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTema.FormattingEnabled = true;
            this.ComboTema.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.ComboTema.Location = new System.Drawing.Point(56, 43);
            this.ComboTema.Name = "ComboTema";
            this.ComboTema.Size = new System.Drawing.Size(187, 26);
            this.ComboTema.TabIndex = 23;
            this.ComboTema.SelectedIndexChanged += new System.EventHandler(this.ComboTema_SelectedIndexChanged);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnClose.BackgroundImage = global::ArquivoEtec.Properties.Resources.cancel2;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnClose.Location = new System.Drawing.Point(236, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(34, 23);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.BtnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.BtnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.SkyBlue;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(271, 29);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Configurações";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(273, 282);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Edit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Edit_KeyDown);
            this.panel1.ResumeLayout(false);
            this.TabConfig.ResumeLayout(false);
            this.tabGeral.ResumeLayout(false);
            this.tabGeral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl TabConfig;
        private System.Windows.Forms.TabPage tabGeral;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox ComboTema;
        private System.Windows.Forms.CheckBox MostraCont;
        private System.Windows.Forms.Button BtnUpdate;
    }
}