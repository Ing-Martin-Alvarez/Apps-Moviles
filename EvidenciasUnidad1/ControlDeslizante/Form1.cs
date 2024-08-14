namespace ControlDeslizante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //txtdelizante.Text = tbrojo.Value.ToString();
            rgb();
        }

        private void tbazul_Scroll(object sender, EventArgs e)
        {
            rgb();
        }

        private void tbverde_Scroll(object sender, EventArgs e)
        {
            rgb();
        }

        private void rgb()
        {
            int rojo = tbrojo.Value;
            int azul = tbazul.Value;
            int verde = tbverde.Value; 

            txtdelizante.BackColor = Color.FromArgb(rojo, verde, azul);
        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            //ColorDialog dlg = new ColorDialog();
           

            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                
                btncolor.BackColor = colorDialog1.Color;
                
            }
        }
    }
}