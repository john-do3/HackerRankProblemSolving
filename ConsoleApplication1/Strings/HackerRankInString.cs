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

    // Complete the hackerrankInString function below.
    static string hackerrankInString(string s)
    {
        string result = "NO";
        string hrank = "hackerrank";
        int fCount = 0;

        foreach (char c in hrank)
        {
            bool found = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (c == s[i])
                {
                    fCount++;
                    found = true;
                    s = s.Substring(i + 1, s.Length - i - 1);
                    break; // for
                }
            }

            if (!found)
                break;//foreach
        }

        if (fCount == hrank.Length)
            result = "YES";

        return result;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("c:\\temp\\sss.txt", true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            string result = hackerrankInString(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
