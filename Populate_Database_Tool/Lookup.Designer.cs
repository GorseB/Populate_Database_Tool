namespace Populate_Database_Tool
{
    partial class Lookup
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Denotation = new System.Windows.Forms.Label();
            this.txt_Translation = new System.Windows.Forms.Label();
            this.txt_MSentence = new System.Windows.Forms.Label();
            this.txt_ESentence = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Lets DO This :D";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Denotation
            // 
            this.txt_Denotation.Location = new System.Drawing.Point(12, 69);
            this.txt_Denotation.Name = "txt_Denotation";
            this.txt_Denotation.Size = new System.Drawing.Size(965, 29);
            this.txt_Denotation.TabIndex = 2;
            this.txt_Denotation.Text = "Denotation";
            this.txt_Denotation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Translation
            // 
            this.txt_Translation.Location = new System.Drawing.Point(12, 98);
            this.txt_Translation.Name = "txt_Translation";
            this.txt_Translation.Size = new System.Drawing.Size(965, 29);
            this.txt_Translation.TabIndex = 3;
            this.txt_Translation.Text = "Translation";
            this.txt_Translation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_MSentence
            // 
            this.txt_MSentence.Location = new System.Drawing.Point(12, 127);
            this.txt_MSentence.Name = "txt_MSentence";
            this.txt_MSentence.Size = new System.Drawing.Size(965, 29);
            this.txt_MSentence.TabIndex = 4;
            this.txt_MSentence.Text = "Maori Sentence";
            this.txt_MSentence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_ESentence
            // 
            this.txt_ESentence.Location = new System.Drawing.Point(12, 156);
            this.txt_ESentence.Name = "txt_ESentence";
            this.txt_ESentence.Size = new System.Drawing.Size(965, 29);
            this.txt_ESentence.TabIndex = 5;
            this.txt_ESentence.Text = "English Sentence";
            this.txt_ESentence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 196);
            this.Controls.Add(this.txt_ESentence);
            this.Controls.Add(this.txt_MSentence);
            this.Controls.Add(this.txt_Translation);
            this.Controls.Add(this.txt_Denotation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Lookup";
            this.Text = "Lookup Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txt_Denotation;
        private System.Windows.Forms.Label txt_Translation;
        private System.Windows.Forms.Label txt_MSentence;
        private System.Windows.Forms.Label txt_ESentence;
    }
}

