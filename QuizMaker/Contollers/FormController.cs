using System.Windows.Forms;

namespace QuizMaker.Contollers
{
    public abstract class FormController // Основная логика для формочек
    {
        private readonly Form _initF;

        internal FormController(Form initForm) => _initF = initForm;

        public void OpenForm(Form openForm, bool isMain = false)
        {
            if (isMain) _initF.Hide();
            else _initF.Close();
            openForm.Show();
        }

        public void CloseForm(Form previousForm)
        {
            _initF.Close();
            previousForm.Show();
        }
    }
}
