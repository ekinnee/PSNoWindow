using System;
using System.Collections.ObjectModel;
using System.Management.Automation;

namespace PSNoWindow
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PSDataCollection results;
            
            using (PowerShell ps = PowerShell.Create())
            {
                var script = @".\Get-AllTechnicians.ps1";
                ps.AddScript(File.ReadAllText(script));
                ps.AddParameter("User", "me");
                IAsyncResult asyncres = ps.BeginInvoke();
                do
                {
                    //Wait
                }
                while (!asyncres.IsCompleted);

                results = ps.EndInvoke(asyncres);
           }
        }
    }
}

