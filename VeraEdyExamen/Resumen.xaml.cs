using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VeraEdyExamen
{
    public partial class Resumen : ContentPage
    {

       

        public Resumen(string user, string nombre, string cuota, string total)
        {
            InitializeComponent();
            lblcuota.Text = cuota;
            lbluser.Text = user;
            lblnombre.Text = nombre;
            txttotal.Text = total;


            

           
        }
    }
}
