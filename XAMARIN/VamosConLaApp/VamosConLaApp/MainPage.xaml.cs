using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VamosConLaApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        //Llamado al evento del boton
        private void Button_Clicked(object sender, EventArgs e)
        {
            String msg = txtcaja.Text;
            txtcampo.Text = msg;
            //txtcampo.Text = "Hola Perrito";
        }

        private void Borrar_Clicked(object sender, EventArgs e)
        {
            txtcampo.Text = null;
        }

        private void Salir_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
