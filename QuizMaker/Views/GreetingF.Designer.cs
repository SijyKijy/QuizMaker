namespace QuizMaker.Views
{
    partial class GreetingF
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
            this.CreateQuizBtn = new System.Windows.Forms.Button();
            this.LoadQuizBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateQuizBtn
            // 
            this.CreateQuizBtn.Location = new System.Drawing.Point(239, 285);
            this.CreateQuizBtn.Name = "CreateQuizBtn";
            this.CreateQuizBtn.Size = new System.Drawing.Size(171, 40);
            this.CreateQuizBtn.TabIndex = 0;
            this.CreateQuizBtn.Text = "Создать викторину";
            this.CreateQuizBtn.UseVisualStyleBackColor = true;
            this.CreateQuizBtn.Click += new System.EventHandler(this.CreateQuizBtn_Click);
            // 
            // LoadQuizBtn
            // 
            this.LoadQuizBtn.Location = new System.Drawing.Point(239, 360);
            this.LoadQuizBtn.Name = "LoadQuizBtn";
            this.LoadQuizBtn.Size = new System.Drawing.Size(171, 40);
            this.LoadQuizBtn.TabIndex = 0;
            this.LoadQuizBtn.Text = "Пройти викторину";
            this.LoadQuizBtn.UseVisualStyleBackColor = true;
            this.LoadQuizBtn.Click += new System.EventHandler(this.LoadQuizBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuizMaker.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(175, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 234);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GreetingF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 463);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoadQuizBtn);
            this.Controls.Add(this.CreateQuizBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GreetingF";
            this.Text = "Quize Maker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateQuizBtn;
        private System.Windows.Forms.Button LoadQuizBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

