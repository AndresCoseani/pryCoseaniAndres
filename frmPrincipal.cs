namespace ProyectoCoseaniAndres
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFirma F = new frmFirma();
            F.ShowDialog();
        }
    }
}
