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
                        ArtNamesData.CRIMSON_WITCH_OF_FLAMES
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.GILDED_DREAMS
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.WANDERERS_TROUPE, ArtNamesData.TENACITY_OF_THE_MILLELITH, ArtNamesData.FLOWER_OF_PARADISE_LOST, ArtNamesData.VOURUKASHAS_GLOW
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ELEMENTAL_MASTERY, StatNamesData.HP_PERCENT
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.PYRO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                }, //Ху Тао

                new Character
                {
                    Name = "Дилюк",
                    MainSets = new List<string>
                    {
                        ArtNamesData.CRIMSON_WITCH_OF_FLAMES
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.GILDED_DREAMS, ArtNamesData.GLADIATOR_FINALE
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.WANDERERS_TROUPE, ArtNamesData.NOBLESSE_OBLIGE, ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GILDED_DREAMS, ArtNamesData.FLOWER_OF_PARADISE_LOST
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.PYRO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                }, //Дилюк

                new Character
                {
                    Name = "Диона",
                    MainSets = new List<string>
                    {
                        ArtNamesData.NOBLESSE_OBLIGE
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.MAIDEN_BELOVED
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.TENACITY_OF_THE_MILLELITH, ArtNamesData.VOURUKASHAS_GLOW
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.ENERGY_RECHARGE, StatNamesData.HP_PERCENT
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE, StatNamesData.ATK_PERCENT
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT
                    },
                }, //Диона

                new Character
                {
                    Name = "Райден",
                    MainSets = new List<string>
                    {
                        ArtNamesData.EMBLEM_OF_SEVERED_FATE
                    },
                    AltSets = new List<string>
                    {

                    },
                    SubSets = new List<string>
                    {

                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ENERGY_RECHARGE, StatNamesData.ATK_PERCENT
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ELEMENTAL_MASTERY
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ELECTRO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                }, //Райден

                new Character
                {
                    Name = "Чжун Ли",
                    MainSets = new List<string>
                    {
                        ArtNamesData.TENACITY_OF_THE_MILLELITH
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.NOBLESSE_OBLIGE
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.GLADIATOR_FINALE, ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.ARCHAIC_PETRA, ArtNamesData.VOURUKASHAS_GLOW
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.ATK_PERCENT
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ENERGY_RECHARGE
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.ATK_PERCENT
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.GEO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
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
                        ArtNamesData.THUNDER­SOOTHER, ArtNamesData.GILDED_DREAMS
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.GLADIATOR_FINALE, ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.THUNDERING_FURY, ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.FLOWER_OF_PARADISE_LOST
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ENERGY_RECHARGE, StatNamesData.ATK_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ELEMENTAL_MASTERY, StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.ELECTRO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                }, //Яэ Мико

                new Character
                {
                    Name = "Эола",
                    MainSets = new List<string>
                    {
                        ArtNamesData.PALE_FLAME, ArtNamesData.BLOODSTAINED_CHIVALRY
                    },
                    AltSets = new List<string>
                    {

                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.GLADIATOR_FINALE, ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.NOBLESSE_OBLIGE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ENERGY_RECHARGE, StatNamesData.ATK_PERCENT
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.PHYS_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                }, //Эола

                new Character
                {
                    Name = "Ёимия",
                    MainSets = new List<string>
                    {
                        ArtNamesData.SHIMENAWAS_REMINISCENCE
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.CRIMSON_WITCH_OF_FLAMES
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.WANDERERS_TROUPE, ArtNamesData.GLADIATOR_FINALE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GILDED_DREAMS, ArtNamesData.FLOWER_OF_PARADISE_LOST
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ENERGY_RECHARGE
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.PYRO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                }, //Ёимия

                new Character
                {
                    Name = "Аль-Хайтам",
                    MainSets = new List<string>
                    {
                        ArtNamesData.GILDED_DREAMS, ArtNamesData.DEEPWOOD_MEMORIES
                    },
                    AltSets = new List<string>
                    {

                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.WANDERERS_TROUPE, ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GILDED_DREAMS, ArtNamesData.FLOWER_OF_PARADISE_LOST, ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.NOBLESSE_OBLIGE, ArtNamesData.GLADIATOR_FINALE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ENERGY_RECHARGE, StatNamesData.ELEMENTAL_MASTERY
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ELEMENTAL_MASTERY
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.DENDRO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                }, //Аль-Хайтам

                new Character
                {
                    Name = "Альбедо",
                    MainSets = new List<string>
                    {
                        ArtNamesData.HUSK_OF_OPULENT_DREAMS
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.TENACITY_OF_THE_MILLELITH, ArtNamesData.NOBLESSE_OBLIGE
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.ARCHAIC_PETRA
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.DEF_PERCENT
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.DEF_PERCENT
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.GEO_AMPLIFICATION, StatNamesData.DEF_PERCENT
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE, StatNamesData.DEF_PERCENT
                    },
                }, //Альбедо

                new Character
                {
                    Name = "Аяка",
                    MainSets = new List<string>
                    {
                        ArtNamesData.BLIZZARD_STRAYER
                    },
                    AltSets = new List<string>
                    {

                    },
                    SubSets = new List<string>
                    {

                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ENERGY_RECHARGE, StatNamesData.ATK_PERCENT
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.CRYO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG
                    },
                }, //Аяка

                new Character
                {
                    Name = "Аято",
                    MainSets = new List<string>
                    {
                        ArtNamesData.HEART_OF_DEPTH
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.GLADIATOR_FINALE, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.NYMPHS_DREAM
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.EMBLEM_OF_SEVERED_FATE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ELEMENTAL_MASTERY
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.HYDRO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                }, //Аято

                new Character
                {
                    Name = "Барбара",
                    MainSets = new List<string>
                    {
                        ArtNamesData.MAIDEN_BELOVED
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.FLOWER_OF_PARADISE_LOST
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.TENACITY_OF_THE_MILLELITH, ArtNamesData.EMBLEM_OF_SEVERED_FATE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.CRIT_RATE
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.HYDRO_AMPLIFICATION, StatNamesData.HP_PERCENT
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.HEALING_BONUS, StatNamesData.CRIT_RATE
                    },
                }, //Барбара

                new Character
                {
                    Name = "Беннет",
                    MainSets = new List<string>
                    {
                        ArtNamesData.NOBLESSE_OBLIGE
                    },
                    AltSets = new List<string>
                    {

                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.TENACITY_OF_THE_MILLELITH, ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.CRIMSON_WITCH_OF_FLAMES, ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GLADIATOR_FINALE, ArtNamesData.VOURUKASHAS_GLOW
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.ENERGY_RECHARGE, StatNamesData.HP_PERCENT
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.ENERGY_RECHARGE, StatNamesData.ATK_PERCENT
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.HP_PERCENT
                    },
                }, //Беннет

                new Character
                {
                    Name = "Бэй Доу",
                    MainSets = new List<string>
                    {
                        ArtNamesData.EMBLEM_OF_SEVERED_FATE
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.THUNDERING_FURY
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GLADIATOR_FINALE, ArtNamesData.THUNDERING_FURY, ArtNamesData.NOBLESSE_OBLIGE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ELEMENTAL_MASTERY
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.ELECTRO_AMPLIFICATION, StatNamesData.ATK_PERCENT
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                }, //Бэй Доу

                new Character
                {
                    Name = "Розария",
                    MainSets = new List<string>
                    {
                        ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.NOBLESSE_OBLIGE
                    },
                    AltSets = new List<string>
                    {

                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GLADIATOR_FINALE, ArtNamesData.BLIZZARD_STRAYER
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.CRYO_AMPLIFICATION, StatNamesData.ATK_PERCENT
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                }, //Розария

                new Character
                {
                    Name = "Син Цю",
                    MainSets = new List<string>
                    {
                        ArtNamesData.EMBLEM_OF_SEVERED_FATE
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.NOBLESSE_OBLIGE
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GLADIATOR_FINALE, ArtNamesData.HEART_OF_DEPTH, ArtNamesData.NYMPHS_DREAM
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ELEMENTAL_MASTERY
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.HYDRO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                }, //Син Цю

                new Character
                {
                    Name = "Е Лань",
                    MainSets = new List<string>
                    {
                        ArtNamesData.EMBLEM_OF_SEVERED_FATE
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.NOBLESSE_OBLIGE
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.TENACITY_OF_THE_MILLELITH, ArtNamesData.HEART_OF_DEPTH, ArtNamesData.NYMPHS_DREAM, ArtNamesData.VOURUKASHAS_GLOW
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ELEMENTAL_MASTERY
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.HYDRO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                }, //Е Лань

                new Character
                {
                    Name = "Чун Юнь",
                    MainSets = new List<string>
                    {
                        ArtNamesData.NOBLESSE_OBLIGE
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.EMBLEM_OF_SEVERED_FATE
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GLADIATOR_FINALE, ArtNamesData.BLIZZARD_STRAYER
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ENERGY_RECHARGE
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.CRYO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                }, //Чун Юнь

                new Character
                {
                    Name = "Шэнь Хэ",
                    MainSets = new List<string>
                    {
                        ArtNamesData.NOBLESSE_OBLIGE
                    },
                    AltSets = new List<string>
                    {

                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GLADIATOR_FINALE, ArtNamesData.BLIZZARD_STRAYER, ArtNamesData.EMBLEM_OF_SEVERED_FATE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.CRYO_AMPLIFICATION, StatNamesData.ATK_PERCENT
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG, StatNamesData.ATK_PERCENT
                    },
                }, //Шэнь Хэ

                new Character
                {
                    Name = "Ци Ци",
                    MainSets = new List<string>
                    {
                        ArtNamesData.OCEAN_HUED_CLAM
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.NOBLESSE_OBLIGE, ArtNamesData.TENACITY_OF_THE_MILLELITH, ArtNamesData.MAIDEN_BELOVED
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GLADIATOR_FINALE, ArtNamesData.BLIZZARD_STRAYER, ArtNamesData.EMBLEM_OF_SEVERED_FATE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.CRYO_AMPLIFICATION, StatNamesData.ATK_PERCENT
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.ATK_PERCENT, StatNamesData.HEALING_BONUS
                    },
                }, //Ци Ци

                new Character
                {
                    Name = "Кэйа",
                    MainSets = new List<string>
                    {
                        ArtNamesData.BLIZZARD_STRAYER
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.EMBLEM_OF_SEVERED_FATE
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GLADIATOR_FINALE, ArtNamesData.NOBLESSE_OBLIGE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.CRYO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.ATK_PERCENT
                    },
                }, //Кэйа

                new Character
                {
                    Name = "Лайла",
                    MainSets = new List<string>
                    {
                        ArtNamesData.TENACITY_OF_THE_MILLELITH
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.NOBLESSE_OBLIGE, ArtNamesData.VOURUKASHAS_GLOW
                    },
                    SubSets = new List<string>
                    {

                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT
                    },
                }, //Лайла

                new Character
                {
                    Name = "Гань Юй",
                    MainSets = new List<string>
                    {
                        ArtNamesData.WANDERERS_TROUPE
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.BLIZZARD_STRAYER, ArtNamesData.LAVAWALKER
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.WANDERERS_TROUPE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GILDED_DREAMS, ArtNamesData.FLOWER_OF_PARADISE_LOST, ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.NOBLESSE_OBLIGE, ArtNamesData.GLADIATOR_FINALE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ENERGY_RECHARGE
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.CRYO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.ATK_PERCENT
                    },
                }, //Гань Юй

                new Character
                {
                    Name = "Кокоми",
                    MainSets = new List<string>
                    {
                        ArtNamesData.TENACITY_OF_THE_MILLELITH, ArtNamesData.OCEAN_HUED_CLAM
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.FLOWER_OF_PARADISE_LOST, ArtNamesData.VOURUKASHAS_GLOW
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.FLOWER_OF_PARADISE_LOST, ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.GLADIATOR_FINALE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.ENERGY_RECHARGE, StatNamesData.ATK_PERCENT
                    },
                    GoodStats = new List<string>
                    {

                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ELEMENTAL_MASTERY
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.HYDRO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.HEALING_BONUS
                    },
                }, //Кокоми

                new Character
                {
                    Name = "Горо",
                    MainSets = new List<string>
                    {
                        ArtNamesData.HUSK_OF_OPULENT_DREAMS
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.NOBLESSE_OBLIGE
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.EMBLEM_OF_SEVERED_FATE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.DEF_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.DEF_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.DEF_PERCENT
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.DEF_PERCENT, StatNamesData.CRIT_RATE
                    },
                }, //Горо

                new Character
                {
                    Name = "Итто",
                    MainSets = new List<string>
                    {
                        ArtNamesData.HUSK_OF_OPULENT_DREAMS
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.RETRACING_BOLIDE
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.ARCHAIC_PETRA
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.DEF_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.DEF_PERCENT
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.GEO_AMPLIFICATION, StatNamesData.DEF_PERCENT
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                }, //Итто

                new Character
                {
                    Name = "Ноэлль",
                    MainSets = new List<string>
                    {
                        ArtNamesData.HUSK_OF_OPULENT_DREAMS
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.GLADIATOR_FINALE, ArtNamesData.RETRACING_BOLIDE
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.ARCHAIC_PETRA
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.DEF_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.DEF_PERCENT
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.GEO_AMPLIFICATION, StatNamesData.DEF_PERCENT
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
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
                        ArtNamesData.RETRACING_BOLIDE, ArtNamesData.ARCHAIC_PETRA, ArtNamesData.WANDERERS_TROUPE
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GLADIATOR_FINALE, ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.NOBLESSE_OBLIGE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.GEO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                }, //Нин Гуан

                new Character
                {
                    Name = "Сахароза",
                    MainSets = new List<string>
                    {
                        ArtNamesData.VIRIDESCENT_VENERER
                    },
                    AltSets = new List<string>
                    {

                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.WANDERERS_TROUPE, ArtNamesData.GILDED_DREAMS, ArtNamesData.FLOWER_OF_PARADISE_LOST, ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.DESERT_PAVILION_CHRONICLE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.ELEMENTAL_MASTERY, StatNamesData.ENERGY_RECHARGE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ELEMENTAL_MASTERY
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.ANEMO_AMPLIFICATION, StatNamesData.ELEMENTAL_MASTERY
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.ELEMENTAL_MASTERY
                    },
                }, //Сахароза

                new Character
                {
                    Name = "Кадзуха",
                    MainSets = new List<string>
                    {
                        ArtNamesData.VIRIDESCENT_VENERER
                    },
                    AltSets = new List<string>
                    {

                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.WANDERERS_TROUPE, ArtNamesData.GILDED_DREAMS, ArtNamesData.FLOWER_OF_PARADISE_LOST, ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.DESERT_PAVILION_CHRONICLE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.ELEMENTAL_MASTERY, StatNamesData.ENERGY_RECHARGE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ELEMENTAL_MASTERY
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.ANEMO_AMPLIFICATION, StatNamesData.ELEMENTAL_MASTERY
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.ELEMENTAL_MASTERY
                    },
                }, //Кадзуха

                new Character
                {
                    Name = "Джинн",
                    MainSets = new List<string>
                    {
                        ArtNamesData.VIRIDESCENT_VENERER
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.NOBLESSE_OBLIGE
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GLADIATOR_FINALE, ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.DESERT_PAVILION_CHRONICLE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE, StatNamesData.ELEMENTAL_MASTERY
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.ANEMO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                }, //Джинн

                new Character
                {
                    Name = "Венти",
                    MainSets = new List<string>
                    {
                        ArtNamesData.VIRIDESCENT_VENERER
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.NOBLESSE_OBLIGE
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GLADIATOR_FINALE, ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.DESERT_PAVILION_CHRONICLE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE, StatNamesData.ELEMENTAL_MASTERY
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE, StatNamesData.ELEMENTAL_MASTERY
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.ANEMO_AMPLIFICATION, StatNamesData.ELEMENTAL_MASTERY
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG, StatNamesData.ELEMENTAL_MASTERY, StatNamesData.ATK_PERCENT
                    },
                }, //Венти

                new Character
                {
                    Name = "Сяо",
                    MainSets = new List<string>
                    {
                        ArtNamesData.VERMILLION_HEREAFTER
                    },
                    AltSets = new List<string>
                    {

                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GLADIATOR_FINALE, ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.DESERT_PAVILION_CHRONICLE, ArtNamesData.VIRIDESCENT_VENERER
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.ANEMO_AMPLIFICATION, StatNamesData.ATK_PERCENT
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                }, //Сяо

                new Character
                {
                    Name = "Странник",
                    MainSets = new List<string>
                    {
                        ArtNamesData.DESERT_PAVILION_CHRONICLE
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.VIRIDESCENT_VENERER
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GLADIATOR_FINALE, ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.VIRIDESCENT_VENERER
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ELEMENTAL_MASTERY
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.ANEMO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                }, //Странник

                new Character
                {
                    Name = "Хэйдзо",
                    MainSets = new List<string>
                    {
                        ArtNamesData.VIRIDESCENT_VENERER
                    },
                    AltSets = new List<string>
                    {

                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GLADIATOR_FINALE, ArtNamesData.DESERT_PAVILION_CHRONICLE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.ANEMO_AMPLIFICATION, StatNamesData.ELEMENTAL_MASTERY
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG, StatNamesData.ELEMENTAL_MASTERY
                    },
                }, //Хэйдзо

                new Character
                {
                    Name = "Фарузан",
                    MainSets = new List<string>
                    {
                        ArtNamesData.VIRIDESCENT_VENERER, ArtNamesData.NOBLESSE_OBLIGE
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.TENACITY_OF_THE_MILLELITH
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GLADIATOR_FINALE, ArtNamesData.DESERT_PAVILION_CHRONICLE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.ENERGY_RECHARGE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.CRIT_DMG
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.ANEMO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                }, //Фарузан

                new Character
                {
                    Name = "Тарталья",
                    MainSets = new List<string>
                    {
                        ArtNamesData.HEART_OF_DEPTH, ArtNamesData.NYMPHS_DREAM
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.GLADIATOR_FINALE
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.NOBLESSE_OBLIGE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ENERGY_RECHARGE
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.HYDRO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                }, //Тарталья

                new Character
                {
                    Name = "Мона",
                    MainSets = new List<string>
                    {
                        ArtNamesData.NOBLESSE_OBLIGE
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.EMBLEM_OF_SEVERED_FATE
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.GLADIATOR_FINALE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.HEART_OF_DEPTH, ArtNamesData.NYMPHS_DREAM
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.HYDRO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                }, //Мона

                new Character
                {
                    Name = "Нилу",
                    MainSets = new List<string>
                    {
                        ArtNamesData.TENACITY_OF_THE_MILLELITH
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.NOBLESSE_OBLIGE, ArtNamesData.HEART_OF_DEPTH, ArtNamesData.GILDED_DREAMS, ArtNamesData.FLOWER_OF_PARADISE_LOST, ArtNamesData.NYMPHS_DREAM,
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.VOURUKASHAS_GLOW
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.ENERGY_RECHARGE, StatNamesData.ELEMENTAL_MASTERY
                    },
                    GoodStats = new List<string>
                    {

                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT
                    },
                }, //Нилу

                new Character
                {
                    Name = "Кандакия",
                    MainSets = new List<string>
                    {
                        ArtNamesData.NOBLESSE_OBLIGE, ArtNamesData.EMBLEM_OF_SEVERED_FATE
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.GLADIATOR_FINALE, ArtNamesData.HEART_OF_DEPTH, ArtNamesData.VOURUKASHAS_GLOW
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.NYMPHS_DREAM
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT
                    },
                }, //Кандакия

                new Character
                {
                    Name = "Янь Фэй",
                    MainSets = new List<string>
                    {
                        ArtNamesData.CRIMSON_WITCH_OF_FLAMES
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.WANDERERS_TROUPE, ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.GILDED_DREAMS
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GILDED_DREAMS, ArtNamesData.FLOWER_OF_PARADISE_LOST, ArtNamesData.GLADIATOR_FINALE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ENERGY_RECHARGE, StatNamesData.HP_PERCENT
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.PYRO_AMPLIFICATION, StatNamesData.ATK_PERCENT
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                }, //Янь Фэй

                new Character
                {
                    Name = "Кли",
                    MainSets = new List<string>
                    {
                        ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.CRIMSON_WITCH_OF_FLAMES
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.GILDED_DREAMS
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.WANDERERS_TROUPE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GILDED_DREAMS, ArtNamesData.FLOWER_OF_PARADISE_LOST, ArtNamesData.GLADIATOR_FINALE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ENERGY_RECHARGE
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.PYRO_AMPLIFICATION, StatNamesData.ATK_PERCENT
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                }, //Кли

                new Character
                {
                    Name = "Сян Лин",
                    MainSets = new List<string>
                    {
                        ArtNamesData.EMBLEM_OF_SEVERED_FATE
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.CRIMSON_WITCH_OF_FLAMES, ArtNamesData.GILDED_DREAMS
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.WANDERERS_TROUPE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GILDED_DREAMS, ArtNamesData.FLOWER_OF_PARADISE_LOST, ArtNamesData.GLADIATOR_FINALE, ArtNamesData.NOBLESSE_OBLIGE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ENERGY_RECHARGE, StatNamesData.ATK_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ELEMENTAL_MASTERY, StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.PYRO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                }, //Сян Лин

                new Character
                {
                    Name = "Эмбер",
                    MainSets = new List<string>
                    {
                        ArtNamesData.NOBLESSE_OBLIGE
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.CRIMSON_WITCH_OF_FLAMES, ArtNamesData.WANDERERS_TROUPE
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GILDED_DREAMS, ArtNamesData.FLOWER_OF_PARADISE_LOST, ArtNamesData.GLADIATOR_FINALE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ENERGY_RECHARGE, StatNamesData.ATK_PERCENT
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.PYRO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                }, //Эмбер

                new Character
                {
                    Name = "Синь Янь",
                    MainSets = new List<string>
                    {
                        ArtNamesData.TENACITY_OF_THE_MILLELITH
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.NOBLESSE_OBLIGE
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.CRIMSON_WITCH_OF_FLAMES, ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GLADIATOR_FINALE, ArtNamesData.PALE_FLAME, ArtNamesData.BLOODSTAINED_CHIVALRY
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.ATK_PERCENT
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ENERGY_RECHARGE, StatNamesData.DEF_PERCENT
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE, StatNamesData.DEF_PERCENT
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.PYRO_AMPLIFICATION, StatNamesData.DEF_PERCENT, StatNamesData.PHYS_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.DEF_PERCENT
                    },
                }, //Синь Янь

                new Character
                {
                    Name = "Юнь Цзинь",
                    MainSets = new List<string>
                    {
                        ArtNamesData.HUSK_OF_OPULENT_DREAMS
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.NOBLESSE_OBLIGE
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.ARCHAIC_PETRA, ArtNamesData.EMBLEM_OF_SEVERED_FATE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.DEF_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.DEF_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.GEO_AMPLIFICATION, StatNamesData.DEF_PERCENT
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.DEF_PERCENT
                    },
                }, //Юнь Цзинь

                new Character
                {
                    Name = "Тома",
                    MainSets = new List<string>
                    {
                        ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.GILDED_DREAMS
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.FLOWER_OF_PARADISE_LOST
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.TENACITY_OF_THE_MILLELITH
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.ENERGY_RECHARGE, StatNamesData.HP_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.CRIT_RATE
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ELEMENTAL_MASTERY, StatNamesData.ENERGY_RECHARGE, StatNamesData.HP_PERCENT
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.PYRO_AMPLIFICATION, StatNamesData.HP_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.ELEMENTAL_MASTERY, StatNamesData.CRIT_RATE
                    },
                }, //Тома

                new Character
                {
                    Name = "Коллеи",
                    MainSets = new List<string>
                    {
                        ArtNamesData.DEEPWOOD_MEMORIES
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.NOBLESSE_OBLIGE, ArtNamesData.EMBLEM_OF_SEVERED_FATE
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.WANDERERS_TROUPE, ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GILDED_DREAMS, ArtNamesData.FLOWER_OF_PARADISE_LOST, ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.NOBLESSE_OBLIGE, ArtNamesData.GLADIATOR_FINALE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ENERGY_RECHARGE, StatNamesData.ELEMENTAL_MASTERY
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ELEMENTAL_MASTERY, StatNamesData.ENERGY_RECHARGE, StatNamesData.ATK_PERCENT
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.DENDRO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                }, //Коллеи

                new Character
                {
                    Name = "Нахида",
                    MainSets = new List<string>
                    {
                        ArtNamesData.DEEPWOOD_MEMORIES, ArtNamesData.GILDED_DREAMS
                    },
                    AltSets = new List<string>
                    {

                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.WANDERERS_TROUPE, ArtNamesData.FLOWER_OF_PARADISE_LOST
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ELEMENTAL_MASTERY
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ELEMENTAL_MASTERY
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.DENDRO_AMPLIFICATION, StatNamesData.ELEMENTAL_MASTERY
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE, StatNamesData.ELEMENTAL_MASTERY
                    },
                }, //Нахида

                new Character
                {
                    Name = "Тигнари",
                    MainSets = new List<string>
                    {
                        ArtNamesData.WANDERERS_TROUPE, ArtNamesData.DEEPWOOD_MEMORIES
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.GILDED_DREAMS
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.WANDERERS_TROUPE, ArtNamesData.FLOWER_OF_PARADISE_LOST, ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GLADIATOR_FINALE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ELEMENTAL_MASTERY, StatNamesData.ATK_PERCENT
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ELEMENTAL_MASTERY, StatNamesData.ATK_PERCENT
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.DENDRO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                }, //Тигнари

                new Character
                {
                    Name = "Яо Яо",
                    MainSets = new List<string>
                    {
                        ArtNamesData.DEEPWOOD_MEMORIES
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.TENACITY_OF_THE_MILLELITH, ArtNamesData.VOURUKASHAS_GLOW
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.MAIDEN_BELOVED
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.ENERGY_RECHARGE, StatNamesData.HP_PERCENT
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.ELEMENTAL_MASTERY, StatNamesData.CRIT_DMG
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ELEMENTAL_MASTERY, StatNamesData.ENERGY_RECHARGE, StatNamesData.HP_PERCENT
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.DENDRO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.HP_PERCENT
                    },
                }, //Яо Яо

                new Character
                {
                    Name = "Рэйзор",
                    MainSets = new List<string>
                    {
                        ArtNamesData.PALE_FLAME
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.GLADIATOR_FINALE
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.NOBLESSE_OBLIGE, ArtNamesData.BLOODSTAINED_CHIVALRY
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ENERGY_RECHARGE, StatNamesData.ATK_PERCENT
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.PHYS_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
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
                        ArtNamesData.GILDED_DREAMS, ArtNamesData.THUNDERING_FURY, ArtNamesData.TENACITY_OF_THE_MILLELITH
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GLADIATOR_FINALE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ENERGY_RECHARGE
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.ELECTRO_AMPLIFICATION, StatNamesData.ATK_PERCENT
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                }, //Фишль

                new Character
                {
                    Name = "Кэ Цин",
                    MainSets = new List<string>
                    {
                        ArtNamesData.THUNDERING_FURY
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.THUNDER­SOOTHER
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GLADIATOR_FINALE, ArtNamesData.NOBLESSE_OBLIGE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.ELECTRO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                }, //Кэ Цин

                new Character
                {
                    Name = "Лиза",
                    MainSets = new List<string>
                    {
                        ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.GILDED_DREAMS
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.NOBLESSE_OBLIGE
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.THUNDERING_FURY, ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GLADIATOR_FINALE, ArtNamesData.WANDERERS_TROUPE, ArtNamesData.FLOWER_OF_PARADISE_LOST
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ELEMENTAL_MASTERY, StatNamesData.ENERGY_RECHARGE
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ELEMENTAL_MASTERY, StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.ELECTRO_AMPLIFICATION, StatNamesData.ELEMENTAL_MASTERY
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG, StatNamesData.ELEMENTAL_MASTERY
                    },
                }, //Лиза

                new Character
                {
                    Name = "Сара",
                    MainSets = new List<string>
                    {
                        ArtNamesData.NOBLESSE_OBLIGE
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.EMBLEM_OF_SEVERED_FATE
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.THUNDERING_FURY, ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GLADIATOR_FINALE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.ELECTRO_AMPLIFICATION, StatNamesData.ELEMENTAL_MASTERY
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                }, //Сара

                new Character
                {
                    Name = "Синобу",
                    MainSets = new List<string>
                    {
                        ArtNamesData.TENACITY_OF_THE_MILLELITH
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.DEEPWOOD_MEMORIES, ArtNamesData.GILDED_DREAMS, ArtNamesData.FLOWER_OF_PARADISE_LOST
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.WANDERERS_TROUPE, ArtNamesData.FLOWER_OF_PARADISE_LOST, ArtNamesData.VOURUKASHAS_GLOW
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.ENERGY_RECHARGE
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.ATK_PERCENT
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE, StatNamesData.ELEMENTAL_MASTERY
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.ELECTRO_AMPLIFICATION, StatNamesData.ELEMENTAL_MASTERY
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.HEALING_BONUS, StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG, StatNamesData.ELEMENTAL_MASTERY
                    },
                }, //Синобу

                new Character
                {
                    Name = "Сайно",
                    MainSets = new List<string>
                    {
                        ArtNamesData.GILDED_DREAMS
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.THUNDERING_FURY, ArtNamesData.THUNDER­SOOTHER
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.WANDERERS_TROUPE, ArtNamesData.FLOWER_OF_PARADISE_LOST
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ELEMENTAL_MASTERY, StatNamesData.ENERGY_RECHARGE
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.ELECTRO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                }, //Сайно

                new Character
                {
                    Name = "Дори",
                    MainSets = new List<string>
                    {
                        ArtNamesData.NOBLESSE_OBLIGE, ArtNamesData.OCEAN_HUED_CLAM
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.FLOWER_OF_PARADISE_LOST
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.TENACITY_OF_THE_MILLELITH, ArtNamesData.VOURUKASHAS_GLOW
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.ATK_PERCENT
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.HEALING_BONUS
                    },
                }, //Дори

                new Character
                {
                    Name = "Дэхья",
                    MainSets = new List<string>
                    {
                        ArtNamesData.CRIMSON_WITCH_OF_FLAMES, ArtNamesData.VOURUKASHAS_GLOW
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.OCEAN_HUED_CLAM, ArtNamesData.GILDED_DREAMS, ArtNamesData.GLADIATOR_FINALE, ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.TENACITY_OF_THE_MILLELITH, ArtNamesData.LAVAWALKER
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.WANDERERS_TROUPE, ArtNamesData.NOBLESSE_OBLIGE, ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GILDED_DREAMS, ArtNamesData.FLOWER_OF_PARADISE_LOST
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ENERGY_RECHARGE, StatNamesData.HP_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.ELEMENTAL_MASTERY
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.PYRO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                }, //Дэхья

                new Character
                {
                    Name = "Мика",
                    MainSets = new List<string>
                    {
                        ArtNamesData.NOBLESSE_OBLIGE
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.OCEAN_HUED_CLAM
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.TENACITY_OF_THE_MILLELITH, ArtNamesData.VOURUKASHAS_GLOW
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.ENERGY_RECHARGE, StatNamesData.HP_PERCENT
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT
                    },
                }, //Мика

                new Character
                {
                    Name = "Бай Чжу",
                    MainSets = new List<string>
                    {
                        ArtNamesData.DEEPWOOD_MEMORIES
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.NOBLESSE_OBLIGE
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.EMBLEM_OF_SEVERED_FATE, ArtNamesData.TENACITY_OF_THE_MILLELITH, ArtNamesData.FLOWER_OF_PARADISE_LOST, ArtNamesData.VOURUKASHAS_GLOW
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.ENERGY_RECHARGE, StatNamesData.ELEMENTAL_MASTERY
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.CRIT_RATE
                    },
                    OkStats = new List<string>
                    {
                        StatNamesData.CRIT_DMG
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.HP_PERCENT
                    },
                }, //Бай Чжу

                new Character
                {
                    Name = "Кавех",
                    MainSets = new List<string>
                    {
                        ArtNamesData.DEEPWOOD_MEMORIES, ArtNamesData.FLOWER_OF_PARADISE_LOST
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.GILDED_DREAMS, ArtNamesData.GLADIATOR_FINALE
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.SHIMENAWAS_REMINISCENCE, ArtNamesData.WANDERERS_TROUPE, ArtNamesData.FLOWER_OF_PARADISE_LOST
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.ELEMENTAL_MASTERY, StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    OkStats = new List<string>
                    {

                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ELEMENTAL_MASTERY, StatNamesData.ATK_PERCENT
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.DENDRO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                }, //Кавех

                new Character
                {
                    Name = "Элой",
                    MainSets = new List<string>
                    {
                        ArtNamesData.SHIMENAWAS_REMINISCENCE
                    },
                    AltSets = new List<string>
                    {
                        ArtNamesData.BLIZZARD_STRAYER
                    },
                    SubSets = new List<string>
                    {
                        ArtNamesData.WANDERERS_TROUPE, ArtNamesData.NOBLESSE_OBLIGE, ArtNamesData.VERMILLION_HEREAFTER, ArtNamesData.ECHOES_OF_AN_OFFERING, ArtNamesData.GILDED_DREAMS, ArtNamesData.FLOWER_OF_PARADISE_LOST, ArtNamesData.GLADIATOR_FINALE
                    },
                    PerfectStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                    GoodStats = new List<string>
                    {
                        StatNamesData.ELEMENTAL_MASTERY, StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    OkStats = new List<string>
                    {
                        
                    },
                    ClockStats = new List<string>
                    {
                        StatNamesData.ATK_PERCENT, StatNamesData.ENERGY_RECHARGE
                    },
                    GobletStats = new List<string>
                    {
                        StatNamesData.CRYO_AMPLIFICATION
                    },
                    CrownStats = new List<string>
                    {
                        StatNamesData.CRIT_RATE, StatNamesData.CRIT_DMG
                    },
                }, //Элой
            };
        }
    }
}
