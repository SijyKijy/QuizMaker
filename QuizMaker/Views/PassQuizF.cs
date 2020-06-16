using System;
using System.Windows.Forms;
using QuizMaker.Contollers;

namespace QuizMaker.Views
{
    public partial class PassQuizF : Form
    {
        private readonly PassQuizController _controller;

        private readonly GreetingF _greeting;

        public PassQuizF(GreetingF greeting, string quizPath)
        {
            InitializeComponent();
            _controller = new PassQuizController(this, quizPath);
            _greeting = greeting;
        }

        private void PassQuiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            _greeting.Show();
        }

        private void PassQuiz_Load(object sender, EventArgs e) => _controller.NextQuiz(true);

        private void OkButton_Click(object sender, EventArgs e) => _controller.NextQuiz();
    }
}
