using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ModalPageNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        async void RegresaPaTras(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}