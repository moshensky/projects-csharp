using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA_Timing_Class
{
    class TimingTest
    {
        static void Main()
        {
            int[] nums = new int[100000];
            BuildArray(nums);
            Timer timer = new Timer();

            timer.startTime();
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(i);
            }

            timer.StopTime();
            string result1 = ("cw and arr.length: " + timer.Result().TotalSeconds);

            timer.startTime();
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
            }

            timer.StopTime();
            string result2 = ("cw and int n = arr.length: " + timer.Result().TotalSeconds);

            timer.startTime();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.AppendLine(i.ToString());
            }

            Console.WriteLine(sb);
            timer.StopTime();
            string result3 = ("cw and int n = arr.length: " + timer.Result().TotalSeconds);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

        }
        static void BuildArray(int[] arr)
        {
            for (int i = 0; i < 100000; i++)
                arr[i] = i;
        }
    }
}
