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
    //2D Array - DS
    public static int hourglassSum(List<List<int>> arr)
    {
        int current = 0;
        int max=int.MinValue;
        for(int i=0; i<4; i++){
            for(int j=0; j<4; j++){
                current += arr[i][j]+arr[i][j+1]+arr[i][j+2];
                current += arr[i+1][j+1];
                current += arr[i+2][j]+arr[i+2][j+1]+arr[i+2][j+2];
                if(current>max){
                    max=current;
                }
                current=0;
            }
        }
        Console.WriteLine(max);
        return max;
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
