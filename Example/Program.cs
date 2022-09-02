using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            AsynchronousExample example = new AsynchronousExample();
            //example.RunWait();
            Console.WriteLine();
            example.RunAsync();
        }
    }
}
