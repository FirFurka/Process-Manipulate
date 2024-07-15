using System;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
class ProgrammManipulate
{
    static void Main(string[] args)
    {
        //GetAllProcesses();
        //FindInProcesses();
        //KillProcesses();

        Console.ReadKey();
    }
    static void GetAllProcesses()
    {
        Process.GetProcesses().ToList().ForEach(p =>
        {
            Console.WriteLine(p.ProcessName + " p.Threads.Count=" + p.Threads.Count + " Id=" + p.Id);
            Process[] ProcessesList = Process.GetProcesses();
        });
    }

    static void FindInProcesses()
    {
        string[] ToLookProcesses = { "discord", "firefox" };
        int slot = 0;
        Process.GetProcesses().ToList().ForEach(p =>
        {
            for (p.ProcessName.ToString().ToLower().Contains(ToLookProcesses[slot] = ToLookProcesses[slot]); slot <= ToLookProcesses.Length-1; slot++)
            {
                if (p.ProcessName.ToString().ToLower().Contains(ToLookProcesses[slot] = ToLookProcesses[slot]))
                {
                    Console.WriteLine(string.Format("Слово '{0}' содержится в массиве, ID: {1}", ToLookProcesses[slot], p.Id));
                }
            }
            slot = 0;
        });
    }
    static void KillProcesses()
    {
        int slot = 0;
        string[] ToLookProcesses = {"discord","firefox"};
        Process.GetProcesses().ToList().ForEach(p =>
        {
            for (p.ProcessName.ToString().ToLower().Contains(ToLookProcesses[slot] = ToLookProcesses[slot]); slot <= ToLookProcesses.Length - 1; slot++)
            {
                if (p.ProcessName.ToString().ToLower().Contains(ToLookProcesses[slot] = ToLookProcesses[slot]))
                {
                    foreach (Process process in Process.GetProcessesByName(ToLookProcesses[slot]))
                    {
                        process.Kill();
                    }
                }
            }
            slot = 0;
        });
    }
}
