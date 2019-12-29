using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList a = new LinkedList();
            a.value = 1;

            LinkedList b = new LinkedList();
            b.value = 2;

            LinkedList c = new LinkedList();
            c.value = 3;

            LinkedList d = new LinkedList();
            d.value = 4;

            LinkedList e = new LinkedList();
            e.value = 5;

            LinkedList f = new LinkedList();
            f.value = 6;

            a.Next = b;
            b.Next = c;
            c.Next = d;
            d.Next = e;
            e.Next = f;

            LinkedList head = new LinkedList();

            head = a;
            //iteration
            do
            {
                Console.WriteLine(head.value);
                head = head.Next;
            } while (head != null);

            // adding a new node

            //Deleting

        }
    }
}
