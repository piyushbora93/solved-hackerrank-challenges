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
    public static int hurdleRace(int k, List<int> height)
    {
        int numberofDosesRequired = 0;
        foreach(var item in height){
            if(k < item){                
                numberofDosesRequired = numberofDosesRequired + (item - k);
                k = item;
            }
        };
        return numberofDosesRequired;
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

        List<int> height = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(heightTemp => Convert.ToInt32(heightTemp)).ToList();

        int result = Result.hurdleRace(k, height);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
