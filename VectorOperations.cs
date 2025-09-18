using OpenTK.Mathematics;

namespace Assignment_2
{
    public static class VectorOperations
    {
        public static Vector3 Add(Vector3 a, Vector3 b)
        {
            return a + b; 
        }

        public static Vector3 Subtract(Vector3 a, Vector3 b)
        {
            return a - b;
        }

        public static float Dot(Vector3 a, Vector3 b)
        {
            return Vector3.Dot(a, b);
        }

        public static Vector3 Cross(Vector3 a, Vector3 b)
        {
            return Vector3.Cross(a, b);
        }
    }
}