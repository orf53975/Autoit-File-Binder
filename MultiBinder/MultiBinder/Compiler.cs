using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;

class Compiler
{
	public static void Compil(string script, string output)
    {
        string compiler = Path.GetTempPath() + "Aut2Exe.exe";
        File.WriteAllBytes(compiler, MultiBinder.Properties.Resources.Aut2exe);
        Process P = new Process();
        P.StartInfo.FileName = compiler;
        P.StartInfo.WorkingDirectory = Path.GetTempPath();
        P.StartInfo.Arguments = "/in " + script + " /out " + output;
        P.Start();
        P.WaitForExit();

    }
}
