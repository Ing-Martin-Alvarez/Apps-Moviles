using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraIMCxam
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnoperacion_Clicked(object sender, EventArgs e)
        {
            String cad = altura.Text;
            float estatura = float.Parse(cad);

            String pesamos = pesito.Text;
            float peso = float.Parse(pesamos);

            CalculadoraIMC(estatura, peso);
        }
        private void CalculadoraIMC(float estatura, float peso)
        {
            String msg;

            float imc = peso / (float)Math.Pow(estatura, 2);
            if(imc < 18.5) { msg = "Tienes Bajo Peso"; }
            else if(imc >= 18.5 && imc < 25) { msg = "Tu Peso es Normal"; }
            else if (imc >= 25 &&  imc < 30) { msg = "Tienes Sobrepeso"; }
            else if (imc >= 30 &&  imc <35) { msg = "Tienes Obesidad grado 1"; }
            else if (imc >= 35 && imc < 40) { msg = "Tienes Obesidad grado 2"; }
            else { msg = "Tienes Obesidad grado 3"; }

            imprimirModal(imc, msg);
        }

        private void imprimirModal(float imc, string msg)
        {
            DisplayAlert("Tu IMC", imc + "\n" + msg, "Aceptar");
        }
    }
}
