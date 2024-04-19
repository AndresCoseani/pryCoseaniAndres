using System;
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
        public PictureBox imgNaveEnemiga4;
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
        public void crearEnemigo1()
        {
            vida = 50;
            nombre = "Nave Enemiga 1";
            puntosDaño = 20;
            imgNaveEnemiga1 = new PictureBox();
            imgNaveEnemiga1.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNaveEnemiga1.ImageLocation = "https://lh3.googleusercontent.com/proxy/_eV29W6JAdr9ho6JloMIRalKBwbhJtWKFMGZxNLTugTITyPXCzBktJB7tUJtpd90w078gbZJmagjcI_9Znvw8Wozzz1l6-3ueXk0px74oz76IRCO8JFAGczCnNcaxfWxKFRTLnx_Dgb58LwoSW53qdz8iebULHp_qG7BZrlnuvavgxj2EQuTRElMP14jJn-DGoPULI76nqedAT0BaMYgtPkfEDmf00FB5Kumv9dUjY5Z-PZWpvMKb7p_lq0k2Y_tQG5LqsDI0g2jHiyZoxr26dd3ztnnNyK2m6hfwv4MidSTlPRlS_k4dT0D05FDNdtwnouOFIgI5PXfIUQ5QsevdQ3X";

        }
        public void crearEnemigo2()
        {
            vida = 75;
            nombre = "Nave Enemiga 2";
            puntosDaño = 40;
            imgNaveEnemiga2 = new PictureBox();
            imgNaveEnemiga2.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNaveEnemiga2.ImageLocation = "https://static.wikia.nocookie.net/fantendo/images/0/09/Imgres-1.png/revision/latest?cb=20151121025428";

        }
        public void crearEnemigo3()
        {
            vida = 100;
            nombre = "Nave Enemiga 3";
            puntosDaño = 60;
            imgNaveEnemiga3 = new PictureBox();
            imgNaveEnemiga3.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNaveEnemiga3.ImageLocation = "https://lh3.googleusercontent.com/proxy/2terI1_Hd9mi6q1T7hC7whIv9tKn_7PqYfWhPj5nJbjciGrsayPtdodUjsHHyn31ASnVb0wFCu3MJ8t6ag12pZtRQCXbMrGYnsi93Yi93mOVss_EyPYjN9z7HfAjSsDGolM9-gllGbvi_zuMQWOuguq88t_uDMVHLXIhwCWczmo5igq87_7XY-j-wnsb9wmTJK-7JW15ZOuDSR_rU3hKKag1HBAjXpwZ51MZ5SH5vIAk84gRSEqCdXzLhM_tRnslOdIN8EVLxCdsaZKo8rNcXAg-Px3DskuyhUSXiJS8K0I6mVPWav9xIKewGyMVcOGgnxQGTzCnXq_-NxJvEYnE3DSQ";

        }
        public void crearEnemigo4()
        {
            vida = 100;
            nombre = "Nave Enemiga 4";
            puntosDaño = 60;
            imgNaveEnemiga4 = new PictureBox();
            imgNaveEnemiga4.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNaveEnemiga4.ImageLocation = "https://lh3.googleusercontent.com/proxy/iyMANheRBJ9f5pMYsUzSlAJPNJPjBZv0ht5g3IF3WUj5q9Y2oqJajGHfOjBFqRVhEkh3UiGNEStXmQSTX2rxARTV8_fId9hCRrXUdWcwGNAPdSnH3v72sIeiWgAZ2enK4PSv4DgLdUhxyNvXD2hJIz0w2vhC6oGMb_BEcG8VNvTewMv9_qjV4UXzL9PaX1acKYlDA6x72A1Jk95E_VAaCeiPtQa8YOOchuDNHUv3EgwKcEGI7MTn5z4wrDg9lHYOshC0ZHh7b75H1bDq1zG3Fwugkv2NPHHJuhaeTIzZ5jHKVYMldCuKpXHv6C_6-hmfHGQ43p-xEXLeReiey2YuScNG";

        }
       

    }
}
