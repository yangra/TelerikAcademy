//We are given integer number n, value v (v=0 or 1) and a position p. 
//Write a sequence of operators that modifies n to hold the value v at 
//the position p from the binary representation of n.
//    Example: n = 5 (00000101), p=3, v=1 -> 13 (00001101)
//             n = 5 (00000101), p=2, v=0 ->  1 (00000001)

using System;

    class ModifyBit
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter bit position:");
        int bitPosition = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter bit vlaue(0 or 1):");
        int bitValue = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(number,2).PadLeft(32,'0'));
        int mask = 1 << bitPosition;
        
        if (bitValue == 1)
        {
            int setBit = mask | number;
            Console.WriteLine(Convert.ToString(setBit, 2).PadLeft(32, '0'));        
        }
        else 
        {
            int unsetBit = ~mask & number;
            Console.WriteLine(Convert.ToString(unsetBit, 2).PadLeft(32, '0'));
        }
    }
}

