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
    public partial class CreateQuiz : Form
    {
        Greeting greeting;
        public CreateQuiz(Greeting greeting)
        {
            InitializeComponent();
            this.greeting = greeting;
        }

        private void CreateQuiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            greeting.Show();
            this.Hide();
        }
    }
}
