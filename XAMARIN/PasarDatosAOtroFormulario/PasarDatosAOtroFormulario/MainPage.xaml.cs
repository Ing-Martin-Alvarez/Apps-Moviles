using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PasarDatosAOtroFormulario
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var estudiantes = new List<estudiante> 
            {
             new estudiante {Name = "Brandon Ricardo Marquez Larios", Status = "Enrolled", Address = "Colima", Course = "Multiplataforma", ImageUrl = "https://media.discordapp.net/attachments/893320281630842881/1105325356770148402/customer-img.jpg?width=117&height=130" },
             new estudiante {Name = "Isabel Rodriguez", Status="Enrolled", Address="Monterrey", Course="Comunicaciones", ImageUrl="https://media.discordapp.net/attachments/893320281630842881/990307211257458708/dibujo_de_martin.png?width=802&height=591" },
             new estudiante {Name = "Martin Alvarez Salazar", Status = "Enrolled", Address = "Colima", Course = "Multiplataforma", ImageUrl = "https://media.discordapp.net/attachments/1020063684174827560/1105319381568847912/IMG_20220906_131415236.jpg?width=443&height=591" },
             new estudiante {Name = "Luz Fernanda", Status = "Enrolled", Address = "Villa de Alvarez", Course = "Consultoria", ImageUrl = "https://media.discordapp.net/attachments/1020063684174827560/1105322645886615593/IMG-20230415-WA0001.jpg?width=788&height=591" }
            };
            myListView.ItemsSource = estudiantes;
        }

        async void myListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var student = e.SelectedItem as estudiante;
            var studentPage = new InfoEstudiantes(student);
            await Navigation.PushAsync(studentPage);
        }
    }
}
