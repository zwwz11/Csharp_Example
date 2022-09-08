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
            AsynchronousExample asynchronousExample = new AsynchronousExample();
            ExceptionFilterExample exceptionFilterExample = new ExceptionFilterExample();
            OutParameterExample outParameterExample = new OutParameterExample();
            TupleExample tupleExample = new TupleExample();
            LocalMethod localMethod = new LocalMethod();

            localMethod.Run();
        }
    }
}
