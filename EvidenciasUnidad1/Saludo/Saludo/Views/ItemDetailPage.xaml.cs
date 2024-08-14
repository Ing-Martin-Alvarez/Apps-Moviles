using System.ComponentModel;
using Xamarin.Forms;
using Saludo.ViewModels;

namespace Saludo.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}