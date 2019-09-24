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

    // Complete the marsExploration function below.
    static int marsExploration(string s)
    {
        int result = 0;
        int sosCount = s.Length / 3;

        for (int i = 0; i < sosCount; i++)
        {
            string curSos = s.Substring(0, 3);
            s = s.Substring(3, s.Length - 3);
            if (curSos[0] != 'S')
                result++;
            if (curSos[1] != 'O')
                result++;
            if (curSos[2] != 'S')
                result++;
        }

        return result;

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("c:\\temp\\sss.txt", true);

        string s = Console.ReadLine();

        int result = marsExploration(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
