namespace QuizMaker
{
    partial class CreateQuiz
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
            this.choice1 = new System.Windows.Forms.TextBox();
            this.choice2 = new System.Windows.Forms.TextBox();
            this.choice3 = new System.Windows.Forms.TextBox();
            this.choice4 = new System.Windows.Forms.TextBox();
            this.topic = new System.Windows.Forms.TextBox();
            this.makeQuizButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddQuiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // choice1
            // 
            this.choice1.Location = new System.Drawing.Point(45, 89);
            this.choice1.Name = "choice1";
            this.choice1.Size = new System.Drawing.Size(392, 20);
            this.choice1.TabIndex = 2;
            // 
            // choice2
            // 
            this.choice2.Location = new System.Drawing.Point(45, 135);
            this.choice2.Name = "choice2";
            this.choice2.Size = new System.Drawing.Size(392, 20);
            this.choice2.TabIndex = 3;
            // 
            // choice3
            // 
            this.choice3.Location = new System.Drawing.Point(45, 181);
            this.choice3.Name = "choice3";
            this.choice3.Size = new System.Drawing.Size(392, 20);
            this.choice3.TabIndex = 4;
            // 
            // choice4
            // 
            this.choice4.Location = new System.Drawing.Point(45, 226);
            this.choice4.Name = "choice4";
            this.choice4.Size = new System.Drawing.Size(392, 20);
            this.choice4.TabIndex = 5;
            // 
            // topic
            // 
            this.topic.Location = new System.Drawing.Point(23, 44);
            this.topic.Name = "topic";
            this.topic.Size = new System.Drawing.Size(438, 20);
            this.topic.TabIndex = 6;
            // 
            // makeQuizButton
            // 
            this.makeQuizButton.Location = new System.Drawing.Point(23, 282);
            this.makeQuizButton.Name = "makeQuizButton";
            this.makeQuizButton.Size = new System.Drawing.Size(75, 23);
            this.makeQuizButton.TabIndex = 7;
            this.makeQuizButton.Text = "Создать";
            this.makeQuizButton.UseVisualStyleBackColor = true;
            this.makeQuizButton.Click += new System.EventHandler(this.MakeQuizButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Тема вопроса:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вариант 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Вариант 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Вариант 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Вариант 4";
            // 
            // AddQuiz
            // 
            this.AddQuiz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddQuiz.Location = new System.Drawing.Point(382, 282);
            this.AddQuiz.Name = "AddQuiz";
            this.AddQuiz.Size = new System.Drawing.Size(79, 23);
            this.AddQuiz.TabIndex = 13;
            this.AddQuiz.Text = "Добавить";
            this.AddQuiz.UseVisualStyleBackColor = true;
            this.AddQuiz.Click += new System.EventHandler(this.AddQuiz_Click);
            // 
            // CreateQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 332);
            this.Controls.Add(this.AddQuiz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.makeQuizButton);
            this.Controls.Add(this.topic);
            this.Controls.Add(this.choice4);
            this.Controls.Add(this.choice3);
            this.Controls.Add(this.choice2);
            this.Controls.Add(this.choice1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateQuiz";
            this.Text = "Создать викторину";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateQuiz_FormClosed);
            this.Load += new System.EventHandler(this.CreateQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox choice1;
        private System.Windows.Forms.TextBox choice2;
        private System.Windows.Forms.TextBox choice3;
        private System.Windows.Forms.TextBox choice4;
        private System.Windows.Forms.TextBox topic;
        private System.Windows.Forms.Button makeQuizButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddQuiz;
    }
}