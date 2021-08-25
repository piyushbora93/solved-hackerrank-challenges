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
    
    public static int chocolateFeast(int n, int c, int m)
    {
        int totalChocolates = Math.DivRem(n, c, out int remainder);
        int wrappers = totalChocolates;
        bool runLoop = true;
        if(wrappers >= m){
                while(runLoop){                        
                int wrappersExchanged = Math.DivRem(wrappers, m, out int remainingWrappers);
                totalChocolates += wrappersExchanged;
                wrappers = wrappers + wrappersExchanged - (wrappersExchanged * m);    
                if(wrappers < m){
                    runLoop = false;
                }
            }
        }                       
        return totalChocolates;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int c = Convert.ToInt32(firstMultipleInput[1]);

            int m = Convert.ToInt32(firstMultipleInput[2]);

            int result = Result.chocolateFeast(n, c, m);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
