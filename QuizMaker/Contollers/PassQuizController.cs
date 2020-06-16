using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using QuizMaker.Models;
using QuizMaker.Views;

namespace QuizMaker.Contollers
{
    public class PassQuizController : FormController
    {
        private readonly PassQuizF _initF;
        private readonly string _quizPath;
        private readonly List<Quiz> _quizzes;

        private int _rightAnswer = 0; // Количество верных ответов
        private int _index = 0; // Текущий индекс в викторине
        private string _answerLog = default; // Лог ответов

        public PassQuizController(PassQuizF initForm, string quizPath) : base(initForm)
        {
            _initF = initForm;
            _quizPath = quizPath;
            _quizzes = DeserializeQuiz();
        }

        public void NextQuiz(bool isFirst = false)
        {
            if (isFirst)
            {
                LoadQuiz(_quizzes[_index]);
            }
            else
            {
                AddAnswerLog(CheckAnswer(_index - 1));

                if (_index < _quizzes.Count)
                {
                    LoadQuiz(_quizzes[_index]);
                }
                else
                {
                    ShowResult();
                    _initF.Close();
                }
            }
        }

        private void ShowResult() => OpenForm(new ResultsF(CalculateResult(), _answerLog));

        private double CalculateResult() => (double)_rightAnswer / _quizzes.Count * 100;

        private bool CheckAnswer(int index)
        {
            foreach (var control in _initF.Controls)
            {
                if (control is RadioButton rb && rb.Checked && rb.AccessibleName == _quizzes[index].RightQuestion)
                {
                    rb.Checked = false;
                    _rightAnswer++;
                    return true;
                }
            }
            return false;
        }

        private void AddAnswerLog(bool isRight)
        {
            if (isRight) _answerLog += $"Вопрос №{_index - 1}: Верно!" + Environment.NewLine;
            else _answerLog += $"Вопрос №{_index - 1}: Неверно!" + Environment.NewLine;
        }

        private void LoadQuiz(Quiz quiz)
        {
            _initF.Controls["ThemeLabel"].Text = quiz.Title;

            foreach (var question in quiz.Questions)
            {
                switch (question.Index)
                {
                    case 1:
                        _initF.Controls["answ1"].Text = question.Content;
                        break;
                    case 2:
                        _initF.Controls["answ2"].Text = question.Content;
                        break;
                    case 3:
                        _initF.Controls["answ3"].Text = question.Content;
                        break;
                    case 4:
                        _initF.Controls["answ4"].Text = question.Content;
                        break;
                }
            }

            _index++;
        }

        private List<Quiz> DeserializeQuiz()
        {
            using (FileStream fs = new FileStream(_quizPath, FileMode.Open))
                return (List<Quiz>)new BinaryFormatter().Deserialize(fs);
        }
    }
}
