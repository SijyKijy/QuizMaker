using System.Windows.Forms;
using QuizMaker.Views;

namespace QuizMaker.Contollers
{
    public class GreetingController : FormController
    {
        private readonly GreetingF _initF;

        internal GreetingController(GreetingF init) : base(init)
        {
            _initF = init;
        }

        public void LoadQuizFile()
        {
            OpenFileDialog fd = new OpenFileDialog { Filter = "Файлы викторины|*.qm" };
            fd.ShowDialog();
            if (!string.IsNullOrEmpty(fd.FileName))
                OpenForm(new PassQuizF(_initF));
        }

        public void InitCreateQuizF() => OpenForm(new CreateQuizF(_initF));
    }
}
