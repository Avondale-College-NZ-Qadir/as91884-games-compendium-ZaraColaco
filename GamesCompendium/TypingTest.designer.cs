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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypingTestForm));
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
            this.TBUserInput.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUserInput.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TBUserInput.Location = new System.Drawing.Point(90, 4023);
            this.TBUserInput.Margin = new System.Windows.Forms.Padding(16, 18, 16, 18);
            this.TBUserInput.Name = "TBUserInput";
            this.TBUserInput.Size = new System.Drawing.Size(5892, 1930);
            this.TBUserInput.TabIndex = 4;
            this.TBUserInput.Text = "";
            this.TBUserInput.Visible = false;
            // 
            // BTStart
            // 
            this.BTStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTStart.ForeColor = System.Drawing.Color.Red;
            this.BTStart.Location = new System.Drawing.Point(2066, 3249);
            this.BTStart.Margin = new System.Windows.Forms.Padding(16, 18, 16, 18);
            this.BTStart.Name = "BTStart";
            this.BTStart.Size = new System.Drawing.Size(1691, 333);
            this.BTStart.TabIndex = 5;
            this.BTStart.Text = "Click to Start";
            this.BTStart.UseVisualStyleBackColor = true;
            this.BTStart.Click += new System.EventHandler(this.BTStart_Click);
            // 
            // TBStory
            // 
            this.TBStory.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBStory.Location = new System.Drawing.Point(90, 468);
            this.TBStory.Margin = new System.Windows.Forms.Padding(16, 18, 16, 18);
            this.TBStory.Multiline = true;
            this.TBStory.Name = "TBStory";
            this.TBStory.ReadOnly = true;
            this.TBStory.Size = new System.Drawing.Size(5892, 2713);
            this.TBStory.TabIndex = 6;
            // 
            // LBdisplay
            // 
            this.LBdisplay.AutoSize = true;
            this.LBdisplay.BackColor = System.Drawing.Color.Transparent;
            this.LBdisplay.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBdisplay.ForeColor = System.Drawing.Color.GhostWhite;
            this.LBdisplay.Location = new System.Drawing.Point(1870, 3681);
            this.LBdisplay.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.LBdisplay.Name = "LBdisplay";
            this.LBdisplay.Size = new System.Drawing.Size(246, 36);
            this.LBdisplay.TabIndex = 7;
            this.LBdisplay.Text = "                                 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(90, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1242, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "Instructions: Copy the text! Case and punctuation matter. Do try your best ";
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            // 
            // BTScore
            // 
            this.BTScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTScore.Location = new System.Drawing.Point(2066, 6156);
            this.BTScore.Margin = new System.Windows.Forms.Padding(16, 18, 16, 18);
            this.BTScore.Name = "BTScore";
            this.BTScore.Size = new System.Drawing.Size(1691, 360);
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
            this.scoreLabel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.White;
            this.scoreLabel.Location = new System.Drawing.Point(1772, 6003);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 28);
            this.scoreLabel.TabIndex = 10;
            this.scoreLabel.Visible = false;
            // 
            // BTreturn
            // 
            this.BTreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTreturn.ForeColor = System.Drawing.Color.Red;
            this.BTreturn.Location = new System.Drawing.Point(2066, 6552);
            this.BTreturn.Margin = new System.Windows.Forms.Padding(16, 18, 16, 18);
            this.BTreturn.Name = "BTreturn";
            this.BTreturn.Size = new System.Drawing.Size(1674, 342);
            this.BTreturn.TabIndex = 11;
            this.BTreturn.Text = "Return to Menu";
            this.BTreturn.UseVisualStyleBackColor = true;
            this.BTreturn.Click += new System.EventHandler(this.BTreturn_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5121, 3618);
            this.label2.Margin = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(884, 117);
            this.label2.TabIndex = 12;
            this.label2.Text = "Welcome to Typing Test";
            // 
            // TypingTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(49F, 117F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1181);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTreturn);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.BTScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBdisplay);
            this.Controls.Add(this.TBStory);
            this.Controls.Add(this.BTStart);
            this.Controls.Add(this.TBUserInput);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.Margin = new System.Windows.Forms.Padding(16, 18, 16, 18);
            this.Name = "TypingTestForm";
            this.Text = "Typing Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TypingTestForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
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

