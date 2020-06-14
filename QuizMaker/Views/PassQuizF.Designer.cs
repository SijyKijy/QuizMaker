namespace QuizMaker.Views
{
    partial class PassQuizF
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
            this.ThemeLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.answ1 = new System.Windows.Forms.RadioButton();
            this.answ2 = new System.Windows.Forms.RadioButton();
            this.answ3 = new System.Windows.Forms.RadioButton();
            this.answ4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.Location = new System.Drawing.Point(218, 55);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(44, 13);
            this.ThemeLabel.TabIndex = 0;
            this.ThemeLabel.Text = "Вопрос";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(202, 413);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // answ1
            // 
            this.answ1.AutoSize = true;
            this.answ1.Location = new System.Drawing.Point(42, 153);
            this.answ1.Name = "answ1";
            this.answ1.Size = new System.Drawing.Size(14, 13);
            this.answ1.TabIndex = 0;
            this.answ1.TabStop = true;
            this.answ1.UseVisualStyleBackColor = true;
            // 
            // answ2
            // 
            this.answ2.AutoSize = true;
            this.answ2.Location = new System.Drawing.Point(42, 213);
            this.answ2.Name = "answ2";
            this.answ2.Size = new System.Drawing.Size(14, 13);
            this.answ2.TabIndex = 0;
            this.answ2.TabStop = true;
            this.answ2.UseVisualStyleBackColor = true;
            // 
            // answ3
            // 
            this.answ3.AutoSize = true;
            this.answ3.Location = new System.Drawing.Point(42, 280);
            this.answ3.Name = "answ3";
            this.answ3.Size = new System.Drawing.Size(14, 13);
            this.answ3.TabIndex = 0;
            this.answ3.TabStop = true;
            this.answ3.UseVisualStyleBackColor = true;
            // 
            // answ4
            // 
            this.answ4.AutoSize = true;
            this.answ4.Location = new System.Drawing.Point(42, 335);
            this.answ4.Name = "answ4";
            this.answ4.Size = new System.Drawing.Size(14, 13);
            this.answ4.TabIndex = 0;
            this.answ4.TabStop = true;
            this.answ4.UseVisualStyleBackColor = true;
            // 
            // PassQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.answ4);
            this.Controls.Add(this.answ3);
            this.Controls.Add(this.answ2);
            this.Controls.Add(this.answ1);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ThemeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PassQuiz";
            //this.Text = Greeting.ofd.FileName;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PassQuiz_FormClosed);
            this.Load += new System.EventHandler(this.PassQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ThemeLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.RadioButton answ1;
        private System.Windows.Forms.RadioButton answ2;
        private System.Windows.Forms.RadioButton answ3;
        private System.Windows.Forms.RadioButton answ4;
    }
}
