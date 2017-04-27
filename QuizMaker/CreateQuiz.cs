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

        public CreateQuiz(Greeting greeting)
        {
            InitializeComponent();
            this.greeting = greeting;
        }

        private void CreateQuiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            greeting.Show();
        }

        private void MakeQuizButton_Click(object sender, EventArgs e)
        {
            // Create a dir
            DirectoryInfo dir = new DirectoryInfo(@"C:\");
            dir.CreateSubdirectory("Quiz");
            // Create a file to write to.
            string path = @"c:\Quiz\Quiz.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(topic.Text + " ^ " + choice1.Text + " ^ " + choice2.Text + " ^ " + choice3.Text + " ^ " + choice4.Text + " _#");
            }
            makeQuizButton.Text = "Готово!";
        }
    }
}
