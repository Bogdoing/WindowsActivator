using System.Diagnostics;

namespace WindowsActivator
{
    internal class Program
    {
        //slmgr/ipk "W269N-WFGWX-YVC9B-4J6C9-T83GX"
        //slmgr /skms kms.digiboy.ir
        //slmgr /ato
        private string Activator_Win_Key = "W269N-WFGWX-YVC9B-4J6C9-T83GX";

        static void Main(string[] args)
        {
            Console.WriteLine("Start cmd.exe!");

            Console.WriteLine(
                "1 - Activator Win 10-11 Pro \r\n" +
                "2 - systeminfo \r\n"
            );

            int menu_i = Convert.ToInt32(Console.ReadLine());

            switch (menu_i)
            {
                case 1:
                    break;
                case 2:
                    Process.Start("cmd.exe", "/C " + "systeminfo");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Undefaint menu item");
                    break;
            }

                       
            Console.WriteLine("End cmd.exe!");

            
        }
    }
}