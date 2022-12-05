using System;
using System.Collections.Generic;

namespace Второй_максимум
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var nums = new List<int>() {};
            while (num != 0)
            {
                nums.Add(num);
                num = int.Parse(Console.ReadLine());
            }
            nums.Sort((x, y) => y.CompareTo(x));
            Console.WriteLine(nums[1]);
        }
    }
}
