namespace QuizMaker
{
    partial class Greeting
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
            this.CreateQuizButton = new System.Windows.Forms.Button();
            this.GoQuizButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateQuizButton
            // 
            this.CreateQuizButton.Location = new System.Drawing.Point(239, 285);
            this.CreateQuizButton.Name = "CreateQuizButton";
            this.CreateQuizButton.Size = new System.Drawing.Size(171, 40);
            this.CreateQuizButton.TabIndex = 0;
            this.CreateQuizButton.Text = "Создать викторину";
            this.CreateQuizButton.UseVisualStyleBackColor = true;
            this.CreateQuizButton.Click += new System.EventHandler(this.CreateQuizButto_Click);
            // 
            // GoQuizButton
            // 
            this.GoQuizButton.Location = new System.Drawing.Point(239, 360);
            this.GoQuizButton.Name = "GoQuizButton";
            this.GoQuizButton.Size = new System.Drawing.Size(171, 40);
            this.GoQuizButton.TabIndex = 1;
            this.GoQuizButton.Text = "Пройти викторину";
            this.GoQuizButton.UseVisualStyleBackColor = true;
            this.GoQuizButton.Click += new System.EventHandler(this.GoQuizButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuizMaker.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(175, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 234);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Greeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 463);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GoQuizButton);
            this.Controls.Add(this.CreateQuizButton);
            this.Name = "Greeting";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateQuizButton;
        private System.Windows.Forms.Button GoQuizButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

