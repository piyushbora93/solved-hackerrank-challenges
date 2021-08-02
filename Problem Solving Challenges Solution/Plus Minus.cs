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
    public static void plusMinus(List<int> arr)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        double positiveTerms = 0;
        double negativeTerms = 0;
        double zeroTerm = 0;
        foreach(var item in arr){
            if(item > 0){
                positiveTerms++;
            }
            else if(item < 0){
                negativeTerms++;
            }
            else{
                zeroTerm++;
            }
        }
        double totalTerms = arr.Count();
        double positiveRatio = Math.Round(positiveTerms/totalTerms,6);
        double negativeRatio = Math.Round(negativeTerms/totalTerms,6);
        double zeroRatio = Math.Round(zeroTerm/totalTerms,6);
        
        textWriter.WriteLine(String.Join(" ", positiveRatio));
        textWriter.WriteLine(String.Join(" ", negativeRatio));
        textWriter.WriteLine(String.Join(" ", zeroRatio));
        textWriter.Flush();
        textWriter.Close();

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
