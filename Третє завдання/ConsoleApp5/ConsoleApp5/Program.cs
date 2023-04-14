using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2._2
{
    internal class Submarine : Vessel
    {
        private string Name;
        private int Crew;
        private int availableCrew;
        private bool _isPrepared = false;
        public bool IsPrepared { get => _isPrepared; }
        private bool _isMoving = false;
        public bool IsMoving { get => _isPrepared; }
        public Submarine(string name, int crewSize)
        {
            this.Name = name;
            this.Crew = crewSize;
            Random rnd = new Random();
            availableCrew = rnd.Next(1, crewSize + 1);
        }
        public override void Move()
        {
            if (availableCrew > Crew / 2)
            {
                PlayCounterStriceInACabine();
                availableCrew += 3;
                return;
            }
            _isMoving = true;
            Console.WriteLine($"{Name} is moving");
        }

        public override void PrepareToMovement()
        {
            if (availableCrew > this.Crew / 3)
            {
                _isPrepared = true;
                Console.WriteLine("Crew is prepearing submarine to move");
            }
            else
            {
                availableCrew += 3;
                Console.WriteLine("Not enough people");
            }
        }
    }
}
