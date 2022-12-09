using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU_Lessons_11_12
{
    public class Event
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Callgroup { get; set; }
        public int CallPeople { get; set; }

        public List<Student> students { get; set; }
        public Event(string name, DateTime date, int callgroup, int callPeople)
        {
            Name = name;
            Date = date;
            Callgroup = callgroup;
            CallPeople = callPeople;
        }

        public void Otbor(List<List<Student>> groups)
        {
            int group = Callgroup;
            List<int> randgroup = new List<int>();
            List<Student> fr = new List<Student>();
            if (group != groups.Count)
            {
                while (group > 0)
                {
                    int r = new Random().Next(0, groups.Count - 1);
                    if (!randgroup.Contains(r))
                    {
                        randgroup.Add(r);
                        group--;
                    }
                }
            }
            else
            {
                for (int i = 0; i < groups.Count; i++)
                    randgroup.Add(i);
            }




            for (int i = 0; i < groups.Count; i++)
            {
                int people = CallPeople;
                if (randgroup.Contains(i))
                {

                    for (int j = 0; j < groups[i].Count; j++)
                    {
                        if (groups[i][j].Loafer && people > 0)
                        {
                            fr.Add(groups[i][j]);

                            groups[i][j].Loafer = false;
                            people--;
                        }
                    }
                    if (people > 0)
                    {
                        for (int j = 0; j < groups[i].Count; j++)
                        {
                            if (!groups[i][j].Loafer && people > 0)
                            {
                                fr.Add(groups[i][j]);
                                groups[i][j].Loafer = false;
                                people--;

                            }
                        }
                    }

                }
            }
            students = fr;
        }



        public void PrintToFile()
        {
            StreamWriter sr = new StreamWriter(@".\..\..\Events.txt");
            sr.WriteLine($"{Name} разыгрывается {Date} числа\nВ которой буду участвовать студенты:");
            for (int i = 0; i < students.Count; i++)
                sr.WriteLine($"Участвует {students[i].Name} из {students[i].Id} группы");
            sr.Close();
        }

    }
}
