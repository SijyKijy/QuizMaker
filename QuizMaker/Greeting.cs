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
        Form f;
        
        public Greeting()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f = new PassQuiz();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f = new CreateQuiz();
            f.Show();
            this.Hide();
        }

        
    }
}
