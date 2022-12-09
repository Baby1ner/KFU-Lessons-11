using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU_Lessons_11_12
{
    public class Student
    {
        public string Name { get; set; }
        public bool Loafer { get; set; }
        public int Group { get; set; }
        public int Id { get; set; }
        private static int Idk;
        public Student(string name, int group)
        {
            Idk++;
            Id = Idk;
            Name = name;
            Group = group;
            Loafer = true;
        }
    }
}
