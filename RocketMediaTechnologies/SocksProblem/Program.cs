using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocksProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] socks = inputArray();
            int result = numberOfPairs(ref socks);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int[] inputArray() 
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            string query = Console.ReadLine();
            string[] q = query.Split(' ');
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(q[i]);
            }
            return arr;
        }

        static int numberOfPairs(ref int[] arr) 
        {
            Dictionary<int, int> socks = new Dictionary<int, int>();
            int temp;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (socks.ContainsKey(arr[i]))
                {
                    temp = socks[arr[i]];
                    socks.Remove(arr[i]);
                    temp++;
                    socks.Add(arr[i], temp);
                }
                else
                {
                    temp = 1;
                    socks.Add(arr[i], temp);
                }

            }
            foreach (int item in socks.Keys)
            {
                count = count + socks[item] / 2;
            }
            return count;
        }
    }
}
