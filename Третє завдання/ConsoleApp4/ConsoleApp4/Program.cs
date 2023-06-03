using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2._2
{
    internal class SailingVessel : Vessel
    {
        public override void Move()
        {
            Console.WriteLine("moving");
        }

        public override void PrepareToMovement()
        {
            Console.WriteLine("preparing to move");
        }
    }
}
