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
    public partial class Multiplication : ContentPage
    {
        double n1;
        double n2;
        double result;

        public Multiplication()
        {
            InitializeComponent();
        }

        private void Calcularmultiplicacion()
        {
            n1 = Convert.ToDouble(txtn1.Text);
            n2 = Convert.ToDouble(txtn2.Text);
            result = n1 * n2;
            lblresultadomultip.Text = result.ToString();
        }

        private void Validarmultiplicacion()
        {
            if (!string.IsNullOrEmpty(txtn1.Text) && !string.IsNullOrEmpty(txtn2.Text))
            {
                Calcularmultiplicacion();
            }
            else
            {
                DisplayAlert("Error", "Ingrese una cantidad", "OK");
            }
        }

        private void btnvolvermultiplicacion_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btncalcularmultiplicacion_Clicked(object sender, EventArgs e)
        {
            Validarmultiplicacion();
        }
    }
}