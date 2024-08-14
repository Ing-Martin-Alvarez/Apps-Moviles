using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using System.Runtime.InteropServices;

namespace CRUD
{
    public partial class App : Application
    {
        private static SQLAullador db;
        public static SQLAullador MiBaseDeDatos
        {
            get
            {
                if(db==null)
                {
                    db = new SQLAullador(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Luchadores.db3"));
                }
                return db;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
