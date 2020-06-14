using System;
using System.IO;
using System.Windows.Forms;

namespace QuizMaker.Views
{
    public partial class ResultsF : Form
    {
        private readonly GreetingF _greeting;

        public ResultsF(GreetingF greeting)
        {
            InitializeComponent();
            _greeting = greeting;
        }

        private void Results_FormClosed(object sender, FormClosedEventArgs e)
        {
            _greeting.Show();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            percentage.Text = Convert.ToString(PassQuizF.RightRatio) + "%";
            StreamReader sr = new StreamReader(@"C:\Quiz\result.txt");
            string line;
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                resultsBox.AppendText(line + "\n");
            }
            sr.Close();
            File.Delete(@"C:\Quiz\result.txt");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _greeting.Show();
            Close();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            _greeting.Show();
            Close();
        }
    }
}
