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
         
    public static long taumBday(int b, int w, int bc, int wc, int z)
    {
        var blackGift = Convert.ToInt64(b);
        var whiteGift = Convert.ToInt64(w);
        var blackCost = Convert.ToInt64(bc);
        var whiteCost = Convert.ToInt64(wc);
        var conversionCost = Convert.ToInt64(z);
        long minimumExpense = 0;
        if(blackCost != whiteCost){
            long difference = Math.Abs(blackCost - whiteCost);            
            if(difference > conversionCost){                
                minimumExpense = blackCost > whiteCost ? ((blackGift * (whiteCost + conversionCost)) + whiteGift * whiteCost) : (blackGift * blackCost + (whiteGift * (blackCost + conversionCost)));
            }
            else{
                minimumExpense = blackGift * blackCost + whiteGift * whiteCost;      
            }
        }
        else{
            minimumExpense = blackGift * blackCost + whiteGift * whiteCost;
        }
        return minimumExpense;
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

            int b = Convert.ToInt32(firstMultipleInput[0]);

            int w = Convert.ToInt32(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int bc = Convert.ToInt32(secondMultipleInput[0]);

            int wc = Convert.ToInt32(secondMultipleInput[1]);

            int z = Convert.ToInt32(secondMultipleInput[2]);

            long result = Result.taumBday(b, w, bc, wc, z);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
