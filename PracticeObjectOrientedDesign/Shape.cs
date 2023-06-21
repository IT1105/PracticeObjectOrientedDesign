using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectOrientedDesign
{
    public class Shape: Circle, Triangle, Square
    {
        public double Radius { get; set; }
        public double SideLength { get; set; }
        // ... 他の共通のプロパティやメソッド ...

        public virtual void AllArea(double radius,double sidelenght)
        {
            Console.WriteLine("円の面積: " + CircleArea(Radius));
            Console.WriteLine("正方形の面積: " + SquareArea(SideLength));
            Console.WriteLine("三角形の面積:" + TriangleArea(SideLength));
        }
    public double CircleArea(double radius)
    {
        return Math.PI * (Math.Pow(radius, 2));
    }
    public double TriangleArea(double sidelenght)
    {
        return Math.Pow(sidelenght, 2) / 2;
    }
    public double SquareArea(double sidelenght)
    {
        return Math.Pow(sidelenght, 2);
    }
}
}
