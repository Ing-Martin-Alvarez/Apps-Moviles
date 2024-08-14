using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using PlayerApp.models;

namespace PlayerApp
{
    public partial class MainPage : ContentPage
    {
        public List<Jugador> jugadores = new List<Jugador>();

        public MainPage()
        {
            InitializeComponent();
            //declaramos la clase
            this.jugadores = new List<Jugador>();
            //creamos un objeto tipo jugador
            Jugador messi = new Jugador()
            {
                nombre = "Lionel Messi",
                equipo = "Paris Saint Germain",
                imagen = "https://s.hs-data.com/bilder/spieler/gross/26622.jpg"
            };
            Jugador drew = new Jugador()
            {
                nombre = "Drew McIntyre",
                equipo = "WWE SmackDown",
                imagen = "https://www.maslucha.com/wp-content/uploads/2020/11/Drew-McIntyre.png"
            };
            //Agregamos el objeto messi al list view
            this.jugadores.Add(messi);
            this.jugadores.Add(drew);
            //Indicarle al listview la fuente de datos para sus items
            this.ListaJugadores.ItemsSource = this.jugadores;
        }
    }
}
