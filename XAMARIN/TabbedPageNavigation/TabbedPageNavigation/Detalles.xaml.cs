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
    public partial class Detalles : ContentPage
    {
        public List<Jugador> players = new List<Jugador>();

        public Detalles()
        {
            this.players = new List<Jugador>();
            InitializeComponent();

            Jugador messi = new Jugador () { Nombre = "Lionel Messi", Equipo = "Paris Saint-Germain", Edad = "34", Foto = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b4/Lionel-Messi-Argentina-2022-FIFA-World-Cup_%28cropped%29.jpg/320px-Lionel-Messi-Argentina-2022-FIFA-World-Cup_%28cropped%29.jpg" };
            Jugador ronaldo = new Jugador() { Nombre = "Cristiano Ronaldo", Equipo = "Manchester United", Edad = "36", Foto = "https://www.fichajes.com/build/images/player-covers/cristiano-ronaldo.352c95f5.jpg" };
            Jugador neymar = new Jugador() { Nombre = "Neymar Jr", Equipo = "Paris Saint-Germain", Edad = "29", Foto = "https://img.a.transfermarkt.technology/portrait/big/68290-1669394812.jpg?lm=1" };
            Jugador mbappe = new Jugador() { Nombre = "Kylian Mbappé", Equipo = "Paris Saint-Germain", Edad = "22", Foto = "https://s.hs-data.com/bilder/spieler/gross/284095.jpg" };
            Jugador bruyne = new Jugador() { Nombre = "Kevin De Bruyne", Equipo = "Manchester City", Edad = "30", Foto = "https://img.a.transfermarkt.technology/portrait/big/88755-1626449012.jpg?lm=1" };
            Jugador robert = new Jugador() { Nombre = "Robert Lewandowski", Equipo = "Bayern Munich", Edad = "33", Foto = "https://i.bundesliga.com/player/dfl-obj-00000m-dfl-clu-00000g-dfl-sea-0001k6.png" };

            //Agregamos el objeto messi al list view
            this.players.Add(messi);
            this.players.Add(ronaldo);
            this.players.Add(neymar);
            this.players.Add(mbappe);
            this.players.Add(bruyne);
            this.players.Add(robert);

            //Indicarle al listview la fuente de datos para sus items
            //tamaño de altura de los campos de la lista
            this.ListaPlayers.RowHeight = 400;
            this.ListaPlayers.ItemsSource = this.players;

        }
    }
}