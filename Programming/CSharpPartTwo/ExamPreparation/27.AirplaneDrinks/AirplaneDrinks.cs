using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AirplaneDrinks
{
    static bool[] visited;
    static bool AllAreVisited()
    {
        for (int i = 0; i < visited.Length; i++)
        {
            if (!visited[i])
            {
                return false;
            }
        }
        return true;
    }
    static void Main()
    {
        int passengers = int.Parse(Console.ReadLine());
        int[] plane = new int[passengers + 1];
        int teaCount = int.Parse(Console.ReadLine());
        List<int> tea = new List<int>();
        int time = 0;
        for (int i = 0; i < teaCount; i++)
        {
            string orderedTea = Console.ReadLine();
            tea.Add(int.Parse(orderedTea));
            
        }
        visited = new bool[passengers];
        int mode = 0;
        //1-tea
        //2-coffee
        tea.Sort();
        int index = 0;
        int served = 0;
        int coffeeCount = passengers - teaCount;
        while (served!=passengers)
        {
            time += 47;
            if (teaCount > 0)
            {
                mode = 1;
            }
            else
            {
                mode = 2;
            }
            time++;
            index++;
            for (int i = 0; i < 7; )
            {
                if (mode == 1 && tea.Contains(index) && visited[index - 1] != true)
                {
                    visited[index - 1] = true;
                    time += 4;
                    served++;
                    i++;
                    teaCount--;
                }
                else if (mode == 2 && !tea.Contains(index) && visited[index - 1] != true)
                {
                    visited[index - 1] = true;
                    time += 4;
                    served++;
                    i++;
                    coffeeCount--;
                }
                else
                {
                    index++;
                    time++;
                }
                if (mode==1&&teaCount==0)
                {
                    break;
                }
                if (mode==2&&coffeeCount==0)
                {
                    break;
                }
            }
            time += index;
            index = 0;
        }
        Console.WriteLine(time);
    }
}

