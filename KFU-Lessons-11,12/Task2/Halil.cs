using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU_Lessons_11_12
{
    internal class Halil : Person
    {
        internal event EventHandler TatarSong;

        internal Halil(string name, string tracked_event)
        {
            this.name = name;
            this.tracked_event = tracked_event;
        }

        internal override void CreateEvent()
        {
            if (TatarSong != null)
            {
                TatarSong(this, new EventArgs());
            }
        }
    }
}
