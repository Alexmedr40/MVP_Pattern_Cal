using MVP_Pattern_Cal.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP_Pattern_Cal.Models;


namespace MVP_Pattern_Cal
{
    public partial class CalculadoraForm : Form, ICalculadoraViews
    {
        public CalculadoraForm()
        {
            InitializeComponent();
            BtnSumar.Click += (sender, e) => SumarRequested?.Invoke(sender, e);
            BtnRestar.Click += (sender, e) => RestarRequested?.Invoke(sender, e);
            BtnMult.Click += (sender, e) => MultiplicarRequested?.Invoke(sender, e);
            BtnDividir.Click += (sender, e) => DividirRequested?.Invoke(sender, e);
            BtnClean.Click += (sender, e) => LimpiarRequested?.Invoke(sender, e);
        }

        public string PrimerNumero
        {
            get => txtFirstNumber.Text;
            set => txtFirstNumber.Text = value;
        }

        public string SegundoNumero
        {
            get => txtSecondNumber.Text;
            set => txtSecondNumber.Text = value;
        }

        public string Resultado { set => lblResultado.Text = value; }

        public event EventHandler SumarRequested;
        public event EventHandler RestarRequested;
        public event EventHandler MultiplicarRequested;
        public event EventHandler DividirRequested;
        public event EventHandler LimpiarRequested;

        public void MostrarError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void LimpiarCampos() 
        {
            txtFirstNumber.Clear();
            txtSecondNumber.Clear();
            lblResultado.Text = string.Empty;
        }
    }
}
