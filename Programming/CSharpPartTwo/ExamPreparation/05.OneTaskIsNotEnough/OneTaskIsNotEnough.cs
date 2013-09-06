using System;
using System.Collections.Generic;
using System.Text;

class OneTaskIsNotEnough
{
    //static int[] lamps;

    //static bool FindDark(ref int index, int N)
    //{
    //    int counter;
    //    if (index + 1 < N - 1)
    //    {
    //        counter = index + 1;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //    while (lamps[counter] != 0)
    //    {
    //        counter++;
    //        if (counter >= N)
    //        {
    //            return false;
    //        }
    //    }
    //    index = counter;
    //    return true;
    //}
    //static int TurnLampsON(int N)
    //{
    //    lamps = new int[N];
    //    int last = 0;
    //    for (int i = 0; i < N; i++)
    //    {
    //        if (i % 2 == 0)
    //        {
    //            lamps[i] = 1;
    //        }
    //        else
    //        {
    //            lamps[i] = 0;
    //        }
    //    }
    //    bool ready = false;
    //    int iteration = 1;
    //    while (!ready)
    //    {
    //        int index = 0;
    //        if (FindDark(ref index, N))
    //        {
    //            lamps[index] = 1;
    //        }
    //        else
    //        {
    //            last = index;
    //            break;
    //        }
    //        bool endReached = false;
    //        while (!endReached)
    //        {
    //            for (int i = 0; i < iteration + 2; i++)
    //            {
    //                if (FindDark(ref index, N))
    //                {

    //                }
    //                else
    //                {
    //                    last = index;
    //                    endReached = true;
    //                    break;
    //                }
    //            }
    //            if (!endReached)
    //            {
    //                lamps[index] = 1;
    //            }
    //        }
    //        for (int i = 0; i < N; i++)
    //        {
    //            if (lamps[i] == 0)
    //            {
    //                ready = false;
    //                last = index;
    //                break;
    //            }
    //            ready = true;
    //        }
    //        iteration++;
    //    }
    //    return last;
    //}

    static int FindLastLamp(int N)
    {
        int lampsLeft = N;
        int[] stillOff = new int[N + 1];
        int[] steps = new int[N + 1];

        for (int i = 1; i <= lampsLeft; i++)
        {
            stillOff[i] = i;
        }
        int step = 0;
        while (lampsLeft > 1)
        {
            step++;
            int currentIndex = 1;
            while(currentIndex <= lampsLeft)
            {
                steps[currentIndex] = step;
                currentIndex += step + 1;
            }
            int newLampsLeft = 0;
            for (int i = 1; i <= lampsLeft; i++)
            {
                if (steps[i]!=step)
                {
                    newLampsLeft++;
                    stillOff[newLampsLeft] = stillOff[i];
                }
            }
            lampsLeft = newLampsLeft;
        }
        return stillOff[1];
    }

    static void Move(char command, ref string direction, ref int posX, ref int posY)
    {
        switch (command)
        {
            case 'S':
                if (direction == "up")
                {
                    posY++;
                }
                else if (direction == "left")
                {
                    posX--;
                }
                else if (direction == "down")
                {
                    posY--;
                }
                else if (direction == "right")
                {
                    posX++;
                }
                break;
            case 'R':
                if (direction == "up")
                {
                    direction = "right";
                }
                else if (direction == "left")
                {
                    direction = "up";
                }
                else if (direction == "down")
                {
                    direction = "left";
                }
                else if (direction == "right")
                {
                    direction = "down";
                }
                break;
            case 'L':
                if (direction == "up")
                {
                    direction = "left";
                }
                else if (direction == "left")
                {
                    direction = "down";
                }
                else if (direction == "down")
                {
                    direction = "right";
                }
                else if (direction == "right")
                {
                    direction = "up";
                }
                break;
            default:
                break;
        }
    }

    static string IsBounded(string command)
    {
        string direction = "up";
        int posX = 0;
        int posY = 0;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < command.Length; j++)
            {
                Move(command[j], ref direction, ref posX, ref posY);
            }
        }
        if (posX == 0 && posY == 0)
        {
            return "bounded";
        }
        else
        {
            return "unbounded";
        }
    }

    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string command1 = Console.ReadLine();
        string command2 = Console.ReadLine();
        Console.WriteLine(FindLastLamp(N));
        Console.WriteLine(IsBounded(command1));
        Console.WriteLine(IsBounded(command2));
    }
}


