namespace Guess
{
    partial class guess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guess));
            this.mainDipsplay = new System.Windows.Forms.TextBox();
            this.submitGuess = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.guessBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hintbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.countDisplay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainDipsplay
            // 
            this.mainDipsplay.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDipsplay.Location = new System.Drawing.Point(12, 12);
            this.mainDipsplay.Multiline = true;
            this.mainDipsplay.Name = "mainDipsplay";
            this.mainDipsplay.ReadOnly = true;
            this.mainDipsplay.Size = new System.Drawing.Size(249, 238);
            this.mainDipsplay.TabIndex = 0;
            this.mainDipsplay.Text = "Guess a number, 1 to 1000!";
            // 
            // submitGuess
            // 
            this.submitGuess.BackColor = System.Drawing.Color.Indigo;
            this.submitGuess.ForeColor = System.Drawing.SystemColors.Control;
            this.submitGuess.Location = new System.Drawing.Point(267, 183);
            this.submitGuess.Name = "submitGuess";
            this.submitGuess.Size = new System.Drawing.Size(136, 67);
            this.submitGuess.TabIndex = 1;
            this.submitGuess.Text = "Guess";
            this.submitGuess.UseVisualStyleBackColor = false;
            this.submitGuess.Click += new System.EventHandler(this.submitGuess_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Indigo;
            this.reset.ForeColor = System.Drawing.SystemColors.Control;
            this.reset.Location = new System.Drawing.Point(409, 183);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(133, 67);
            this.reset.TabIndex = 2;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // guessBox
            // 
            this.guessBox.BackColor = System.Drawing.Color.Indigo;
            this.guessBox.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessBox.ForeColor = System.Drawing.SystemColors.Window;
            this.guessBox.Location = new System.Drawing.Point(267, 133);
            this.guessBox.MaxLength = 4;
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(136, 44);
            this.guessBox.TabIndex = 3;
            this.guessBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(314, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Guess";
            // 
            // hintbox
            // 
            this.hintbox.Location = new System.Drawing.Point(267, 36);
            this.hintbox.Multiline = true;
            this.hintbox.Name = "hintbox";
            this.hintbox.ReadOnly = true;
            this.hintbox.Size = new System.Drawing.Size(275, 50);
            this.hintbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(268, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hint";
            // 
            // countDisplay
            // 
            this.countDisplay.BackColor = System.Drawing.Color.Indigo;
            this.countDisplay.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDisplay.ForeColor = System.Drawing.SystemColors.Window;
            this.countDisplay.Location = new System.Drawing.Point(406, 133);
            this.countDisplay.MaxLength = 4;
            this.countDisplay.Name = "countDisplay";
            this.countDisplay.Size = new System.Drawing.Size(136, 44);
            this.countDisplay.TabIndex = 7;
            this.countDisplay.Text = "0";
            this.countDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(449, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Attempts";
            // 
            // guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(554, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hintbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guessBox);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.submitGuess);
            this.Controls.Add(this.mainDipsplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guess";
            this.Text = "Guess!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainDipsplay;
        private System.Windows.Forms.Button submitGuess;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox guessBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hintbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countDisplay;
        private System.Windows.Forms.Label label3;
    }
}

