using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Hops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] field = Console.ReadLine().Split(new String[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(item => int.Parse(item)).ToArray();
            int numberDirections = int.Parse(Console.ReadLine());
            int[] fieldCopy = new int[field.Length];
            BigInteger max = int.MinValue;

            int index = 0;
            for (int i = 0; i < numberDirections; i++)
            {
                int[] directions = Console.ReadLine().Split(new String[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(item => int.Parse(item)).ToArray();
                Array.Copy(field, fieldCopy, field.Length);
                BigInteger sum = fieldCopy[0];
                fieldCopy[0] = int.MaxValue;
                index = 0;
                for (int j = 0; j < directions.Length; j++)
                {
                    if (directions[j] > 0)
                    {
                        index = index + directions[j];
                        if (index > (fieldCopy.Length - 1) || fieldCopy[index] == int.MaxValue || directions[j] == 0)
                        {
                            break;
                        }
                        else
                        {
                            sum = sum + fieldCopy[index];
                            fieldCopy[index] = int.MaxValue;
                        }
                    }
                    else if (directions[j] < 0)
                    {
                        index = index + directions[j];
                        if (index <= 0 || fieldCopy[index] == int.MaxValue || directions[j] == 0)
                        {
                            break;
                        }
                        else
                        {
                            sum = sum + fieldCopy[index];
                            fieldCopy[index] = int.MaxValue;
                        }
                    }
                }
                if (sum > max)
                {
                    max = sum;
                }
            }
            Console.WriteLine(max);
        }
    }
}
