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

    public static int migratoryBirds(List<int> arr)
    {         
        int maxOccuringBird = 1;
        int maxCount = arr.Count(x => x == 1);
        
        for(int i = 2; i < 6; i++) {
            int currentCount = arr.Count(x => x == i);
            
            if(currentCount > maxCount){
                maxCount = currentCount;
                maxOccuringBird = i;
            }
            else if(currentCount == maxCount && maxOccuringBird > i){
                maxCount = currentCount;
                maxOccuringBird = i;
            }
        }
        return maxOccuringBird;    
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
