namespace ValidacionEdad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void validarFecha()
        {
            DateTime hoy = DateTime.Today;

            if (dateTimePicker1.Value.Date > hoy)
            {
                MessageBox.Show("Fecha invalidad", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblResultado.Text = ("No puedes seleccionar fecha futuras");
            }
            else if (dateTimePicker1.Value.Date.AddYears(18) <= hoy)
            {
                MessageBox.Show("Eres mayor de edad", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblResultado.Text = ("Eres mayor de edad");
            }
            else
            {
                MessageBox.Show("Eres menor de edad", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblResultado.Text = ("Eres menor de edad");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validarFecha();
        }
    }
}