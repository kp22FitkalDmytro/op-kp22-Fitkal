using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class UnitTests
    {
        public bool Test()
        {
            Vector vector1 = new Vector(1, -10, 0, 5);
            Vector vector2 = new Vector(6, -20, 0, 9);
            double expectedPlus = -30;
            double expectedMultiply = 0;
            int expectedDivide = 2;
            double actualPlus = vector1 + vector2;
            double actualMultiply = vector1 * vector2;
            double actualDivide = vector1 / vector2;

            if (actualDivide != expectedDivide || actualPlus != expectedPlus || actualMultiply != expectedMultiply)
            {
                Console.WriteLine("1 failed");
                return false;
            }

            Vector vector3 = new Vector(0);
            Vector vector4 = new Vector(0);
            double expectedPlus2 = 0;
            double expectedMultiply2 = 0;
            int expectedDivide2 = 2;
            double actualPlus2 = vector3 + vector4;
            double actualMultiply2 = vector3 * vector4;
            double actualDivide2 = vector3 / vector4;

            if (actualDivide2 != expectedDivide2 || actualPlus2 != expectedPlus2 || actualMultiply2 != expectedMultiply2)
            {
                Console.WriteLine("Second test failed");
                return false;
            }

            Vector vector5 = new Vector(-1, 1, 5);
            Vector vector6 = new Vector(-8, 8, 8);
            double expectedPlus3 = -40;
            double expectedMultiply3 = 1500;
            int expectedDivide3 = 0;
            double actualPlus3 = vector5 + vector6;
            double actualMultiply3 = vector5 * vector6;
            double actualDivide3 = vector5 / vector6;

            if (actualDivide3 != expectedDivide3 || actualPlus3 != expectedPlus3 || actualMultiply3 != expectedMultiply3)
            {
                Console.WriteLine("3 failed");
                return false;
            }
            Console.WriteLine("All PASSED");
            return true;
        }

    }
}
