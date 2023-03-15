
//affine
// 2 key
//liter u s

//a=3 b=7
// e(x)=(a*x+b)%26
//e(b)=(3*1+7)%26

//a=3 b=7
// d(x)=a-1*(x-b)%26
//d(b)=9*(1-7)%26

//key-1?????????

using System;

public static class Globals
{
    //Key values of a and b
    public static readonly int a = 3;
    public static readonly int b = 7;
    public static string encryptMessage(string msg)
    {
        ///Cipher Text initially empty
        string cipher = "";
        for (int i = 0; i < msg.Length; i++)
        {

            if (msg[i] >= 65 && msg[i] <= 90)
            {
                cipher = cipher + (char)((((a * (msg[i] - 65)) + b) % 26) + 65);
            }
            else if (msg[i] >= 97 && msg[i] <= 122)
            {
                cipher = cipher + (char)((((a * (msg[i] - 97)) + b) % 26) + 97);
            }
            else
            {
                cipher += msg[i];
            }
        }
        return cipher;
    }


    public static string decryptMessage(string msg)
    {
        int a = 3;
        int a_inverse=0;
        for (int i = 1; i <= 26; i++)
        {
            if (((i * a) % 26) == 1)
            {
                a_inverse = i;
            }



        }


        string plain = "";
        for (int i = 0; i < msg.Length; i++)
        {

            if (msg[i] >= 65 && msg[i] <= 90)
            {
                plain = plain + (char)(((a_inverse * ((msg[i] + 65 - b)) % 26)) + 65);
            }
            else if (msg[i] >= 97 && msg[i] <= 122)
            {
                plain = plain + (char)(((a_inverse * ((msg[i] + 97 - b)) % 26)) + 93);
            }
        }
        return plain;
    }
    internal static void Main()
    {

        string str = "afdine";
        string enc = encryptMessage(str);
        Console.Write(enc);
        Console.Write("\n");
        Console.Write(decryptMessage(enc));
        Console.Write("\n");

        Console.Write("\n");
       
    }
}
