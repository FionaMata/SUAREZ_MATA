using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Suarez_Mata_ExPacMan
{
    public class Pacman : Personatge
    {
        bool esViu;
        bool esNadal = true;

        public Pacman() 
        {
            EsViu = true;
            
            base.Vida = 3;
            base.Visibilitat = Visibility.Visible;
            base.MovimentDireccio = Direccio.SUD;
            base.PosX = 0;
            base.PosY = 1;

            this.PathDown = $"/Imatges/pacman/{CheckSiEsNadal()}pacman_down.png";
            this.PathLeft = $"/Imatges/pacman/{CheckSiEsNadal()}pacman_left.png";
            this.PathRight = $"/Imatges/pacman/{CheckSiEsNadal()}pacman_right.png";
            this.PathUp = $"/Imatges/pacman/{CheckSiEsNadal()}pacman_up.png";
        }

        public bool EsViu { get => esViu; set => esViu = value; }
        public bool EsNadal 
        { 
            get => esNadal; 
        }

        public string CheckSiEsNadal()
        {
            string path = "";
            if (EsNadal) path = "christmas/";
            return path;
        }
    }
}
