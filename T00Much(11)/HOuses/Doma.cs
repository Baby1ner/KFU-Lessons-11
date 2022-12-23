using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much_11_Home
{
    internal class Doma
    {

        public int Id;
        private double height;
        private int floor;
        private int flat;
        private int porch;
        private static int Idk = 1;


        public Doma()
        {
            Id = Idk;
            Idk++;
        }

        public void dom()
        {
            Id = Idk;
            Idk++;
            Console.WriteLine("Введите высоту здания");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество этажей");
            floor = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество квартир");
            flat = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество подъездов");
            porch = int.Parse(Console.ReadLine());
        }


        public void heightfloor()
        {
            Console.WriteLine($"Высота этажа {height / floor} метров");
        }
        private int flatinporch()
        {
            return flat / porch;
        }
        private int flatinfloor()
        {
            return flatinporch() / floor;
        }
        public void flatinf()
        {
            Console.WriteLine($"В подъезде: {flatinporch()} квартир, а на этаже {flatinfloor()} квартиры");
        }

        public void Print()
        {
            Console.WriteLine($"Номер: {Id}, Высота: {height}, Этажность: {floor},Количество квартир: {flat}, Количество подъездов: {porch} ");

        }


    }
}
