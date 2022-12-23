using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much_11_Home
{
    class Creator
    {
        private Creator()
        { }
        public static Doma Create()
        {
            Doma built = new Doma();
            buildings[built.Id] = built;
            return built;
        }
        public static void Delete(int number)
        {
            buildings.Remove(buildings[number]);
        }
        private static Hashtable buildings = new Hashtable();
    }
}
