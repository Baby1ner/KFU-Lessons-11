using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU_Lessons_11_12
{
    internal class Kamil : Person
    {
        internal event EventHandler ManyBitches;

        internal Kamil(string name, string tracked_event)
        {
            this.name = name;
            this.tracked_event = tracked_event;
        }

        internal override void CreateEvent()
        {
            if (ManyBitches != null)
            {
                ManyBitches(this, new EventArgs());
            }
        }
    }
}
