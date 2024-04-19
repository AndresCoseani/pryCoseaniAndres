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
    public partial class frmJuego : Form
    {
        clsNave objNave;
        clsNave objEnemigo;
        clsNave objDisparo;
        private System.Windows.Forms.Timer timer;
        private bool Disparando = false;
     

        public frmJuego()
        {
            InitializeComponent();
            
        }

        private void frmJuego_Load(object sender, EventArgs e)
        {

            objNave = new clsNave();
            objNave.crearJugador();
            objNave.imgNave.Location = new Point(350, 400);
            Controls.Add(objNave.imgNave);

            objEnemigo = new clsNave();
            objEnemigo.crearEnemigo1();
            objEnemigo.imgNaveEnemiga1.Location = new Point(150, 100);
            Controls.Add(objEnemigo.imgNaveEnemiga1);

            objEnemigo = new clsNave();
            objEnemigo.crearEnemigo2();
            objEnemigo.imgNaveEnemiga2.Location = new Point(300, 100);
            Controls.Add(objEnemigo.imgNaveEnemiga2);

            objEnemigo = new clsNave();
            objEnemigo.crearEnemigo3();
            objEnemigo.imgNaveEnemiga3.Location = new Point(450, 100);
            Controls.Add(objEnemigo.imgNaveEnemiga3);

            objEnemigo = new clsNave();
            objEnemigo.crearEnemigo4();
            objEnemigo.imgNaveEnemiga4.Location = new Point(600, 100);
            Controls.Add(objEnemigo.imgNaveEnemiga4);

        }

        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {
            //problar de hacer 2 picture box como hizo el profe y despues vere como se hace para que salga desde la nave

            if (e.KeyCode == Keys.Right)
            {
                objNave.imgNave.Location = new Point(objNave.imgNave.Location.X + 5,
                  objNave.imgNave.Location.Y);
            }
            if (e.KeyCode == Keys.Left)
            {
                objNave.imgNave.Location = new Point(objNave.imgNave.Location.X - 5,
                 objNave.imgNave.Location.Y);
            }
            if (e.KeyCode == Keys.Space)
            {
                // Crear el disparo
                PictureBox disparo = new PictureBox();
                disparo.BackColor = Color.Yellow;
                disparo.Size = new Size(5, 15);
                disparo.Location = new Point(objNave.imgNave.Left + objNave.imgNave.Width / 2 - disparo.Width / 2,
                                             objNave.imgNave.Top - disparo.Height);
                Controls.Add(disparo);

                // Mover el disparo hacia arriba
                timer.Interval = 20;
                timer.Tick += (s, _) =>
                {
                    disparo.Top -= 5;

                    // Verificar si el disparo ha salido de la pantalla
                    if (disparo.Top < 0)
                    {
                        // Remover el disparo
                        Controls.Remove(disparo);
                        timer.Stop();
                        disparo.Dispose();
                    }
                };
                timer.Start();

            }
        }

        private void disparoTimer_Tick(object sender, EventArgs e)
        {
            //    if (Disparando)
            //    {
            //        Disparo();
            //    }
        }
        //private void Disparar()
        //{
        //    // Crear un nuevo PictureBox para representar el disparo
        //    objDisparo.Disparo = new PictureBox();
        //    objDisparo.Disparo.BackColor = Color.Yellow; // Puedes cambiar el color del disparo
        //    objDisparo.Disparo.Size = new Size(5, 15);
        //    objDisparo.Disparo.Location = new Point(objDisparo.imgDisparo.Left + objDisparo.imgDisparo.Width / 2 - objDisparo.Disparo.Width / 2,
        //                                          objDisparo.imgDisparo.Top - objDisparo.Disparo.Height);
        //    Controls.Add(objDisparo.Disparo);
        //    timer.Start();
        //}
        //private void Disparo()
        //{
        //    // Mover el disparo hacia arriba
        //    objDisparo.Disparo.Top -= 5;

        //    // Verificar si el disparo ha salido de la pantalla
        //    if (objDisparo.Disparo.Top < 0)
        //    {
        //        // Remover el disparo
        //        Controls.Remove(objDisparo.Disparo);
        //        objDisparo.Disparo.Dispose();
        //        Disparando = false; // Permitir al jugador disparar nuevamente

        //    }
        //    if (objDisparo.imgDisparo.Bounds.IntersectsWith(objDisparo.imgNaveEnemiga1.Bounds) || objDisparo.imgDisparo.Bounds.IntersectsWith( objDisparo.imgNaveEnemiga2.Bounds) || objDisparo.imgDisparo.Bounds.IntersectsWith(objDisparo.imgNaveEnemiga3.Bounds) || objDisparo.imgDisparo.Bounds.IntersectsWith(objDisparo.imgNaveEnemiga4.Bounds))
        //    {

        //    }

        //}
    }
}
