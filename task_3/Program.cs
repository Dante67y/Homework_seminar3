// Напишите программу, которая принимает на вход число N и выдаёт таблицу кубов чисел от 1 до N

// int n;
// n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++)
// {
//     Console.WriteLine(i * i * i);
// }

int n, i = 1;
n = Convert.ToInt32(Console.ReadLine());
while (i <= n)
{
    Console.WriteLine(i * i * i);
    i++;
}
