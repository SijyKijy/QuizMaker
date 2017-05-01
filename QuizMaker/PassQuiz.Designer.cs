namespace QuizMaker
{
    partial class PassQuiz
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
            this.Q1Label = new System.Windows.Forms.Label();
            this.Q2Label = new System.Windows.Forms.Label();
            this.Q3Label = new System.Windows.Forms.Label();
            this.Q4Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.Location = new System.Drawing.Point(199, 26);
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
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // Q1Label
            // 
            this.Q1Label.AutoSize = true;
            this.Q1Label.Location = new System.Drawing.Point(30, 140);
            this.Q1Label.Name = "Q1Label";
            this.Q1Label.Size = new System.Drawing.Size(43, 13);
            this.Q1Label.TabIndex = 2;
            this.Q1Label.Text = "Ответ1";
            // 
            // Q2Label
            // 
            this.Q2Label.AutoSize = true;
            this.Q2Label.Location = new System.Drawing.Point(373, 140);
            this.Q2Label.Name = "Q2Label";
            this.Q2Label.Size = new System.Drawing.Size(43, 13);
            this.Q2Label.TabIndex = 3;
            this.Q2Label.Text = "Ответ2";
            // 
            // Q3Label
            // 
            this.Q3Label.AutoSize = true;
            this.Q3Label.Location = new System.Drawing.Point(30, 301);
            this.Q3Label.Name = "Q3Label";
            this.Q3Label.Size = new System.Drawing.Size(43, 13);
            this.Q3Label.TabIndex = 4;
            this.Q3Label.Text = "Ответ3";
            // 
            // Q4Label
            // 
            this.Q4Label.AutoSize = true;
            this.Q4Label.Location = new System.Drawing.Point(373, 301);
            this.Q4Label.Name = "Q4Label";
            this.Q4Label.Size = new System.Drawing.Size(43, 13);
            this.Q4Label.TabIndex = 5;
            this.Q4Label.Text = "Ответ4";
            // 
            // PassQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Q4Label);
            this.Controls.Add(this.Q3Label);
            this.Controls.Add(this.Q2Label);
            this.Controls.Add(this.Q1Label);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ThemeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PassQuiz";
            this.Text = "Пройти викторину";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PassQuiz_FormClosed);
            this.Load += new System.EventHandler(this.PassQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ThemeLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label Q1Label;
        private System.Windows.Forms.Label Q2Label;
        private System.Windows.Forms.Label Q3Label;
        private System.Windows.Forms.Label Q4Label;
    }
}