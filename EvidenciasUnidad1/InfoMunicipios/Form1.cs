using System.Collections;
using System.Windows.Forms;

namespace InfoMunicipios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Municipios> Lista = null;

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int indice = listBox1.SelectedIndex;

            //Creamos la lista de imagenes
            ImageList escudos = new ImageList();
            escudos.ImageSize = new Size(100, 136);

            //Añadimos la lista de imagenes
            escudos.Images.Add(Image.FromFile(@"C:\Users\EvilDeath\Documents\TEC NM\DAMP\EvidenciasUnidad1\InfoMunicipios\Escudos\Armeria.png"));
            escudos.Images.Add(Image.FromFile(@"C:\Users\EvilDeath\Documents\TEC NM\DAMP\EvidenciasUnidad1\InfoMunicipios\Escudos\Comala.png"));
            escudos.Images.Add(Image.FromFile(@"C:\Users\EvilDeath\Documents\TEC NM\DAMP\EvidenciasUnidad1\InfoMunicipios\Escudos\Colima.png"));
            escudos.Images.Add(Image.FromFile(@"C:\Users\EvilDeath\Documents\TEC NM\DAMP\EvidenciasUnidad1\InfoMunicipios\Escudos\Coquimatlan.png"));
            escudos.Images.Add(Image.FromFile(@"C:\Users\EvilDeath\Documents\TEC NM\DAMP\EvidenciasUnidad1\InfoMunicipios\Escudos\Cuauhtemoc.png"));
            escudos.Images.Add(Image.FromFile(@"C:\Users\EvilDeath\Documents\TEC NM\DAMP\EvidenciasUnidad1\InfoMunicipios\Escudos\Ixtlahuacan.png"));
            escudos.Images.Add(Image.FromFile(@"C:\Users\EvilDeath\Documents\TEC NM\DAMP\EvidenciasUnidad1\InfoMunicipios\Escudos\Manzanillo.png"));
            escudos.Images.Add(Image.FromFile(@"C:\Users\EvilDeath\Documents\TEC NM\DAMP\EvidenciasUnidad1\InfoMunicipios\Escudos\Minatitlan.png"));
            escudos.Images.Add(Image.FromFile(@"C:\Users\EvilDeath\Documents\TEC NM\DAMP\EvidenciasUnidad1\InfoMunicipios\Escudos\Tecoman.png"));
            escudos.Images.Add(Image.FromFile(@"C:\Users\EvilDeath\Documents\TEC NM\DAMP\EvidenciasUnidad1\InfoMunicipios\Escudos\VAlvarez.png"));
            
            if (indice == 0)
            {
                pictureBox1.Image = escudos.Images[0];
                pictureBox1.Visible = true;
            }
            else if (indice == 1)
            {
                pictureBox1.Image = escudos.Images[1];
                pictureBox1.Visible = true;
            }
            else if (indice == 2)
            {
                pictureBox1.Image = escudos.Images[2];
                pictureBox1.Visible = true;
            }
            else if (indice == 3)
            {
                pictureBox1.Image = escudos.Images[3];
                pictureBox1.Visible = true;
            }
            else if (indice == 4)
            {
                pictureBox1.Image = escudos.Images[4];
                pictureBox1.Visible = true;
            }
            else if (indice == 5)
            {
                pictureBox1.Image = escudos.Images[5];
                pictureBox1.Visible = true;
            }
            else if (indice == 6)
            {
                pictureBox1.Image = escudos.Images[6];
                pictureBox1.Visible = true;
            }
            else if (indice == 7)
            {
                pictureBox1.Image = escudos.Images[7];
                pictureBox1.Visible = true;
            }
            else if (indice == 8)
            {
                pictureBox1.Image = escudos.Images[8];
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Image = escudos.Images[9];
                pictureBox1.Visible = true;
            }
            
            MessageBox.Show("Nombre: " + Lista[indice].ciudad + "\nExtension: " +
                Lista[indice].extension + "\nPoblacion: " +
                Lista[indice].poblacion + "\n", "---Datos del municipio--- \n");

            //pbQue.Visible = true;//mostramos la imagen
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Crear el Arraylist
            Lista = new List<Municipios>();    

            //crear objetos de municipios
            Municipios armeria = new Municipios();
            armeria.ciudad = "Armeria";
            armeria.extension = "341.6 km2";
            armeria.poblacion = "27,623";
            Lista.Add(armeria);

            Municipios comala = new Municipios();
            comala.ciudad = "Comala";
            comala.extension = "254 km2";
            comala.poblacion = "21,631";
            Lista.Add(comala);

            Municipios colima = new Municipios();
            colima.ciudad = "Colima";
            colima.extension = "1 668.2 km2";
            colima.poblacion = "157,048";
            Lista.Add(colima);

            Municipios coquimatlan = new Municipios();
            coquimatlan.ciudad = "Coquimatlan";
            coquimatlan.extension = "320.19 km2";
            coquimatlan.poblacion = "20,837";
            Lista.Add(coquimatlan);

            Municipios cuahutemoc = new Municipios();
            cuahutemoc.ciudad = "Cuahutemoc";
            cuahutemoc.extension = "373.16 km2";
            cuahutemoc.poblacion = "31,627";
            Lista.Add(cuahutemoc);

            Municipios ixtlahuacan = new Municipios();
            ixtlahuacan.ciudad = "Ixtlahuacan";
            ixtlahuacan.extension = "376.078 km2";
            ixtlahuacan.poblacion = "5,623";
            Lista.Add(ixtlahuacan);

            Municipios manzanillo = new Municipios();
            manzanillo.ciudad = "Manzanillo";
            manzanillo.extension = "56000 km2";
            manzanillo.poblacion = "191,031";
            Lista.Add(manzanillo);

            Municipios minatitlan = new Municipios();
            minatitlan.ciudad = "Minatitlan";
            minatitlan.extension = "214.61 km2";
            minatitlan.poblacion = "10,231";
            Lista.Add(minatitlan);

            Municipios tecoman = new Municipios();
            tecoman.ciudad = "Tecoman";
            tecoman.extension = "834.77 km2";
            tecoman.poblacion = "116,305";
            Lista.Add(tecoman);

            Municipios VAlvarez = new Municipios();
            VAlvarez.ciudad = "Villa de Alvarez";
            VAlvarez.extension = "428.39 km2";
            VAlvarez.poblacion = "149,762";
            Lista.Add(VAlvarez);
        }
    }
}