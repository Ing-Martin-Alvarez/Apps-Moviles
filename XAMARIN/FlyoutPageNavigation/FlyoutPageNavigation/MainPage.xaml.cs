using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace FlyoutPageNavigation
{
    public partial class MainPage : Xamarin.Forms.FlyoutPage
    {
        public MainPage()
        {
            InitializeComponent();
            Hamburguesa.ListaVistas.ItemSelected += OnItemSelected;
        }
        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as ClaseFlyout;
            if(item != null)
            {
                Detail = new Xamarin.Forms.NavigationPage((Xamarin.Forms.Page)Activator.CreateInstance(item.pagina));
                Hamburguesa.ListaVistas.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
