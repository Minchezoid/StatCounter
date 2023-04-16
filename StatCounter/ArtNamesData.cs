using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatCounter
{
    public static class ArtNamesData
    {
        private static readonly List<string> _allArtefacts;

        public static string[] AllArtefacts => _allArtefacts.ToArray();

        public const string GLADIATOR_FINALE = "Конец гладиатора"; 
        public const string WANDERERS_TROUPE = "Странствующий ансамбль";
        public const string NOBLESSE_OBLIGE = "Церемония древней знати"; 
        public const string BLOODSTAINED_CHIVALRY = "Рыцарь крови";
        public const string MAIDEN_BELOVED = "Возлюбленная дева"; 
        public const string VIRIDESCENT_VENERER = "Изумрудная тень";
        public const string ARCHAIC_PETRA = "Архаичный камень"; 
        public const string RETRACING_BOLIDE = "Встречная комета";
        public const string THUNDER­SOOTHER = "Усмиряющий гром"; 
        public const string THUNDERING_FURY = "Громогласный рев ярости";
        public const string LAVAWALKER = "Ступающий по лаве"; 
        public const string CRIMSON_WITCH_OF_FLAMES = "Горящая алая ведьма";
        public const string BLIZZARD_STRAYER = "Заблудший в метели"; 
        public const string HEART_OF_DEPTH = "Сердце глубин";
        public const string TENACITY_OF_THE_MILLELITH = "Стойкость Миллелита"; 
        public const string PALE_FLAME = "Бледный огонь";
        public const string SHIMENAWAS_REMINISCENCE = "Воспоминания Симэнавы"; 
        public const string EMBLEM_OF_SEVERED_FATE = "Эмблема рассечённой судьбы";
        public const string HUSK_OF_OPULENT_DREAMS = "Кокон сладких грёз"; 
        public const string OCEAN_HUED_CLAM = "Моллюск морских красок";
        public const string VERMILLION_HEREAFTER = "Киноварное загробье"; 
        public const string ECHOES_OF_AN_OFFERING = "Отголоски подношения";
        public const string DEEPWOOD_MEMORIES = "Воспоминания дремучего леса"; 
        public const string DESERT_PAVILION_CHRONICLE = "Хроники Чертогов в пустыне";
        public const string FLOWER_OF_PARADISE_LOST = "Цветок потерянного рая"; 
        public const string NYMPHS_DREAM = "Сон нимфы";
        public const string VOURUKASHAS_GLOW = "Сияние Вурукаши";
        
        static ArtNamesData()
        {
            _allArtefacts = new List<string>
            {
                GLADIATOR_FINALE,
                WANDERERS_TROUPE,
                NOBLESSE_OBLIGE,
                BLOODSTAINED_CHIVALRY,
                MAIDEN_BELOVED,
                VIRIDESCENT_VENERER,
                ARCHAIC_PETRA,
                RETRACING_BOLIDE,
                THUNDER­SOOTHER,
                THUNDERING_FURY,
                LAVAWALKER,
                CRIMSON_WITCH_OF_FLAMES,
                BLIZZARD_STRAYER,
                HEART_OF_DEPTH,
                TENACITY_OF_THE_MILLELITH,
                PALE_FLAME,
                SHIMENAWAS_REMINISCENCE,
                EMBLEM_OF_SEVERED_FATE,
                HUSK_OF_OPULENT_DREAMS,
                OCEAN_HUED_CLAM,
                VERMILLION_HEREAFTER,
                ECHOES_OF_AN_OFFERING,
                DEEPWOOD_MEMORIES,
                DESERT_PAVILION_CHRONICLE,
                FLOWER_OF_PARADISE_LOST,
                NYMPHS_DREAM,
                VOURUKASHAS_GLOW
            };
        }

    }
}
