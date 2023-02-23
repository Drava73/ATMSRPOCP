using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSRPOCP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                ATM card = new ATM();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(1);
            }
        }
    }
}
