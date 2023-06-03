using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SailingVessel sailingVessel = new SailingVessel();
            sailingVessel.PrepareToMovement();
            sailingVessel.Move();
            Submarine submarine = new Submarine();
            submarine.PlayCounterStriceInACabine();
            submarine.PrepareToMovement();
            submarine.Move();

        }
    }
}
