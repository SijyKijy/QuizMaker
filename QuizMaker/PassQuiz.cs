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
        public static string path = @"";
        int rightAnswer = 0;
        int userAnswer = 0;
        int counter = 1;
        public static double rightRatio = 0;
        bool canRead = true;
        StreamReader reader = new StreamReader(path);
        FileInfo result = new FileInfo(@"C:\Quiz\result.txt");

        public PassQuiz(Greeting greeting)
        {
            InitializeComponent();
            this.greeting = greeting;
        }
        private void PassQuiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            greeting.Show();
        }   

        private void PassQuiz_Load(object sender, EventArgs e)
        {
            QuestionLoader();      
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Checker();
            CompareAnswers(rightAnswer);
            counter++;
            
            if (canRead)
            { 
                QuestionLoader();
            }
            else
            {
                /*     Form s = new Results();
                     s.Show();
                     this.Close();
                rightRatio = rightRatio / Convert.ToDouble(counter) * 100;
                */
                this.Close();
            }
            
        }

        private void QuestionLoader()
        {
            
            while (!reader.EndOfStream)
            {
                string s_line = reader.ReadLine();
                if (s_line.StartsWith("?"))
                {
                    s_line = s_line.Substring(1);
                    ThemeLabel.Text = s_line;
                }
                else if (s_line.StartsWith("1!"))
                {
                    s_line = s_line.Substring(2);
                    answ1.Text = s_line;
                }
                else if (s_line.StartsWith("2!"))
                {
                    s_line = s_line.Substring(2);
                    answ2.Text = s_line;
                }
                else if (s_line.StartsWith("3!"))
                {
                    s_line = s_line.Substring(2);
                    answ3.Text = s_line;
                }
                else if (s_line.StartsWith("4!"))
                {
                    s_line = s_line.Substring(2);
                    answ4.Text = s_line;
                }
                else if (s_line.StartsWith("*!"))
                {
                    s_line = s_line.Substring(2);
                    rightAnswer = Convert.ToInt32(s_line);
                    
                }
                
                else if (s_line.StartsWith("==="))
                {
                    break;
                }    

            }
            
        }

        private void CompareAnswers(int s)
        {
            
            if (answ1.Checked)
            {
                userAnswer = 1;
            }
            else if (answ2.Checked)
            {
                userAnswer = 2;
            }
            else if (answ3.Checked)
            {
                userAnswer = 3;
            }
            else if (answ4.Checked)
            {
                userAnswer = 4;
            }

            if (userAnswer == s)
            {
                using (StreamWriter sw = result.AppendText())
                {
                    sw.WriteLine("Вопрос №" + counter + ": Верно!");
                    rightRatio++;
                    sw.Close();
                }
            }
            else
            {
                using (StreamWriter sw = result.AppendText())
                {
                    sw.WriteLine("Вопрос №" + counter + ": Неверно!");
                    sw.Close();
                }
            }
            
            

        }
        private void Checker()
        {
            if(reader.EndOfStream)
            {
                canRead = false;
            }
        }

        
    }
}
