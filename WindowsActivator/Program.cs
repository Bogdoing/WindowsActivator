using System.Diagnostics;

namespace WindowsActivator
{
    internal class Program
    {

        private string Activator_Win = "W269N-WFGWX-YVC9B-4J6C9-T83GX";

        static void Main(string[] args)
        {
            Console.WriteLine("Start cmd.exe!");

            Process.Start("cmd.exe", "/C " + "systeminfo");

            //Console.WriteLine("End cmd.exe!");

            Console.ReadKey();
        }
    }
}