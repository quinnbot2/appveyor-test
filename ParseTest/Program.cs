using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibTest;

namespace ParseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ParserClass foo = new ParserClass();

            foo.Parse("parse this file"); 

            Console.ReadLine();
        }
    }
}
