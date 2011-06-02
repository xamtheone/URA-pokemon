using System;
using System.Collections.Generic;
using System.Text;

namespace URA_Pokemon
{
    public class PileEffortPoint : Stack<EffortPoints>
    {
        public EffortPoints this[int i]
        {
            get
            {
                return this.ToArray()[i];
            }
            
        }

        public void Add(EffortPoints ep)
        {
            this.Push(ep);
        }
    }

    public class PileEvolution : Stack<Evolution>
    {
        public Evolution this[int i]
        {
            get
            {
                return this.ToArray()[i];
            }

        }
        public void Add(Evolution e)
        {
            this.Push(e);
        }
    }
}
