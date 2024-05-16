using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCoseaniAndres
{
    public partial class frmFirma : Form
    {
        private Bitmap ArchivoImagen;
        public frmFirma()
        {
            InitializeComponent();
            ArchivoImagen = new Bitmap(picFirma.Width, picFirma.Height);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            DateTime fechaHoraActual = DateTime.Now;
            string nombreArchivo = $"Firma_{fechaHoraActual:yyyy.MM.dd},{fechaHoraActual:HH.mm}hrs.jpg";
            string carpetaFirma = Path.Combine(Application.StartupPath, "Firmas");
            string rutaFirma = Path.Combine(carpetaFirma, nombreArchivo);
            if (!Directory.Exists(carpetaFirma))
            {
                Directory.CreateDirectory(carpetaFirma);
            }
            ArchivoImagen.Save(rutaFirma, System.Drawing.Imaging.ImageFormat.Jpeg);
            MessageBox.Show("La firma se guardo correctamente");
            this.Close();
        }

        private void picFirma_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics oG = Graphics.FromImage(ArchivoImagen))
                {
                    oG.FillEllipse(Brushes.Gray, e.X, e.Y, 5, 5);
                }

                // Actualiza la imagen del PictureBox
                picFirma.Image = ArchivoImagen;
            }
        }

        private void frmFirma_Load(object sender, EventArgs e)
        {

        }
    }
}
