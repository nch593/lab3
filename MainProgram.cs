using System;
using Library;

class MainProgram
{
    static void Main()
    {
        int minTwo = MinFinder.Min(23, 28);
        int minThree = MinFinder.Min(25, 21, 23);

        Console.WriteLine("Minimum number for 2 numbers: " + minTwo);
        Console.WriteLine("Minimum number for 3 numbers: " + minThree);
    }
}
