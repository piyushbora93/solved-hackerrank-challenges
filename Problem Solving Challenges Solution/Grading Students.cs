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
    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> finalScores = new List<int>();
        int nextHigherVal = 0;
        foreach(var score in grades){
            if(score >= 38){
                if(score % 5 == 0){
                    finalScores.Add(score);
                }
                else if(score % 5 > 2){
                    finalScores.Add(5 * (score / 5) + 5);
                }
                else{
                    finalScores.Add(score);
                }
            }
            else{
                finalScores.Add(score);
            }
        }    
        finalScores.OrderByDescending(i => i);   
        return finalScores;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
