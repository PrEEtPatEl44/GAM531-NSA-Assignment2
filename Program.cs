// Program.cs
using System;
using OpenTK.Mathematics;

namespace Assignment_2
{
    class Program
    {
        static void Main()
        {
            //sample vectors
            Vector3 v1 = new Vector3(2, 2, 3);
            Vector3 v2 = new Vector3(7, 5, 6);


            Console.WriteLine("VECTOR OPERATIONS\n\n");
            //vector operations
            Console.WriteLine($"Addition= {VectorOperations.Add(v1, v2)}");
            Console.WriteLine($"Subtraction= {VectorOperations.Subtract(v1, v2)}");
            Console.WriteLine($"Dot Product= {VectorOperations.Dot(v1, v2)}");
            Console.WriteLine($"Cross Product= {VectorOperations.Cross(v1, v2)}");

            Console.WriteLine("\nMATRIX OPERATIONS\n\n");
            //matrix operations
            Matrix4 identity = MatrixOperations.Identity();
            Matrix4 translation = MatrixOperations.Translation(3f, 4f, 5f);
            Matrix4 rotation = MatrixOperations.RotationZ(MathHelper.DegreesToRadians(90)); 
            Matrix4 scale = MatrixOperations.Scale(4f);

            Vector4 v3 = new Vector4(1, 6, -9, 0); //sample vector for transformation

            Matrix4 transform = translation * rotation * scale;
            Vector4 transformedV3 = transform * v3;


            //matrix transformation
            Console.WriteLine($"Identity Matrix= {identity}");
            Console.WriteLine($"Translation Matrix (3, 4, 5)= {translation}");
            Console.WriteLine($"Rotation Matrix 90 degree on z axid= {rotation}");
            Console.WriteLine($"Scale Matrix scale by 4= {scale}");
            Console.WriteLine($"Combined Transformation Matrix= {transform}");
            Console.WriteLine($"Original Vector= {v3}");
            Console.WriteLine($"Transformed Vector= {transformedV3}");

        }
    }
}