namespace Memory_Game
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
            this.LBWelcome.Font = new System.Drawing.Font("Monotype Corsiva", 28F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBWelcome.ForeColor = System.Drawing.Color.MediumPurple;
            this.LBWelcome.Location = new System.Drawing.Point(12, 18);
            this.LBWelcome.Name = "LBWelcome";
            this.LBWelcome.Size = new System.Drawing.Size(646, 67);
            this.LBWelcome.TabIndex = 0;
            this.LBWelcome.Text = "Welcome to the Memory Game!";
            // 
            // LBinstructions
            // 
            this.LBinstructions.AutoSize = true;
            this.LBinstructions.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBinstructions.Location = new System.Drawing.Point(29, 85);
            this.LBinstructions.Name = "LBinstructions";
            this.LBinstructions.Size = new System.Drawing.Size(1285, 44);
            this.LBinstructions.TabIndex = 1;
            this.LBinstructions.Text = "Instructions: You will be shown a phrase for 5 seconds and you must try to rememb" +
    "er it and type it.\r\n";
            // 
            // BTStart
            // 
            this.BTStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTStart.ForeColor = System.Drawing.Color.HotPink;
            this.BTStart.Location = new System.Drawing.Point(24, 171);
            this.BTStart.Name = "BTStart";
            this.BTStart.Size = new System.Drawing.Size(267, 65);
            this.BTStart.TabIndex = 2;
            this.BTStart.Text = "Click to Start";
            this.BTStart.UseVisualStyleBackColor = true;
            this.BTStart.Click += new System.EventHandler(this.BTStart_Click);
            // 
            // TBText
            // 
            this.TBText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBText.Location = new System.Drawing.Point(24, 171);
            this.TBText.Name = "TBText";
            this.TBText.ReadOnly = true;
            this.TBText.Size = new System.Drawing.Size(1295, 118);
            this.TBText.TabIndex = 3;
            this.TBText.Text = "";
            // 
            // TBUser
            // 
            this.TBUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUser.ForeColor = System.Drawing.Color.MediumPurple;
            this.TBUser.Location = new System.Drawing.Point(24, 363);
            this.TBUser.Name = "TBUser";
            this.TBUser.ReadOnly = true;
            this.TBUser.Size = new System.Drawing.Size(1293, 145);
            this.TBUser.TabIndex = 4;
            this.TBUser.Text = "";
            // 
            // BTscore
            // 
            this.BTscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTscore.ForeColor = System.Drawing.Color.HotPink;
            this.BTscore.Location = new System.Drawing.Point(24, 539);
            this.BTscore.Name = "BTscore";
            this.BTscore.Size = new System.Drawing.Size(280, 59);
            this.BTscore.TabIndex = 5;
            this.BTscore.Text = "Click to Check";
            this.BTscore.UseVisualStyleBackColor = true;
            this.BTscore.Click += new System.EventHandler(this.BTscore_Click);
            // 
            // LBscore
            // 
            this.LBscore.AutoSize = true;
            this.LBscore.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBscore.ForeColor = System.Drawing.Color.MediumPurple;
            this.LBscore.Location = new System.Drawing.Point(12, 604);
            this.LBscore.Name = "LBscore";
            this.LBscore.Size = new System.Drawing.Size(0, 85);
            this.LBscore.TabIndex = 6;
            this.LBscore.Visible = false;
            // 
            // BTReturn
            // 
            this.BTReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTReturn.ForeColor = System.Drawing.Color.HotPink;
            this.BTReturn.Location = new System.Drawing.Point(24, 702);
            this.BTReturn.Name = "BTReturn";
            this.BTReturn.Size = new System.Drawing.Size(281, 65);
            this.BTReturn.TabIndex = 7;
            this.BTReturn.Text = "Return to Menu";
            this.BTReturn.UseVisualStyleBackColor = true;
            this.BTReturn.Click += new System.EventHandler(this.BTReturn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 951);
            this.Controls.Add(this.BTReturn);
            this.Controls.Add(this.LBscore);
            this.Controls.Add(this.BTscore);
            this.Controls.Add(this.TBUser);
            this.Controls.Add(this.TBText);
            this.Controls.Add(this.BTStart);
            this.Controls.Add(this.LBinstructions);
            this.Controls.Add(this.LBWelcome);
            this.Name = "Form1";
            this.Text = "Form1";
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

