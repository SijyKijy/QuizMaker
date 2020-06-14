using System;
using System.Windows.Forms;
using QuizMaker.Contollers;

namespace QuizMaker.Views
{
    public partial class CreateQuizF : Form
    {
        private readonly CreateQuizController _controller;

        public CreateQuizF(GreetingF greeting)
        {
            InitializeComponent();
            _controller = new CreateQuizController(this, greeting);
        }

        private void MakeQuizBtn_Click(object sender, EventArgs e) => _controller.CreateQuizFile();

        private void AddQuizBtn_Click(object sender, EventArgs e) => _controller.AddQuiz();
    }
}
