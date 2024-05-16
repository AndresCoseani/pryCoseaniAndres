using pryCoseaniAndres;

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
            frmUsuario U = new frmUsuario();
            U.ShowDialog();
        }

        private void accederToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
