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
    
    public static string funnyString(string s)
    {
        string result = "Funny";
        string reverseInput = new string(s.Reverse().ToArray());
        if(s == reverseInput){
            result = "Funny";
        }
        else{        
            byte[] originalString = Encoding.ASCII.GetBytes(s);
            byte[] reverseString = Encoding.ASCII.GetBytes(reverseInput);
            
            for(int i = 0; i < originalString.Length - 1; i++){
                // if(Math.Abs(originalString[i] - originalString[i + 1]) == Math.Abs(reverseString[i] - reverseString[i + 1])){
                //     continue;
                // }
                if(Math.Abs(originalString[i] - originalString[i + 1]) != Math.Abs(reverseString[i] - reverseString[i + 1])){
                    result = "Not Funny";
                    break;
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

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            string result = Result.funnyString(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
