﻿using System.CodeDom.Compiler;
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

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr)
    {
        double below = 0, above = 0, zero = 0;

        int count = arr.Length;
        foreach (int i in arr)
        {
            if (i < 0)
                below++;
            else if (i > 0)
                above++;
            else
                zero++;
        }

        Console.WriteLine(string.Format("{0:0.000000}", above / count));
        Console.WriteLine(string.Format("{0:0.000000}", below / count));
        Console.WriteLine(string.Format("{0:0.000000}", zero / count));

        //Console.ReadLine();

    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
