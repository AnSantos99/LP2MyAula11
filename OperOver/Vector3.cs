using System;
using System.Collections.Generic;
using System.Text;

namespace OperOver
{
    struct Vector3
    {
        
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Vector3(float a, float b, float c) 
        {
            X = a;
            Y = b;
            Z = c;
        }


        public float Magnitude =>
            (float)Math.Sqrt(X * X+ Y * Y + Z * Z);

        public static bool operator >(Vector3 v1, Vector3 v2)
            => v1.Magnitude > v2.Magnitude;

        public static bool operator <(Vector3 v1, Vector3 v2)
            => v1.Magnitude < v2.Magnitude;







    }
}
