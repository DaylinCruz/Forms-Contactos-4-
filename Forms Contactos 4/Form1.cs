namespace Forms_Contactos_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Contacto [] x;
        int i = 0;

        private void btnadd_Click(object sender, EventArgs e)
        {

            Contacto x = new Contacto();
            x.Nombre = txtname.Text;
            x.FechaNacimiento = dtpdate.Value;
            x.Telefono = txttelphone.Text;
            x.Correo = txtcorreo.Text;
            RESULTADO.Items.Add(x);

        }
    }
}
   