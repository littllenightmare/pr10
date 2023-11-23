using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr10
{
    internal class GenerateRandom
    {
        public static int[] GenerateRandomArray(int min, int max)
        {
                if (min <= 0)
                {
                    int count = 0;
                    for (int j = min; j <= max; j++)
                    {
                        count++;
                    }
                    int[] array = new int[count];
                    for (int i = 0; i < count; i++)
                    {
                        array[i] = min++;
                    }
                    return array;
                }
                else
                {
                    int count = 0;
                    for (int j = min; j <= max; j++)
                    {
                        count++;
                    }
                    int[] array = new int[count];
                    for (int i = 0; i < count; i++)
                    {
                        array[i] = min++;
                    }
                    return array;
                }

        }
    }
}
