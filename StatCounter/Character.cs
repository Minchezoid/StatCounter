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
        public List<string> MainSets { get; set; }
        public List<string> AltSets { get; set; }
        public List<string> SubSets { get; set; }
        public List<string> PerfectStats { get; set; }
        public List<string> GoodStats { get; set; }
        public List<string> OkStats { get; set; }
        //public string[][] MainStats { get; set; }
        public List<string> ClockStats { get; set; }
        public List<string> GobletStats { get; set; }
        public List<string> CrownStats { get; set; }


        public double First { get; set; }
        public double Second { get; set; }
        public double Third { get; set; }

        public string Name { get; set; }

        //public Character(string name, List<string> mainSets, List<string> altSets, List<string> subSets, List<string> perfectStats, List<string> goodStats, List<string> okStats, string[][] mainStats)
        //{
        //    Name = name;
        //    MainSets = mainSets;
        //    AltSets = altSets;
        //    SubSets = subSets;
        //    PerfectStats = perfectStats;
        //    GoodStats = goodStats;
        //    OkStats = okStats;
        //    MainStats = mainStats;
        //}
        public string Check(Artefact a)
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
                foreach (string s in ClockStats)
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
                foreach (string s in GobletStats)
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
                foreach (string s in CrownStats)
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
                    First += a.CritDmg;
                else if (s == "Шанс крит. попадания %")
                    First += a.CritRate;
                else if (s == "Сила атаки %")
                    First += a.Atk;
                else if (s == "HP %")
                    First += a.Hp;
                else if (s == "Защита %")
                    First += a.Def;
                else if (s == "Восст. энергии %")
                    First += a.Er;
                else if (s == "Мастерство стихий")
                    First += a.Em;
            }

            foreach (string s in GoodStats)
            {
                if (s == "Крит. урон %")
                    Second += a.CritDmg;
                else if (s == "Шанс крит. попадания %")
                    Second += a.CritRate;
                else if (s == "Сила атаки %")
                    Second += a.Atk;
                else if (s == "HP %")
                    Second += a.Hp;
                else if (s == "Защита %")
                    Second += a.Def;
                else if (s == "Восст. энергии %")
                    Second += a.Er;
                else if (s == "Мастерство стихий")
                    Second += a.Em;
            }

            foreach (string s in OkStats)
            {
                if (s == "Крит. урон %")
                    Third += a.CritDmg;
                else if (s == "Шанс крит. попадания %")
                    Third += a.CritRate;
                else if (s == "Сила атаки %")
                    Third += a.Atk;
                else if (s == "HP %")
                    Third += a.Hp;
                else if (s == "Защита %")
                    Third += a.Def;
                else if (s == "Восст. энергии %")
                    Third += a.Er;
                else if (s == "Мастерство стихий")
                    Third += a.Em;
            }
            //Третий по полезности стат переливаем во второй, деля его на 2
            Second += (Third / 2);

            //Считаем главные статы и добавляем чуточку во второй если у нас заминОЧКА
            if (First - Math.Truncate(First) > 0.8)
                First = Math.Truncate(First) + 1;
            else if (First - Math.Truncate(First) > 0.4)
            {
                First = Math.Truncate(First);
                Second += 1;
            }  
            else
            {
                Second += (First - Math.Truncate(First)) / 2;
                First = Math.Truncate(First);
            }

            //Округляем второй по полезности стат
            if (Second - Math.Truncate(Second) > 0.8)
                Second = Math.Truncate(Second) + 1;
            else
                Second = Math.Truncate(Second);


            //Выведем это говнище в виде оценки чтобы челам понятно было

            if (a.Piece == "Цветок" | a.Piece == "Перо") //Оценка 1
            {
                if (First < 4)
                    return "-";
                else if (First == 4)
                    if (Second >= 2)
                        return "Хорошо";
                    else
                        return "-";
                else if (First == 5)
                    if (Second >= 2)
                        return "Отлично";
                    else
                        return "Хорошо";
                else if (First == 6)
                    if (Second >= 2)
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
                    if (Second / 2 >= 1)
                    {
                        First += (Second / 2) - ((Second / 2) - Math.Truncate(Second / 2));
                        Second = Second - Math.Truncate(Second / 2) * 2;
                    }
                    if (First < 4)
                        return "-";
                    else if (First == 4)
                        if (Second >= 1)
                            return "Хорошо";
                        else
                            return "-";
                    else if (First == 5)
                        if (Second >= 1)
                            return "Отлично";
                        else
                            return "-";
                    else if (First == 6)
                        if (Second >= 1)
                            return "Идеально";
                        else
                            return "Отлично";
                    else
                        return "Идеально";
                }
                else //Оценка 2 (+)
                {
                    if (First < 3)
                        return "-";
                    else if (First == 3)
                        if (Second >= 3)
                            return "Хорошо";
                        else
                            return "-";
                    else if (First == 4)
                        if (Second >= 3)
                            return "Отлично";
                        else if (Second >= 1)
                            return "Хорошо";
                        else
                            return "-";
                    else if (First == 5)
                        if (Second >= 3)
                            return "Идеально";
                        else if (Second >= 1)
                            return "Отлично";
                        else
                            return "Хорошо";
                    else if (First == 6)
                        if (Second >= 1)
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
                    if (Second / 2 >= 1)
                    {
                        First += (Second / 2) - ((Second / 2) - Math.Truncate(Second / 2));
                        Second = Second - Math.Truncate(Second / 2) * 2;
                    }
                    if (First < 4)
                        return "-";
                    else if (First == 4)
                            return "Хорошо";
                    else if (First == 5)
                            return "Отлично";
                    else if (First == 6)
                            return "Идеально";
                    else
                        return "Идеально";
                }
                else //Оценка 3 (+)
                {
                    if (First < 3)
                        return "-";
                    else if (First == 3)
                        if (Second >= 2)
                            return "Хорошо";
                        else
                            return "-";
                    else if (First == 4)
                        if (Second >= 2)
                            return "Отлично";
                        else
                            return "Хорошо";
                    else if (First == 5)
                        if (Second >= 2)
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
                    if (Second / 2 >= 1)
                    {
                        First += (Second / 2) - ((Second / 2) - Math.Truncate(Second / 2));
                        Second = Second - Math.Truncate(Second / 2)*2;
                    }
                    if (First < 3)
                        return "-";
                    else if (First == 3)
                        if (Second >= 1)
                            return "Хорошо";
                        else
                            return "-";
                    else if (First == 4)
                        if (Second >= 1)
                            return "Отлично";
                        else
                            return "Хорошо";
                    else if (First == 5)
                        if (Second >= 1)
                            return "Идеально";
                        else
                            return "Отлично";
                    else
                        return "Идеально";
                }
                else //Оценка 4 (+)
                {
                    if (First < 2)
                        return "-";
                    else if (First == 2)
                        if (Second >= 3)
                            return "Хорошо";
                        else
                            return "-";
                    else if (First == 3)
                        if (Second >= 3)
                            return "Отлично";
                        else if (Second >= 1)
                            return "Хорошо";
                        else
                            return "-";
                    else if (First == 4)
                        if (Second >= 3)
                            return "Идеально";
                        else if (Second >= 1)
                            return "Отлично";
                        else
                            return "Хорошо";
                    else if (First == 5)
                        if (Second >= 1)
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
