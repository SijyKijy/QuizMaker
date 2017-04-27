using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuizMaker
{
    public partial class CreateQuiz : Form
    {
        Greeting greeting;
        string path = @"c:\Quiz\Quiz.txt";

        public CreateQuiz(Greeting greeting)
        {
            InitializeComponent();
            this.greeting = greeting;
        }


        private void CreateQuiz_Load(object sender, EventArgs e)
        {
            // Создание директории и файла для редактирования.
            DirectoryInfo dir = new DirectoryInfo(@"C:\");
            dir.CreateSubdirectory("Quiz");
            using (StreamWriter sw = File.CreateText(path))
            {
                File.SetAttributes(path, FileAttributes.Hidden);
            }
        }

        private void CreateQuiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            greeting.Show();
        }

        private void MakeQuizButton_Click(object sender, EventArgs e)
        {
            // Создание окончательного файла для викторины.
            string value = "Моя викторина";
            if (InputBoxClass.InputBox("Название викторины", "Введите название викторины:", ref value) == DialogResult.OK)
            {
                try
                {
                    File.SetAttributes(path, FileAttributes.Normal);
                    File.Move(path, @"c:\Quiz\" + value + ".txt");
                    this.Close();
                }
                catch (IOException)
                {
                    MessageBox.Show("Файл не найден!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (System.ArgumentException)
                {
                    MessageBox.Show("Недопустимое имя файла!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddQuiz_Click(object sender, EventArgs e)
        {
            // Добавление текста.
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(topic.Text + " ^ " + choice1.Text + " ^ " + choice2.Text + " ^ " + choice3.Text + " ^ " + choice4.Text + " _#");
                sw.WriteLine("===\n");
                topic.Clear();
                choice1.Clear();
                choice2.Clear();
                choice3.Clear();
                choice4.Clear();
                sw.Close();
            }
        }
    }
}
