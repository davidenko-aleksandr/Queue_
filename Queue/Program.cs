using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();

            queue.Enqueued("One");
            queue.Enqueued("Two");
            queue.Enqueued("Three");
            queue.Enqueued("Four");
            queue.Enqueued("Five");
            queue.Enqueued("Six");

            var item1 = queue.Count;
            Console.WriteLine($"В очереди {item1} элеиентов.");

            var item2 = queue.Dequeued();
            Console.WriteLine($"Первый элемент очереди  - {item2} ");

            var item3 = queue.Dequeued();
            Console.WriteLine($"Второй элемент очереди  - {item3} ");

           
            Console.WriteLine($"В очереди теперь  {item1} элеиентов.");
        }
    }
}
