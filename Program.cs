using System;
using System.Net.Security;
using System.Threading.Tasks;

namespace MyApp
{
    class Program
    {
        static string? a = null;
        
        static void Main(string[] args)
        {
             A();
             B();

        }

        public static void A()
        {
            Console.WriteLine(a+"A");
        }

        public static void B()
        {
            a = "hello";
            Console.WriteLine(a+"B");
        }
       
    }

        
}
