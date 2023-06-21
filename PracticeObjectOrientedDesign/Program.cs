using Microsoft.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectOrientedDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape sharp = new Shape();

            sharp.Radius = 10;
            sharp.SideLength = 5;

            sharp.AllArea(sharp.Radius, sharp.SideLength);
        }
    }
}
