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
        public Results()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            
            percentage.Text = Convert.ToString(PassQuiz.rightRatio) + "%";
            StreamReader sr = new StreamReader(@"C:\Quiz\result.txt");
            string line;
            while(!sr.EndOfStream)
            {
                line = sr.ReadLine();
                resultsBox.AppendText(line + "\n");
            }
            sr.Close();
            File.Delete(@"C:\Quiz\result.txt");
        }
    }
}
