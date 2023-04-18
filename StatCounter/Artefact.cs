using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatCounter
{
    public class Artefact
    {
        public double Atk;
        public double Def;
        public double Hp;
        public double Em;
        public double Er;
        public double CritDmg;
        public double CritRate;
        public string Set;
        public string MainStat;
        public string Piece;

        public Artefact(double atk, double hp, double def, double er, double em, double critdmg, double critrate, string set, string mainstat, string piece)
        {
            //вносим туды статы
            Atk = Math.Round(atk / 5, 3); //5
            Def = Math.Round(def / 6.2, 3); //6,2
            Hp = Math.Round(hp / 5, 3); //5
            Em = Math.Round(em / 20, 3); //20
            Er = Math.Round(er / 5.5, 3); //5,5
            CritDmg = Math.Round(critdmg / 6.6, 3); //6,6
            CritRate = Math.Round(critrate / 3.3, 3); //3,3
            //ещё сет мэйнстат и тип куска 
            Set = set;
            MainStat = mainstat;
            Piece = piece;
        }
    }
}