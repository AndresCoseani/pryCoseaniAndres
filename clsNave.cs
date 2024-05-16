﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoCoseaniAndres
{
    internal class clsNave
    {
        int vida;
        string nombre;
        int puntosDaño;
        public PictureBox imgNave;
        public PictureBox imgNaveEnemiga1;
        public PictureBox imgNaveEnemiga2;
        public PictureBox imgNaveEnemiga3;
        public PictureBox imgDisparo;
        public PictureBox Disparo;
       
        public void crearJugador()
        {
            vida = 100;
            nombre = "Nave";
            puntosDaño = 50;
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNave.ImageLocation = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/a80c8979-22d6-49c7-bca4-97613a4a9237/d5rt6sa-32b3d6c4-0c7f-4931-8425-e8cd6d9b86ed.gif/v1/fill/w_256,h_256,q_85,strp/galaga_ship_by_camdencc_d5rt6sa-fullview.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9MjU2IiwicGF0aCI6IlwvZlwvYTgwYzg5NzktMjJkNi00OWM3LWJjYTQtOTc2MTNhNGE5MjM3XC9kNXJ0NnNhLTMyYjNkNmM0LTBjN2YtNDkzMS04NDI1LWU4Y2Q2ZDliODZlZC5naWYiLCJ3aWR0aCI6Ijw9MjU2In1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmltYWdlLm9wZXJhdGlvbnMiXX0.qkp-4L8OwExCwG90P7kwIV_BzrOud-geOG9v6v1e10M";
        }
        public void crearEnemigo()
        {
            vida = 50;
            nombre = "Nave Enemiga 1";
            puntosDaño = 20;
            imgNaveEnemiga1 = new PictureBox();
            imgNaveEnemiga1.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNaveEnemiga1.ImageLocation = "https://art.pixilart.com/46897995ff44.gif";


            vida = 75;
            nombre = "Nave Enemiga 2";
            puntosDaño = 40;
            imgNaveEnemiga2 = new PictureBox();
            imgNaveEnemiga2.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNaveEnemiga2.ImageLocation = "https://lh3.googleusercontent.com/proxy/WxMvsITMCM_7PJcCmf0pz3kquo5HwVIo0BCBQtiwDhRQD3spMuPXkkGGmf0XeS6m35hyncgOFZogJmfCU2IBY4gHPpkpyXe9dGGYyCkmTi1FsJ37criaFxNaQrO5lKYlTO8aoK_vPi60UCq-RfzaIiFqtJcOhx5yxU5IW9JFlAQqRcfW0E_X31Gc5yljLtVdfGv_n9U2ujQAMUdSUMBuaKjcgH8fiMPeKIoRJRZO9m7_OABs2JrPacA5UW4XOZGQtxq2dLy8cfPO-bjoXRq6UZ_TNHgCWPzft4nE9ilEHy0C64x74BYRcJlqaF8JqVwy2fkf44nhSIDrEMTtllvAb08e";

            vida = 100;
            nombre = "Nave Enemiga 3";
            puntosDaño = 60;
            imgNaveEnemiga3 = new PictureBox();
            imgNaveEnemiga3.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNaveEnemiga3.ImageLocation = "https://forum.processing.org/two/uploads/imageupload/837/OIVTOMPH7AA8.gif";

        }
    }
}
