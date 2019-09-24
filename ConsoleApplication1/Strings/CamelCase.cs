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

    // Complete the camelcase function below.
    static int camelcase(string s)
    {
        int result = 1;

        foreach (char c in s)
        {
            if (Char.IsUpper(c))
                result++;
        }

        return result;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("c:\\temp\\sss.txt", true);

        string s = Console.ReadLine();

        int result = camelcase(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}