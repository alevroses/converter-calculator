using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Conversor.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Convertir : ContentPage
    {
        double n1;
        double n2;
        double result;

        public Convertir()
        {
            InitializeComponent();
        }

        private void Calcular()
        {
            n1 = Convert.ToDouble(txtn1.Text);
            n2 = Convert.ToDouble(txtn2.Text);
            result = n1 + n2;
            lblresultado.Text = result.ToString();
        }

        private void Validar()
        {
            if (!string.IsNullOrEmpty(txtn1.Text) && !string.IsNullOrEmpty(txtn2.Text))
            {
                Calcular();
            }
            else
            {
                DisplayAlert("Error", "Ingrese una cantidad", "OK");
            }
        }

        private void btnvolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btncalcular_Clicked(object sender, EventArgs e)
        {
            Validar();
        }
    }
}