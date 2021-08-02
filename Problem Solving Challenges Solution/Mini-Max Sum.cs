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
    public static void miniMaxSum(List<int> arr)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        List<long> newList = arr.ConvertAll(i => (long)i);
        long[] newArr = newList.ToArray();
        Array.Sort(newArr);        
        long minimumSum = newArr[0] + newArr[1] + newArr[2] + newArr[3];        
        long maximumSum = newArr[1] + newArr[2] + newArr[3] + newArr[4];
        
        textWriter.WriteLine(String.Join(" ", minimumSum,maximumSum));
        textWriter.Flush();
        textWriter.Close();
       
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        Result.miniMaxSum(arr);
    }
}
