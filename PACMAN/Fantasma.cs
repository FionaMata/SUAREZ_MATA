using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace PACMAN
{
    public class Fantasma : Personatge
    {
        private string nom;
        private ColorTriat color;

        public Fantasma(ColorTriat pColor, int x, int y)
        {
            this.MovimentDireccio = Direccio.SUD;
            this.PosX = x;
            this.PosY = y;
            this.Color = pColor;
                        
            this.PathDown = $"/Imatges/phantom/{CheckPathColor()}/phantom_down.png";
            this.PathLeft = $"/Imatges/phantom/{CheckPathColor()}/phantom_left.png";
            this.PathRight = $"/Imatges/phantom/{CheckPathColor()}/phantom_right.png";
            this.PathUp = $"/Imatges/phantom/{CheckPathColor()}/phantom_up.png";

            this.Path = PathDown;
        }

        public string Nom { get => nom; set => nom = value; }
        public ColorTriat Color { get => color; set => color = value; }

        // Canvia el path segons el color enum escollit
        private string CheckPathColor()
        {
            string newPath = "";

            switch (Color)
            {
                case ColorTriat.BLAU: newPath = "blue"; break;
                case ColorTriat.VERD: newPath = "green"; break;
                case ColorTriat.VERMELL: newPath = "red"; break;
            }
            return newPath;
        }
    }
}
