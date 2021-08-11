using System;
using Modele;
using StubPers;
using System.Linq;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            User u  = new User("iubgfgf", "jhbfduhbfd", "fiybiuyfdbuydbgf");
            User u1 = new User("iubgfgf", "jhbfduhbfd", "fiybiuyfdbuydbgf");
            User u2 = new User("iubgfgf", "jhbfduhbfd", "fiybiuyfdbuydbgf");
            User u3 = new User("iubgfgf", "jhbfduhbfd", "fiybiuyfdbuydbgf");
            Console.WriteLine( u.ToString());
            Console.WriteLine( u1.ToString());
            Console.WriteLine( u2.ToString());
            Console.WriteLine( u3.ToString());
           
            


        }
    }
}
