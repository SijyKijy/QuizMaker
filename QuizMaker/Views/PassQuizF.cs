using System;
using System.IO;
using System.Windows.Forms;

namespace QuizMaker.Views
{
    public partial class PassQuizF : Form
    {
        private readonly GreetingF _greeting;
        public static string Path = "";
        private int _rightAnswer = 0;
        private int _userAnswer = 0;
        private int _counter = 0;
        public static double RightRatio = 0;
        private bool _canRead = true;
        private bool _isOpened = false;
        private readonly StreamReader _reader = new StreamReader(Path);
        private readonly FileInfo _result = new FileInfo(@"C:\Quiz\result.txt");

        public PassQuizF(GreetingF greeting)
        {
            InitializeComponent();
            this._greeting = greeting;
        }
        private void PassQuiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_isOpened)
            {
                _greeting.Show();
            }
        }

        private void PassQuiz_Load(object sender, EventArgs e)
        {
            QuestionLoader();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Checker();
            CompareAnswers(_rightAnswer);
            _counter++;

            if (_canRead)
            {
                QuestionLoader();
            }
            else
            {
                RightRatio = RightRatio / Convert.ToDouble(_counter) * 100;
                RightRatio = Math.Round(RightRatio);
                Form s = new ResultsF(_greeting);
                s.Show();
                _isOpened = true;
                Close();
            }
            answ1.Checked = false;
            answ2.Checked = false;
            answ3.Checked = false;
            answ4.Checked = false;
        }

        private void QuestionLoader()
        {
            while (!_reader.EndOfStream)
            {
                string line = _reader.ReadLine();
                if (line.StartsWith("?"))
                {
                    line = line.Substring(1);
                    ThemeLabel.Text = line;
                }
                else if (line.StartsWith("1!"))
                {
                    line = line.Substring(2);
                    answ1.Text = line;
                }
                else if (line.StartsWith("2!"))
                {
                    line = line.Substring(2);
                    answ2.Text = line;
                }
                else if (line.StartsWith("3!"))
                {
                    line = line.Substring(2);
                    answ3.Text = line;
                }
                else if (line.StartsWith("4!"))
                {
                    line = line.Substring(2);
                    answ4.Text = line;
                }
                else if (line.StartsWith("*!"))
                {
                    line = line.Substring(2);
                    _rightAnswer = Convert.ToInt32(line);
                }
                else if (line.StartsWith("==="))
                {
                    break;
                }
            }
        }

        private void CompareAnswers(int s)
        {
            if (answ1.Checked)
            {
                _userAnswer = 1;
            }
            else if (answ2.Checked)
            {
                _userAnswer = 2;
            }
            else if (answ3.Checked)
            {
                _userAnswer = 3;
            }
            else if (answ4.Checked)
            {
                _userAnswer = 4;
            }

            if (_userAnswer == s)
            {
                using (StreamWriter sw = _result.AppendText())
                {
                    sw.WriteLine("Вопрос №" + _counter + ": Верно!");
                    RightRatio++;
                }
            }
            else
            {
                using (StreamWriter sw = _result.AppendText())
                {
                    sw.WriteLine("Вопрос №" + _counter + ": Неверно!");
                }
            }
        }

        private void Checker()
        {
            if (_reader.EndOfStream)
            {
                _canRead = false;
            }
        }
    }
}
