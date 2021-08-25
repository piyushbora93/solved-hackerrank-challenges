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
    public static int minimumDistances(List<int> a)
    {
        int result = 0;
        List<int> tempList = new List<int>();                
        foreach(var item in a){
            if(!(tempList.Any(x => x == item))){
                tempList.Add(item);  
                var firstPosition = a.FindIndex(x  => x == item);
                var lastPosition = a.FindLastIndex(x => x == item);
                if(firstPosition != lastPosition){
                    if(result == 0 || result == -1){
                        result = lastPosition - firstPosition;
                    }
                    else{
                        result = result > lastPosition - firstPosition ? lastPosition - firstPosition: result;
                    }
                }
                else if(result == 0){
                    result = -1;
                }
            }
        }
    return result;
    }
}
        
    
        

   

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.minimumDistances(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
