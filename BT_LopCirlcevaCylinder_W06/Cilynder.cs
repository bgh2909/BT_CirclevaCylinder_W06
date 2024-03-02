using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BT_LopCirlcevaCylinder_W06.Program;

namespace BT_LopCirlcevaCylinder_W06
{
    internal class Cilynder
    {
        public class Cylinder : Circle
        {
            private double height;

            public Cylinder()
            {
                height = 1.0;
            }

            public Cylinder(double radius, double height) : base(radius)
            {
                this.height = height;
            }

            public Cylinder(double radius, double height, string color) : base(radius, color)
            {
                this.height = height;
            }

            public double GetHeight()
            {
                return height;
            }

            public void SetHeight(double height)
            {
                this.height = height;
            }

            public double GetVolume()
            {
                return GetArea() * height;
            }

            public override string ToString()
            {
                return $"Cylinder[radius={GetRadius()}, height={height}, color={GetColor()}]";
            }
        }
    }
}
