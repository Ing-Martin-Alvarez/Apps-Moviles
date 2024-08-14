using System.Configuration;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbMunicipios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valor = cmbMunicipios.SelectedIndex;
            MessageBox.Show("Seleccionaste el elemnto: \n" + cmbMunicipios.Items[valor].ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] municipios = ["Armeria", "Colima", "Comala", "Coquimatlan", "Cuahutemoc", "Ixtlahuacan", "Tecoman", "Manzanillo", "Minatitlan", "Villa de Alvarez"];
            cmbMunicipios.Items.AddRange(municipios);
            /*
            cmbMunicipios.Items.Add("Armeria");
            cmbMunicipios.Items.Add("Colima");
            cmbMunicipios.Items.Add("Comala");
            cmbMunicipios.Items.Add("Coquimatlan");
            cmbMunicipios.Items.Add("Cuahutemoc");
            cmbMunicipios.Items.Add("Ixtlahuacan");
            cmbMunicipios.Items.Add("Tecoman");
            cmbMunicipios.Items.Add("Manzanillo");
            cmbMunicipios.Items.Add("Minatitlan");
            cmbMunicipios.Items.Add("Villa de Alvarez");
            */
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int valor = 0;

            valor = cmbMunicipios.SelectedIndex;

            if (valor > 0)
            {
                //Borra los valores del combobox
                cmbMunicipios.Items.RemoveAt(valor);
            }
            else
            {
                MessageBox.Show("Selecciona un municipio");
            }
        }
    }
}