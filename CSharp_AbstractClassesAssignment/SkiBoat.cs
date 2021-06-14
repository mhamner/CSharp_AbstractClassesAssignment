using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_AbstractClassesAssignment
{
    public class SkiBoat : Ship
    {
        public override void Move()
        {
            Console.WriteLine("Starting onboard motor!");
            base.Move();
        }
        public override void Stop()
        {
            Console.WriteLine("Stopping onboard motor!");
            base.Stop();
        }
        public override void BlowHorn()
        {
            Console.WriteLine("Beep!");
        }
    }
}
