/*
Man Nguyen 10/5/2017

Given list of money values (e.g. $0.05, $0.10, $0.25), how many unique combinations can generate total of max (e.g $0.95)

*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Rextester
{
    public class Program
    {
        static int[] vals = new int[] {1, 5, 10, 25, 15, 20, 13};
        static int max = 26;
        static List<string> results;
        public static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            // store the results here, for output at end.
            results = new List<string>();
            // process each value in the vals array
            for (int i=0; i<vals.Length; ++i)
            {
                // clear out all denominations
                nums.Clear();
                // for each of the preceding indices, initialize theirs to 0
                for (int j=0; j<i; ++j)
                    nums.Add(0);
                GetCombo(i, nums);
            }
            // display the distinct values
            if (results.Count == 0)
                Console.WriteLine("No combination was found");
            else 
                results.Distinct().ToList().ForEach(s => Console.WriteLine(s.Substring(0, s.Length-1)));
        }
        
        static void GetCombo(int index, List<int> nums)
        {
            int current = 0;
            // calculate the running sum so far
            for (int i=0; i<nums.Count; ++i)
                current += nums[i] * vals[i];

            // starting w/ denom of 0, increment until max is met or exceeded
            int denom = 0;
            nums.Add(0);
            while (index < vals.Length && current + denom * vals[index] <= max)
            {
                nums[nums.Count-1] = denom;
                // if current sum matches, then store the combination
                if (current + denom * vals[index] == max)
                {
                    var sb = new StringBuilder();
                    for (int k=0; k<nums.Count; ++k)
                    {
                        if (nums[k] > 0)
                            sb.AppendFormat("{0}*{1}+", nums[k], vals[k]);
                    }
                    results.Add(sb.ToString());
                    break;
                }
                // otherwise increment to the next index
                GetCombo(index+1, nums);
                ++denom;
            }
            nums.RemoveAt(nums.Count - 1);
        }
        
               
    }
    
}
