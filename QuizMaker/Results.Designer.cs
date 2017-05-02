namespace QuizMaker
{
    partial class Results
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.percentage.TabIndex = 1;
            this.percentage.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.percentage);
            this.Controls.Add(this.resultsBox);
            this.Name = "Results";
            this.Text = "Ваши результаты";
            this.Load += new System.EventHandler(this.Results_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox resultsBox;
        private System.Windows.Forms.Label percentage;
        private System.Windows.Forms.Button button1;
    }
}