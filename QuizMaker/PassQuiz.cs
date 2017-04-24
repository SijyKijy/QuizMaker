using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaker
{
    public partial class PassQuiz : Form
    {
        Greeting greeting;
        public PassQuiz(Greeting greeting)
        {
            InitializeComponent();
            this.greeting = greeting;
        }

        private void PassQuiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            greeting.Show();
            this.Close();
        }
    }
}
