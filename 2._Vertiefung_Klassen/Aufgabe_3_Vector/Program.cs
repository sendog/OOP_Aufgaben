namespace Aufgabe_3__Vector__30_Punkte_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(1, 1);
            Vector v2 = new Vector(1, 1);
            Console.WriteLine(1.0f * (float)v1);
            Console.WriteLine(-(v1 + v1 * 5.0f + ++v1));
            Console.WriteLine(new Vector(1, 1) + ++v2 * 10 + v2++);
            Console.WriteLine(v2);
            Console.WriteLine(v1);
            Console.WriteLine(v1 == v2 ? "ja" : "nein");
            Console.WriteLine
             (new Vector(1, 1) != new Vector(1, 1) ? "ja" : "nein");
        }

        class Vector
        {
            private float x { get; }
            private float y { get; }

            public Vector(float x, float y)
            {
                this.x = x;
                this.y = y;
            }

            public override string ToString()
            {
                return $"({x}/{y})";
            }


            public static Vector operator +(Vector v1, Vector v2) { return new Vector(v1.x + v2.x, v1.y + v2.y); }
            public static Vector operator *(float s, Vector v2) { return new Vector(s * v2.x, s * v2.y); }
            public static Vector operator *(Vector v1, float s) { return new Vector(v1.x * s, v1.y * s); }
            public static Vector operator ++(Vector v) { return (v + v); }
            public static Vector operator -(Vector v) { return new Vector(-v.x, -v.y); }
            public static bool operator ==(Vector v1, Vector v2) { return v1.x == v2.x && v1.y == v2.y; }
            public static bool operator !=(Vector v1, Vector v2) { return !(v1 == v2); }


            public static explicit operator float(Vector v) { return (float)Math.Sqrt(v.x * v.x + v.y * v.y); }

        }
    }
}
