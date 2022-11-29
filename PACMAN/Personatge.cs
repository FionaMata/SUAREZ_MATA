using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Suarez_Mata_ExPacMan
{
    public abstract class Personatge
    {
        private Direccio movimentDireccio;
        private Visibility visibilitat;

        private int vida;
        private int posX;
        private int posY;

        private string pathDown;
        private string pathLeft;
        private string pathRight;
        private string pathUp;
        private string path;

        public Personatge() { }

        public virtual Direccio MovimentDireccio { get => movimentDireccio; set => movimentDireccio = value; }
        public virtual Visibility Visibilitat { get => visibilitat; set => visibilitat = value; }

        public virtual int Vida { get => vida; set => vida = value; }
        public int PosX { get => posX; set => posX = value; }
        public int PosY { get => posY; set => posY = value; }

        public string PathDown { get => pathDown; set => pathDown = value; }
        public string PathLeft { get => pathLeft; set => pathLeft = value; }
        public string PathRight { get => pathRight; set => pathRight = value; }
        public string PathUp { get => pathUp; set => pathUp = value; }
        public string Path 
        {
            get
            {
                if (MovimentDireccio == Direccio.SUD) path = PathDown;
                else if (MovimentDireccio == Direccio.OEST) path = PathLeft;
                else if (MovimentDireccio == Direccio.EST) path = PathRight;
                else if (MovimentDireccio == Direccio.NORD) path = PathUp;
                return path;
            }
            set => path = value; 
        }
    }
}
