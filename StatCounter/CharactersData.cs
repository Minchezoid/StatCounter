using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatCounter
{
    public static class CharactersData
    {
        private static readonly List<Character> _allCharacters;

        public static Character[] AllCharacters => _allCharacters.ToArray();

        static CharactersData()
        {
            _allCharacters = new List<Character>
            {
                new Character
                {
                    Name = "Ху Тао",
                    MainSets = new List<string>
                    {
                        "Горящая алая ведьма"
                    },
                    AltSets = new List<string>
                    {
                        "Воспоминания Симэнавы", "Позолоченные сны"
                    },
                    SubSets = new List<string>
                    {
                        "Странствующий ансамбль", "Стойкость Миллелита", "Цветок потерянного рая", "Сияние Вурукаши"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Мастерство стихий", "HP %"
                    },
                    OkStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    ClockStats = new List<string>
                    {
                        "HP %", "Мастерство стихий"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Пиро урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                }, //Ху Тао

                new Character
                {
                    Name = "Дилюк",
                    MainSets = new List<string>
                    {
                        "Горящая алая ведьма"
                    },
                    AltSets = new List<string>
                    {
                        "Позолоченные сны", "Конец гладиатора"
                    },
                    SubSets = new List<string>
                    {
                        "Странствующий ансамбль", "Церемония древней знати", "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Позолоченные сны", "Цветок потерянного рая"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Мастерство стихий"
                    },
                    OkStats = new List<string>
                    {
                        
                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %", "Мастерство стихий"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Пиро урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                }, //Дилюк

                new Character
                {
                    Name = "Диона",
                    MainSets = new List<string>
                    {
                        "Церемония древней знати"
                    },
                    AltSets = new List<string>
                    {
                        "Возлюбленная юная дева"
                    },
                    SubSets = new List<string>
                    {
                        "Эмблема рассечённой судьбы", "Стойкость Миллелита", "Сияние Вурукаши"
                    },
                    PerfectStats = new List<string>
                    {
                        "Восст. энергии %", "HP %"
                    },
                    GoodStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %", "Сила атаки %"
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        "HP %", "Восст. энергии %"
                    },
                    GobletStats = new List<string>
                    {
                        "HP %"
                    },
                    CrownStats = new List<string>
                    {
                        "HP %"
                    },
                }, //Диона

                new Character
                {
                    Name = "Райден",
                    MainSets = new List<string>
                    {
                        "Эмблема рассечённой судьбы"
                    },
                    AltSets = new List<string>
                    {
                        
                    },
                    SubSets = new List<string>
                    {
                        
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Восст. энергии %", "Сила атаки %"
                    },
                    OkStats = new List<string>
                    {
                        "Мастерство стихий"
                    },
                    ClockStats = new List<string>
                    {
                        "Восст. энергии %"
                    },
                    GobletStats = new List<string>
                    {
                        "Сила атаки %", "Бонус Электро урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                }, //Райден

                new Character
                {
                    Name = "Чжун Ли",
                    MainSets = new List<string>
                    {
                        "Стойкость Миллелита"
                    },
                    AltSets = new List<string>
                    {
                        "Церемония древней знати"
                    },
                    SubSets = new List<string>
                    {
                        "Конец гладиатора", "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Архаичный камень", "Сияние Вурукаши"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "HP %", "Сила атаки %"
                    },
                    OkStats = new List<string>
                    {
                        "Восст. энергии %"
                    },
                    ClockStats = new List<string>
                    {
                        "HP %", "Сила атаки %"
                    },
                    GobletStats = new List<string>
                    {
                        "HP %", "Бонус Гео урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "HP %", "Крит. урон %", "Шанс крит. попадания %"
                    },
                }, //Чжун Ли

                new Character
                {
                    Name = "Яэ Мико",
                    MainSets = new List<string>
                    {
                        
                    },
                    AltSets = new List<string>
                    {
                        "Усмиряющий гром", "Позолоченные сны"
                    },
                    SubSets = new List<string>
                    {
                        "Конец гладиатора", "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Громогласный рёв ярости", "Эмблема рассечённой судьбы", "Цветок потерянного рая"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Восст. энергии %", "Сила атаки %", "Мастерство стихий"
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %", "Мастерство стихий", "Восст. энергии %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Электро урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                }, //Яэ Мико

                new Character
                {
                    Name = "Эола",
                    MainSets = new List<string>
                    {
                        "Бледный огонь", "Рыцарь крови"
                    },
                    AltSets = new List<string>
                    {

                    },
                    SubSets = new List<string>
                    {
                        "Конец гладиатора", "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Эмблема рассечённой судьбы", "Церемония древней знати"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Восст. энергии %", "Сила атаки %"
                    },
                    OkStats = new List<string>
                    {
                        
                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус физ. урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                }, //Эола

                new Character
                {
                    Name = "Ёимия",
                    MainSets = new List<string>
                    {
                        "Воспоминания Симэнавы"
                    },
                    AltSets = new List<string>
                    {
                        "Горящая алая ведьма"
                    },
                    SubSets = new List<string>
                    {
                        "Странствующий ансамбль", "Конец гладиатора", "Киноварное загробье", "Отголоски подношения", "Позолоченные сны", "Цветок потерянного рая"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Мастерство стихий"
                    },
                    OkStats = new List<string>
                    {
                        "Восст. энергии %"
                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %", "Мастерство стихий"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Пиро урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                }, //Ёимия

                new Character
                {
                    Name = "Аль-Хайтам",
                    MainSets = new List<string>
                    {
                        "Позолоченные сны", "Воспоминания дремучего леса"
                    },
                    AltSets = new List<string>
                    {
                        
                    },
                    SubSets = new List<string>
                    {
                        "Странствующий ансамбль", "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Позолоченные сны", "Цветок потерянного рая", "Эмблема рассечённой судьбы", "Церемония древней знати", "Конец гладиатора"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Восст. энергии %", "Мастерство стихий"
                    },
                    OkStats = new List<string>
                    {
                        "Сила атаки %"
                    },
                    ClockStats = new List<string>
                    {
                        "Мастерство стихий"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Дендро урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                }, //Аль-Хайтам

                new Character
                {
                    Name = "Альбедо",
                    MainSets = new List<string>
                    {
                        "Кокон сладких грёз"
                    },
                    AltSets = new List<string>
                    {
                        "Стойкость Миллелита", "Церемония древней знати"
                    },
                    SubSets = new List<string>
                    {
                        "Архаичный камень"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Защита %"
                    },
                    OkStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    ClockStats = new List<string>
                    {
                        "Защита %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Гео урона %", "Защита %"
                    },
                    CrownStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %", "Защита %"
                    },
                }, //Альбедо

                new Character
                {
                    Name = "Аяка",
                    MainSets = new List<string>
                    {
                        "Заблудший в метели"
                    },
                    AltSets = new List<string>
                    {
                        
                    },
                    SubSets = new List<string>
                    {
                        
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Восст. энергии %", "Сила атаки %"
                    },
                    OkStats = new List<string>
                    {
                        
                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Крио урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Крит. урон %"
                    },
                }, //Аяка

                new Character
                {
                    Name = "Аято",
                    MainSets = new List<string>
                    {
                        "Сердце глубин"
                    },
                    AltSets = new List<string>
                    {
                        "Конец гладиатора", "Отголоски подношения", "Сон нимфы"
                    },
                    SubSets = new List<string>
                    {
                        "Воспоминания Симэнавы", "Киноварное загробье", "Эмблема рассечённой судьбы"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    OkStats = new List<string>
                    {
                        "Мастерство стихий"
                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Гидро урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                }, //Аято

                new Character
                {
                    Name = "Барбара",
                    MainSets = new List<string>
                    {
                        "Возлюбленная юная дева"
                    },
                    AltSets = new List<string>
                    {
                        "Цветок потерянного рая"
                    },
                    SubSets = new List<string>
                    {
                        "Стойкость Миллелита", "Эмблема рассечённой судьбы"
                    },
                    PerfectStats = new List<string>
                    {
                        "HP %", "Восст. энергии %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Шанс крит. попадания %"
                    },
                    OkStats = new List<string>
                    {
                        "Крит. урон %"
                    },
                    ClockStats = new List<string>
                    {
                        "HP %", "Восст. энергии %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Гидро урона %", "HP %"
                    },
                    CrownStats = new List<string>
                    {
                        "Бонус лечения %", "Шанс крит. попадания %"
                    },
                }, //Барбара

                new Character
                {
                    Name = "Беннет",
                    MainSets = new List<string>
                    {
                        "Церемония древней знати"
                    },
                    AltSets = new List<string>
                    {
                        
                    },
                    SubSets = new List<string>
                    {
                        "Стойкость Миллелита", "Эмблема рассечённой судьбы", "Горящая алая ведьма", "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Конец гладиатора", "Сияние Вурукаши"
                    },
                    PerfectStats = new List<string>
                    {
                        "Восст. энергии %", "HP %"
                    },
                    GoodStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                    OkStats = new List<string>
                    {
                        "Сила атаки %", "Мастерство стихий"
                    },
                    ClockStats = new List<string>
                    {
                        "HP %", "Восст. энергии %", "Сила атаки %"
                    },
                    GobletStats = new List<string>
                    {
                        "HP %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "HP %"
                    },
                }, //Беннет

                new Character
                {
                    Name = "Бэй Доу",
                    MainSets = new List<string>
                    {
                        "Эмблема рассечённой судьбы"
                    },
                    AltSets = new List<string>
                    {
                        "Громогласный рёв ярости"
                    },
                    SubSets = new List<string>
                    {
                        "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Конец гладиатора", "Громогласный рёв ярости", "Церемония древней знати"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    OkStats = new List<string>
                    {
                        "Мастерство стихий"
                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Электро урона %", "Сила атаки %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                }, //Бэй Доу

                new Character
                {
                    Name = "Розария",
                    MainSets = new List<string>
                    {
                        "Эмблема рассечённой судьбы", "Церемония древней знати"
                    },
                    AltSets = new List<string>
                    {
                        
                    },
                    SubSets = new List<string>
                    {
                        "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Конец гладиатора", "Заблудший в метели"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    OkStats = new List<string>
                    {
                        
                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Крио урона %", "Сила атаки %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                }, //Розария

                new Character
                {
                    Name = "Син Цю",
                    MainSets = new List<string>
                    {
                        "Эмблема рассечённой судьбы"
                    },
                    AltSets = new List<string>
                    {
                        "Церемония древней знати"
                    },
                    SubSets = new List<string>
                    {
                        "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Конец гладиатора", "Сердце глубин", "Сон нимфы"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    OkStats = new List<string>
                    {
                        "Мастерство стихий"
                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Гидро урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                }, //Син Цю

                new Character
                {
                    Name = "Е Лань",
                    MainSets = new List<string>
                    {
                        "Эмблема рассечённой судьбы"
                    },
                    AltSets = new List<string>
                    {
                        "Церемония древней знати"
                    },
                    SubSets = new List<string>
                    {
                        "Стойкость Миллелита", "Сердце глубин", "Сон нимфы", "Сияние Вурукаши"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "HP %", "Восст. энергии %"
                    },
                    OkStats = new List<string>
                    {
                        "Мастерство стихий"
                    },
                    ClockStats = new List<string>
                    {
                        "HP %", "Восст. энергии %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Гидро урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                }, //Е Лань

                new Character
                {
                    Name = "Чун Юнь",
                    MainSets = new List<string>
                    {
                        "Церемония древней знати"
                    },
                    AltSets = new List<string>
                    {
                        "Эмблема рассечённой судьбы"
                    },
                    SubSets = new List<string>
                    {
                        "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Конец гладиатора", "Заблудший в метели"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %"
                    },
                    OkStats = new List<string>
                    {
                        "Восст. энергии %"
                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Крио урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                }, //Чун Юнь

                new Character
                {
                    Name = "Шэнь Хэ",
                    MainSets = new List<string>
                    {
                        "Церемония древней знати"
                    },
                    AltSets = new List<string>
                    {
                        
                    },
                    SubSets = new List<string>
                    {
                        "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Конец гладиатора", "Заблудший в метели", "Эмблема рассечённой судьбы"
                    },
                    PerfectStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    GoodStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    OkStats = new List<string>
                    {
                        
                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Крио урона %", "Сила атаки %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %", "Сила атаки %"
                    },
                }, //Шэнь Хэ

                new Character
                {
                    Name = "Ци Ци",
                    MainSets = new List<string>
                    {
                        "Моллюск морских красок"
                    },
                    AltSets = new List<string>
                    {
                        "Церемония древней знати", "Стойкость Миллелита", "Возлюбленная юная дева"
                    },
                    SubSets = new List<string>
                    {
                        "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Конец гладиатора", "Заблудший в метели", "Эмблема рассечённой судьбы"
                    },
                    PerfectStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    GoodStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Крио урона %", "Сила атаки %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Сила атаки %", "Бонус лечения %"
                    },
                }, //Ци Ци

                new Character
                {
                    Name = "Кэйа",
                    MainSets = new List<string>
                    {
                        "Заблудший в метели"
                    },
                    AltSets = new List<string>
                    {
                        "Эмблема рассечённой судьбы"
                    },
                    SubSets = new List<string>
                    {
                        "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Конец гладиатора", "Церемония древней знати"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Крио урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Сила атаки %"
                    },
                }, //Кэйа

                new Character
                {
                    Name = "Лайла",
                    MainSets = new List<string>
                    {
                        "Стойкость Миллелита"
                    },
                    AltSets = new List<string>
                    {
                        "Церемония древней знати", "Сияние Вурукаши"
                    },
                    SubSets = new List<string>
                    {
                        
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %"
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        "HP %"
                    },
                    GobletStats = new List<string>
                    {
                        "HP %"
                    },
                    CrownStats = new List<string>
                    {
                        "HP %"
                    },
                }, //Лайла

                new Character
                {
                    Name = "Гань Юй",
                    MainSets = new List<string>
                    {
                        "Странствующий ансамбль"
                    },
                    AltSets = new List<string>
                    {
                        "Воспоминания Симэнавы", "Заблудший в метели"
                    },
                    SubSets = new List<string>
                    {
                        "Странствующий ансамбль", "Киноварное загробье", "Отголоски подношения", "Позолоченные сны", "Цветок потерянного рая", "Эмблема рассечённой судьбы", "Церемония древней знати", "Конец гладиатора"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Мастерство стихий"
                    },
                    OkStats = new List<string>
                    {
                        "Восст. энергии %"
                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Крио урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Сила атаки %"
                    },
                }, //Гань Юй

                new Character
                {
                    Name = "Кокоми",
                    MainSets = new List<string>
                    {
                        "Стойкость Миллелита", "Моллюск морских красок"
                    },
                    AltSets = new List<string>
                    {
                        "Цветок потерянного рая", "Сияние Вурукаши"
                    },
                    SubSets = new List<string>
                    {
                        "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Цветок потерянного рая", "Эмблема рассечённой судьбы", "Конец гладиатора"
                    },
                    PerfectStats = new List<string>
                    {
                        "HP %", "Восст. энергии", "Сила атаки %"
                    },
                    GoodStats = new List<string>
                    {
                        
                    },
                    OkStats = new List<string>
                    {
                        "Мастерство стихий"
                    },
                    ClockStats = new List<string>
                    {
                        "HP %", "Восст. энергии %"
                    },
                    GobletStats = new List<string>
                    {
                        "HP %", "Бонус Гидро урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "HP %", "Бонус лечения %"
                    },
                }, //Кокоми

                new Character
                {
                    Name = "Горо",
                    MainSets = new List<string>
                    {
                        "Кокон сладких грёз"
                    },
                    AltSets = new List<string>
                    {
                        "Церемония древней знати"
                    },
                    SubSets = new List<string>
                    {
                        "Эмблема рассечённой судьбы"
                    },
                    PerfectStats = new List<string>
                    {
                        "Защита %", "Восст. энергии %"
                    },
                    GoodStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                    OkStats = new List<string>
                    {
                        "Сила атаки %"
                    },
                    ClockStats = new List<string>
                    {
                        "Защита %", "Восст. энергии %"
                    },
                    GobletStats = new List<string>
                    {
                        "Защита %"
                    },
                    CrownStats = new List<string>
                    {
                        "Защита %", "Шанс крит. попадания %"
                    },
                }, //Горо

                new Character
                {
                    Name = "Итто",
                    MainSets = new List<string>
                    {
                        "Кокон сладких грёз"
                    },
                    AltSets = new List<string>
                    {
                        "Встречная комета"
                    },
                    SubSets = new List<string>
                    {
                        "Архаичный камень"
                    },
                    PerfectStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                    GoodStats = new List<string>
                    {
                        "Защита %", "Восст. энергии %"
                    },
                    OkStats = new List<string>
                    {
                        "Сила атаки %"
                    },
                    ClockStats = new List<string>
                    {
                        "Защита %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Гео урона %", "Защита %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                }, //Итто

                new Character
                {
                    Name = "Ноэлль",
                    MainSets = new List<string>
                    {
                        "Кокон сладких грёз"
                    },
                    AltSets = new List<string>
                    {
                        "Конец гладиатора", "Встречная комета"
                    },
                    SubSets = new List<string>
                    {
                        "Архаичный камень"
                    },
                    PerfectStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                    GoodStats = new List<string>
                    {
                        "Защита %", "Восст. энергии %"
                    },
                    OkStats = new List<string>
                    {
                        "Сила атаки %"
                    },
                    ClockStats = new List<string>
                    {
                        "Защита %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Гео урона %", "Защита %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                }, //Ноэлль

                new Character
                {
                    Name = "Нин Гуан",
                    MainSets = new List<string>
                    {
                        
                    },
                    AltSets = new List<string>
                    {
                        "Встречная комета", "Архаичный камень", "Странствующий ансамбль"
                    },
                    SubSets = new List<string>
                    {
                        "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Конец гладиатора", "Эмблема рассечённой судьбы", "Церемония древней знати"
                    },
                    PerfectStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    OkStats = new List<string>
                    {
                        
                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Гео урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                }, //Нин Гуан

                new Character
                {
                    Name = "Сахароза",
                    MainSets = new List<string>
                    {
                        "Изумрудная тень"
                    },
                    AltSets = new List<string>
                    {
                        
                    },
                    SubSets = new List<string>
                    {
                        "Странствующий ансамбль", "Позолоченные сны", "Цветок потерянного рая", "Эмблема рассечённой судьбы", "Хроники Чертогов в пустыне"
                    },
                    PerfectStats = new List<string>
                    {
                        "Мастерство стихий", "Восст. энергии %"
                    },
                    GoodStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                    OkStats = new List<string>
                    {
                        "Сила атаки %"
                    },
                    ClockStats = new List<string>
                    {
                        "Мастерство стихий"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Анемо урона %", "Мастерство стихий"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Мастерство стихий"
                    },
                }, //Сахароза

                new Character
                {
                    Name = "Кадзуха",
                    MainSets = new List<string>
                    {
                        "Изумрудная тень"
                    },
                    AltSets = new List<string>
                    {

                    },
                    SubSets = new List<string>
                    {
                        "Странствующий ансамбль", "Позолоченные сны", "Цветок потерянного рая", "Эмблема рассечённой судьбы", "Хроники Чертогов в пустыне"
                    },
                    PerfectStats = new List<string>
                    {
                        "Мастерство стихий", "Восст. энергии %"
                    },
                    GoodStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                    OkStats = new List<string>
                    {
                        "Сила атаки %"
                    },
                    ClockStats = new List<string>
                    {
                        "Мастерство стихий"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Анемо урона %", "Мастерство стихий"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Мастерство стихий"
                    },
                }, //Кадзуха

                new Character
                {
                    Name = "Джинн",
                    MainSets = new List<string>
                    {
                        "Изумрудная тень"
                    },
                    AltSets = new List<string>
                    {
                        "Церемония древней знати"
                    },
                    SubSets = new List<string>
                    {
                        "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Конец гладиатора", "Эмблема рассечённой судьбы", "Хроники Чертогов в пустыне"
                    },
                    PerfectStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %", "Мастерство стихий"
                    },
                    OkStats = new List<string>
                    {
                        
                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Анемо урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                }, //Джинн

                new Character
                {
                    Name = "Венти",
                    MainSets = new List<string>
                    {
                        "Изумрудная тень"
                    },
                    AltSets = new List<string>
                    {
                        "Церемония древней знати"
                    },
                    SubSets = new List<string>
                    {
                        "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Конец гладиатора", "Эмблема рассечённой судьбы", "Хроники Чертогов в пустыне"
                    },
                    PerfectStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %", "Мастерство стихий"
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %", "Мастерство стихий"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Анемо урона %", "Мастерство стихий"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %", "Мастерство стихий", "Сила атаки %"
                    },
                }, //Венти

                new Character
                {
                    Name = "Сяо",
                    MainSets = new List<string>
                    {
                        "Киноварное загробье"
                    },
                    AltSets = new List<string>
                    {
                        
                    },
                    SubSets = new List<string>
                    {
                        "Воспоминания Симэнавы", "Отголоски подношения", "Конец гладиатора", "Эмблема рассечённой судьбы", "Хроники Чертогов в пустыне", "Изумрудная тень"
                    },
                    PerfectStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Анемо урона %", "Сила атаки %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                }, //Сяо

                new Character
                {
                    Name = "Странник",
                    MainSets = new List<string>
                    {
                        "Хроники Чертогов в пустыне"
                    },
                    AltSets = new List<string>
                    {
                        "Изумрудная тень"
                    },
                    SubSets = new List<string>
                    {
                        "Киноварное загробье", "Воспоминания Симэнавы", "Отголоски подношения", "Конец гладиатора", "Эмблема рассечённой судьбы", "Изумрудная тень"
                    },
                    PerfectStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    OkStats = new List<string>
                    {
                        "Мастерство стихий"
                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %", "Мастерство стихий"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Анемо урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                }, //Странник

                new Character
                {
                    Name = "Хэйдзо",
                    MainSets = new List<string>
                    {
                        "Изумрудная тень"
                    },
                    AltSets = new List<string>
                    {
                        
                    },
                    SubSets = new List<string>
                    {
                        "Киноварное загробье", "Воспоминания Симэнавы", "Отголоски подношения", "Конец гладиатора", "Хроники Чертогов в пустыне"
                    },
                    PerfectStats = new List<string>
                    {
                        "Сила атаки %", "Мастерство стихий"
                    },
                    GoodStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                    OkStats = new List<string>
                    {
                        
                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %", "Мастерство стихий"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Анемо урона %", "Мастерство стихий"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %", "Мастерство стихий"
                    },
                }, //Хэйдзо

                new Character
                {
                    Name = "Фарузан",
                    MainSets = new List<string>
                    {
                        "Изумрудная тень", "Церемония древней знати"
                    },
                    AltSets = new List<string>
                    {
                        "Эмблема рассечённой судьбы", "Стойкость Миллелита"
                    },
                    SubSets = new List<string>
                    {
                        "Киноварное загробье", "Воспоминания Симэнавы", "Отголоски подношения", "Конец гладиатора", "Хроники Чертогов в пустыне"
                    },
                    PerfectStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Восст. энергии %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Крит. урон %"
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Анемо урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                }, //Фарузан

                new Character
                {
                    Name = "Тарталья",
                    MainSets = new List<string>
                    {
                        "Сердце глубин", "Сон нимфы"
                    },
                    AltSets = new List<string>
                    {
                        "Конец гладиатора"
                    },
                    SubSets = new List<string>
                    {
                        "Киноварное загробье", "Воспоминания Симэнавы", "Отголоски подношения", "Церемония древней знати"
                    },
                    PerfectStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Мастерство стихий"
                    },
                    OkStats = new List<string>
                    {
                        "Восст. энергии %"
                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Гидро урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                }, //Тарталья

                new Character
                {
                    Name = "Мона",
                    MainSets = new List<string>
                    {
                        "Церемония древней знати"
                    },
                    AltSets = new List<string>
                    {
                        "Эмблема рассечённой судьбы"
                    },
                    SubSets = new List<string>
                    {
                        "Конец гладиатора", "Киноварное загробье", "Воспоминания Симэнавы", "Отголоски подношения", "Сердце глубин", "Сон нимфы"
                    },
                    PerfectStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    OkStats = new List<string>
                    {
                        
                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Гидро урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                }, //Мона

                new Character
                {
                    Name = "Нилу",
                    MainSets = new List<string>
                    {
                        "Стойкость Миллелита"
                    },
                    AltSets = new List<string>
                    {
                        "Церемония древней знати", "Сердце глубин", "Позолоченные сны", "Цветок потерянного рая", "Сон нимфы", 
                    },
                    SubSets = new List<string>
                    {
                        "Сияние Вурукаши"
                    },
                    PerfectStats = new List<string>
                    {
                        "HP %", "Восст. энергии %", "Мастерство стихий"
                    },
                    GoodStats = new List<string>
                    {
                        
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        "HP %", "Восст. энергии %"
                    },
                    GobletStats = new List<string>
                    {
                        "HP %"
                    },
                    CrownStats = new List<string>
                    {
                        "HP %"
                    },
                }, //Нилу

                new Character
                {
                    Name = "Кандакия",
                    MainSets = new List<string>
                    {
                        "Церемония древней знати", "Эмблема рассечённой судьбы"
                    },
                    AltSets = new List<string>
                    {
                        "Конец гладиатора", "Сердце глубин", "Сияние Вурукаши"
                    },
                    SubSets = new List<string>
                    {
                        "Сон нимфы"
                    },
                    PerfectStats = new List<string>
                    {
                        "HP %", "Восст. энергии %"
                    },
                    GoodStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        "HP %"
                    },
                    GobletStats = new List<string>
                    {
                        "HP %"
                    },
                    CrownStats = new List<string>
                    {
                        "HP %"
                    },
                }, //Кандакия

                new Character
                {
                    Name = "Янь Фэй",
                    MainSets = new List<string>
                    {
                        "Горящая алая ведьма"
                    },
                    AltSets = new List<string>
                    {
                        "Странствующий ансамбль", "Воспоминания Симэнавы", "Позолоченные сны"
                    },
                    SubSets = new List<string>
                    {
                        "Эмблема рассечённой судьбы", "Киноварное загробье", "Отголоски подношения", "Позолоченные сны", "Цветок потерянного рая", "Конец гладиатора"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Мастерство стихий"
                    },
                    OkStats = new List<string>
                    {
                        "Восст. энергии %", "HP %"
                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %", "Мастерство стихий"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Пиро урона %", "Сила атаки %"
                    },
                    CrownStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                }, //Янь Фэй

                new Character
                {
                    Name = "Кли",
                    MainSets = new List<string>
                    {
                        "Воспоминания Симэнавы", "Горящая алая ведьма"
                    },
                    AltSets = new List<string>
                    {
                        "Позолоченные сны"
                    },
                    SubSets = new List<string>
                    {
                        "Странствующий ансамбль", "Киноварное загробье", "Отголоски подношения", "Позолоченные сны", "Цветок потерянного рая", "Конец гладиатора"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Мастерство стихий"
                    },
                    OkStats = new List<string>
                    {
                        "Восст. энергии %"
                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %", "Мастерство стихий"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Пиро урона %", "Сила атаки %"
                    },
                    CrownStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                }, //Кли

                new Character
                {
                    Name = "Сян Лин",
                    MainSets = new List<string>
                    {
                        "Эмблема рассечённой судьбы"
                    },
                    AltSets = new List<string>
                    {
                        "Горящая алая ведьма", "Позолоченные сны"
                    },
                    SubSets = new List<string>
                    {
                        "Воспоминания Симэнавы", "Странствующий ансамбль", "Киноварное загробье", "Отголоски подношения", "Позолоченные сны", "Цветок потерянного рая", "Конец гладиатора", "Церемония древней знати"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Восст. энергии %", "Сила атаки %", "Мастерство стихий"
                    },
                    OkStats = new List<string>
                    {
                        
                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %", "Мастерство стихий", "Восст. энергии %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Пиро урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                }, //Сян Лин

                new Character
                {
                    Name = "Эмбер",
                    MainSets = new List<string>
                    {
                        "Церемония древней знати"
                    },
                    AltSets = new List<string>
                    {
                        "Эмблема рассечённой судьбы", "Горящая алая ведьма", "Странствующий ансамбль"
                    },
                    SubSets = new List<string>
                    {
                        "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Позолоченные сны", "Цветок потерянного рая", "Конец гладиатора"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Восст. энергии %", "Сила атаки %"
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Пиро урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                }, //Эмбер

                new Character
                {
                    Name = "Синь Янь",
                    MainSets = new List<string>
                    {
                        "Стойкость Миллелита"
                    },
                    AltSets = new List<string>
                    {
                        "Эмблема рассечённой судьбы", "Церемония древней знати"
                    },
                    SubSets = new List<string>
                    {
                        "Горящая алая ведьма", "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Конец гладиатора", "Бледный огонь", "Рыцарь крови"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Сила атаки %"
                    },
                    GoodStats = new List<string>
                    {
                        "Восст. энергии %", "Защита %"
                    },
                    OkStats = new List<string>
                    {
                        "Шанс крит. попадания %"
                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %", "Защита %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Пиро урона %", "Защита %", "Бонус физ. урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Крит. урон %", "Защита %"
                    },
                }, //Синь Янь

                new Character
                {
                    Name = "Юнь Цзинь",
                    MainSets = new List<string>
                    {
                        "Кокон сладких грёз"
                    },
                    AltSets = new List<string>
                    {
                        "Церемония древней знати"
                    },
                    SubSets = new List<string>
                    {
                        "Архаичный камень", "Эмблема рассечённой судьбы"
                    },
                    PerfectStats = new List<string>
                    {
                        "Защита %", "Восст. энергии %"
                    },
                    GoodStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                    OkStats = new List<string>
                    {
                        
                    },
                    ClockStats = new List<string>
                    {
                        "Защита %", "Восст. энергии %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Гео урона %", "Защита %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Защита %"
                    },
                }, //Юнь Цзинь

                new Character
                {
                    Name = "Тома",
                    MainSets = new List<string>
                    {
                        "Эмблема рассечённой судьбы", "Позолоченные сны"
                    },
                    AltSets = new List<string>
                    {
                        "Цветок потерянного рая"
                    },
                    SubSets = new List<string>
                    {
                        "Стойкость Миллелита"
                    },
                    PerfectStats = new List<string>
                    {
                        "Восст. энергии %", "HP %", "Мастерство стихий"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Шанс крит. попадания %"
                    },
                    OkStats = new List<string>
                    {
                        "Крит. урон %"
                    },
                    ClockStats = new List<string>
                    {
                        "Мастерство стихий", "Восст. энергии %", "HP %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Пиро урона %", "HP %", "Мастерство стихий"
                    },
                    CrownStats = new List<string>
                    {
                        "Крит. урон %", "Мастерство стихий", "Шанс крит. попадания %"
                    },
                }, //Тома

                new Character
                {
                    Name = "Коллеи",
                    MainSets = new List<string>
                    {
                        "Воспоминания дремучего леса"
                    },
                    AltSets = new List<string>
                    {
                        "Церемония древней знати", "Эмблема рассечённой судьбы"
                    },
                    SubSets = new List<string>
                    {
                        "Странствующий ансамбль", "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Позолоченные сны", "Цветок потерянного рая", "Эмблема рассечённой судьбы", "Церемония древней знати", "Конец гладиатора"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Восст. энергии %", "Мастерство стихий"
                    },
                    OkStats = new List<string>
                    {
                        "Сила атаки %"
                    },
                    ClockStats = new List<string>
                    {
                        "Мастерство стихий", "Восст. энергии %", "Сила атаки %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Дендро урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                }, //Коллеи

                new Character
                {
                    Name = "Нахида",
                    MainSets = new List<string>
                    {
                        "Воспоминания дремучего леса", "Позолоченные сны"
                    },
                    AltSets = new List<string>
                    {
                       
                    },
                    SubSets = new List<string>
                    {
                        "Странствующий ансамбль", "Цветок потерянного рая"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Мастерство стихий"
                    },
                    OkStats = new List<string>
                    {
                        "Сила атаки %"
                    },
                    ClockStats = new List<string>
                    {
                        "Мастерство стихий"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Дендро урона %", "Мастерство стихий"
                    },
                    CrownStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %", "Мастерство стихий"
                    },
                }, //Нахида

                new Character
                {
                    Name = "Тигнари",
                    MainSets = new List<string>
                    {
                        "Странствующий ансамбль", "Воспоминания дремучего леса"
                    },
                    AltSets = new List<string>
                    {
                        "Позолоченные сны"
                    },
                    SubSets = new List<string>
                    {
                        "Странствующий ансамбль", "Цветок потерянного рая", "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Конец гладиатора"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Мастерство стихий", "Сила атаки %"
                    },
                    OkStats = new List<string>
                    {
                        
                    },
                    ClockStats = new List<string>
                    {
                        "Мастерство стихий", "Сила атаки %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Дендро урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                }, //Тигнари

                new Character
                {
                    Name = "Яо Яо",
                    MainSets = new List<string>
                    {
                        "Воспоминания дремучего леса"
                    },
                    AltSets = new List<string>
                    {
                        "Стойкость Миллелита", "Сияние Вурукаши"
                    },
                    SubSets = new List<string>
                    {
                        "Эмблема рассечённой судьбы", "Возлюбленная юная дева"
                    },
                    PerfectStats = new List<string>
                    {
                        "Восст. энергии %", "HP %"
                    },
                    GoodStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Мастерство стихий", "Крит. урон %"
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        "Мастерство стихий", "Восст. энергии %", "HP %"
                    },
                    GobletStats = new List<string>
                    {
                        "HP %", "Бонус Дендро урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "HP %"
                    },
                }, //Яо Яо

                new Character
                {
                    Name = "Рэйзор",
                    MainSets = new List<string>
                    {
                        "Бледный огонь"
                    },
                    AltSets = new List<string>
                    {
                        "Конец гладиатора"
                    },
                    SubSets = new List<string>
                    {
                        "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Эмблема рассечённой судьбы", "Церемония древней знати", "Рыцарь крови"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Восст. энергии %", "Сила атаки %"
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус физ. урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                }, //Рэйзор

                new Character
                {
                    Name = "Фишль",
                    MainSets = new List<string>
                    {
                        
                    },
                    AltSets = new List<string>
                    {
                        "Позолоченные сны", "Громогласный рёв ярости", "Стойкость Миллелита"
                    },
                    SubSets = new List<string>
                    {
                        "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Конец гладиатора"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Мастерство стихий"
                    },
                    OkStats = new List<string>
                    {
                        "Восст. энергии %"
                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %", "Мастерство стихий"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Электро урона %", "Сила атаки %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                }, //Фишль

                new Character
                {
                    Name = "Кэ Цин",
                    MainSets = new List<string>
                    {
                        "Громогласный рёв ярости"
                    },
                    AltSets = new List<string>
                    {
                        "Усмиряющий гром"
                    },
                    SubSets = new List<string>
                    {
                        "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Конец гладиатора", "Церемония древней знати"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Мастерство стихий"
                    },
                    OkStats = new List<string>
                    {
                        
                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %", "Мастерство стихий"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Электро урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                }, //Кэ Цин

                new Character
                {
                    Name = "Лиза",
                    MainSets = new List<string>
                    {
                        "Эмблема рассечённой судьбы", "Позолоченные сны"
                    },
                    AltSets = new List<string>
                    {
                        "Церемония древней знати"
                    },
                    SubSets = new List<string>
                    {
                        "Громогласный рёв ярости", "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Конец гладиатора", "Странствующий ансамбль", "Цветок потерянного рая"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Мастерство стихий", "Восст. энергии %"
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %", "Мастерство стихий", "Восст. энергии %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Электро урона %", "Мастерство стихий"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %", "Мастерство стихий"
                    },
                }, //Лиза

                new Character
                {
                    Name = "Сара",
                    MainSets = new List<string>
                    {
                        "Церемония древней знати"
                    },
                    AltSets = new List<string>
                    {
                        "Эмблема рассечённой судьбы"
                    },
                    SubSets = new List<string>
                    {
                        "Громогласный рёв ярости", "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Конец гладиатора"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Электро урона %", "Мастерство стихий"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                }, //Сара

                new Character
                {
                    Name = "Синобу",
                    MainSets = new List<string>
                    {
                        "Стойкость Миллелита"
                    },
                    AltSets = new List<string>
                    {
                        "Воспоминания дремучего леса", "Позолоченные сны", "Цветок потерянного рая"
                    },
                    SubSets = new List<string>
                    {
                        "Эмблема рассечённой судьбы", "Странствующий ансамбль", "Цветок потерянного рая", "Сияние Вурукаши"
                    },
                    PerfectStats = new List<string>
                    {
                        "HP %", "Мастерство стихий"
                    },
                    GoodStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Восст. энергии %"
                    },
                    OkStats = new List<string>
                    {
                        "Крит. урон %", "Сила атаки %"
                    },
                    ClockStats = new List<string>
                    {
                        "HP %", "Сила атаки %", "Восст. энергии %", "Мастерство стихий"
                    },
                    GobletStats = new List<string>
                    {
                        "HP %", "Бонус Электро урона %", "Мастерство стихий"
                    },
                    CrownStats = new List<string>
                    {
                        "HP %", "Бонус лечения %", "Шанс крит. попадания %", "Крит. урон %", "Мастерство стихий"
                    },
                }, //Синобу

                new Character
                {
                    Name = "Сайно",
                    MainSets = new List<string>
                    {
                        "Позолоченные сны"
                    },
                    AltSets = new List<string>
                    {
                        "Громогласный рёв ярости", "Усмиряющий гром"
                    },
                    SubSets = new List<string>
                    {
                        "Эмблема рассечённой судьбы", "Странствующий ансамбль", "Цветок потерянного рая"
                    },
                    PerfectStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                    GoodStats = new List<string>
                    {
                        "Мастерство стихий", "Восст. энергии %"
                    },
                    OkStats = new List<string>
                    {
                        "Сила атаки %"
                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %", "Мастерство стихий"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Электро урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                }, //Сайно

                new Character
                {
                    Name = "Дори",
                    MainSets = new List<string>
                    {
                        "Церемония древней знати", "Моллюск морских красок"
                    },
                    AltSets = new List<string>
                    {
                        "Цветок потерянного рая"
                    },
                    SubSets = new List<string>
                    {
                        "Эмблема рассечённой судьбы", "Стойкость Миллелита", "Сияние Вурукаши"
                    },
                    PerfectStats = new List<string>
                    {
                        "HP %", "Восст. энергии %"
                    },
                    GoodStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Сила атаки %"
                    },
                    OkStats = new List<string>
                    {
                        "Крит. урон %"
                    },
                    ClockStats = new List<string>
                    {
                        "HP %", "Восст. энергии %"
                    },
                    GobletStats = new List<string>
                    {
                        "HP %"
                    },
                    CrownStats = new List<string>
                    {
                        "HP %", "Бонус лечения %"
                    },
                }, //Дори

                new Character
                {
                    Name = "Дэхья",
                    MainSets = new List<string>
                    {
                        "Горящая алая ведьма", "Сияние Вурукаши"
                    },
                    AltSets = new List<string>
                    {
                        "Моллюск морских красок", "Позолоченные сны", "Конец гладиатора", "Эмблема рассечённой судьбы", "Стойкость Миллелита"
                    },
                    SubSets = new List<string>
                    {
                        "Странствующий ансамбль", "Церемония древней знати", "Воспоминания Симэнавы", "Киноварное загробье", "Отголоски подношения", "Позолоченные сны", "Цветок потерянного рая"
                    },
                    PerfectStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                    GoodStats = new List<string>
                    {
                        "Восст. энергии %", "HP %", "Мастерство стихий"
                    },
                    OkStats = new List<string>
                    {
                        "Сила атаки %"
                    },
                    ClockStats = new List<string>
                    {
                        "HP %", "Мастерство стихий"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Пиро урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Крит. урон %", "Шанс крит. попадания %"
                    },
                }, //Дэхья

                new Character
                {
                    Name = "Мика",
                    MainSets = new List<string>
                    {
                        "Церемония древней знати"
                    },
                    AltSets = new List<string>
                    {
                        "Моллюск морских красок"
                    },
                    SubSets = new List<string>
                    {
                        "Эмблема рассечённой судьбы", "Стойкость Миллелита", "Сияние Вурукаши"
                    },
                    PerfectStats = new List<string>
                    {
                        "Восст. энергии %", "HP %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Крит. урон %", "Шанс крит. попадания %"
                    },
                    OkStats = new List<string>
                    {
                        
                    },
                    ClockStats = new List<string>
                    {
                        "HP %", "Восст. энергии %"
                    },
                    GobletStats = new List<string>
                    {
                        "HP %"
                    },
                    CrownStats = new List<string>
                    {
                        "HP %"
                    },
                }, //Мика

                new Character
                {
                    Name = "Бай Чжу",
                    MainSets = new List<string>
                    {
                        "Воспоминания дремучего леса"
                    },
                    AltSets = new List<string>
                    {
                        "Церемония древней знати"
                    },
                    SubSets = new List<string>
                    {
                        "Эмблема рассечённой судьбы", "Стойкость Миллелита", "Цветок потерянного рая", "Сияние Вурукаши"
                    },
                    PerfectStats = new List<string>
                    {
                        "HP %", "Восст. энергии %", "Мастерство стихий"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Шанс крит. попадания %"
                    },
                    OkStats = new List<string>
                    {
                        "Крит. урон %"
                    },
                    ClockStats = new List<string>
                    {
                        "HP %", "Восст. энергии %"
                    },
                    GobletStats = new List<string>
                    {
                        "HP %"
                    },
                    CrownStats = new List<string>
                    {
                        "HP %"
                    },
                }, //Бай Чжу

                new Character
                {
                    Name = "Кавех",
                    MainSets = new List<string>
                    {
                        "Воспоминания дремучего леса", "Цветок потерянного рая"
                    },
                    AltSets = new List<string>
                    {
                        "Позолоченные сны", "Конец гладиатора"
                    },
                    SubSets = new List<string>
                    {
                        "Воспоминания Симэнавы", "Странствующий ансамбль", "Цветок потерянного рая"
                    },
                    PerfectStats = new List<string>
                    {
                        "Мастерство стихий", "Шанс крит. попадания %", "Крит. урон %"
                    },
                    GoodStats = new List<string>
                    {
                        "Сила атаки %", "Восст. энергии %"
                    },
                    OkStats = new List<string>
                    {
                        
                    },
                    ClockStats = new List<string>
                    {
                        "Мастерство стихий", "Сила атаки %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Дендро урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                }, //Кавех

                new Character
                {
                    Name = "Элой",
                    MainSets = new List<string>
                    {
                        "Воспоминания Симэнавы"
                    },
                    AltSets = new List<string>
                    {
                        "Заблудший в метели"
                    },
                    SubSets = new List<string>
                    {
                        "Странствующий ансамбль", "Церемония древней знати", "Киноварное загробье", "Отголоски подношения", "Позолоченные сны", "Цветок потерянного рая", "Конец гладиатора"
                    },
                    PerfectStats = new List<string>
                    {
                        "Сила атаки %", "Шанс крит. попадания %", "Крит. урон %"
                    },
                    GoodStats = new List<string>
                    {
                        "Мастерство стихий"
                    },
                    OkStats = new List<string>
                    {
                        "Восст. энергии %"
                    },
                    ClockStats = new List<string>
                    {
                        "Сила атаки %"
                    },
                    GobletStats = new List<string>
                    {
                        "Бонус Крио урона %"
                    },
                    CrownStats = new List<string>
                    {
                        "Шанс крит. попадания %", "Крит. урон %"
                    },
                }, //Элой
            };
        }
    }
}
