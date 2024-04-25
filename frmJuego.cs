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
                timer1.Start(); timer2.Start();
            }

        }
        // Declarar una variable para contar las naves enemigas en pantalla
        private int cantidadNavesEnemigasEnPantalla = 0;
        // Declarar una constante para el límite máximo de naves enemigas en pantalla
        private const int limiteNavesEnemigas = 200;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random aleatorioenemigo = new Random();
            int contador = 0;
            while (contador < 2 && cantidadNavesEnemigasEnPantalla < limiteNavesEnemigas)
            {
                clsNave objEnemigo = new clsNave();

                int posX = aleatorioenemigo.Next(0, 800);
                int posY = aleatorioenemigo.Next(0, 300);
                // Verificar si las coordenadas están demasiado cerca de las naves existentes
                bool demasiadoCerca = listaEnemigos.Any(enemigo =>
                    Math.Abs(posX - enemigo.imgNaveEnemiga1.Location.X) < 100 &&
                    Math.Abs(posY - enemigo.imgNaveEnemiga1.Location.Y) < 100 ||
                    Math.Abs(posX - enemigo.imgNaveEnemiga2.Location.X) < 100 &&
                    Math.Abs(posY - enemigo.imgNaveEnemiga2.Location.Y) < 100||
                    Math.Abs(posX - enemigo.imgNaveEnemiga3.Location.X) < 100 &&
                    Math.Abs(posY - enemigo.imgNaveEnemiga3.Location.Y) < 100);

                // Si las coordenadas están demasiado cerca, generar nuevas coordenadas
                if (demasiadoCerca)
                    continue;

                int codigoenemigo = aleatorioenemigo.Next(1000, 3000);
                switch (codigoenemigo)
                {
                    case < 2000:
                        objEnemigo.crearEnemigo();
                        objEnemigo.imgNaveEnemiga1.Location = new Point(posX, posY);
                        Controls.Add(objEnemigo.imgNaveEnemiga1);
                        objEnemigo.imgNaveEnemiga1.Tag = "enemigo";
                        break;
                    case > 2500:
                        objEnemigo.crearEnemigo();
                        objEnemigo.imgNaveEnemiga2.Location = new Point(posX, posY);
                        Controls.Add(objEnemigo.imgNaveEnemiga2);
                        objEnemigo.imgNaveEnemiga2.Tag = "enemigo";
                        break;
                    case > 1000:
                        objEnemigo.crearEnemigo();
                        objEnemigo.imgNaveEnemiga3.Location = new Point(posX, posY);
                        Controls.Add(objEnemigo.imgNaveEnemiga3);
                        objEnemigo.imgNaveEnemiga3.Tag = "enemigo";
                        break;

                    default:
                        break;
                }

                listaEnemigos.Add(objEnemigo);
                cantidadNavesEnemigasEnPantalla++;
                contador++;
            }
            timer1.Stop();
        }

        private void frmJuego_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                espacioPresionado = false; // Marca la tecla de espacio como no presionada
                label1.Visible = false;
               
               
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
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

                    }
                    picDisparo.Location = new Point(picDisparo.Location.X, picDisparo.Location.Y - 5);
                    lblScore.Text = "Score:" + enemigosEliminados.ToString();
                }
                else
                {
                    picDisparo.Dispose();
                    listaDisparos.Remove(picDisparo);
                }
                if (listaEnemigos == null)
                {
                    MessageBox.Show("Ganaste!", "De Acuerdo");
                    this.Close();
                }
            }

        }
    }
}

