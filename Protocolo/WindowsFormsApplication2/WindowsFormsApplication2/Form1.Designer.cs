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
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Txt3 = new System.Windows.Forms.TextBox();
            this.Txt4 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.REsutlado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(26, 13);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(100, 20);
            this.Txt1.TabIndex = 0;
            // 
            // Txt3
            // 
            this.Txt3.Location = new System.Drawing.Point(26, 109);
            this.Txt3.Name = "Txt3";
            this.Txt3.Size = new System.Drawing.Size(100, 20);
            this.Txt3.TabIndex = 0;
            // 
            // Txt4
            // 
            this.Txt4.Location = new System.Drawing.Point(26, 157);
            this.Txt4.Name = "Txt4";
            this.Txt4.Size = new System.Drawing.Size(100, 20);
            this.Txt4.TabIndex = 0;
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(26, 61);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(100, 20);
            this.Txt2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // REsutlado
            // 
            this.REsutlado.AutoSize = true;
            this.REsutlado.Location = new System.Drawing.Point(269, 157);
            this.REsutlado.Name = "REsutlado";
            this.REsutlado.Size = new System.Drawing.Size(35, 13);
            this.REsutlado.TabIndex = 2;
            this.REsutlado.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 428);
            this.Controls.Add(this.REsutlado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txt4);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt3);
            this.Controls.Add(this.Txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.TextBox Txt3;
        private System.Windows.Forms.TextBox Txt4;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label REsutlado;
    }
}

