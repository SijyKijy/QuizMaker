using System;
using System.Windows.Forms;

namespace QuizMaker.Views
{
    public partial class ResultsF : Form
    {
        private readonly double _result;
        private readonly string _answerLog;

        public ResultsF(double result, string answerLog)
        {
            InitializeComponent();

            _result = result;
            _answerLog = answerLog;
        }

        private void Results_FormClosed(object sender, FormClosedEventArgs e) => GreetingF.GetForm().Show();

        private void Results_Load(object sender, EventArgs e)
        {
            percentage.Text = $"{Math.Round(_result, 0)}%";
            resultsBox.Text = _answerLog;
        }

        private void OKBtn_Click(object sender, EventArgs e) => Close();
    }
}
