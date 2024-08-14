using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CRUD.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaDeEmpleados : ContentPage
    {
        public PaginaDeEmpleados()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                myCollectionView.ItemsSource = await App.MiBaseDeDatos.LeeEmpleados();
            }
            catch { }
        }

        async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DetallesDeEmpleado());
        }
    }
}