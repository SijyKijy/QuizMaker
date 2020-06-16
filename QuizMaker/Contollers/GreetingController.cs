using System;
using System.Windows.Forms;
using QuizMaker.Views;

namespace QuizMaker.Contollers
{
    public class GreetingController : FormController
    {
        private readonly GreetingF _initF;

        internal GreetingController(GreetingF initForm) : base(initForm) => _initF = initForm;

        public void LoadQuizFile()
        {
            OpenFileDialog fd = new OpenFileDialog
            {
                Filter = "Файлы викторины|*.qm",
                Title = "Выберите файл с викториной",
                InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + Properties.Settings.Default.FolderName
            };

            fd.ShowDialog();

            if (!string.IsNullOrEmpty(fd.FileName))
                OpenForm(new PassQuizF(_initF, fd.FileName), true);
        }

        public void InitCreateQuizF() => OpenForm(new CreateQuizF(_initF), true);
    }
}
