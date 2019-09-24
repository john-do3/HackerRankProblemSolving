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

class Result
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */
    /*int round(double i, int v)
    {
        return Math.round(i / v) * v;
    }*/

    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> result = new List<int>();

        foreach (int grade in grades)
        {
            int res = grade;

            if (grade > 38)
            {
                int rounded = Convert.ToInt32(Math.Round(grade / 5.0)) * 5;

                int diff = rounded - grade;
                if ((diff > 0) && (diff < 3))
                    res = rounded;
            }

            result.Add(res);

        }

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("c:\\temp\\hr_output.txt", true);

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
