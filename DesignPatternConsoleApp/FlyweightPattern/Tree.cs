using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    public class Tree
    {
        public void Display(int x, int y, int age) {
            Console.WriteLine($"坐标：{x},{y}  树龄：{age}");
        }
    }
}
