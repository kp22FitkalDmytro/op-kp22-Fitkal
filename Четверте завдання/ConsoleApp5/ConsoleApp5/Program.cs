using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2._3
{
    internal class Submarine : IVessel
    {
        public void Move()
        {
            Console.WriteLine("moving");
        }

        public void PrepareToMovement()
        {
            Console.WriteLine("to move");
        }
        public void PlayCounterStriceInACabine()
        {
            Console.WriteLine("You can not do this");
        }
    }
}
