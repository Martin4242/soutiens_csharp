using System;
using System.ComponentModel.DataAnnotations;

namespace Cryptanalysis
{
public static class Tools
{
    public static int Modulus(int a, int b)
    {
        if (b < 0)
            b = -b;
        
        var mod = a % b;
        return mod < 0 ? b + mod : mod;
    }

    public static int LetterIndex(char c)
    {
        int m = Convert.ToInt32(c);
        if (m >= 65 && m <= 90)
        {
            m -= 65;
            return m;
        }

        if (m >= 97 && m <= 122)
        {
            m -= 97;
            m += 26;
            return m;
        }

        return -1;
    }

    public static char RotChar(char c, int n)
    {
        int m = LetterIndex(c);
        if (m == -1)
        {
            return c;
        }
        if (m < 26)
        {
            m = Modulus(m + n, 26);
            return Convert.ToChar(m + 65);
        }

        if (m > 26 && m < 52)
        {
            m = Modulus(m + n, 26);
            return Convert.ToChar(m + 97);
        }
        else
        {
            return c;
        }
    }

    public static int[] Histogram(string str)
    {
        int[] hist = new int[26];

        for (int i = 0; i < str.Length; i++)
        {
            int m = Modulus(LetterIndex(str[i]), 26);
            if (m > -1 && m < 51)
            {
                hist[m] += 1;
            }
        }

        return hist;
    }
    
    public static string FilterLetters(string str)
    {
        string res = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (LetterIndex(str[i]) != -1)
            {
                res += str[i];
            }
        }

        return res;
    }

    public static string Extract(string str, int start, int step)
    {
        string res = "";
        string res2 = "";
        int j = 0;
        
        for (int i = start; i < str.Length; i++)
        {
            res += str[i];
        }

        while (j < res.Length)
        {
            res2 += res[j];
            j += step;
        }
        
        return res2;
    }
}
}
