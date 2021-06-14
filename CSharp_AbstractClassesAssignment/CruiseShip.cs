using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_AbstractClassesAssignment
{
    public class CruiseShip : Ship
    {
        public override void Move()
        {
            Console.WriteLine("Starting all 112 engines!");
            base.Move();
        }
        public override void Stop()
        {
            Console.WriteLine("Stopping all 112 engines!");
            base.Stop();
        }
        public override void BlowHorn()
        {
            Console.WriteLine("WAAAAAAAAOOOOOOO!!!!");
        }
    }
}
