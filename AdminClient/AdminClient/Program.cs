using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminClient
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPage());
            //Application.Run(new Members());
            //Application.Run(new Orders());
            //Application.Run(new Products());
            //Application.Run(new BlackList());
            //Application.Run(new Chart());
            
        }
    }
}
