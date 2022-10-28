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
    public partial class Division : ContentPage
    {
        double n1;
        double n2;
        double result;

        public Division()
        {
            InitializeComponent();
        }

        private void Calculardivision()
        {
            n1 = Convert.ToDouble(txtn1.Text);
            n2 = Convert.ToDouble(txtn2.Text);
            result = n1 / n2;
            lblresultadodivision.Text = result.ToString();
        }

        private void Validarresta()
        {
            if (!string.IsNullOrEmpty(txtn1.Text) && !string.IsNullOrEmpty(txtn2.Text))
            {
                Calculardivision();
            }
            else
            {
                DisplayAlert("Error", "Ingrese una cantidad", "OK");
            }
        }

        private void btnvolverdivision_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btncalculardivision_Clicked(object sender, EventArgs e)
        {
            Validarresta();
        }
    }
}