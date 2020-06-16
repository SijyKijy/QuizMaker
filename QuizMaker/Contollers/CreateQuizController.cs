using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using QuizMaker.Models;
using QuizMaker.Views;

namespace QuizMaker.Contollers
{
    public class CreateQuizController : FormController
    {
        private readonly List<Quiz> _quiz;

        private readonly CreateQuizF _initF;
        private readonly Form _previousF;

        internal CreateQuizController(CreateQuizF initForm, Form previous) : base(initForm)
        {
            _quiz = new List<Quiz>();

            _initF = initForm;
            _previousF = previous;
        }

        public void CreateQuizFile()
        {
            if (_quiz.Count == 0)
            {
                MessageBox.Show("Добавьте хотя бы один вопрос!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string quizName = "Моя викторина";
            if (InputBoxClass.InputBox("Название викторины", "Введите название викторины:", ref quizName) == DialogResult.OK)
            {
                try
                {
                    Directory.CreateDirectory(Properties.Settings.Default.FolderName);
                    using (FileStream fs = new FileStream($"{Properties.Settings.Default.FolderName}/{quizName}.qm", FileMode.Create))
                        new BinaryFormatter().Serialize(fs, _quiz);

                    MessageBox.Show("Викторина сохранена!", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CloseForm(_previousF);
                }
                catch (IOException)
                {
                    MessageBox.Show("Файл не найден!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Недопустимое имя файла!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Нет доступа!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void AddQuiz()
        {
            string rightQuestion = default;
            string title = default;
            List<Question> questions = new List<Question>();

            foreach (Control component in _initF.Controls)
            {
                if (component.Tag != null && component is TextBox tb) // Поля ввода (Тема и вопросы)
                {
                    if (string.IsNullOrEmpty(tb.Text.Trim(' ')))
                    {
                        MessageBox.Show($"{tb.AccessibleDescription} не заполнен(а)!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    switch ((string)tb.Tag) // Узнаём какое поле "тема", а какое "вопрос"
                    {
                        case "Topic":
                            title = tb.Text.Trim(' ');
                            break;
                        case "Choice":
                            questions.Add(new Question(index: Convert.ToInt32(tb.AccessibleName), content: tb.Text.Trim(' ')));
                            break;
                    }
                    tb.Clear(); // TODO: Фиксануть стирание текста при не полном заполнении
                }

                if ((component is RadioButton rb) && rb.Checked && (string)rb.Tag == "Option") // Кнопки ответа
                    rightQuestion = rb.AccessibleName;
            }

            _quiz.Add(new Quiz(title, questions, rightQuestion)); // Добавляем всё в коллекцию викторин
        }
    }
}
