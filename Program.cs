using System;
using System.Collections.ObjectModel;
using System.Management.Automation;

namespace PSNoWindow
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (PowerShell ps = PowerShell.Create())
            {

                Collection<PSObject> results = ps.AddScript("Get-Process | Sort-Object WorkingSet | Select-Object ProcessName, WorkingSet").Invoke();
                /*
                for (int i = 0; i < results.Count; i++)
                {
                    Console.WriteLine(results[i].Properties["ProcessName"]);
                    Console.WriteLine(results[i].Properties["WorkingSet"]);
                }
                */
                //Console.ReadKey();
            }
        }
    }
}

