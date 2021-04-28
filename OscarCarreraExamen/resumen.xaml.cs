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
    public partial class resumen : ContentPage
    {
        public resumen(String user, String nombre, String pago)
        {
            InitializeComponent();
            lblUser.Text = user;
            txtNombre.Text = nombre;
            txtPago.Text = pago;
        }
    }
}