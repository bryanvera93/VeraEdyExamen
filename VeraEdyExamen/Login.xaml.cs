using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VeraEdyExamen
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        public async void btnAbrir_registro_Clicked(System.Object sender, System.EventArgs e)
        {

            string user = txtuser.Text;
            string pass = txtpass.Text;

            if (txtuser.Text == "estudiante2020" && txtpass.Text == "uisrael2020")
            {
                await DisplayAlert("Bienvenido", "Datos correctos", "Aceptar");
            }


            else
            {
                await DisplayAlert("ERROR", "Datos incorrectos", "Aceptar");
                return;
            }


            await Navigation.PushAsync(new Registro (user,pass));


        }
    }
}
