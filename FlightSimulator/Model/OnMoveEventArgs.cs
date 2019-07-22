using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator
{
    public class OnMoveEventArgs
    {
        public int Velocity { get; }
        public int Height { get; }
        public bool InFlight { get; }

        public OnMoveEventArgs(int velocity, int height, bool inFlight)
        {
            Velocity = velocity;
            Height = height;
            InFlight = inFlight;
        }
    }
}
