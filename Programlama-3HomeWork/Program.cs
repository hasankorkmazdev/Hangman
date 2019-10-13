using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programlama_3HomeWork
{
    static class Program
    {
        public static Form1 f1;
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>

        [STAThread]
    
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Creater());
        }
        public static  Form1 Creater()
        {
            f1 = new Form1();
            return f1;
        }
    }
}
