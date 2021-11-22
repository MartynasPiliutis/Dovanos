using Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DovanosWinApp
{
    static class Program
    {
        public static VaikuBiblioteka vaikuBiblioteka = new VaikuBiblioteka();
        public static DovanuBiblioteka dovanuBiblioteka = new DovanuBiblioteka();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new dovanosApp());
        }
    }
}
