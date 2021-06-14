using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_AbstractClassesAssignment
{
    public class SailBoat : Ship
    {
        public override void Move()
        {
            Console.WriteLine("Raising sails!");
            base.Move();
        }
        public override void Stop()
        {
            Console.WriteLine("Lowering sails!");
            base.Stop();
        }
        public override void BlowHorn()
        {
            Console.WriteLine("Toot!");
        }
    }
}
