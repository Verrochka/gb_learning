// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

void print3Ddistance(double aX, double aY, double aZ, double bX, double bY, double bZ)
{
    double deltaX = aX - bX;
    double deltaY = aY - bY;
    double deltaZ = aZ - bZ;
    double c = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    Console.WriteLine($"Расстояние между точками в 3D пространстве равно {c}");
}

print3Ddistance(3, 6, 8, 2, 1, -7);
