namespace Menu
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.aluno = new System.Windows.Forms.ToolStripButton();
            this.curso = new System.Windows.Forms.ToolStripButton();
            this.config = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aluno
            // 
            this.aluno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aluno.Image = ((System.Drawing.Image)(resources.GetObject("aluno.Image")));
            this.aluno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aluno.Name = "aluno";
            this.aluno.Size = new System.Drawing.Size(54, 54);
            this.aluno.Text = "Cadastro de Aluno";
            this.aluno.Click += new System.EventHandler(this.aluno_Click);
            // 
            // curso
            // 
            this.curso.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.curso.Image = ((System.Drawing.Image)(resources.GetObject("curso.Image")));
            this.curso.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.curso.Name = "curso";
            this.curso.Size = new System.Drawing.Size(54, 54);
            this.curso.Text = "Cadastro de Curso";
            this.curso.Click += new System.EventHandler(this.curso_Click);
            // 
            // config
            // 
            this.config.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.config.Image = ((System.Drawing.Image)(resources.GetObject("config.Image")));
            this.config.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(54, 54);
            this.config.Text = "Configuração";
            this.config.Click += new System.EventHandler(this.config_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aluno,
            this.toolStripLabel1,
            this.toolStripLabel4,
            this.curso,
            this.toolStripLabel3,
            this.config});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1108, 57);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Menu";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 54);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(64, 54);
            this.toolStripLabel4.Text = "                   ";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(64, 54);
            this.toolStripLabel3.Text = "                   ";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Menu.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1108, 420);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arquivo Permanente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton aluno;
        private System.Windows.Forms.ToolStripButton curso;
        private System.Windows.Forms.ToolStripButton config;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
    }
}

