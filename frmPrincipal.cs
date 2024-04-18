namespace ProyectoCoseaniAndres
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void firmaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmFirma f = new frmFirma();
            f.ShowDialog();
        }
    }
}
