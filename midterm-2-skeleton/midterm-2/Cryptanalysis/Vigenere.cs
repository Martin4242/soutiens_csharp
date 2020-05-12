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
        throw new NotImplementedException();
    }

    public string Decrypt(string cypherText)
    {
        throw new NotImplementedException();
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
