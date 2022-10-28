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
    public partial class Subtraction : ContentPage
    {
        double n1;
        double n2;
        double result;

        public Subtraction()
        {
            InitializeComponent();
        }

        private void Calcularresta()
        {
            n1 = Convert.ToDouble(txtn1.Text);
            n2 = Convert.ToDouble(txtn2.Text);
            result = n1 - n2;
            lblresultadoresta.Text = result.ToString();
        }

        private void Validarresta()
        {
            if (!string.IsNullOrEmpty(txtn1.Text) && !string.IsNullOrEmpty(txtn2.Text))
            {
                Calcularresta();
            }
            else
            {
                DisplayAlert("Error", "Ingrese una cantidad", "OK");
            }
        }

        private void btnvolverresta_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btncalcularresta_Clicked(object sender, EventArgs e)
        {
            Validarresta();
        }
    }
}