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


    public static List<int> breakingRecords(List<int> scores)
    {
        List<int> result = new List<int>();
        int maximumScore = scores.First();
        int minimumScore = scores.First();
        int maxScoreCount = 0;
        int minScoreCount = 0;
        foreach(int currentScore in scores){
            if(currentScore > maximumScore){
                maximumScore = currentScore;
                maxScoreCount++;                
            }
            if(currentScore < minimumScore){
                minimumScore = currentScore;
                minScoreCount++;
            }
        }
        
        result.Add(maxScoreCount);
        result.Add(minScoreCount);
        return result;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
