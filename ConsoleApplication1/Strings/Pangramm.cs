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

    // Complete the pangrams function below.
    static string pangrams(string s)
    {        
        string alphabet = "abcdefghijklmnopqrstuwxyz";
        s = s.ToLower();
        int r = 1;

        foreach (char c in alphabet)
        {
            if (s.Count(x => x == c) >= 1)
                r++;
        }

        return r == 26 ? "pangram" : "not pangram";
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("c:\\temp\\sss.txt", true);

        string s = Console.ReadLine();

        string result = pangrams(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
