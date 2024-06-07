using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_sharp_App_ArielM.BankApp;
using C_sharp_App_ArielM.DraftApp;
using C_sharp_App_ArielM.SportApp;
using C_sharp_App_ArielM.TransportationApp;

namespace C_sharp_App_ArielM.PrimeMain
{
    internal class RunMain
    {
        public static void RunMe()
        {
            Console.WriteLine("1 – Bank App | 2 – Sport App | 3 – Transportation App | 4 – Draft App | 0- Exit");
            int num = int.Parse(Console.ReadLine());
            while (num != 0)
            {

                switch (num)
                {
                    case 1:
                        BankAppMain.MainEntry();
                        break;
                    case 2:
                        SportAppMain.MainEntry();
                        break;
                    case 3:
                        TransportationAppMain.MainEntry();
                        break;
                    case 4:
                        DraftAppMain.MainEntry();
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;

                         
                }
                num = int.Parse(Console.ReadLine());
            }
        }
    }
}
