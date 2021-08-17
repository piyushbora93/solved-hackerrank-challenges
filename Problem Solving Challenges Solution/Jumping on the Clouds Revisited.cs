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

class Solution {

    static int jumpingOnClouds(int[] c, int k) {
        int energy = 100;
        int index = 0;
        while(index > -1){
            index = (index + k) % c.Length;            
            if(c[index] == 0){
                energy--;
                index = index;
            }
            else{
                energy = energy - 3; //Read the problem carefully. It says it loses -1 energy on every jump and an extra -2 when it lands on a cloud numbered 1.
            }
            
            if(index == 0){
                break;
            }            
        }
        return energy;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int result = jumpingOnClouds(c, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
