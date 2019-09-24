using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr)
    {
        //Int64 minSum = arr.Where(x => x != arr.Max()).Sum();
        //Int64 maxSum = arr.Where(x => x != arr.Min()).Sum();
        int min = arr.Min();
        int max = arr.Max();
        Int64 minSum = 0, maxSum = 0;

        if (arr.Distinct().Count() == 1)
        {
            minSum = arr[0] * 4;
            maxSum = minSum;
        }
        else
            foreach (int i in arr)
            {
                if (i != max)
                    minSum += i;

                if (i != min)
                    maxSum += i;
            }

        Console.WriteLine($"{minSum} {maxSum}");

        Console.ReadLine();
    }

    static void Main(string[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}