
/*
Man Nguyen 10/5/2017
Another good interview question to ask using linked list
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Item head = new Item();
            Item tail = head;
            for (int i=1; i<10; ++i)
            {
                tail = Add(tail, i);
                if (i==3 || i == 5 || i == 7) 
                {
                    tail = Add(tail, i);
                    tail = Add(tail, i);
                }
            }
            RemoveDuplicate(head);
            Print(head);
            
        }
        
        // assume ordered list
        static void RemoveDuplicate(Item ptr)
        {
            if (ptr == null) return;
            Item prevPtr = null;
            while (ptr != null)
            {
                if (prevPtr != null && prevPtr.Val == ptr.Val)
                {
                    prevPtr.next = ptr.next;// set the pointer to the next one
                    // Delete ptr; in c# case, managed memory, just let it go
                }
                else 
                {
                    prevPtr = ptr;
                }
                ptr = ptr.next;
            }
        }
        
        static void Print(Item ptr)
        {
            while (ptr != null)
            {
                Console.WriteLine(ptr.Val.ToString());
                ptr = ptr.next;
            }
        }
        
        static Item Add(Item ptr, int val)
        {
            Item i = new Item() {Val = val};
            if (ptr != null) ptr.next = i;
            return i;
        }
    }
    
    public class Item
    {
        public int Val;
        public Item next;
    }
}
