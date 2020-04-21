using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    class Vector
    {
        public double x, y, z;
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Z { get => z; set => z = value; }
        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Vector()
        {
        }

        public static Vector operator +(Vector obj1, Vector obj2)
        {
            Vector arr = new Vector();
            arr.x = obj1.x + obj2.x;
            arr.y = obj1.y + obj2.y;
            arr.z = obj1.z + obj2.z;
            return arr;
        }
        public static double operator %(Vector obj1, Vector obj2)
        {
            return obj1.x * obj2.x + obj1.y * obj2.y + obj1.z * obj2.z;
        }
        public static Vector operator *(Vector obj1, Vector obj2)
        {
            Vector arr = new Vector();
            arr.x = obj1.y * obj2.z - obj1.z * obj2.y;
            arr.y = obj1.z * obj2.x - obj1.x * obj2.z;
            arr.z = obj1.x * obj2.y - obj1.y * obj2.x;
            return arr;
        }
        public static string cos(Vector obj)
        {
            double v1mod = Math.Sqrt(Math.Pow(obj.x, 2) + Math.Pow(obj.y, 2) + Math.Pow(obj.z, 2));
            double cosa = obj.x / v1mod;
            double cosb = obj.y / v1mod;
            double cosg = obj.z / v1mod;
            return "    Cosa = " + String.Format("{0:0.###}", cosa) + "; " + "Cosb = " + String.Format("{0:0.###}", cosb) + "; " + "Cosg = " + String.Format("{0:0.###}", cosg);
        }
        public static string OutPut(Vector obj)
        {
            return "{   " + obj.x + "; " + obj.y + "; " + obj.z + "   }" + Vector.cos(obj);
        }
    }
}
