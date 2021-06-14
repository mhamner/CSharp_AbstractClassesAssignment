using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_AbstractClassesAssignment
{
    public abstract class Ship
    {
        public virtual void Move()
        {
            Console.WriteLine("The ship has started to move!");
        }
        public virtual void Stop()
        {
            Console.WriteLine("The ship has stopped.");
        }
        public abstract void BlowHorn();
    }
}
