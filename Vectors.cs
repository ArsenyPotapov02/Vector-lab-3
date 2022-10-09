using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    public class Vectors
    {
        public double x, y, z;

        public Vectors(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;// параметры для плоскости
            
        }

        public Vectors()
        {
        }

        public double GetLenght()
        {
            return Math.Round(Math.Sqrt ( Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)), 5);
        }

        public static Vectors operator+(Vectors v1, Vectors v2)
        {
            return new Vectors(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vectors operator -(Vectors v1, Vectors v2)
        {
            return new Vectors(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public double GetScalar(Vectors vector)
        {
            return x * vector.x + y * vector.y + z * vector.z;
        }
       

        public static Vectors operator *(Vectors v1, Vectors v2)
        {
            return new Vectors(v1.y * v2.z - v1.z * v2.y, v1.z * v2.x - v1.x * v2.z, v1.x * v2.y - v1.y * v2.x);
        }

       
   
        public override string ToString()
        {
            return "{" + x + "; " + y + "; " + z + "}";
        }

        public override bool Equals(object obj)
        {
            return obj is Vectors vectors &&
                   x == vectors.x &&
                   y == vectors.y &&
                   z == vectors.z;
        }
    }
}
