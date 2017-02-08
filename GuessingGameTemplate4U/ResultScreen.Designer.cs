namespace GuessingGameTemplate4U
{
    partial class ResultScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.promptLabel = new System.Windows.Forms.Label();
            this.answerOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numGuess = new System.Windows.Forms.Label();
            this.guessOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(49, 28);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(207, 37);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Guessing Game";
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.ForeColor = System.Drawing.Color.White;
            this.promptLabel.Location = new System.Drawing.Point(7, 88);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(286, 21);
            this.promptLabel.TabIndex = 7;
            this.promptLabel.Text = "Congratulations! You guessed correctly!";
            // 
            // answerOutput
            // 
            this.answerOutput.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.answerOutput.ForeColor = System.Drawing.Color.White;
            this.answerOutput.Location = new System.Drawing.Point(22, 130);
            this.answerOutput.Name = "answerOutput";
            this.answerOutput.Size = new System.Drawing.Size(257, 50);
            this.answerOutput.TabIndex = 8;
            this.answerOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Guesses :";
            // 
            // numGuess
            // 
            this.numGuess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGuess.ForeColor = System.Drawing.Color.White;
            this.numGuess.Location = new System.Drawing.Point(140, 206);
            this.numGuess.Name = "numGuess";
            this.numGuess.Size = new System.Drawing.Size(74, 21);
            this.numGuess.TabIndex = 10;
            this.numGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guessOutput
            // 
            this.guessOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessOutput.ForeColor = System.Drawing.Color.White;
            this.guessOutput.Location = new System.Drawing.Point(11, 242);
            this.guessOutput.Name = "guessOutput";
            this.guessOutput.Size = new System.Drawing.Size(282, 38);
            this.guessOutput.TabIndex = 11;
            this.guessOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ResultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.guessOutput);
            this.Controls.Add(this.numGuess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answerOutput);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "ResultScreen";
            this.Size = new System.Drawing.Size(300, 300);
            this.Load += new System.EventHandler(this.ResultScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Label answerOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numGuess;
        private System.Windows.Forms.Label guessOutput;
    }
}
