using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_VS_Class_VS_2_queues
{
    class Program
    {
        static void Main(string[] args)
        {
            AAA_Timing_Class.Timer timer = new AAA_Timing_Class.Timer();

            Queue<DataClass> qClass = new Queue<DataClass>();
            Queue<DataStruct> qStruct = new Queue<DataStruct>();
            Queue<int> int1 = new Queue<int>();
            Queue<int> int2 = new Queue<int>();

            int length = 10000000;

            timer.startTime();
            for (int i = 0; i < length; i++)
            {
                int1.Enqueue(i);
                int2.Enqueue(i);
            }
            timer.StopTime();

            string result = "int1/2 :";
            result += " " + timer.Result().TotalMilliseconds + "\n";

            timer.startTime();
            for (int i = 0; i < length; i++)
            {
                qClass.Enqueue(new DataClass(i, i));
            }
            timer.StopTime();

            result += "Class:";
            result += " " + timer.Result().TotalMilliseconds + "\n";

            timer.startTime();
            for (int i = 0; i < length; i++)
            {
                DataStruct num = new DataStruct(i, i);
                num.x = i;
                num.y = i;

                qStruct.Enqueue(num);
            }
            timer.StopTime();

            result += "Struct:";
            result += " " + timer.Result().TotalMilliseconds + "\n";


            Console.WriteLine(result);

        }
    }

    struct DataStruct
    {
        public int x;
        public int y;

        public DataStruct(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class DataClass
    {
        public int X { get; set; }
        public int Y { get; set; }

        public DataClass(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
