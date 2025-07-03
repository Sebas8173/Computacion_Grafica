using System;
using System.Windows.Forms;

namespace Algoritmo_de_punto_medio
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FrmHome.Instance); // Usar Singleton
        }
    }
}