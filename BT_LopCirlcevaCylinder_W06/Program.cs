using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BT_LopCirlcevaCylinder_W06.Cilynder;

namespace BT_LopCirlcevaCylinder_W06
{
    internal class Program
    {
        public class Circle
        {
            private double radius;
            private string color;

            public Circle()
            {
                radius = 1.0;
                color = "red";
            }

            public Circle(double radius)
            {
                this.radius = radius;
                color = "red";
            }

            public Circle(double radius, string color)
            {
                this.radius = radius;
                this.color = color;
            }

            public double GetRadius()
            {
                return radius;
            }

            public void SetRadius(double radius)
            {
                this.radius = radius;
            }

            public string GetColor()
            {
                return color;
            }

            public void SetColor(string color)
            {
                this.color = color;
            }

            public double GetArea()
            {
                return Math.PI * radius * radius;
            }

            public override string ToString()
            {
                return $"Circle[radius={radius}, color={color}]";
            }
        }
            static void Main(string[] args)
            {
                Circle circle1 = new Circle();
                Console.WriteLine(circle1);

                Circle circle2 = new Circle(2.5);
                Console.WriteLine(circle2);

                Circle circle3 = new Circle(3.0, "blue");
                Console.WriteLine(circle3);
         

                Cylinder cylinder1 = new Cylinder();
                Console.WriteLine(cylinder1);

                Cylinder cylinder2 = new Cylinder(2.0, 3.0);
                Console.WriteLine(cylinder2);

                Cylinder cylinder3 = new Cylinder(1.5, 4.0, "green");
                Console.WriteLine(cylinder3);

                Console.ReadKey();
        }
        }
    }

