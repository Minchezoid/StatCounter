using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatCounter
{
    public class Character
    {
        public string[] MainSets { get; set; }
        public string[] AltSets { get; set; }
        public string[] SubSets { get; set; }
        public string[] PerfectStats { get; set; }
        public string[] GoodStats { get; set; }
        public string[] OkStats { get; set; }
        public string[][] MainStats { get; set; }

        public double first { get; set; }
        public double second { get; set; }
        public double third { get; set; }

        public string Name { get; set; }

        public Character(string name, string[] mainSets, string[] altSets, string[] subSets, string[] perfectStats, string[] goodStats, string[] okStats, string[][] mainStats)
        {
            Name = name;
            MainSets = mainSets;
            AltSets = altSets;
            SubSets = subSets;
            PerfectStats = perfectStats;
            GoodStats = goodStats;
            OkStats = okStats;
            MainStats = mainStats;
        }
        public string Checker(Artefact a)
        {

            bool mainstatus = false;

            foreach (string stat in PerfectStats)
                if (a.MainStat == stat)
                {
                    mainstatus = true;
                    break;
                }
                else
                    continue;

            bool status = false;

            if (a.Piece == "Часы")
            {
                foreach (string s in MainStats[0])
                {
                    if (s == a.MainStat)
                    {
                        status = true;
                        break;
                    }
                }

                if (status == false)
                    return "-";
            }    
            else if (a.Piece == "Кубок")
            {
                foreach (string s in MainStats[1])
                {
                    if (s == a.MainStat)
                    {
                        status = true;
                        break;
                    }
                }

                if (status == false)
                    return "-";
            }
            else if (a.Piece == "Шапка")
            {
                foreach (string s in MainStats[2])
                {
                    if (s == a.MainStat)
                    {
                        status = true;
                        break;
                    }
                }

                if (status == false)
                    return "-";
            }

            foreach (string s in PerfectStats)
            {
                if (s == "Крит. урон %")
                    first += a.CritDmg;
                else if (s == "Шанс крит. попадания %")
                    first += a.CritRate;
                else if (s == "Сила атаки %")
                    first += a.Atk;
                else if (s == "HP %")
                    first += a.Hp;
                else if (s == "Защита %")
                    first += a.Def;
                else if (s == "Восст. энергии %")
                    first += a.Er;
                else if (s == "Мастерство стихий")
                    first += a.Em;
            }

            foreach (string s in GoodStats)
            {
                if (s == "Крит. урон %")
                    second += a.CritDmg;
                else if (s == "Шанс крит. попадания %")
                    second += a.CritRate;
                else if (s == "Сила атаки %")
                    second += a.Atk;
                else if (s == "HP %")
                    second += a.Hp;
                else if (s == "Защита %")
                    second += a.Def;
                else if (s == "Восст. энергии %")
                    second += a.Er;
                else if (s == "Мастерство стихий")
                    second += a.Em;
            }

            foreach (string s in OkStats)
            {
                if (s == "Крит. урон %")
                    third += a.CritDmg;
                else if (s == "Шанс крит. попадания %")
                    third += a.CritRate;
                else if (s == "Сила атаки %")
                    third += a.Atk;
                else if (s == "HP %")
                    third += a.Hp;
                else if (s == "Защита %")
                    third += a.Def;
                else if (s == "Восст. энергии %")
                    third += a.Er;
                else if (s == "Мастерство стихий")
                    third += a.Em;
            }
            //Третий по полезности стат переливаем во второй, деля его на 2
            second += (third / 2);

            //Считаем главные статы и добавляем чуточку во второй если у нас заминОЧКА
            if (first - Math.Truncate(first) > 0.8)
                first = Math.Truncate(first) + 1;
            else if (first - Math.Truncate(first) > 0.4)
            {
                first = Math.Truncate(first);
                second += 1;
            }  
            else
            {
                second += (first - Math.Truncate(first)) / 2;
                first = Math.Truncate(first);
            }

            //Округляем второй по полезности стат
            if (second - Math.Truncate(second) > 0.8)
                second = Math.Truncate(second) + 1;
            else
                second = Math.Truncate(second);


            //Выведем это говнище в виде оценки чтобы челам понятно было

            if (a.Piece == "Цветок" | a.Piece == "Перо") //Оценка 1
            {
                if (first < 4)
                    return "-";
                else if (first == 4)
                    if (second >= 2)
                        return "Хорошо";
                    else
                        return "-";
                else if (first == 5)
                    if (second >= 2)
                        return "Отлично";
                    else
                        return "Хорошо";
                else if (first == 6)
                    if (second >= 2)
                        return "Идеально";
                    else
                        return "Отлично";
                else
                    return "Идеально";
            }
            else if (a.Piece == "Часы")
            {
                if (mainstatus == true) //Оценка 2
                {
                    if (second / 2 >= 1)
                    {
                        first += (second / 2) - ((second / 2) - Math.Truncate(second / 2));
                        second = second - Math.Truncate(second / 2) * 2;
                    }
                    if (first < 4)
                        return "-";
                    else if (first == 4)
                        if (second >= 1)
                            return "Хорошо";
                        else
                            return "-";
                    else if (first == 5)
                        if (second >= 1)
                            return "Отлично";
                        else
                            return "-";
                    else if (first == 6)
                        if (second >= 1)
                            return "Идеально";
                        else
                            return "Отлично";
                    else
                        return "Идеально";
                }
                else //Оценка 2 (+)
                {
                    if (first < 3)
                        return "-";
                    else if (first == 3)
                        if (second >= 3)
                            return "Хорошо";
                        else
                            return "-";
                    else if (first == 4)
                        if (second >= 3)
                            return "Отлично";
                        else if (second >= 1)
                            return "Хорошо";
                        else
                            return "-";
                    else if (first == 5)
                        if (second >= 3)
                            return "Идеально";
                        else if (second >= 1)
                            return "Отлично";
                        else
                            return "Хорошо";
                    else if (first == 6)
                        if (second >= 1)
                            return "Идеально";
                        else
                            return "Отлично";
                    else
                        return "Идеально";
                }
            }
            else if (a.Piece == "Кубок")
            {
                if (mainstatus == true) //Оценка 3
                {
                    if (second / 2 >= 1)
                    {
                        first += (second / 2) - ((second / 2) - Math.Truncate(second / 2));
                        second = second - Math.Truncate(second / 2) * 2;
                    }
                    if (first < 4)
                        return "-";
                    else if (first == 4)
                            return "Хорошо";
                    else if (first == 5)
                            return "Отлично";
                    else if (first == 6)
                            return "Идеально";
                    else
                        return "Идеально";
                }
                else //Оценка 3 (+)
                {
                    if (first < 3)
                        return "-";
                    else if (first == 3)
                        if (second >= 2)
                            return "Хорошо";
                        else
                            return "-";
                    else if (first == 4)
                        if (second >= 2)
                            return "Отлично";
                        else
                            return "Хорошо";
                    else if (first == 5)
                        if (second >= 2)
                            return "Идеально";
                        else
                            return "Отлично";
                    else
                        return "Идеально";
                }
                
            }
            else if (a.Piece == "Шапка")
            {
                if (mainstatus == true) //Оценка 4
                {
                    if (second / 2 >= 1)
                    {
                        first += (second / 2) - ((second / 2) - Math.Truncate(second / 2));
                        second = second - Math.Truncate(second / 2)*2;
                    }
                    if (first < 3)
                        return "-";
                    else if (first == 3)
                        if (second >= 1)
                            return "Хорошо";
                        else
                            return "-";
                    else if (first == 4)
                        if (second >= 1)
                            return "Отлично";
                        else
                            return "Хорошо";
                    else if (first == 5)
                        if (second >= 1)
                            return "Идеально";
                        else
                            return "Отлично";
                    else
                        return "Идеально";
                }
                else //Оценка 4 (+)
                {
                    if (first < 2)
                        return "-";
                    else if (first == 2)
                        if (second >= 3)
                            return "Хорошо";
                        else
                            return "-";
                    else if (first == 3)
                        if (second >= 3)
                            return "Отлично";
                        else if (second >= 1)
                            return "Хорошо";
                        else
                            return "-";
                    else if (first == 4)
                        if (second >= 3)
                            return "Идеально";
                        else if (second >= 1)
                            return "Отлично";
                        else
                            return "Хорошо";
                    else if (first == 5)
                        if (second >= 1)
                            return "Идеально";
                        else
                            return "Отлично";
                    else
                        return "Идеально";
                }
            }
            else
                return "Выбери кусок!";
        }
    }
}
