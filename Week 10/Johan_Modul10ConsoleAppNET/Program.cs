using System;
using System.Windows.Forms;

namespace Johan_Modul10ConsoleAppNET
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Menjalankan Form1
            Application.Run(new Form1());
        }
    }
}
