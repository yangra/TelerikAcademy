using System;

class Laser
{
    static int[] Getnumbers()
    {
        string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] result = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            result[i] = int.Parse(numbers[i]);
        }
        return result;
    }

    static void Main()
    {
        int[] size = Getnumbers();
        int[] startPoint = Getnumbers();
        int[] direction = Getnumbers();

        bool[,,] cuboid = new bool[size[0] + 1, size[1] + 1, size[2] + 1];

        for (int i = 1; i < size[0]; i++)
        {
            cuboid[i, size[1], 1] = true;
            cuboid[i, size[1], size[2]] = true;
            cuboid[i, 1, 1] = true;
            cuboid[i, 1, size[2]] = true;
        }

        for (int i = 1; i < size[1]; i++)
        {
            cuboid[1, i, 1] = true;
            cuboid[size[0], i, 1] = true;
            cuboid[size[0], i, size[2]] = true;
            cuboid[1, i, size[2]] = true;
        }

        for (int i = 1; i < size[2]; i++)
        {
            cuboid[size[0], size[1], i] = true;
            cuboid[1, size[1], i] = true;
            cuboid[1, 1, i] = true;
            cuboid[size[0], 1, i] = true;
        }
        int w = startPoint[0];
        int h = startPoint[1];
        int d = startPoint[2];

        int changeW = direction[0];
        int changeH = direction[1];
        int changeD = direction[2];

        if (!cuboid[w,h,d])
        {
            cuboid[w, h, d] = true;
        }

        while (true)
        {
            if (w + changeW > size[0] || w + changeW < 1)
            {
                changeW *= -1;
            }
            if (h + changeH > size[1] || h + changeH < 1)
            {
                changeH *= -1;
            }
            if (d + changeD > size[2] || d + changeD < 1)
            {
                changeD *= -1;
            }
            if (!cuboid[w+changeW,h+changeH,d+changeD])
            {
                w += changeW;
                h += changeH;
                d += changeD;
                cuboid[w, h, d] = true;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("{0} {1} {2}",w,h,d);
    }
}

