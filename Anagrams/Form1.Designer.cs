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
            this.BTstart = new System.Windows.Forms.Button();
            this.TBLetters = new System.Windows.Forms.RichTextBox();
            this.TBUser = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.LB2.Size = new System.Drawing.Size(1145, 28);
            this.LB2.TabIndex = 1;
            this.LB2.Text = "Instructions: Use the following letters to make as many 4 or more Letter words as" +
    " you can in one minute. Press Enter after each word";
            // 
            // BTstart
            // 
            this.BTstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTstart.ForeColor = System.Drawing.Color.Red;
            this.BTstart.Location = new System.Drawing.Point(18, 115);
            this.BTstart.Name = "BTstart";
            this.BTstart.Size = new System.Drawing.Size(172, 41);
            this.BTstart.TabIndex = 2;
            this.BTstart.Text = "Click to Start";
            this.BTstart.UseVisualStyleBackColor = true;
            this.BTstart.Click += new System.EventHandler(this.BTstart_Click);
            // 
            // TBLetters
            // 
            this.TBLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBLetters.Location = new System.Drawing.Point(12, 162);
            this.TBLetters.Name = "TBLetters";
            this.TBLetters.ReadOnly = true;
            this.TBLetters.Size = new System.Drawing.Size(1007, 96);
            this.TBLetters.TabIndex = 3;
            this.TBLetters.Text = "";
            // 
            // TBUser
            // 
            this.TBUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUser.Location = new System.Drawing.Point(12, 312);
            this.TBUser.Name = "TBUser";
            this.TBUser.Size = new System.Drawing.Size(1007, 317);
            this.TBUser.TabIndex = 4;
            this.TBUser.Text = "";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 33);
            this.label1.TabIndex = 0;
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBUser);
            this.Controls.Add(this.TBLetters);
            this.Controls.Add(this.BTstart);
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
        private System.Windows.Forms.Button BTstart;
        private System.Windows.Forms.RichTextBox TBLetters;
        private System.Windows.Forms.RichTextBox TBUser;
        private System.Windows.Forms.Label label1;
        }
    }

