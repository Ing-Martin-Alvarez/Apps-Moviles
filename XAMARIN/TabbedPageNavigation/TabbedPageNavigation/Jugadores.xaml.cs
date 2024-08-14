using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPageNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Jugadores : ContentPage
    {
        public Jugadores()
        {
            InitializeComponent();
            // Crear la lista de jugadores
            var jugadores = new List<Jugador>
            {
                new Jugador { Nombre = "Lionel Messi", Equipo = "Paris Saint-Germain", Edad = "34", Foto = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b4/Lionel-Messi-Argentina-2022-FIFA-World-Cup_%28cropped%29.jpg/320px-Lionel-Messi-Argentina-2022-FIFA-World-Cup_%28cropped%29.jpg"},
                new Jugador { Nombre = "Cristiano Ronaldo", Equipo = "Manchester United", Edad = "36", Foto = "https://www.fichajes.com/build/images/player-covers/cristiano-ronaldo.352c95f5.jpg"},
                new Jugador { Nombre = "Neymar Jr", Equipo = "Paris Saint-Germain", Edad = "29", Foto = "https://img.a.transfermarkt.technology/portrait/big/68290-1669394812.jpg?lm=1"},
                new Jugador { Nombre = "Kylian Mbappé", Equipo = "Paris Saint-Germain", Edad = "22", Foto = "https://s.hs-data.com/bilder/spieler/gross/284095.jpg"},
                new Jugador { Nombre = "Kevin De Bruyne", Equipo = "Manchester City", Edad = "30", Foto = "https://img.a.transfermarkt.technology/portrait/big/88755-1626449012.jpg?lm=1"},
                new Jugador { Nombre = "Robert Lewandowski", Equipo = "Bayern Munich", Edad = "33", Foto = "https://i.bundesliga.com/player/dfl-obj-00000m-dfl-clu-00000g-dfl-sea-0001k6.png"},
            };

            // Vincular la lista de jugadores al ListView
            jugadoresListView.ItemsSource = jugadores;

            // Configurar los elementos de la lista para que se muestren correctamente
            jugadoresListView.ItemTemplate = new DataTemplate(() =>
            {
                var nombreLabel = new Label();
                nombreLabel.SetBinding(Label.TextProperty, "Nombre");

                /*var equipoLabel = new Label();
                equipoLabel.SetBinding(Label.TextProperty, "Equipo");

                var edadLabel = new Label();
                edadLabel.SetBinding(Label.TextProperty, "Edad");*/

                var layout = new StackLayout();
                layout.Children.Add(nombreLabel);
                /*layout.Children.Add(equipoLabel);
                layout.Children.Add(edadLabel);*/

                return new ViewCell { View = layout };
            });
        }
    }
}