using MVP_Pattern_Cal.Models;
using MVP_Pattern_Cal.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_Pattern_Cal
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var model = new CalculadoraModel();
            var view = new CalculadoraForm();
            var presenter = new CalculadoraPresenter(view, model);

            Application.Run(view as Form);
        }
    }
}
