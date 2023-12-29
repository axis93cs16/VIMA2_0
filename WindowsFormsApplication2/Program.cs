using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIMA2_0
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new Form2();
            Application.Run(new Form1());
            //AXVLC.VLCPlugin2 axVLCPlugin21my2 = new AXVLC.VLCPlugin2();
        }
    }
}
