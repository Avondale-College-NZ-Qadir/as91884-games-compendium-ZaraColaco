namespace Memory_Game
{
    partial class MemoryGameForm
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
            this.LBWelcome = new System.Windows.Forms.Label();
            this.LBinstructions = new System.Windows.Forms.Label();
            this.BTStart = new System.Windows.Forms.Button();
            this.TBText = new System.Windows.Forms.RichTextBox();
            this.TBUser = new System.Windows.Forms.RichTextBox();
            this.BTscore = new System.Windows.Forms.Button();
            this.LBscore = new System.Windows.Forms.Label();
            this.BTReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBWelcome
            // 
            this.LBWelcome.AutoSize = true;
            this.LBWelcome.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBWelcome.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.LBWelcome.Location = new System.Drawing.Point(11, 15);
            this.LBWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBWelcome.Name = "LBWelcome";
            this.LBWelcome.Size = new System.Drawing.Size(770, 79);
            this.LBWelcome.TabIndex = 0;
            this.LBWelcome.Text = "Welcome to the Memory Game!";
            // 
            // LBinstructions
            // 
            this.LBinstructions.AutoSize = true;
            this.LBinstructions.BackColor = System.Drawing.Color.Transparent;
            this.LBinstructions.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBinstructions.ForeColor = System.Drawing.Color.Indigo;
            this.LBinstructions.Location = new System.Drawing.Point(17, 94);
            this.LBinstructions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBinstructions.Name = "LBinstructions";
            this.LBinstructions.Size = new System.Drawing.Size(1317, 90);
            this.LBinstructions.TabIndex = 1;
            this.LBinstructions.Text = "Instructions: You will be shown a phrase for 5 seconds and you must try to rememb" +
    "er it and type it.\r\nDo not press extra keys at the end e.g SpaceBar and Enter. Y" +
    "ou will loose.\r\n";
            // 
            // BTStart
            // 
            this.BTStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTStart.ForeColor = System.Drawing.Color.HotPink;
            this.BTStart.Location = new System.Drawing.Point(25, 186);
            this.BTStart.Margin = new System.Windows.Forms.Padding(2);
            this.BTStart.Name = "BTStart";
            this.BTStart.Size = new System.Drawing.Size(178, 42);
            this.BTStart.TabIndex = 2;
            this.BTStart.Text = "Click to Start";
            this.BTStart.UseVisualStyleBackColor = true;
            this.BTStart.Click += new System.EventHandler(this.BTStart_Click);
            // 
            // TBText
            // 
            this.TBText.BackColor = System.Drawing.Color.Lavender;
            this.TBText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBText.Location = new System.Drawing.Point(25, 232);
            this.TBText.Margin = new System.Windows.Forms.Padding(2);
            this.TBText.Name = "TBText";
            this.TBText.ReadOnly = true;
            this.TBText.ShortcutsEnabled = false;
            this.TBText.Size = new System.Drawing.Size(865, 88);
            this.TBText.TabIndex = 3;
            this.TBText.Text = "";
            // 
            // TBUser
            // 
            this.TBUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUser.ForeColor = System.Drawing.Color.MediumPurple;
            this.TBUser.Location = new System.Drawing.Point(25, 333);
            this.TBUser.Margin = new System.Windows.Forms.Padding(2);
            this.TBUser.Name = "TBUser";
            this.TBUser.ReadOnly = true;
            this.TBUser.ShortcutsEnabled = false;
            this.TBUser.Size = new System.Drawing.Size(863, 96);
            this.TBUser.TabIndex = 4;
            this.TBUser.Text = "";
            // 
            // BTscore
            // 
            this.BTscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTscore.ForeColor = System.Drawing.Color.Indigo;
            this.BTscore.Location = new System.Drawing.Point(25, 443);
            this.BTscore.Margin = new System.Windows.Forms.Padding(2);
            this.BTscore.Name = "BTscore";
            this.BTscore.Size = new System.Drawing.Size(187, 38);
            this.BTscore.TabIndex = 5;
            this.BTscore.Text = "Click to Check";
            this.BTscore.UseVisualStyleBackColor = true;
            this.BTscore.Click += new System.EventHandler(this.BTscore_Click);
            // 
            // LBscore
            // 
            this.LBscore.AutoSize = true;
            this.LBscore.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBscore.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.LBscore.Location = new System.Drawing.Point(15, 504);
            this.LBscore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBscore.Name = "LBscore";
            this.LBscore.Size = new System.Drawing.Size(0, 57);
            this.LBscore.TabIndex = 6;
            this.LBscore.Visible = false;
            // 
            // BTReturn
            // 
            this.BTReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTReturn.ForeColor = System.Drawing.Color.Indigo;
            this.BTReturn.Location = new System.Drawing.Point(25, 578);
            this.BTReturn.Margin = new System.Windows.Forms.Padding(2);
            this.BTReturn.Name = "BTReturn";
            this.BTReturn.Size = new System.Drawing.Size(187, 42);
            this.BTReturn.TabIndex = 7;
            this.BTReturn.Text = "Return to Menu";
            this.BTReturn.UseVisualStyleBackColor = true;
            this.BTReturn.Click += new System.EventHandler(this.BTReturn_Click);
            // 
            // MemoryGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1023, 618);
            this.Controls.Add(this.BTReturn);
            this.Controls.Add(this.LBscore);
            this.Controls.Add(this.BTscore);
            this.Controls.Add(this.TBUser);
            this.Controls.Add(this.TBText);
            this.Controls.Add(this.BTStart);
            this.Controls.Add(this.LBinstructions);
            this.Controls.Add(this.LBWelcome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MemoryGameForm";
            this.Text = "Memory Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MemoryGameForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBWelcome;
        private System.Windows.Forms.Label LBinstructions;
        private System.Windows.Forms.Button BTStart;
        private System.Windows.Forms.RichTextBox TBText;
        private System.Windows.Forms.RichTextBox TBUser;
        private System.Windows.Forms.Button BTscore;
        private System.Windows.Forms.Label LBscore;
        private System.Windows.Forms.Button BTReturn;
    }
}

