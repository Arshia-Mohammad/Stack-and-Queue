using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Scenario: Need to create a C# program that maintains Browser navigaion/URl history anf printout job queues using Stack and Queue 
            //Stack: Last In First Out (LIFO) - Used for Browser navigation history
            //Queue: First In First Out (FIFO) - Used for Job Queues
            //Step 1: Create a Stack for Browser navigation history\
            //Step 2: Create a Queue for Job Queues
            //Step 3: Implement methods to push and pop URLs in Stack( methods are predefined in Stack class)
            //Step 4: Implement methods to enqueue and dequeue jobs in Queue(methods are predefined in Queue class)
            //Step 5: Print out the contents of Stack and Queue
            //Step 6: Test the program with sample data
            Stack<string> pages= new Stack<string>();
            pages.Push("Chrome");
            pages.Push("vs");
            pages.Push("zoom");
            
            foreach (var page in pages) {
                Console.WriteLine(page); }
            Console.WriteLine(pages.Peek());
            Console.WriteLine(pages.Pop());

            Queue<string> prints= new Queue<string>();
            prints.Enqueue("dev");
            prints.Enqueue("sde");
            prints.Enqueue("consultant");
            prints.Enqueue("hr");
            foreach (var print in prints)
            {
                Console.WriteLine(print);
            }
            prints
        }
    }
}
