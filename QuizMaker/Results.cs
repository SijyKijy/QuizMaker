using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaker
{
    public partial class Results : Form
    {
        Greeting greeting;

        public Results(Greeting greeting)
        {
            InitializeComponent();
            this.greeting = greeting;
        }

        private void Results_FormClosed(object sender, FormClosedEventArgs e)
        {
            greeting.Show();
        }

        private void Results_Load(object sender, EventArgs e)
        {

            percentage.Text = Convert.ToString(PassQuiz.rightRatio) + "%";
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

        private void button1_Click(object sender, EventArgs e)
        {
            greeting.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            greeting.Show();
            this.Close();
        }
    }
}
