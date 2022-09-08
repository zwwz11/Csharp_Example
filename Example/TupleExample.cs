using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class TupleExample
    {
        public void Run()
        {
            List<int> data = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };
            Calculate(data);

            var result = Calculate(data);
            Console.WriteLine($"Sum : {result.sum}");
            Console.WriteLine($"Avg : {result.avg}");
        }

        private (int sum, double avg) Calculate(List<int> data)
        {
            int sum = 0;
            double avg = 0;

            sum = data.AsEnumerable().Sum();
            avg = data.AsEnumerable().Average();

            return (sum, avg);
        }
    }
}
