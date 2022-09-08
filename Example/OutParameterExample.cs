using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class OutParameterExample
    {
        public void Run()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.X = 10;
            rectangle.Y = 20;
            GetRectangleArea(rectangle, out int area);
            Console.WriteLine($"가로 = {rectangle.X}, 세로 = {rectangle.Y} 사각형의 넓이는 = {area}");
        }

        private void GetRectangleArea(Rectangle rectangle ,out int area)
        {
            area = rectangle.X * rectangle.Y;
        }
    }

    class Rectangle
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
