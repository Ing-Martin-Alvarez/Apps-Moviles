namespace CalendarExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cbformato.Checked)
            {
                txtfecha.Text = calendar.Value.ToShortDateString();
                MessageBox.Show("La fecha es: "+ calendar.Value.ToShortTimeString() + "\nLa hora es: " + calendar.Value.ToShortTimeString(), "Fecha Seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtfecha.Text = calendar.Value.ToLongDateString();
                MessageBox.Show("La fecha es: " + calendar.Value.ToLongDateString()+ "\nLa hora es: "+ calendar.Value.ToShortTimeString(), "Fecha Seleccionada" ,MessageBoxButtons.OK ,MessageBoxIcon.Information );
            }
            txthora.Text = calendar.Value.ToShortTimeString();

            /*txtfecha.Text = calendar.Value.ToShortDateString();
            txtfecha.Text = calendar.Value.ToLongDateString();
            txthora.Text = calendar.Value.ToShortTimeString();*/
        }
    }
}