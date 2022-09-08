using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class LocalMethod
    {
        public void Run()
        {
            LocalRun("LocalRun 1번 호출");
            LocalRun("LocalRun 2번 호출");
            LocalRun("LocalRun 3번 호출");

            void LocalRun(string message)
            {
                Console.WriteLine(message);
            }
        }
    }
}
