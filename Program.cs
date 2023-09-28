using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lexico2
{
    class Program
    {
        static void Main(string[] args) 
        {
            try
            {
                using (Lexico L = new Lexico())
                {
                    while (!L.FinArchivo())
                    {
                        L.nextToken();
                    }
                }
            } 

        }
    }
}