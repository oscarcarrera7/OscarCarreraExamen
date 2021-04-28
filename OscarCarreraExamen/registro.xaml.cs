using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OscarCarreraExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registro : ContentPage
    {
        public registro(String user, String pass)
        {
            InitializeComponent();
            lblUser.Text = "Usuario conectado: " + user;
            
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double monto = Convert.ToDouble(txtMonto.Text);

            double inicial = (1800 - monto);
            double pagoin = (inicial / 3);
            double saldo = pagoin + 90;

            txtPago.Text = saldo.ToString();
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            
            String nombre = txtNombre.Text;
            String user = lblUser.Text;
            String pago = txtPago.Text;

            DisplayAlert("Mensaje", "Elemento Guardado con exito", "Gracias");

            await Navigation.PushAsync(new resumen(nombre, user, pago));
        }
    }
}