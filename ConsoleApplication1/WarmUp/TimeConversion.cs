using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s)
    {
        /*
         * Write your code here.
         */
        DateTime d = DateTime.Parse(s);
        return d.ToString("HH:mm:ss");
    }

    static void Main(string[] args)
    {
        TextWriter tw = new StreamWriter("c:\\temp\\hr_output.txt", true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}