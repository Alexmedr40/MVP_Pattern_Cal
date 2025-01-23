using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Pattern_Cal.Views
{
    public interface ICalculadoraViews
    {
        string PrimerNumero { get; }
        string SegundoNumero { get; }
        string Resultado { set; }

        event EventHandler SumarRequested;
        event EventHandler RestarRequested;
        event EventHandler MultiplicarRequested;
        event EventHandler DividirRequested;
        event EventHandler LimpiarRequested;

        void MostrarError(string error);
    }
}
