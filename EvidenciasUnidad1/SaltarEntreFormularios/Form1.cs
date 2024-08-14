namespace SaltarEntreFormularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string contra = txtContra.Text;

            if((user == "Luz") && (contra == "Martin"))
            {
                Form2 m = new Form2();
                m.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hey wey metiste datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        
    }
}