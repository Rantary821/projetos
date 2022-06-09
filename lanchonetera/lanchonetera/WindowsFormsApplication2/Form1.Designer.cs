namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.X = new System.Windows.Forms.Button();
            this.minimiza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(157)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(-14, -23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 468);
            this.panel1.TabIndex = 0;
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.Gainsboro;
            this.X.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.X.FlatAppearance.BorderSize = 0;
            this.X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.ForeColor = System.Drawing.Color.Red;
            this.X.Location = new System.Drawing.Point(766, 0);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(34, 30);
            this.X.TabIndex = 1;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // minimiza
            // 
            this.minimiza.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.minimiza.FlatAppearance.BorderSize = 0;
            this.minimiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimiza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimiza.ForeColor = System.Drawing.Color.Blue;
            this.minimiza.Location = new System.Drawing.Point(726, 0);
            this.minimiza.Name = "minimiza";
            this.minimiza.Size = new System.Drawing.Size(34, 30);
            this.minimiza.TabIndex = 1;
            this.minimiza.Text = "-";
            this.minimiza.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(812, 437);
            this.Controls.Add(this.minimiza);
            this.Controls.Add(this.X);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Button minimiza;
    }
}

