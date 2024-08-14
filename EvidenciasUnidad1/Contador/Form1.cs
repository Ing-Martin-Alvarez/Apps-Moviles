namespace Contador
{
    public partial class Form1 : Form
    {
        //declaramos variable o atributo de la clase
        private int contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btna_Click(object sender, EventArgs e)
        {
            //Incrementamos variable contador y la mostramos en el label
            contador++;
            displayContador();
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            //Decrementar variable y mostrarlo en el label
            contador--;
            displayContador();
        }

        private void btnr_Click(object sender, EventArgs e)
        {
            //reinicia el contador
            contador = 0;
            displayContador();
        }

        private void displayContador()
        {
            numero.Text = contador.ToString();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}