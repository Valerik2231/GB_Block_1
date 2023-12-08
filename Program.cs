using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] input = {"Hello", "2", "World", ":-)" };
        int count = 0;
        int resultcount = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Length <=3)
            {
                count++;
            }
        }
        var result = new string[count];
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Length <= 3)
            {
                result[resultcount] = input[i];
                resultcount++;
            }
        }
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }

    





}





