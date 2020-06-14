using System.Windows.Forms;

namespace QuizMaker.Contollers
{
    public abstract class FormController // Основная логика для формочек
    {
        private readonly Form _initF;

        internal FormController(Form init)
        {
            _initF = init;
        }

        public void OpenForm(Form openForm)
        {
            _initF.Hide();
            openForm.Show();
        }

        public void CloseForm(Form previousForm)
        {
            _initF.Close();
            previousForm.Show();
        }
    }
}
