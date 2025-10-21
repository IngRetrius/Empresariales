using System;
using System.Windows.Forms;
using AgropecuarioCliente.Forms;

namespace AgropecuarioCliente
{
    /// <summary>
    /// Punto de entrada principal para la aplicación.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
        }
    }
}