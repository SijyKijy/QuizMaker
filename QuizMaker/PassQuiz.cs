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
    public partial class PassQuiz : Form
    {
        Greeting greeting;
        //string path = @"c:\Quiz\Quiz.txt";

        public PassQuiz(Greeting greeting)
        {
            InitializeComponent();
            this.greeting = greeting;
        }
        private void PassQuiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            greeting.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = "Test";
            if (InputBoxClass.InputBox("Название викторины", "Введите название викторины:", ref value) == DialogResult.OK)
            {
                string path = @"c:\Quiz\" + value + ".txt";
                StreamReader reader = new StreamReader(path);
                while (!reader.EndOfStream)
                {
                    //str += reader.ReadLine();
                    string s_line = reader.ReadLine();
                    if (s_line.StartsWith("?"))
                    {
                        s_line = s_line.Substring(1);
                        ThemeLabel.Text = s_line;
                    }
                    else if (s_line.StartsWith("1!"))
                    {
                        s_line = s_line.Substring(2);
                        Q1Label.Text = s_line;
                    }
                    else if (s_line.StartsWith("2!"))
                    {
                        s_line = s_line.Substring(2);
                        Q2Label.Text = s_line;
                    }
                    else if (s_line.StartsWith("3!"))
                    {
                        s_line = s_line.Substring(2);
                        Q3Label.Text = s_line;
                    }
                    else if (s_line.StartsWith("4!"))
                    {
                        s_line = s_line.Substring(2);
                        Q4Label.Text = s_line;
                    }
                    else if (s_line.StartsWith("*!"))
                    {

                    }
                    else if (s_line.StartsWith("==="))
                    {
                        Console.WriteLine("STOOOOOOP!");
                    }
                }
            }
        }
    }
}
