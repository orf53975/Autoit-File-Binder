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

    public static string ChunkBase64(string base64, string varname)
    {
        int chunkSize = 400;
        int stringLength = base64.Length;
        string splitted = "\nLocal $" + varname + "\n";
        for (int i = 0; i < stringLength; i += chunkSize)
        {
            if (i + chunkSize > stringLength) chunkSize = stringLength - i;
            string commande = "$" + varname + " &= '" + base64.Substring(i, chunkSize) + "'\n";
            splitted += commande;
        }
        return splitted;
    }
}