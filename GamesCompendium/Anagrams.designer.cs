namespace Anagrams
    {
    partial class AnagramsForm
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
            this.LBPrompts = new System.Windows.Forms.Label();
            this.BTscore = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.BTreturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB1
            // 
            this.LB1.AutoSize = true;
            this.LB1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB1.ForeColor = System.Drawing.Color.OrangeRed;
            this.LB1.Location = new System.Drawing.Point(7, 9);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(510, 57);
            this.LB1.TabIndex = 0;
            this.LB1.Text = "Welcome to ANAGRAMS!";
            // 
            // LB2
            // 
            this.LB2.AutoSize = true;
            this.LB2.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB2.ForeColor = System.Drawing.Color.Black;
            this.LB2.Location = new System.Drawing.Point(15, 70);
            this.LB2.Name = "LB2";
            this.LB2.Size = new System.Drawing.Size(1010, 66);
            this.LB2.TabIndex = 1;
            this.LB2.Text = "Instructions: Use the following letters to make as many 3 or more letter words as" +
    " you can in one minute. \r\nPress Enter after each word. Remember you can only use" +
    " each letter once.";
            // 
            // BTstart
            // 
            this.BTstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTstart.ForeColor = System.Drawing.Color.Red;
            this.BTstart.Location = new System.Drawing.Point(9, 137);
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
            this.TBLetters.ForeColor = System.Drawing.Color.OrangeRed;
            this.TBLetters.Location = new System.Drawing.Point(9, 185);
            this.TBLetters.Name = "TBLetters";
            this.TBLetters.ReadOnly = true;
            this.TBLetters.Size = new System.Drawing.Size(1007, 96);
            this.TBLetters.TabIndex = 3;
            this.TBLetters.Text = "";
            this.TBLetters.Visible = false;
            // 
            // TBUser
            // 
            this.TBUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUser.Location = new System.Drawing.Point(9, 322);
            this.TBUser.Name = "TBUser";
            this.TBUser.Size = new System.Drawing.Size(1007, 317);
            this.TBUser.TabIndex = 4;
            this.TBUser.Text = "";
            // 
            // LBPrompts
            // 
            this.LBPrompts.Font = new System.Drawing.Font("Monotype Corsiva", 26F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPrompts.ForeColor = System.Drawing.Color.OrangeRed;
            this.LBPrompts.Location = new System.Drawing.Point(9, 286);
            this.LBPrompts.Name = "LBPrompts";
            this.LBPrompts.Size = new System.Drawing.Size(394, 33);
            this.LBPrompts.TabIndex = 0;
            this.LBPrompts.Visible = false;
            // 
            // BTscore
            // 
            this.BTscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTscore.ForeColor = System.Drawing.Color.Red;
            this.BTscore.Location = new System.Drawing.Point(10, 645);
            this.BTscore.Name = "BTscore";
            this.BTscore.Size = new System.Drawing.Size(210, 44);
            this.BTscore.TabIndex = 5;
            this.BTscore.Text = "Click for Score";
            this.BTscore.UseVisualStyleBackColor = true;
            this.BTscore.Visible = false;
            this.BTscore.Click += new System.EventHandler(this.BTscore_Click_1);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Monotype Corsiva", 26F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.scoreLabel.Location = new System.Drawing.Point(13, 699);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 43);
            this.scoreLabel.TabIndex = 6;
            // 
            // BTreturn
            // 
            this.BTreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTreturn.ForeColor = System.Drawing.Color.Red;
            this.BTreturn.Location = new System.Drawing.Point(9, 742);
            this.BTreturn.Margin = new System.Windows.Forms.Padding(2);
            this.BTreturn.Name = "BTreturn";
            this.BTreturn.Size = new System.Drawing.Size(211, 42);
            this.BTreturn.TabIndex = 7;
            this.BTreturn.Text = "Return to Menu";
            this.BTreturn.UseVisualStyleBackColor = true;
            this.BTreturn.Click += new System.EventHandler(this.BTreturn_Click);
            // 
            // AnagramsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 768);
            this.Controls.Add(this.BTreturn);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.BTscore);
            this.Controls.Add(this.LBPrompts);
            this.Controls.Add(this.TBUser);
            this.Controls.Add(this.TBLetters);
            this.Controls.Add(this.BTstart);
            this.Controls.Add(this.LB2);
            this.Controls.Add(this.LB1);
            this.Name = "AnagramsForm";
            this.Text = "Anagrams";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnagramsForm_FormClosing);
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
        private System.Windows.Forms.Label LBPrompts;
        private System.Windows.Forms.Button BTscore;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button BTreturn;
    }
    }

