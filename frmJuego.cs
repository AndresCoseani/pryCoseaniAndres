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
        List<clsNave> listaEnemigos = new List<clsNave>();
        List<PictureBox> listaDisparos = new List<PictureBox>();
        bool espacioPresionado = false;
        PictureBox picDisparos = new PictureBox();
        int enemigosEliminados = 0;
       
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
            
           Random aleatorioenemigo = new Random();
           Random posicionX = new Random();
           Random posicionY = new Random();
            int contador = 0;
            int posY = 0;
            int posX= 0;
            while (contador < 5)
            {
                clsNave objEnemigo = new clsNave();
                objEnemigo.crearEnemigo();

                int codigoenemigo = aleatorioenemigo.Next(3, 5);
                posX = posicionX.Next(0, 300);
                posY = posicionY.Next(0, 300);

                switch (codigoenemigo)
                {
                    case 0:
                        objEnemigo.imgNaveEnemiga1.Location = new Point(posX, posY);
                        Controls.Add(objEnemigo.imgNaveEnemiga1);
                        break;
                    case 1:
                        objEnemigo.imgNaveEnemiga2.Location = new Point(posX, posY);
                        Controls.Add(objEnemigo.imgNaveEnemiga2);
                        break;
                    case 2:
                        objEnemigo.imgNaveEnemiga3.Location = new Point(posX, posY);
                        Controls.Add(objEnemigo.imgNaveEnemiga3);
                        break;
                    case 3:
                        objEnemigo.imgNaveEnemiga4.Location = new Point(posX, posY);
                        Controls.Add(objEnemigo.imgNaveEnemiga4);
                        break;
                    default:
                        break;
                }

                listaEnemigos.Add(objEnemigo);
                contador++;
            }

            lblScore.Text = "Score:" + enemigosEliminados.ToString();
        }



        
        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {
            

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
            if (e.KeyCode == Keys.Space && !espacioPresionado)
            {
                espacioPresionado = true;

                // Crear un nuevo PictureBox para representar el disparo
                PictureBox picDisparo = new PictureBox();
                picDisparo.BackColor = Color.White;
                picDisparo.Size = new Size(5, 15);
                picDisparo.Location = new Point(objNave.imgNave.Location.X + objNave.imgNave.Width / 2 - picDisparo.Width / 2,
                                                objNave.imgNave.Location.Y);
                Controls.Add(picDisparo);
                listaDisparos.Add(picDisparo); // Agregar el PictureBox del disparo a la lista de disparos
                timer1.Start();
            }

        }
    
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox picDisparo in listaDisparos.ToList())
            {
                if (picDisparo.Location.Y > 0)
                {
                    foreach (clsNave enemigo in listaEnemigos.ToList())
                    {
                        if (enemigo.imgNaveEnemiga1 != null && picDisparo.Bounds.IntersectsWith(enemigo.imgNaveEnemiga1.Bounds))
                        {
                            picDisparo.Dispose();
                            enemigo.imgNaveEnemiga1.Dispose();
                            listaDisparos.Remove(picDisparo);
                            listaEnemigos.Remove(enemigo);
                            enemigosEliminados++;
                            break;
                        }
                        else if (enemigo.imgNaveEnemiga2 != null && picDisparo.Bounds.IntersectsWith(enemigo.imgNaveEnemiga2.Bounds))
                        {
                            picDisparo.Dispose();
                            enemigo.imgNaveEnemiga2.Dispose();
                            listaDisparos.Remove(picDisparo);
                            listaEnemigos.Remove(enemigo);
                            enemigosEliminados++;
                            break;
                        }
                        else if (enemigo.imgNaveEnemiga3 != null && picDisparo.Bounds.IntersectsWith(enemigo.imgNaveEnemiga3.Bounds))
                        {
                            picDisparo.Dispose();
                            enemigo.imgNaveEnemiga3.Dispose();
                            listaDisparos.Remove(picDisparo);
                            listaEnemigos.Remove(enemigo);
                            enemigosEliminados++;
                            break;
                        }
                        else if (enemigo.imgNaveEnemiga4 != null && picDisparo.Bounds.IntersectsWith(enemigo.imgNaveEnemiga4.Bounds))
                        {
                            picDisparo.Dispose();
                            enemigo.imgNaveEnemiga4.Dispose();
                            listaDisparos.Remove(picDisparo);
                            listaEnemigos.Remove(enemigo);
                            enemigosEliminados++;
                            break;
                        }
                    }
                    picDisparo.Location = new Point(picDisparo.Location.X, picDisparo.Location.Y - 5);
                    lblScore.Text = "Score:" + enemigosEliminados.ToString();
                }
                else
                {
                    picDisparo.Dispose();
                    listaDisparos.Remove(picDisparo);
                }
            }

        }
    
        private void frmJuego_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                espacioPresionado = false; // Marca la tecla de espacio como no presionada
            }
        }
    }
}

