using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_02
{
    //Lagyan mo pangalan Eugene ~ Ross
    class Program //Eugene Sumandi 
    {
        static void Main(string[] args)
        {
            int num = 20;
            for (int i = 0; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}