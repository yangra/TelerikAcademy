using System;
using System.Collections.Generic;
using System.IO;

class Employees
{
    static void Main(string[] args)
    {
        List<string> result;
        string[] positions;
        int[] ranks;
        string[] employees;
        string[] employeePosition;
        StreamReader reader = new StreamReader(@"../../test.011.in.txt");
        using (reader)
        {
            result = new List<string>();
            int numPositions = int.Parse(reader.ReadLine());
            positions = new string[numPositions];
            ranks = new int[numPositions];
            for (int i = 0; i < numPositions; i++)
            {
                string[] position = reader.ReadLine().Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
                if (position.Length > 2)
                {
                    position[0] = String.Join(" ", position, 0, position.Length - 1);
                }
                positions[i] = position[0];
                ranks[i] = int.Parse(position[position.Length - 1]);
            }
            int numEmployees = int.Parse(reader.ReadLine());
            employees = new string[numEmployees];
            employeePosition = new string[numEmployees];
            for (int i = 0; i < numEmployees; i++)
            {
                string[] employee = reader.ReadLine().Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
                employee[0] = String.Join(" ", employee, 0, 2);
                if (employee.Length > 3)
                {
                    employee[1] = String.Join(" ", employee, 2, employee.Length - 2);
                }
                else
                {
                    employee[1] = employee[2];
                }
                employees[i] = employee[0];
                employeePosition[i] = employee[1];
            }
        }

        Array.Sort(ranks, positions);
        Array.Reverse(ranks);
        Array.Reverse(positions);
        string[] allEmployees = new string[employees.Length];
        int[] allRanks = new int[employees.Length];
        int index = 0;


        for (int i = 0; i < positions.Length; i++)
        {
            for (int j = 0; j < employeePosition.Length; j++)
            {
                if (employeePosition[j] == positions[i])
                {
                    allEmployees[index] = employees[j];
                    allRanks[index] = ranks[i];
                    index++;
                }
            }
            
        }
        HashSet<int> extractedRanks = new HashSet<int>();
        for (int i = 0; i < ranks.Length; i++)
        {
            extractedRanks.Add(ranks[i]);
        }
        int[] finalRanks = new int[extractedRanks.Count];
        index = 0;
        foreach (int rank in extractedRanks)
        {
            finalRanks[index] = rank;
            index++;
        }
        for (int i = 0; i < finalRanks.Length; i++)
        {

            List<int> matchingNames = CountAllInstances(allRanks, finalRanks[i]);
            if (matchingNames.Count > 0)
            {
                if (matchingNames.Count > 1)
                {
                    string[] names = new string[matchingNames.Count];
                    string[] families = new string[matchingNames.Count];
                    for (int j = 0; j < names.Length; j++)
                    {
                        names[j] = allEmployees[matchingNames[j]];
                        string[] splitName = names[j].Split();
                        families[j] = splitName[1];
                    }
                    Array.Sort(families, names);
                    List<int> sameFamilyCount = new List<int>();
                    List<int> startIndex = new List<int>();
                    for (int j = 0; j < families.Length; j++)
                    {
                        int count = 1;
                        if (j != 0 && families[j] == families[j - 1])
                        {
                            count++;
                            startIndex.Add(j - 1);
                            while (j < families.Length && families[j] == families[j + 1])
                            {
                                count++;
                                j++;
                            }
                            sameFamilyCount.Add(count);
                        }
                    }
                    for (int j = 0; j < sameFamilyCount.Count; j++)
                    {
                        string[] changeNames = new string[sameFamilyCount[j]];
                        for (int k = 0; k < sameFamilyCount[j]; k++)
                        {
                            changeNames[k] = names[startIndex[j] + k];

                        }
                        Array.Sort(changeNames);
                        for (int k = 0; k < changeNames.Length; k++)
                        {
                            names[startIndex[j] + k] = changeNames[k];
                        }
                    }
                    for (int j = 0; j < names.Length; j++)
                    {
                        result.Add(names[j]);
                    }
                }
                else
                {
                    result.Add(allEmployees[matchingNames[0]]);
                }
            }
        }
        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine(result[i]);
        }
    }

    static List<int> CountAllInstances(int[] array, int match)
    {
        List<int> count = new List<int>();
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == match)
            {
                count.Add(i);
            }
        }
        return count;
    }
}

