using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EPGuilcasoR
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
           
        }  

        private async void btnVer_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());

            double total = Convert.ToDouble(txtDatoR.Text);
            double dato2 = Convert.ToDouble(txtPorciento.Text);
            double datoR = 1800;
            double porciento = datoR / 3 * 0.5;
            string nombre = Convert.ToString(txtNombre.Text);
            txtDatoR.Text = total.ToString();
            txtPorciento.Text = porciento.ToString();
            lblResultado.Text = porciento.ToString();
        }
    }
}