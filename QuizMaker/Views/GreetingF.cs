using System;
using System.Windows.Forms;
using QuizMaker.Contollers;

namespace QuizMaker.Views
{
    public partial class GreetingF : Form
    {
        private readonly GreetingController _controller;
        private static GreetingF s_mainForm;

        public GreetingF()
        {
            InitializeComponent();
            _controller = new GreetingController(this);
            s_mainForm = this;
        }

        public static GreetingF GetForm() => s_mainForm;

        private void LoadQuizBtn_Click(object sender, EventArgs e) => _controller.LoadQuizFile();

        private void CreateQuizBtn_Click(object sender, EventArgs e) => _controller.InitCreateQuizF();
    }
}
