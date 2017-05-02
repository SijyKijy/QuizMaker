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
    public partial class Greeting : Form
    {
         
        public static OpenFileDialog Ofd = new OpenFileDialog { Filter = "Текстовые файлы|*.txt" };
        public Greeting()
        {
            InitializeComponent();
        }

        private void GoQuizButton_Click(object sender, EventArgs e)
        {
            
            
            Ofd.ShowDialog();
            PassQuiz.path = Ofd.FileName;
            try
            {
                if (Ofd.FileName != null)
                {
                    Form f = new PassQuiz(this);
                    f.Show();
                    this.Hide();
                }
            }
            catch (ArgumentException)
            {

            }
        }

        private void CreateQuizButto_Click(object sender, EventArgs e)
        {
            Form f = new CreateQuiz(this);
            f.Show();
            this.Hide();
        }

   
    }
}
