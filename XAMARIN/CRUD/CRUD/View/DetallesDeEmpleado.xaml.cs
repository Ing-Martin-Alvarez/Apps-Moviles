using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CRUD.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetallesDeEmpleado : ContentPage
    {
        public DetallesDeEmpleado()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NombreIntroducido.Text) || string.IsNullOrWhiteSpace(LocalidadEntrada.Text))
            {
                await DisplayAlert("Invalido", "Se ha detectado un espacio en blanco", "Ok");
            }
            else
                AddNuevoEmpleado();
        }

        async void AddNuevoEmpleado()
        {
            await App.MiBaseDeDatos.CrearEmpleado(new Model.empleadomodel 
            {
                Name = NombreIntroducido.Text,
                Address = LocalidadEntrada.Text
            });
            await Navigation.PopAsync();

        }
    }
}