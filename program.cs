using System;
using System.Windows.Forms;
using JogoAdivinhacao.Views;

namespace JogoAdivinhacao
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
}
