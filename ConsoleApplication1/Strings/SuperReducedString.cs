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

    // Complete the superReducedString function below.
    static string superReducedString(string s)
    {
        bool found;

        do
        {
            found = false;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    found = true;
                    s = s.Remove(i, 2);
                    break;
                }
            }

            if (string.IsNullOrEmpty(s))
                found = false;
        }
        while (found);

        return string.IsNullOrEmpty(s) ? "Empty String" : s;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("c:\\temp\\sss.txt", true);

        string s = Console.ReadLine();

        string result = superReducedString(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}