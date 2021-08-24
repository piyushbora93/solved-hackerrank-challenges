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
    public static string appendAndDelete(string s, string t, int k)
    {        
        int count = 0;
        int i = s.Length - 1;
        if(s.Length > t.Length){
                while(i > -1){
                s = s.Remove(i, 1);
                i--;
                count++;
                if(s == t || (s.Length <= t.Length && s == t.Substring(0, s.Length))){
                    break;
                }                                
            }
            if(count <= k){
                if(s == t){
                    count = count;
                }
                else if(s != t && s == t.Substring(0, s.Length)){
                    count = count + t.Length - s.Length;                    
                }
                else{
                    count = count + t.Length;                    
                }
            }            
        }
        else if(s.Length == t.Length){
            while(i > -1){
                s = s.Remove(i,1);
                i--;
                count++;
                if(s == t.Substring(0, s.Length)){
                    break;
                }
            }
            if(count <= k){
                if(s == t){
                    count = count;
                }
                else if(s != t && s == t.Substring(0, s.Length)){
                    count = count + t.Length - s.Length;                    
                }
            }
        }
        else{            
             if(s == t.Substring(0, s.Length) && (t.Length - s.Length < k)){
                while(i > -1){
                    s = s.Remove(i,1);
                    i--;
                    count++;
                    if(s == t.Substring(0, s.Length)  && (count + t.Length - s.Length == k )){
                        break;
                    }                    
                }
                if(s.Length == 0){
                    count = count + t.Length;                    
                }
                else{
                    count = count + t.Length - s.Length;
                }
                
            }            
        }       
        string result = count <= k ? "Yes" : "No";
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string t = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.appendAndDelete(s, t, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
