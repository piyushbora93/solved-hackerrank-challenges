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
    public static int jumpingOnClouds(List<int> c)
    {
        int i = 0;
        int jumps = 0;
        while(i < c.Count()){
            if(i == c.Count() - 1){
                break;
            }
            if(i + 2 <= c.Count() - 1){
                if(c[i + 2] == 0){
                    jumps++;
                    i = i + 2; 
                    continue;                   
                }
                else if(c[i + 1] == 0){
                    jumps++;
                    i = i + 1;
                    continue;
                }
            }
            else{                
                    jumps++;
                    i = i + 1;                
            }                        
        }
        return jumps;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();

        int result = Result.jumpingOnClouds(c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
