﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

double x, y, z, x1, y1, z1, len;
x = Convert.ToDouble(Console.ReadLine());
y = Convert.ToDouble(Console.ReadLine());
z = Convert.ToDouble(Console.ReadLine());
x1 = Convert.ToDouble(Console.ReadLine());
y1 = Convert.ToDouble(Console.ReadLine());
z1 = Convert.ToDouble(Console.ReadLine());
len = Math.Cbrt((x - x1) * (x - x1) * (x - x1) + (y - y1) * (y - y1) * (y - y1) + (z - z1) * (z - z1) * (z - z1));
Console.WriteLine(len);
