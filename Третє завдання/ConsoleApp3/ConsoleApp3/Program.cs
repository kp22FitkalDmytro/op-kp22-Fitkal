using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SailingVessel vessel = new SailingVessel();
            vessel.PrepareToMovement();
            vessel.Move();
            Submarine submarine = new Submarine("whale", 24);

            do
            {
                submarine.PrepareToMovement();
            }
            while (!submarine.IsPrepared);
            do
            {
                submarine.Move();
            }
            while (!submarine.IsMoving);
        }
    }
}
