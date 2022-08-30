Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"Кубы чисел до {N}: ");
for (int i = 1; i < N + 1; i++) Console.Write($"{i * i * i} ");