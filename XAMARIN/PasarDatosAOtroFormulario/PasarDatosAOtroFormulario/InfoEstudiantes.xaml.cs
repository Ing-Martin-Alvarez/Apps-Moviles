using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace PasarDatosAOtroFormulario
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoEstudiantes : ContentPage
    {
        public InfoEstudiantes(estudiante student)
        {
            InitializeComponent();

            Title = student.Name;

            var nameLabel = new Label
            {
                Text = student.Name,
                FontSize = 24,
                FontAttributes = FontAttributes.Bold
            };

            var statuslabel = new Label
            {
                Text = student.Status,
                FontSize = 18
            };

            var courseslabel = new Label
            {
                Text = student.Course,
                FontSize = 18
            };

            var addresslabel = new Label
            {
                Text = student.Address,
                FontSize = 18
            };

            var image = new Image
            {
                Source = student.ImageUrl, // Aqui 'ImageUrl' es el nombre de la propiedad que contiene la URL de la imagen del estudiante en la clase 'estudiante'.
                HeightRequest = 200,
                WidthRequest = 200,
                Aspect = Aspect.AspectFill,
                Margin = new Thickness(0, 20, 0, 20)
            };

            var layout = new StackLayout
            {
                Padding = new Thickness(20),
                Spacing = 10,
                Children = {
                    nameLabel,
                    statuslabel,
                    courseslabel,
                    addresslabel,
                    image
                }
            };

            Content = layout;
        }
    }
}