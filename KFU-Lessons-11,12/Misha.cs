using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU_Lessons_11_12
{
    internal class Misha : Person
    {
        internal event EventHandler MovieCameOut;

        internal Misha(string name, string surname, string tracked_event)
        {
            this.name = name;
            this.surname = surname;
            this.tracked_event = tracked_event;
        }

        internal override void CreateEvent()
        {
            if (MovieCameOut != null)
            {
                MovieCameOut(this, new EventArgs());
            }
        }
    }
}
