using AAA_Timing_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_property
{
    class CountTests
    {
        static void Main(string[] args)
        {

            Timer timer = new Timer();

            int length = 1000000;
            List<int> list = new List<int>();

            for (int i = 0; i < length; i++)
            {
                list.Add(i);
            }

            ICollection<int> test = list;
            timer.startTime();
            for (int i = 0; i < length; i++)
            {
                int b = test.First();
            }
            timer.StopTime();
            Console.WriteLine(timer.Result().TotalMilliseconds);


            timer.startTime();
            for (int i = 0; i < length; i++)
            {
                foreach (var item in test)
                {
                    int b = item;
                    break;
                }
            }
            timer.StopTime();
            Console.WriteLine(timer.Result().TotalMilliseconds);
        }
    }
}
