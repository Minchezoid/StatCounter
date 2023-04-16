using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatCounter
{
    public static class StatNamesData
    {
        private static readonly List<string> _allStats;

        public static string[] AllStats => _allStats.ToArray();

        public const string CRIT_DMG = "Крит. урон %";
        public const string CRIT_RATE = "Шанс крит. попадания %";
        public const string ELEMENTAL_MASTERY = "Мастерство стихий";
        public const string ATK_PERCENT = "Сила атаки %";
        public const string ENERGY_RECHARGE = "Восст. энергии %";
        public const string HP_PERCENT = "HP %";
        public const string DEF_PERCENT = "Защита %";

        public const string HEALING_BONUS = "Бонус лечения %";
        public const string PYRO_AMPLIFICATION = "Бонус Пиро урона %";
        public const string HYDRO_AMPLIFICATION = "Бонус Гидро урона %";
        public const string DENDRO_AMPLIFICATION = "Бонус Дендро урона %";
        public const string GEO_AMPLIFICATION = "Бонус Гео урона %";
        public const string ANEMO_AMPLIFICATION = "Бонус Анемо урона %";
        public const string ELECTRO_AMPLIFICATION = "Бонус Электро урона %";
        public const string CRYO_AMPLIFICATION = "Бонус Крио урона %"; 
        public const string PHYS_AMPLIFICATION = "Бонус физ. урона %";

    }
}
