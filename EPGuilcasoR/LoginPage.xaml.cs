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
    public partial class PassworPage : ContentPage
    {
        public PassworPage()
        {
            InitializeComponent();
        }

        private async void btnPaginas_Clicked(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUser.Text;
                await Navigation.PushAsync(new MainPage(usuario));
            }
            catch(Exception ex)
            {
                DisplayAlert("Atencion", ex.Message, "Aceptar");
            }
            
        }
    }
}