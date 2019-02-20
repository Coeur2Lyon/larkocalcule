using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace LarkoCalcule
{
    class Jeu
    {
        string position1;
        string position2;
        string position3;
        string position4;

        private int chiffre1 = 0;
        private int chiffre2 = 0;
        private int vraiResultat = 0;
        private int positionresultat = 0;
        private int fauxresultat1 = 0;
        private int fauxresultat2 = 0;
        private int fauxresultat3 = 0;

        public int Chiffre1 { get => chiffre1; set => chiffre1 = value;}
        public int Chiffre2 { get => chiffre2; set => chiffre2 = value;}
        public int VraiResultat { get => vraiResultat; set => vraiResultat = value;}
        public int Positionresultat { get => positionresultat; set => positionresultat = value;}
        public int Fauxresultat1 { get => fauxresultat1; set => fauxresultat1 = value; }
        public int Fauxresultat2 { get => fauxresultat2; set => fauxresultat2 = value; }
        public int Fauxresultat3 { get => fauxresultat3; set => fauxresultat3 = value; }
        public string Position1 { get => position1; set => position1 = value; }
        public string Position2 { get => position2; set => position2 = value; }
        public string Position3 { get => position3; set => position3 = value; }
        public string Position4 { get => position4; set => position4 = value; }

        public void GenererAleatoiresChiffres()
        {
            Random aleatoire = new Random();
            Chiffre1 = aleatoire.Next(1, 10);
            Chiffre2 = aleatoire.Next(1, 10);
            Positionresultat = aleatoire.Next(1, 4);
        }
       
        public void PositionnerLesResultatsAleatoirement()
        {
            Random aleatoire = new Random();
            Positionresultat = aleatoire.Next(1, 4);
            switch (Positionresultat)
            {
                case 1:
                    Position1 = (VraiResultat).ToString();
                    Position2 = (Fauxresultat1).ToString();
                    Position3 = (Fauxresultat2).ToString();
                    Position4 = (Fauxresultat3).ToString();
                    break;
                case 2:
                    Position1 = (Fauxresultat1).ToString();
                    Position2 = (VraiResultat).ToString();
                    Position3 = (Fauxresultat2).ToString();
                    Position4 = (Fauxresultat3).ToString();
                    break;
                case 3:
                    Position1 = (Fauxresultat2).ToString();
                    Position2 = (Fauxresultat1).ToString();
                    Position3 = (VraiResultat).ToString();
                    Position4 = (Fauxresultat3).ToString();
                    break;
                case 4:
                    Position1 = (Fauxresultat3).ToString();
                    Position2 = (Fauxresultat1).ToString();
                    Position3 = (Fauxresultat2).ToString();
                    Position4 = (VraiResultat).ToString();
                    break;
            }
        }

    }
}
