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
    public static int howManyGames(int p, int d, int m, int s)
    {
        int currentPrice = p;
        int budgetLeft = s;
        int totalGames = 0;  
        if(s >= p){
                while(budgetLeft >= m){
                    if(budgetLeft < currentPrice){
                        break;
                    }
                    if(currentPrice >= m){
                        budgetLeft = budgetLeft - currentPrice;
                        totalGames++;
                        currentPrice = currentPrice - d;
                    }
                    else{
                        budgetLeft = budgetLeft - m;
                        totalGames++;
                        currentPrice = m;
                    }
            }
        }                  
        return totalGames;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int p = Convert.ToInt32(firstMultipleInput[0]);

        int d = Convert.ToInt32(firstMultipleInput[1]);

        int m = Convert.ToInt32(firstMultipleInput[2]);

        int s = Convert.ToInt32(firstMultipleInput[3]);

        int answer = Result.howManyGames(p, d, m, s);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}
