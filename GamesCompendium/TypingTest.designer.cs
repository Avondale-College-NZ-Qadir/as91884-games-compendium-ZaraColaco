﻿namespace Speed_Typing_Test___Form_Template
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
            this.SuspendLayout();
            // 
            // TBUserInput
            // 
            this.TBUserInput.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUserInput.ForeColor = System.Drawing.Color.Olive;
            this.TBUserInput.Location = new System.Drawing.Point(26, 655);
            this.TBUserInput.Name = "TBUserInput";
            this.TBUserInput.Size = new System.Drawing.Size(1086, 333);
            this.TBUserInput.TabIndex = 4;
            this.TBUserInput.Text = "";
            this.TBUserInput.Visible = false;
            // 
            // BTStart
            // 
            this.BTStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTStart.ForeColor = System.Drawing.Color.Red;
            this.BTStart.Location = new System.Drawing.Point(380, 543);
            this.BTStart.Name = "BTStart";
            this.BTStart.Size = new System.Drawing.Size(310, 57);
            this.BTStart.TabIndex = 5;
            this.BTStart.Text = "Click to Start";
            this.BTStart.UseVisualStyleBackColor = true;
            this.BTStart.Click += new System.EventHandler(this.BTStart_Click);
            // 
            // TBStory
            // 
            this.TBStory.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBStory.Location = new System.Drawing.Point(26, 68);
            this.TBStory.Multiline = true;
            this.TBStory.Name = "TBStory";
            this.TBStory.ReadOnly = true;
            this.TBStory.Size = new System.Drawing.Size(1086, 467);
            this.TBStory.TabIndex = 6;
            // 
            // LBdisplay
            // 
            this.LBdisplay.AutoSize = true;
            this.LBdisplay.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBdisplay.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBdisplay.Location = new System.Drawing.Point(384, 603);
            this.LBdisplay.Name = "LBdisplay";
            this.LBdisplay.Size = new System.Drawing.Size(319, 49);
            this.LBdisplay.TabIndex = 7;
            this.LBdisplay.Text = "                                 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1095, 49);
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
            this.BTScore.Location = new System.Drawing.Point(393, 1008);
            this.BTScore.Name = "BTScore";
            this.BTScore.Size = new System.Drawing.Size(310, 62);
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
            this.scoreLabel.Location = new System.Drawing.Point(326, 1026);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 44);
            this.scoreLabel.TabIndex = 10;
            this.scoreLabel.Visible = false;
            // 
            // BTreturn
            // 
            this.BTreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTreturn.ForeColor = System.Drawing.Color.Red;
            this.BTreturn.Location = new System.Drawing.Point(383, 1096);
            this.BTreturn.Name = "BTreturn";
            this.BTreturn.Size = new System.Drawing.Size(307, 58);
            this.BTreturn.TabIndex = 11;
            this.BTreturn.Text = "Return to Menu";
            this.BTreturn.UseVisualStyleBackColor = true;
            this.BTreturn.Click += new System.EventHandler(this.BTreturn_Click_1);
            // 
            // TypingTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2128, 1182);
            this.Controls.Add(this.BTreturn);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.BTScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBdisplay);
            this.Controls.Add(this.TBStory);
            this.Controls.Add(this.BTStart);
            this.Controls.Add(this.TBUserInput);
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
    }
    }
