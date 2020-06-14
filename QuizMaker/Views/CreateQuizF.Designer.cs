namespace QuizMaker.Views
{
    partial class CreateQuizF
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
            this.Choice1TB = new System.Windows.Forms.TextBox();
            this.Choice2TB = new System.Windows.Forms.TextBox();
            this.Choice3TB = new System.Windows.Forms.TextBox();
            this.Choice4TB = new System.Windows.Forms.TextBox();
            this.TopicTB = new System.Windows.Forms.TextBox();
            this.MakeQuizBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddQuizBtn = new System.Windows.Forms.Button();
            this.Opt1RB = new System.Windows.Forms.RadioButton();
            this.Opt2RB = new System.Windows.Forms.RadioButton();
            this.Opt3RB = new System.Windows.Forms.RadioButton();
            this.Opt4RB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Choice1TB
            // 
            this.Choice1TB.AccessibleDescription = "Вариант 1";
            this.Choice1TB.AccessibleName = "1";
            this.Choice1TB.Location = new System.Drawing.Point(45, 89);
            this.Choice1TB.Name = "Choice1TB";
            this.Choice1TB.Size = new System.Drawing.Size(392, 20);
            this.Choice1TB.TabIndex = 2;
            this.Choice1TB.Tag = "Choice";
            // 
            // Choice2TB
            // 
            this.Choice2TB.AccessibleDescription = "Вариант 2";
            this.Choice2TB.AccessibleName = "2";
            this.Choice2TB.Location = new System.Drawing.Point(45, 135);
            this.Choice2TB.Name = "Choice2TB";
            this.Choice2TB.Size = new System.Drawing.Size(392, 20);
            this.Choice2TB.TabIndex = 3;
            this.Choice2TB.Tag = "Choice";
            // 
            // Choice3TB
            // 
            this.Choice3TB.AccessibleDescription = "Вариант 3";
            this.Choice3TB.AccessibleName = "3";
            this.Choice3TB.Location = new System.Drawing.Point(45, 181);
            this.Choice3TB.Name = "Choice3TB";
            this.Choice3TB.Size = new System.Drawing.Size(392, 20);
            this.Choice3TB.TabIndex = 4;
            this.Choice3TB.Tag = "Choice";
            // 
            // Choice4TB
            // 
            this.Choice4TB.AccessibleDescription = "Вариант 4";
            this.Choice4TB.AccessibleName = "4";
            this.Choice4TB.Location = new System.Drawing.Point(45, 226);
            this.Choice4TB.Name = "Choice4TB";
            this.Choice4TB.Size = new System.Drawing.Size(392, 20);
            this.Choice4TB.TabIndex = 5;
            this.Choice4TB.Tag = "Choice";
            // 
            // TopicTB
            // 
            this.TopicTB.AccessibleDescription = "Тема вопроса";
            this.TopicTB.AccessibleName = "0";
            this.TopicTB.Location = new System.Drawing.Point(23, 44);
            this.TopicTB.Name = "TopicTB";
            this.TopicTB.Size = new System.Drawing.Size(438, 20);
            this.TopicTB.TabIndex = 1;
            this.TopicTB.Tag = "Topic";
            // 
            // MakeQuizBtn
            // 
            this.MakeQuizBtn.Location = new System.Drawing.Point(23, 282);
            this.MakeQuizBtn.Name = "MakeQuizBtn";
            this.MakeQuizBtn.Size = new System.Drawing.Size(75, 23);
            this.MakeQuizBtn.TabIndex = 7;
            this.MakeQuizBtn.Text = "Создать";
            this.MakeQuizBtn.UseVisualStyleBackColor = true;
            this.MakeQuizBtn.Click += new System.EventHandler(this.MakeQuizBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тема вопроса:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Вариант 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Вариант 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Вариант 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Вариант 4";
            // 
            // AddQuizBtn
            // 
            this.AddQuizBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddQuizBtn.Location = new System.Drawing.Point(382, 282);
            this.AddQuizBtn.Name = "AddQuizBtn";
            this.AddQuizBtn.Size = new System.Drawing.Size(79, 23);
            this.AddQuizBtn.TabIndex = 6;
            this.AddQuizBtn.Text = "Добавить";
            this.AddQuizBtn.UseVisualStyleBackColor = true;
            this.AddQuizBtn.Click += new System.EventHandler(this.AddQuizBtn_Click);
            // 
            // Opt1RB
            // 
            this.Opt1RB.AccessibleName = "1";
            this.Opt1RB.AutoSize = true;
            this.Opt1RB.Checked = true;
            this.Opt1RB.Location = new System.Drawing.Point(444, 91);
            this.Opt1RB.Name = "Opt1RB";
            this.Opt1RB.Size = new System.Drawing.Size(14, 13);
            this.Opt1RB.TabIndex = 0;
            this.Opt1RB.TabStop = true;
            this.Opt1RB.Tag = "Option";
            this.Opt1RB.UseVisualStyleBackColor = true;
            // 
            // Opt2RB
            // 
            this.Opt2RB.AccessibleName = "2";
            this.Opt2RB.AutoSize = true;
            this.Opt2RB.Location = new System.Drawing.Point(444, 137);
            this.Opt2RB.Name = "Opt2RB";
            this.Opt2RB.Size = new System.Drawing.Size(14, 13);
            this.Opt2RB.TabIndex = 0;
            this.Opt2RB.TabStop = true;
            this.Opt2RB.Tag = "Option";
            this.Opt2RB.UseVisualStyleBackColor = true;
            // 
            // Opt3RB
            // 
            this.Opt3RB.AccessibleName = "3";
            this.Opt3RB.AutoSize = true;
            this.Opt3RB.Location = new System.Drawing.Point(444, 183);
            this.Opt3RB.Name = "Opt3RB";
            this.Opt3RB.Size = new System.Drawing.Size(14, 13);
            this.Opt3RB.TabIndex = 0;
            this.Opt3RB.TabStop = true;
            this.Opt3RB.Tag = "Option";
            this.Opt3RB.UseVisualStyleBackColor = true;
            // 
            // Opt4RB
            // 
            this.Opt4RB.AccessibleName = "4";
            this.Opt4RB.AutoSize = true;
            this.Opt4RB.Location = new System.Drawing.Point(444, 228);
            this.Opt4RB.Name = "Opt4RB";
            this.Opt4RB.Size = new System.Drawing.Size(14, 13);
            this.Opt4RB.TabIndex = 0;
            this.Opt4RB.TabStop = true;
            this.Opt4RB.Tag = "Option";
            this.Opt4RB.UseVisualStyleBackColor = true;
            // 
            // CreateQuizF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 332);
            this.Controls.Add(this.Opt4RB);
            this.Controls.Add(this.Opt3RB);
            this.Controls.Add(this.Opt2RB);
            this.Controls.Add(this.Opt1RB);
            this.Controls.Add(this.AddQuizBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MakeQuizBtn);
            this.Controls.Add(this.TopicTB);
            this.Controls.Add(this.Choice4TB);
            this.Controls.Add(this.Choice3TB);
            this.Controls.Add(this.Choice2TB);
            this.Controls.Add(this.Choice1TB);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateQuizF";
            this.Text = "Создать викторину";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Choice1TB;
        private System.Windows.Forms.TextBox Choice2TB;
        private System.Windows.Forms.TextBox Choice3TB;
        private System.Windows.Forms.TextBox Choice4TB;
        private System.Windows.Forms.TextBox TopicTB;
        private System.Windows.Forms.Button MakeQuizBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddQuizBtn;
        private System.Windows.Forms.RadioButton Opt1RB;
        private System.Windows.Forms.RadioButton Opt2RB;
        private System.Windows.Forms.RadioButton Opt3RB;
        private System.Windows.Forms.RadioButton Opt4RB;
    }
}
