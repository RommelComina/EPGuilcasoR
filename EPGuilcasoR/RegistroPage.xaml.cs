using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EPGuilcasoR
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuario)
        {
            InitializeComponent();
            lblUser.Text = usuario;
        }

        private void btnResultado_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                double dato1 = Convert.ToDouble(txtDato1.Text);
                double dato2 = Convert.ToDouble(txtDato2.Text);
                double datoR = 1800;
                double suma = dato1 + dato2;
                double total = dato1 + dato2 - datoR;
                double porciento = datoR / 3 * 0.5;
                string nombre = Convert.ToString(txtNombre.Text);
                txtRespuesta.Text = suma.ToString();
                txtDatoR.Text = total.ToString();
                lblResultado.Text = porciento.ToString();    
   
            }
            catch(Exception ex)
            {
                DisplayAlert("Precaucion", ex.Message, "Gracias");
            }
        }

        private async void btnSiguiente_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new HomePage());
        }
    }
}
