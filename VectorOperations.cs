using OpenTK.Mathematics;

namespace Assignment_2
{
    public static class VectorOperations
    {
        public static Vector3 Add(Vector3 a, Vector3 b)
        {
            return a + b; // OpenTK's Vector3 supports operator overloading
        }

        public static Vector3 Subtract(Vector3 a, Vector3 b)
        {
            return a - b;
        }

        public static float Dot(Vector3 a, Vector3 b)
        {
            return Vector3.Dot(a, b); // OpenTK's built-in dot product
        }

        public static Vector3 Cross(Vector3 a, Vector3 b)
        {
            return Vector3.Cross(a, b); // OpenTK's built-in cross product
        }
    }
}