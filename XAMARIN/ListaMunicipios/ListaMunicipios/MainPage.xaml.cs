using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ListaMunicipios.models;
using System.IO;
using System.Reflection;

namespace ListaMunicipios
{
    public partial class MainPage : ContentPage
    {
        //Declaramos una lista para los objetos municipio
        List<Municipios> mpio = new List<Municipios>();

        public MainPage()
        {
            InitializeComponent();
            agregarDatos();

            //añadimos los datos a la vista
            ListaMunicipios.ItemsSource = mpio;
        }

        private void agregarDatos()
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;

            //Los datos de los municipios
            Municipios armeria = new Municipios();
            armeria.nombre = "Armeria";
            armeria.superficie = "327 km2";
            armeria.poblacion = "27,625 habitantes";
            armeria.Imagenurl = "https://ieecolima.org.mx/images/municipios/armeria.png";
            //agregarlo a la lista
            mpio.Add(armeria);

            Municipios comala = new Municipios();
            comala.nombre = "Comala";
            comala.superficie = "254 km2";
            comala.poblacion = "21,631 habitantes";
            comala.Imagenurl = "https://ieecolima.org.mx/images/comala.png";
            mpio.Add(comala);

            Municipios colima = new Municipios();
            colima.nombre = "Colima";
            colima.superficie = "1,668.2 km2";
            colima.poblacion = "157,048 habitantes";
            colima.Imagenurl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bd/Escudo_de_Colima%2C_Colima.svg/1200px-Escudo_de_Colima%2C_Colima.svg.png";
            mpio.Add(colima);

            Municipios coquimatlan = new Municipios();
            coquimatlan.nombre = "Coquimatlan";
            coquimatlan.superficie = "320.19 km2";
            coquimatlan.poblacion = "20,837 habitantes";
            coquimatlan.Imagenurl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5e/Escudo_de_Coquimatlan.png/250px-Escudo_de_Coquimatlan.png";
            mpio.Add(coquimatlan);

            Municipios cuahutemoc = new Municipios();
            cuahutemoc.nombre = "Cuahutemoc";
            cuahutemoc.superficie = "373.16 km2";
            cuahutemoc.poblacion = "31,627 habitantes";
            cuahutemoc.Imagenurl = "https://ieecolima.org.mx/images/cuauhtemoc.png";
            mpio.Add(cuahutemoc);

            Municipios ixtlahuacan = new Municipios();
            ixtlahuacan.nombre = "Ixtlahuacan";
            ixtlahuacan.superficie = "376.078 km2";
            ixtlahuacan.poblacion = "5,623 habitantes";
            ixtlahuacan.Imagenurl = "https://ieecolima.org.mx/images/ixtlahuacan.png";
            mpio.Add(ixtlahuacan);

            Municipios manzanillo = new Municipios();
            manzanillo.nombre = "Manzanillo";
            manzanillo.superficie = "56,000 km2";
            manzanillo.poblacion = "191,031 habitantes";
            manzanillo.Imagenurl = "https://ieecolima.org.mx/images/manzanillo.png";
            mpio.Add(manzanillo);

            Municipios minatitlan = new Municipios();
            minatitlan.nombre = "Minatitlan";
            minatitlan.superficie = "214.61 km2";
            minatitlan.poblacion = "10,231 habitantes";
            minatitlan.Imagenurl = "https://ieecolima.org.mx/images/minatitlan.png";
            mpio.Add(minatitlan);

            Municipios tecoman = new Municipios();
            tecoman.nombre = "Tecoman";
            tecoman.superficie = "834.77 km2";
            tecoman.poblacion = "116,305 habitantes";
            tecoman.Imagenurl = "https://ieecolima.org.mx/images/tecoman.png";
            mpio.Add(tecoman);

            Municipios VAlvarez = new Municipios();
            VAlvarez.nombre = "Villa de Alvarez";
            VAlvarez.superficie = "428.39 km2";
            VAlvarez.poblacion = "149,762 habitantes";
            VAlvarez.Imagenurl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2f/Escudo_de_Villa_de_Alvarez.png/230px-Escudo_de_Villa_de_Alvarez.png";
            mpio.Add(VAlvarez);
        }

        private void ListaMunicipios_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var municipios = e.SelectedItem as Municipios;
            if (municipios != null)
            {
                DisplayAlert("Municipio seleccionado", $"Ha seleccionado {municipios.nombre}, el cual tiene una superficie de {municipios.superficie}, una poblacion de {municipios.poblacion}", "OK");
            }
        }
    }
}
