using System;


namespace hometask9.models;

public static class Extension
{




    public static void MatchCount(this string sentence, string word)
    {
        int result = 0;
        int j = 0;
        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] == word[j])
            {
                j++;
                if (j == word.Length)
                {
                    result++;
                    j = 0;

                }
            }
            else
            {
                j = 0;
            }
        }
        Console.WriteLine($"soz tekrari{result}");
    }
}