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
            string carpetaFirma = Path.Combine(Application.StartupPath, "Firmas");// Combina la ruta del directorio de inicio de la aplicación con el subdirectorio "Firmas"
            string rutaFirma = Path.Combine(carpetaFirma, nombreArchivo);//combina la carpet firma con el nombre
            if (!Directory.Exists(carpetaFirma))//pregunta si la carpeta existe
            {
                Directory.CreateDirectory(carpetaFirma);//la crea
            }
            ArchivoImagen.Save(rutaFirma, System.Drawing.Imaging.ImageFormat.Jpeg);//guarda todo
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
