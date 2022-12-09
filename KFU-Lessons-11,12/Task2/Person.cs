using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU_Lessons_11_12
{
    internal abstract class Person
    {
        internal string name;
        internal string tracked_event;
        internal abstract void CreateEvent();
    }
}
