using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OscarCarreraExamen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            String user = txtUser.Text;
            String pass = txtPass.Text;

            if ((user == "estudiante2021") && (pass == "uisrael2021"))
            {
                await Navigation.PushAsync(new registro(user, pass));
            }
            else
            {
                DisplayAlert("Alerta", "Usuario o contraseña equivocados", "Gracias");
            }

        }
    }
}
