/*
Man Nguyen 

These are some questions I use for interviews

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
            //Your code goes here
            for (int i=3; i<=10; ++i)
                Console.WriteLine(string.Format("{0}! = {1}", i, Factorial(i)));
            for (int i=3; i<=10; ++i)
                Console.WriteLine(string.Format("{0}! = {1}", i, FactorialRecursion(i)));
            for (int i=0; i<=10; ++i)
                Console.WriteLine(string.Format("Fibo({0}) = {1}", i, Fibo(i)));
            for (int i=0; i<=10; ++i)
                Console.WriteLine(string.Format("FiboRecursion({0}) = {1}", i, FiboRecursion(i)));
        }

    
    
        static int Factorial(int num)
        {
            int prod = 1;
            for (int i=1; i<=num; ++i)
                prod *= i;
            return prod;
        }
        static int FactorialRecursion(int num)
        {
            if (num <= 1) return 1;
            return num * FactorialRecursion(num-1);
        }
        
        static int Fibo(int num)
        {
            if (num < 2) return 1;
            int[] arr = new int[num+1];
            arr[0] = 1;
            arr[1] = 1;
            
            for (int i=2; i<=num; ++i)
            {
                arr[i] = arr[i-1] + arr[i-2];
            }
            return arr[num];
        }
        
        static int FiboRecursion(int num)
        {
            if (num < 2) return 1;
            return FiboRecursion(num-1) + FiboRecursion(num-2);
        }
        
    }
    
}
