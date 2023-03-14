using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_14
{
    public class Bullet : IShape
    {
        private double radius;

        public Bullet()
        {
            this.radius = 0;
        }

        public Bullet(double radius)
        {
            this.radius = radius;
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double GetVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }

        public void print_val()
        {
            Console.WriteLine($"Volume: {GetVolume():F2}");
        }
    }
}
