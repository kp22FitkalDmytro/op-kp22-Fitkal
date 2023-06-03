using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2._3
{
    internal class SailingVessel : IVessel
    {
        public void Move()
        {
            Console.WriteLine("moving");
        }

        public void PrepareToMovement()
        {
            Console.WriteLine("prepearing to move");
        }
    }
}