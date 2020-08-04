namespace Speed_Typing_Test___Form_Template
    {
    partial class TypingTestForm
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
            this.components = new System.ComponentModel.Container();
            this.TBUserInput = new System.Windows.Forms.RichTextBox();
            this.BTStart = new System.Windows.Forms.Button();
            this.TBStory = new System.Windows.Forms.TextBox();
            this.LBdisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BTScore = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.BTreturn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBUserInput
            // 
            this.TBUserInput.BackColor = System.Drawing.Color.White;
            this.TBUserInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBUserInput.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUserInput.ForeColor = System.Drawing.Color.Olive;
            this.TBUserInput.Location = new System.Drawing.Point(11, 490);
            this.TBUserInput.Margin = new System.Windows.Forms.Padding(2);
            this.TBUserInput.Name = "TBUserInput";
            this.TBUserInput.ShortcutsEnabled = false;
            this.TBUserInput.Size = new System.Drawing.Size(725, 218);
            this.TBUserInput.TabIndex = 4;
            this.TBUserInput.Text = "";
            this.TBUserInput.Visible = false;
            // 
            // BTStart
            // 
            this.BTStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTStart.ForeColor = System.Drawing.Color.Red;
            this.BTStart.Location = new System.Drawing.Point(253, 411);
            this.BTStart.Margin = new System.Windows.Forms.Padding(2);
            this.BTStart.Name = "BTStart";
            this.BTStart.Size = new System.Drawing.Size(207, 37);
            this.BTStart.TabIndex = 5;
            this.BTStart.Text = "Click to Start";
            this.BTStart.UseVisualStyleBackColor = true;
            this.BTStart.Click += new System.EventHandler(this.BTStart_Click);
            // 
            // TBStory
            // 
            this.TBStory.BackColor = System.Drawing.Color.LightCyan;
            this.TBStory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBStory.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBStory.ForeColor = System.Drawing.Color.Black;
            this.TBStory.Location = new System.Drawing.Point(11, 102);
            this.TBStory.Margin = new System.Windows.Forms.Padding(2);
            this.TBStory.Multiline = true;
            this.TBStory.Name = "TBStory";
            this.TBStory.ReadOnly = true;
            this.TBStory.Size = new System.Drawing.Size(725, 305);
            this.TBStory.TabIndex = 6;
            // 
            // LBdisplay
            // 
            this.LBdisplay.AutoSize = true;
            this.LBdisplay.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBdisplay.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBdisplay.Location = new System.Drawing.Point(11, 450);
            this.LBdisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBdisplay.Name = "LBdisplay";
            this.LBdisplay.Size = new System.Drawing.Size(213, 36);
            this.LBdisplay.TabIndex = 7;
            this.LBdisplay.Text = "                                 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(5, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(899, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Instructions: Copy the text! Case doesn\'t matter but punctuation does. Do try you" +
    "r best ";
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            // 
            // BTScore
            // 
            this.BTScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTScore.Location = new System.Drawing.Point(264, 710);
            this.BTScore.Margin = new System.Windows.Forms.Padding(2);
            this.BTScore.Name = "BTScore";
            this.BTScore.Size = new System.Drawing.Size(207, 40);
            this.BTScore.TabIndex = 9;
            this.BTScore.Text = "Click for score";
            this.BTScore.UseVisualStyleBackColor = true;
            this.BTScore.Visible = false;
            this.BTScore.Click += new System.EventHandler(this.BTScore_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.scoreLabel.Location = new System.Drawing.Point(259, 710);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 36);
            this.scoreLabel.TabIndex = 10;
            this.scoreLabel.Visible = false;
            // 
            // BTreturn
            // 
            this.BTreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTreturn.ForeColor = System.Drawing.Color.Red;
            this.BTreturn.Location = new System.Drawing.Point(264, 754);
            this.BTreturn.Margin = new System.Windows.Forms.Padding(2);
            this.BTreturn.Name = "BTreturn";
            this.BTreturn.Size = new System.Drawing.Size(205, 38);
            this.BTreturn.TabIndex = 11;
            this.BTreturn.Text = "Return to Menu";
            this.BTreturn.UseVisualStyleBackColor = true;
            this.BTreturn.Click += new System.EventHandler(this.BTreturn_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 57);
            this.label2.TabIndex = 12;
            this.label2.Text = "Welcome To Typing Test!";
            // 
            // TypingTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1283, 803);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTreturn);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.BTScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBdisplay);
            this.Controls.Add(this.TBStory);
            this.Controls.Add(this.BTStart);
            this.Controls.Add(this.TBUserInput);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TypingTestForm";
            this.Text = "Typing Test";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TypingTestForm_FormClosing);
            this.Load += new System.EventHandler(this.TypingTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.RichTextBox TBUserInput;
        private System.Windows.Forms.Button BTStart;
        private System.Windows.Forms.TextBox TBStory;
        private System.Windows.Forms.Label LBdisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BTScore;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button BTreturn;
        private System.Windows.Forms.Label label2;
        }
    }

