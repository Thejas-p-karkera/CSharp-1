using System;
using System.Windows.Forms;

namespace C__WindowsForm_Assignment
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2()); // Ensure Form1 is the correct form name
        }
    }
}
