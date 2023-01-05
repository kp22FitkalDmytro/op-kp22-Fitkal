using System;
class Program
{
    static void Main(String[] args)
    {
        while (true)
        {
            Console.WriteLine("enter size of square array:");
            bool isValidN = int.TryParse(Console.ReadLine(), out int n);
            if (!isValidN)
            {
                Console.WriteLine("enter the right number");
                return;
            }
            int[,] array = init(n);
            print(array);
            Console.ReadLine();
            Console.Clear();
            array = Result(array);
            print(array);
            Console.WriteLine("number of open Sites is:" + numberOfOpenSites(array));
            Console.WriteLine("is percolates:" + percolates(array));
            Console.WriteLine("enter for testcase");
            Console.ReadLine();
            Console.Clear();
            testcase();
        }

    }
    static int[,] init(int n)
    {
        Random rnd = new Random();
        int[,] array = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int x = rnd.Next(2);
                if (x == 0)
                {
                    array[i, j] = 2;
                }
                else if (x == 1 && i == 0)
                {
                    array[i, j] = 0;
                }
                else if (x == 1)
                {
                    array[i, j] = 1;
                }
            }
        }
        return array;
    }
    static int[,] Open(int row, int col, int[,] array)
    {
        int a = 2;
        int b = 2;
        int c = 2;
        int d = 2;
        if (row != 0) a = array[row - 1, col];
        if (col != 0) b = array[row, col - 1];
        if (row < array.GetLength(0) - 1) c = array[row + 1, col];
        if (col < array.GetLength(1) - 1) d = array[row, col + 1];
        if (array[row, col] == 1 && (a == 0 || b == 0 || c == 0 || d == 0))
        {
            array[row, col] = 0;
            return array;
        }
        return array;
    }
    static bool isOpen(int row, int col, int[,] array)
    {
        if (array[row, col] == 2) return false;
        return true;
    }
    static bool isFull(int row, int col, int[,] array)
    {
        if (array[row, col] == 1) return false;
        return true;
    }
    static int numberOfOpenSites(int[,] array)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == 0 || array[i, j]==1)
                {
                    count++;
                }
            }
        }
        return count;
    }
    static bool percolates(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (array[array.GetLength(1) - 1, i] == 0)
            {
                return true;
            }
        }
        return false;
    }
    static void print(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == 1)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Write("  ");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else if (array[i, j] == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("  ");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else if (array[i, j] == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("  ");
                    Console.BackgroundColor = ConsoleColor.Black;
                }

            }
            Console.WriteLine();
        }
    }
    static int[,] Result(int[,] array)
    {
        int sum = 0;
        int etalonsum = 0;
        bool x = true;
        while (x)
        {
            etalonsum = sum;
            sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array = Open(i, j, array);
                    sum += array[i, j];
                }
            }
            if (etalonsum == sum)
            {
                x = false;
            }
        }
        return array;
    }
    static void testcase()
    {
        int[,] testArray1 = { { 0, 2, 2, 2 }, { 1, 1, 2, 1 }, { 1, 1, 1, 2 }, { 1, 1, 2, 2 } };
        bool isFullTest1and1Test1 = true;
        bool isOpenTest1and1Test1 = true;
        int numberOfOpenSites1 = 9;
        bool percoclates1 = true;
        int[,] testArray1Traversal1 = Result(testArray1);
        if (isFullTest1and1Test1 == isFull(1, 1, testArray1Traversal1) || isOpenTest1and1Test1 == isOpen(1, 1, testArray1Traversal1) || numberOfOpenSites1 == numberOfOpenSites(testArray1Traversal1) || percoclates1 == percolates(testArray1Traversal1))
        {
            Console.WriteLine("Test 1 Passed");
        }
        else
        {
            Console.WriteLine("Test 1 not Passed");
        }
        int[,] testArray2 = { { 0, 0, 2, 0 }, { 1, 2, 2, 1 }, { 1, 2, 2, 1 }, { 1, 2, 1, 1 } };
        bool isFullTest1and1Test2 = false;
        bool isOpenTest1and1Test2 = false;
        int numberOfOpenSites2 = 10;
        bool percoclates2 = true;
        int[,] testArray1Traversal2 = Result(testArray1);
        if (isFullTest1and1Test2 == isFull(1, 1, testArray1Traversal2) || isOpenTest1and1Test2 == isOpen(1, 1, testArray1Traversal2) || numberOfOpenSites2 == numberOfOpenSites(testArray1Traversal2) || percoclates2 == percolates(testArray1Traversal2))
        {
            Console.WriteLine("Test 2 Passed");
        }
        else
        {
            Console.WriteLine("Test 2 not Passed");
        }
        int[,] testArray3 = { { 0, 2, 0, 2 }, { 1, 2, 1, 2 }, { 1, 1, 2, 1 }, { 2, 2, 1, 2 } };
        bool isFullTest1and1Test3 = false;
        bool isOpenTest1and1Test3 = false;
        int numberOfOpenSites3 = 8;
        bool percoclates3 = false;
        int[,] testArray1Traversal3 = Result(testArray3);
        if (isFullTest1and1Test3 == isFull(1, 1, testArray1Traversal3) || isOpenTest1and1Test3 == isOpen(1, 1, testArray1Traversal3) || numberOfOpenSites3 == numberOfOpenSites(testArray1Traversal3) || percoclates3 == percolates(testArray1Traversal3))
        {
            Console.WriteLine("Test 3 Passed");
        }
        else
        {
            Console.WriteLine("Test 3 not Passed");
        }
    }
}