using System;
using System.Collections.Generic;

//Объявить тип делегата
delegate string StrMod(string str);
class StringOps
{
    public static string ReplaseSpaces(string s)
    {
        Console.WriteLine("Замена пробелов дефисами");
        return s.Replace(' ', '-');
    }
    public static string RemoveSpaces(string s)
    {
        Console.WriteLine("Удаление пробелов");
        string temp = "";
        int i;
        for (i = 0; i < s.Length; i++)
        {
            if (s[i] != ' ')
            {
                temp += s[i];
            }
        }
        return temp;
    }
    public static string Reverce(string s)
    {
        string temp = "";
        int i, j;

        Console.WriteLine("Обращение строки");
        for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
        {
            temp += s[i];
        }
        return temp;
    }

}
class DelegateTest
{  
    static void Main()
    {        
        //Сконструировали делегат
        StrMod strOp = StringOps.ReplaseSpaces;
        string str;
        List<string> list = new List<string>();
        string s = "Это простой тест";

        //Вызвать методы с помощью делегата
        list.Add(strOp(s));
        strOp = StringOps.RemoveSpaces;
        list.Add(strOp(s));
        strOp = StringOps.Reverce;
        list.Add(strOp(s));
        foreach (String str1 in list) 
        {
            Console.WriteLine("Результирующая строка: {0}", str1);
        }
        Console.ReadKey();
    }
}

