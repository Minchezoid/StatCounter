using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatCounter
{
    public class Artefact
    {
        public double Atk { get; set; }
        public double Def { get; set; }
        public double Hp { get; set; }
        public double Em { get; set; }
        public double Er { get; set; }
        public double CritDmg { get; set; }
        public double CritRate { get; set; }
        public string Set { get; set; }
        public string MainStat { get; set; }
        public string Piece { get; set; }

        public Artefact(double atk, double hp, double def, double er, double em, double critdmg, double critrate, string set, string mainstat, string piece)
        {
            //вносим туды статы
            Atk = Math.Round(atk / 5, 3); 
            Def = Math.Round(def / 6.2, 3); 
            Hp = Math.Round(hp / 5, 3); 
            Em = Math.Round(em / 20, 3); 
            Er = Math.Round(er / 5.5, 3); 
            CritDmg = Math.Round(critdmg / 6.6, 3);
            CritRate = Math.Round(critrate / 3.3, 3); 
            //ещё сет мэйнстат и тип куска 
            Set = set;
            MainStat = mainstat;
            Piece = piece;
        }
    }
}
