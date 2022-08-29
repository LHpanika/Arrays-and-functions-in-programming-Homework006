// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. // Первые два числа Фибоначчи: 0 и 1.// Если N = 5 -> 0 1 1 2 3// Если N = 3 -> 0 1 1// Если N = 7 -> 0 1 1 2 3 5 8
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int []  Fibo = new int[number];
Fibo[0] = 0;Fibo[1] = 1;
for (int i=2; i<Fibo.Length; i++)
{    Fibo[i] = Fibo [i-1] + Fibo [i-2];}
Console.WriteLine(string.Join(" , ", Fibo));