using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace Priority_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //OrderedBag<Item> pq = new OrderedBag<Item>();

            //Item one = new Item();
            //one.Priority = 10;

            //Item second = new Item();
            //second.Priority = 2;

            //Item second2 = new Item();
            //second2.Priority = 2;

            //Item third = new Item();
            //third.Priority = 3;

            //pq.Add(one);
            //pq.Add(second);
            //pq.Add(third);
            //pq.Add(second2);

            //second.Priority = 29;

            //foreach (var item in pq)
            //{
            //    Console.WriteLine(item);
            //}

            OrderedMultiDictionary<int, Item> dict = new OrderedMultiDictionary<int, Item>(true);

            Item one = new Item();
            one.Priority = 10;

            Item second = new Item();
            second.Priority = 2;

            Item second2 = new Item();
            second2.Priority = 2;

            Item third = new Item();
            third.Priority = 3;


            dict.Add(one.Priority, one);
            dict.Add(second.Priority, second);
            dict.Add(second2.Priority, second2);
            dict.Add(third.Priority, third);

            var items = dict[2];

            //bool pass = true;
            //foreach (var item in items)
            //{
            //    if (pass)
            //    {
            //        pass = false;
            //        continue;
            //    }

            //    dict[item.Priority].Remove(item);
            //    break;
            //}

            second.Priority = 11111;

            foreach (var item in dict)
            {
                Console.WriteLine(item.Value);
            }




        }
    }

    class Item : IComparable<Item>
    {
        private static int counter = 0;

        public int Priority { get; set; }

        private int id;

        public Item()
        {
            counter++;
            this.id = counter;
        }

        public override string ToString()
        {
            return this.Priority.ToString() + " " + this.id.ToString();
        }

        public int CompareTo(Item other)
        {
            return this.Priority - other.Priority;
        }
    }
}
