// MatrixOperations.cs
using OpenTK.Mathematics;

namespace Assignment_2
{
    public static class MatrixOperations
    {
        public static Matrix4 Identity()
        {
            return Matrix4.Identity;
        }

        public static Matrix4 Scale(float a)
        {
            return Matrix4.CreateScale(a);
        }

        public static Matrix4 RotationZ(float angle) // angle in radians
        {
            return Matrix4.CreateRotationX(angle); 
        }

        public static Matrix4 Translation(float x, float y, float z)
        {
            return Matrix4.CreateTranslation(x, y, z);
        }

    }
}