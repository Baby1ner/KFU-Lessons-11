using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU_Lessons_11_12
{
    internal class Ilya : Person
    {
        internal event EventHandler Sigmafilm;

        internal Ilya(string name, string tracked_event)
        {
            this.name = name;
            this.tracked_event = tracked_event;
        }

        internal override void CreateEvent()
        {
            if (Sigmafilm != null)
            {
                Sigmafilm(this, new EventArgs());
            }
        }
    }
}
