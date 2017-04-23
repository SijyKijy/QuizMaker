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
        public PassQuiz()
        {
            InitializeComponent();
        }

        private void PassQuiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
