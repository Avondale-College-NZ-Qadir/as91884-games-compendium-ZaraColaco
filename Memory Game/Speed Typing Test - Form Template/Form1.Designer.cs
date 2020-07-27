namespace Speed_Typing_Test___Form_Template
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
            this.components = new System.ComponentModel.Container();
            this.TBUserInput = new System.Windows.Forms.RichTextBox();
            this.BTStart = new System.Windows.Forms.Button();
            this.TBStory = new System.Windows.Forms.TextBox();
            this.LBdisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BTScore = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBUserInput
            // 
            this.TBUserInput.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUserInput.ForeColor = System.Drawing.Color.Olive;
            this.TBUserInput.Location = new System.Drawing.Point(17, 426);
            this.TBUserInput.Margin = new System.Windows.Forms.Padding(2);
            this.TBUserInput.Name = "TBUserInput";
            this.TBUserInput.Size = new System.Drawing.Size(725, 218);
            this.TBUserInput.TabIndex = 4;
            this.TBUserInput.Text = "";
            this.TBUserInput.Visible = false;
            // 
            // BTStart
            // 
            this.BTStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTStart.ForeColor = System.Drawing.Color.Red;
            this.BTStart.Location = new System.Drawing.Point(253, 353);
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
            this.TBStory.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBStory.Location = new System.Drawing.Point(17, 44);
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
            this.LBdisplay.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBdisplay.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBdisplay.Location = new System.Drawing.Point(256, 392);
            this.LBdisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBdisplay.Name = "LBdisplay";
            this.LBdisplay.Size = new System.Drawing.Size(213, 33);
            this.LBdisplay.TabIndex = 7;
            this.LBdisplay.Text = "                                 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(736, 33);
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
            this.BTScore.Location = new System.Drawing.Point(262, 655);
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
            this.scoreLabel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.scoreLabel.Location = new System.Drawing.Point(217, 667);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 28);
            this.scoreLabel.TabIndex = 10;
            this.scoreLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 768);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.BTScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBdisplay);
            this.Controls.Add(this.TBStory);
            this.Controls.Add(this.BTStart);
            this.Controls.Add(this.TBUserInput);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
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
        }
    }

