// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точек А и В: ");
int[] points = new int[6];
string[] enterPoint = new string [] {"X1", "Y1", "Z1", "X2", "Y2", "Z2"};
for (int i = 0; i < enterPoint.Length; i++)
{
    Console.Write($"Введите {enterPoint[i]}: ");
    int point = Convert.ToInt32(Console.ReadLine());
    points [i] = point;
}
double result = Math.Round(Math.Sqrt((points[3] - points[0]) * (points[3] - points[0]) + (points[4] - points[1]) * (points[4] - points[1]) + (points[5] - points[2]) * (points[5] - points[2])), 2);
Console.WriteLine($"Растояние между точками координат: {result}");