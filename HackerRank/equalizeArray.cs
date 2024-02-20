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

    /*
     * Complete the 'equalizeArray' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int equalizeArray(List<int> arr)
    {
        int maxCount = int.MinValue;
        int count = 1;
        int maxCountVal = 0;
        arr.Sort();
        for(int i=0; i<arr.Count-1; i++){
            // Console.WriteLine(arr[i]);
            if(arr[i]==arr[i+1]) {
                count++;
                // Console.WriteLine(count);
                // Console.WriteLine("here?");
                
            }
            else{
                count=1;
            }
            if(count>=maxCount) {
                maxCount=count;
                maxCountVal=arr[i];
                // Console.WriteLine(maxCount);
                // Console.WriteLine(maxCountVal);
                // Console.WriteLine("there?");
            }
        }
        // Console.WriteLine(maxCount);
        // Console.WriteLine(maxCountVal);
        
        return arr.Count-maxCount; 
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.equalizeArray(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}