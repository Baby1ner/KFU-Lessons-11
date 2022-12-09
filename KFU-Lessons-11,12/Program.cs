using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using KFU_Lessons_11_12;

namespace KFU_Lessons_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Задание 1");
            List<string> fileLines = File.ReadAllLines(@".\..\..\students.txt").ToList();
            List<Student> students = new List<Student>();
            foreach (var fileLine in fileLines)
            {
                var splitFileLine = fileLine.Split(new[] { " " }, StringSplitOptions.None);
                string name = splitFileLine[0];
                int group = Convert.ToInt32(splitFileLine[1]);
                students.Add(new Student(name, group));
            }

            List<Student> group1 = new List<Student>();
            List<Student> group2 = new List<Student>();
            List<Student> group3 = new List<Student>();
            
            for (int i = 0; i < students.Count; i++)
            {
                switch (students[i].Group)
                {
                    case 1:
                        group1.Add(students[i]);
                        break;
                    case 2:
                        group2.Add(students[i]);
                        break;
                    case 3:
                        group3.Add(students[i]);
                        break;
                } 
            }
            List<List<Student>> groups = new List<List<Student>>() { group1, group2, group3 };
            Event event1 = new Event("Уборка класса", new DateTime(2022, 12, 15), 2, 1);
            event1.Otbor(groups);
            event1.PrintToFile();
            Event event2 = new Event("Поход в лес", new DateTime(2022, 12, 20), 3, 2);
            event2.Otbor(groups);
            event2.PrintToFile();
            Event event3 = new Event("Забрать документы", new DateTime(2022, 12, 17), 3, 1);
            event3.Otbor(groups);
            event3.PrintToFile();
            Event event4 = new Event("Пойти на математику", new DateTime(2022, 12, 17), 3, 3);
            event4.Otbor(groups);
            event4.PrintToFile();
            */

            Console.WriteLine("Задачи 2");
            List<string> events = new List<string> { "фильм где главный герой тупа я", "по улице идет толпа девочек", "татарские треки" };
            Ilya ilya = new Ilya("Илья", "фильм где главный герой тупа я");
            ilya.Sigmafilm += Ilya_NewSigmafilm;
            Halil halil = new Halil("Халиль", "татарские треки");
            halil.TatarSong += Halil_NewTatarSong;
            Kamil kamil = new Kamil("Камиль", "по улице идет толпа девочек");
            kamil.ManyBitches += Kamil_NewManyBitches;
            List<Person> people = new List<Person> { ilya, halil, kamil};

            Console.WriteLine("Есть следующие потенциальные события: ");
            for (byte i = 0; i < events.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {events[i]}");
            }
            Console.WriteLine("\nСоздайте одно из них, написав его название:");
            string event_user = Console.ReadLine().ToLower();

            bool is_mass = false;
            while (!is_mass)
            {
                for (byte i = 0; i < events.Count; i++)
                {
                    if (events[i].Equals(event_user))
                    {
                        is_mass = true;
                    }
                }
                if (!is_mass)
                {
                    Console.WriteLine("Написанного вами события нет в списке, заново укажите событие");
                    event_user = Console.ReadLine();
                }
            }


            int temp = 0;
            for (byte i = 0; i < people.Count; i++)
            {
                if (people[i].tracked_event.Equals(event_user))
                {
                    people[i].CreateEvent(); 
                    temp++;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("Данное событие никто не отслеживает");
            }


        }        


        private static void Ilya_NewSigmafilm(object sender, EventArgs e)
        {
            Console.WriteLine("Илья пошел смотреть очередной сигма фильм со словами, это буквально я ");
        }


        private static void Halil_NewTatarSong(object sender, EventArgs e)
        {
            Console.WriteLine("Халиль пошел жестко флексить под новый трек Салавата Фэхетдинова");
        }

        private static void Kamil_NewManyBitches(object sender, EventArgs e)
        {
            Console.WriteLine("Камиль пошел пикапить дефок");
        }





    }
}