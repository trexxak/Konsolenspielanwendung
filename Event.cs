using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsolenspiel
{
    internal class Event
    {
        private int eventId;
        public Event(int id)
        {
            this.eventId = id;
        }

        public void activate()
        {
            switch (eventId)
            {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    break;
            }
        }
    }
}
