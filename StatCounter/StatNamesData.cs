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
        private static readonly List<string> _clockStats;
        private static readonly List<string> _gobletStats;
        private static readonly List<string> _crownStats;

        public static string[] AllStats => _allStats.ToArray();
        public static string[] ClockStats => _clockStats.ToArray();
        public static string[] GobletStats => _gobletStats.ToArray();
        public static string[] CrownStats => _crownStats.ToArray();

        public const string ATK_PERCENT = "Сила атаки %";
        public const string HP_PERCENT = "HP %";
        public const string DEF_PERCENT = "Защита %";
        public const string ENERGY_RECHARGE = "Восст. энергии %";
        public const string ELEMENTAL_MASTERY = "Мастерство стихий";
        public const string CRIT_DMG = "Крит. урон %";
        public const string CRIT_RATE = "Шанс крит. попадания %";
        public const string HEALING_BONUS = "Бонус лечения %";

        public const string ANEMO_AMPLIFICATION = "Бонус Анемо урона %";
        public const string GEO_AMPLIFICATION = "Бонус Гео урона %";
        public const string ELECTRO_AMPLIFICATION = "Бонус Электро урона %";
        public const string DENDRO_AMPLIFICATION = "Бонус Дендро урона %";
        public const string HYDRO_AMPLIFICATION = "Бонус Гидро урона %";
        public const string PYRO_AMPLIFICATION = "Бонус Пиро урона %";
        public const string CRYO_AMPLIFICATION = "Бонус Крио урона %"; 
        public const string PHYS_AMPLIFICATION = "Бонус физ. урона %";

        public const string ATK_FLAT = "Сила атаки";
        public const string HP_FLAT = "HP";

        static StatNamesData()
        {
            _allStats = new List<string>
            {
                ATK_PERCENT,
                HP_PERCENT,
                DEF_PERCENT,
                ENERGY_RECHARGE,
                ELEMENTAL_MASTERY,
                CRIT_DMG,
                CRIT_RATE,
                HEALING_BONUS,
                ANEMO_AMPLIFICATION,
                GEO_AMPLIFICATION,
                ELECTRO_AMPLIFICATION,
                DENDRO_AMPLIFICATION,
                HYDRO_AMPLIFICATION,
                PYRO_AMPLIFICATION,
                CRYO_AMPLIFICATION,
                PHYS_AMPLIFICATION,
                ATK_FLAT,
                HP_FLAT
            };

            _clockStats = new List<string>
            {
                ATK_PERCENT,
                HP_PERCENT,
                DEF_PERCENT,
                ENERGY_RECHARGE,
                ELEMENTAL_MASTERY,
            };

            _gobletStats = new List<string>
            {
                ATK_PERCENT,
                HP_PERCENT,
                DEF_PERCENT,
                ELEMENTAL_MASTERY,
                ANEMO_AMPLIFICATION,
                GEO_AMPLIFICATION,
                ELECTRO_AMPLIFICATION,
                DENDRO_AMPLIFICATION,
                HYDRO_AMPLIFICATION,
                PYRO_AMPLIFICATION,
                CRYO_AMPLIFICATION,
                PHYS_AMPLIFICATION,
            };

            _crownStats = new List<string>
            {
                ATK_PERCENT,
                HP_PERCENT,
                DEF_PERCENT,
                ELEMENTAL_MASTERY,
                CRIT_DMG,
                CRIT_RATE,
                HEALING_BONUS,
            };
        }
    }
}
