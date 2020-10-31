using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VeraEdyExamen
{
    public partial class Registro : ContentPage
    {
        public Registro(string user, string nombre)
        {
            InitializeComponent();

            lbluser.Text = user;
    

        }


        void btn_calcular_Clicked(System.Object sender, System.EventArgs e) {


            string user = txtnombre.Text;

            if (this.txtnombre.Text == null)
            {
                DisplayAlert("Error", "Ingresa el nombre", "Error");
                return;
            }

            try
            {

                decimal cuotaI = 0;
                decimal.TryParse(txtmontoi.Text, out cuotaI);
                if (cuotaI == 0 || cuotaI >= 1800)
                {
                    DisplayAlert("Error", "Cuota inicial fuera de rango", "Error");
                    return;
                }


               
                    decimal montoi = Convert.ToDecimal(txtmontoi.Text);
                    

                    //Resultado

                    decimal pendiente = 1800 - montoi;
                    
                    decimal cuota = (pendiente / 3) + ((1800) * 0.05M);
                    txtcuota.Text = cuota.ToString("N2"); ;


                    decimal total = montoi + cuota * 3;
                    txttotal.Text = total.ToString("N2"); ;    
                    


                }
                catch (Exception ex)
                {
                   DisplayAlert("Mensaje de alerta", "ERROR" + ex.Message, "Ok");
                }

            }

        

        private async void btnabrir_resumen_Clicked(System.Object sender, System.EventArgs e)
        {
            string user = lbluser.Text;
            string nombre = txtnombre.Text;
            string cuota = txtcuota.Text;
            string total = txttotal.Text;

            
            await Navigation.PushAsync(new Resumen(user, nombre, cuota, total));
        }
    }
}

