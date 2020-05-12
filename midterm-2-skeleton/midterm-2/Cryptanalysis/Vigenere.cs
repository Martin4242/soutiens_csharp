using System;

namespace Cryptanalysis
{
public class Vigenere
{
    private string key;
    public const float FrenchIndexOfCoincidence = 0.0778F;
    public Vigenere(string key)
    {
        for (int i = 0; i < key.Length; i++)
        {
            if (Tools.LetterIndex(key[i]) == -1 )
            {
                throw new ArgumentException("la key n'est pas une lettre");
            }
        }
        
        this.key = key;
    }

    public string Encrypt(string msg)
    {
        int c = 0;
        string res = "";
        for (int i = 0; i < msg.Length; i++)
        {
            if (Tools.LetterIndex(msg[i]) != -1)
            {
                res += Tools.RotChar(msg[i], Convert.ToChar(key[c]));
                c += 1;
            }
            else
            {
                res += msg[i];
            }
            
            if (c == key.Length - 1)
            {
                c = 0;
            }
        }

        return res;
    }

    public string Decrypt(string cypherText)
    {
        int c = 0;
        string res = "";
        for (int i = 0; i < cypherText.Length; i++)
        {
            if (Tools.LetterIndex(cypherText[i]) != -1)
            {
                res += Tools.RotChar(cypherText[i], Convert.ToChar( -key[c]));
                c += 1;
            }
            else
            {
                res += cypherText[i];
            }

            if (c == key.Length - 1)
            {
                c = 0;
            }
        }

        return res;
    }

    public static string GuessKeyWithLength(string cypherText, int keyLength)
    {
        throw new NotImplementedException();
    }
    
    public static float IndexOfCoincidence(string str)
    {
        throw new NotImplementedException();
    }

    public static int GuessKeyLength(string cypherText)
    {
        throw new NotImplementedException();
    }
    
    public static string GuessKey(string cypherText)
    {
        throw new NotImplementedException();
    }
}
}
