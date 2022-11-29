using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supervisório___Correia
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        //[STAThread]
        //[MTAThread]
        static void Main()
        {
            TitaniumAS.Opc.Client.Bootstrap.Initialize();
            var thread = new Thread(RunApplication);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        static void RunApplication()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

}
