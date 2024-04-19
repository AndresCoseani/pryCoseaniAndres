namespace ProyectoCoseaniAndres
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void juegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJuego J = new frmJuego();
            J.ShowDialog();
        }
    }
}
