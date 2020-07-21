namespace Anagrams
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
            this.LB1 = new System.Windows.Forms.Label();
            this.LB2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB1
            // 
            this.LB1.AutoSize = true;
            this.LB1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB1.ForeColor = System.Drawing.Color.OrangeRed;
            this.LB1.Location = new System.Drawing.Point(12, 27);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(278, 33);
            this.LB1.TabIndex = 0;
            this.LB1.Text = "Welcome to ANAGRAMS!";
            // 
            // LB2
            // 
            this.LB2.AutoSize = true;
            this.LB2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB2.Location = new System.Drawing.Point(15, 70);
            this.LB2.Name = "LB2";
            this.LB2.Size = new System.Drawing.Size(1004, 28);
            this.LB2.TabIndex = 1;
            this.LB2.Text = "Instructions: Use the following letters to make as many words as you can in one m" +
    "inute. Press Enter after each word";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 750);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LB2);
            this.Controls.Add(this.LB1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label LB1;
        private System.Windows.Forms.Label LB2;
        private System.Windows.Forms.Button button1;
        }
    }

