﻿using System;
using System.Windows.Forms;
using QuizMaker.Views;

namespace QuizMaker
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GreetingF());
        }
    }
}
