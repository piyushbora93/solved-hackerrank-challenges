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

    public static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
    {
        int fine = 0;
        if(y1 != y2 && y1 > y2){
            fine = 10000;
            return fine;
        }
        else if(m1 == m2 && y1 == y2 && d1 != d2 && d1 > d2){
            fine = 15 * Math.Abs(d1 - d2);
            return fine;
        }
        else if(y1 == y2 && m1 != m2 && m1 > m2){
            fine = 500 * Math.Abs(m1 - m2);
            return fine;
        }
        return fine;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int d1 = Convert.ToInt32(firstMultipleInput[0]);

        int m1 = Convert.ToInt32(firstMultipleInput[1]);

        int y1 = Convert.ToInt32(firstMultipleInput[2]);

        string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int d2 = Convert.ToInt32(secondMultipleInput[0]);

        int m2 = Convert.ToInt32(secondMultipleInput[1]);

        int y2 = Convert.ToInt32(secondMultipleInput[2]);

        int result = Result.libraryFine(d1, m1, y1, d2, m2, y2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
