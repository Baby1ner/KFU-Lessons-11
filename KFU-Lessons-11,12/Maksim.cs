using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU_Lessons_11_12
{
    internal class Maksim : Person
    {
        /// <summary>
        /// Событие - на ютубе вышло новое видео с котиками
        /// </summary>
        internal event EventHandler NewCatVideo;

        internal Maksim(string name, string surname, string tracked_event)
        {
            this.name = name;
            this.surname = surname;
            this.tracked_event = tracked_event;
        }

        internal override void CreateEvent()
        {
            if (NewCatVideo != null)
            {
                NewCatVideo(this, new EventArgs());
            }
        }
    }
}
