using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

//int row = 8;

//var x = "*";

//for (int i = 0; i < row; i++)
//{
//    Console.Write(x);
//}
//    Console.WriteLine();

//for (int i = 0; i < row - 2; i++)
//{
//    Console.Write(x);

//    for (int j = 0; j < row - 2; j++)
//    {
//        Console.Write(" ");
//    }
//    Console.WriteLine(x);
//}
//for (int i = 0; i < row; i++)
//{
//    Console.Write(x);
//}
//Console.WriteLine();


//string case1 = "The qUick!  bRoWn fox    jumped OVER the    lazy dog";
//string case2 = "The qUick!  bRoWn fox    jumped, OVER the    lazy. dog";

//string correctedCase = "";

//List<string> list = case1.ToLower().Split(' ').ToList();

//list.RemoveAll(s => s == "");

//for (int i = 0; i < list.Count; i++)
//{
//    list[i] = string.Concat((list[i])[0].ToString().ToUpper()) + list[i].Substring(1);

//}
//correctedCase = string.Join("", list);
//correctedCase = Regex.Replace(correctedCase, "[^0-9A-Za-z _-]", "");
//Console.WriteLine(correctedCase);


//************************************
// KATA C# nro 1
//public class Example
//{
//    public static void Main()
//    {
//        string case1 = "The qUick!  bRoWn fox    jumped, OVER the    lazy. dog";
//        List<string> list = case1.ToLower().Split(' ').ToList();
//        list.RemoveAll(s => s == "");

//        string correctedCase = Converter(list);
//        Console.WriteLine(correctedCase);

//    }

//    private static string Converter(List<string> list)
//    {
//        string x = "";
//        for (int i = 0; i < list.Count; i++)
//        {
//            list[i] = string.Concat((list[i])[0].ToString().ToUpper()) + list[i].Substring(1);

//        }
//        x = string.Join("", list);
//        x = Regex.Replace(x, "[^0-9A-Za-z _-]", "");
//        return x;
//    }
//}
//*********************************


// KATA C# nro 2: Simplifying Fractions
public class Example
{
    public static void Main()
    {
        Console.WriteLine(Fractions("4/6"));
        Console.WriteLine(Fractions("10/11"));
        Console.WriteLine(Fractions("100/400"));
        Console.WriteLine(Fractions("8/4"));
        Console.WriteLine(Fractions("8/8"));
        Console.WriteLine(Fractions("12/4"));

    }

    private static string Fractions(string fraction)
    {
        string fraction1 = fraction;

        int num1 = int.Parse(fraction1.Split('/')[0]);
        int num2 = int.Parse(fraction1.Split('/').Last());
        int gcd = 1;


        for (int i = 1; i <= num1; i++)
        {
            if (num1 % i == 0 && num2 % i == 0)
            {
                gcd = i;
            }
        }

        num1 = num1 / gcd;
        num2 = num2 / gcd;

        if (num2 == 1)
        {
            string result = num1.ToString();
            return result;

        }
        else
        {

            return (num1 + "/" + num2);
        }

    }

}



