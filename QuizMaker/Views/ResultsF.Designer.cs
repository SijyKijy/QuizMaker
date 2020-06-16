namespace QuizMaker.Views
{
    partial class ResultsF
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
            this.resultsBox = new System.Windows.Forms.RichTextBox();
            this.percentage = new System.Windows.Forms.Label();
            this.OKBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultsBox
            // 
            this.resultsBox.Location = new System.Drawing.Point(12, 12);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(357, 231);
            this.resultsBox.TabIndex = 0;
            this.resultsBox.Text = "";
            // 
            // percentage
            // 
            this.percentage.AutoSize = true;
            this.percentage.BackColor = System.Drawing.SystemColors.Control;
            this.percentage.Cursor = System.Windows.Forms.Cursors.Default;
            this.percentage.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage.ForeColor = System.Drawing.SystemColors.Highlight;
            this.percentage.Location = new System.Drawing.Point(38, 249);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(137, 61);
            this.percentage.TabIndex = 0;
            this.percentage.Text = "label1";
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(273, 275);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 0;
            this.OKBtn.Text = "ОК";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // ResultsF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 319);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.percentage);
            this.Controls.Add(this.resultsBox);
            this.Name = "ResultsF";
            this.Text = "Ваши результаты";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Results_FormClosed);
            this.Load += new System.EventHandler(this.Results_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox resultsBox;
        private System.Windows.Forms.Label percentage;
        private System.Windows.Forms.Button OKBtn;
    }
}
