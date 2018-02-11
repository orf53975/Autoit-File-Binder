using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

class Stub
{
    static Random random = new Random();
    public static string RandomString(int length)
    {
        const string pool = "abcdefghijklmnopqrstuvwxyzAZERTYUIOPQSDFGHJKLMWXCVBN";
        var builder = new StringBuilder();

        for (var i = 0; i < length; i++)
        {
            var c = pool[random.Next(0, pool.Length)];
            builder.Append(c);
        }

        return builder.ToString();
    }

    public static string Base64String(string file)
    {
        byte[] array = File.ReadAllBytes(file);
        return Convert.ToBase64String(array);
    }

    public static string ChuckSplit(string toSplit, string var, int chunkSize)
    {
        int strlength = toSplit.Length;

        int chunk = (int)Math.Ceiling((decimal)strlength / (decimal)chunkSize);
        var strarray = new string[chunk];

        int lengthRemaining = strlength;

        for (int i = 0; i < chunk; i++)
        {
            int lengthToUse = Math.Min(lengthRemaining, chunkSize);
            int startIndex = chunkSize * i;
            strarray[i] = toSplit.Substring(startIndex, lengthToUse);

            lengthRemaining = lengthRemaining - lengthToUse;
        }

        StringBuilder sb = new StringBuilder();
        sb.Append("\nLocal $" + var + "\n");
        foreach (string str in strarray)
        {
            sb.AppendLine("$" + var + " &= '" + str + "'");
        }
        return sb.ToString() + "\n";
    }
}