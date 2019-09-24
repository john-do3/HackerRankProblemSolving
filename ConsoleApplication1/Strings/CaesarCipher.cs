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
    // Complete the caesarCipher function below.
    static string caesarCipher(string s, int k)
    {
        string result = string.Empty;

        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        int len = alphabet.Length;
        int shift = k % len;
        char newC;

        foreach (char c in s)
        {
            char cDummy = Char.ToLower(c);
            int idx = alphabet.IndexOf(cDummy);

            if (idx < 0)
            {
                result += c;
                continue;
            }

            bool isCapital = c != cDummy;
            int newIdx = idx + shift;

            if (newIdx < len)
                newC = alphabet[newIdx];
            else
                newC = alphabet[newIdx - len];

            if (isCapital)
                newC = Char.ToUpper(newC);

            result += newC;
        }

        return result;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("c:\\temp\\sss.txt", true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine());

        string result = caesarCipher(s, k);

        textWriter.WriteLine(result);
        Console.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}
