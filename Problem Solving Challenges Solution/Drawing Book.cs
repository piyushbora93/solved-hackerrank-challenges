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

    public static int pageCount(int n, int p)
    {
        int countFirst = 0;
        int countLast = 0;
        int currentPageFirst = 1;
        int currentPageLast = n % 2 == 0 ? n : n - 1;
        while(currentPageFirst < p){
                currentPageFirst += 2;
                countFirst++;
            };
        if(n % 2 == 0){            
            while(p < currentPageLast){
                currentPageLast -= 2;
                countLast++;
            }
        }       
        else{
            if(n - p > 1){
                while(p < currentPageLast){
                    currentPageLast -= 2;
                    countLast++;
                } 
            }
            else{
                countLast = 0;
            }
        }         
        return Math.Min(countFirst,countLast);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.pageCount(n, p);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
