using MVP_Pattern_Cal.Models;
using MVP_Pattern_Cal.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Pattern_Cal.Presenters
{
    public class CalculadoraPresenter
    {
        private readonly ICalculadoraViews _view;
        private readonly CalculadoraModel  _model;

        public CalculadoraPresenter(ICalculadoraViews view, CalculadoraModel model)
        {
            _view = view;
            _model = model;

            _view.SumarRequested += OnSumarRequested;
            _view.RestarRequested += OnRestarRequested;
            _view.MultiplicarRequested += OnMultiplicarRequested;
            _view.DividirRequested += OnDividirRequested;
            _view.LimpiarRequested += OnLimpiarRequested;
        }

        private void OnSumarRequested(object sender, EventArgs e) => Calcular((a, b) => _model.Sumar(a, b));
        private void OnRestarRequested(object sender, EventArgs e) => Calcular((a, b) => _model.Restar(a, b));
        private void OnMultiplicarRequested(object sender, EventArgs e) => Calcular((a, b) => _model.Multiplicar(a, b));
        private void OnDividirRequested(object sender, EventArgs e) => Calcular((a, b) => _model.Dividir(a, b));

        private void OnLimpiarRequested(object sender, EventArgs e)
        {
            _view.Resultado = string.Empty;
            _view.PrimerNumero =  string.Empty;
            _view.SegundoNumero = string.Empty;
        }

        private void Calcular(Func<double, double, double> operation)
        {
            try
            {
                if (double.TryParse(_view.PrimerNumero, out double firstNumber) &&
                    double.TryParse(_view.SegundoNumero, out double secondNumber))
                {
                    double result = operation(firstNumber, secondNumber);
                    _view.Resultado = result.ToString();
                }
                else
                {
                    _view.MostrarError("Por favor, introduce números válidos.");
                }
            }
            catch (Exception ex)
            {
                _view.MostrarError(ex.Message);
            }
        }

    }
}
