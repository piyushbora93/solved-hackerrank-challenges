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
    public static void staircase(int n)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int j = 1;        
        while(j < n + 1){
            string res = new StringBuilder(n).Insert(0, " ", n - j).Insert(n-j, "#",j).ToString();            
            j++;
            textWriter.WriteLine(String.Join(" ", res));
        }
        textWriter.Flush();
        textWriter.Close();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
