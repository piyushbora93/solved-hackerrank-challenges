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

    public static long repeatedString(string s, long n)
    {
        long result = 0;
        if(s.Length < n){
            if(s.Length == 1){
                if(s == "a"){
                    return n;
                }
                else{
                    return result;
                }
            }
            else{
                long count = s.Count(f => f == 'a');
             long quotient = Math.DivRem(n, Convert.ToInt64(s.Length), out long remainder);
             count = count * quotient;                                
            long index = 0;    
            if(remainder > 0){
               index = s.Substring(0, Convert.ToInt32(remainder)).Count(f => f == 'a');              
            }
            result = count + index;
            return result;   
            }            
        }
        else{
            result = s.Substring(0, Convert.ToInt32(n)).Count(f => f == 'a');
            return result;
        }
        return result;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
