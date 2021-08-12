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
    
    public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
    {        
        List<int> finalList = new List<int>();         
        if(k <= a.Count()){
            List<int> rotatedList = a.GetRange(Math.Abs(a.Count() - k), k).ToList();
            for(int i = 0; i < a.Count() - k; i++){
            rotatedList.Add(a[i]);
            }
            rotatedList.ToArray();
            for(int i = 0; i < queries.Count();i++){
               var x = queries[i];
               finalList.Add(rotatedList[x]);
            }
        }
        else{
            Math.DivRem(k, a.Count(), out int result);
            List<int> rotatedList = a.GetRange(Math.Abs(a.Count() - result), result).ToList();
            for(int i = 0; i < a.Count() - result; i++){
            rotatedList.Add(a[i]);
            }
            rotatedList.ToArray();
            for(int i = 0; i < queries.Count();i++){
               var x = queries[i];
               finalList.Add(rotatedList[x]);
            }
        }
                        
        return finalList;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        int q = Convert.ToInt32(firstMultipleInput[2]);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> queries = new List<int>();

        for (int i = 0; i < q; i++)
        {
            int queriesItem = Convert.ToInt32(Console.ReadLine().Trim());
            queries.Add(queriesItem);
        }

        List<int> result = Result.circularArrayRotation(a, k, queries);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
