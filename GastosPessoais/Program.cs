using DevExpress.XtraSplashScreen;
using GastosPessoais.Properties;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace GastosPessoais
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new form_login());
            
        }
    }
}
