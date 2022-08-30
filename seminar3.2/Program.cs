int[] A = new int[3];
int[] B = new int[3];

Console.WriteLine("Введите координаты точки А: ");
Console.Write("X: ");
A[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
A[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
A[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("X: ");
B[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
B[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
B[2] = Convert.ToInt32(Console.ReadLine());

double DistanceBetweenPoints(int[] a, int[] b)
{
    return Math.Sqrt(Math.Pow((b[0] - a[0]), 2) + Math.Pow((b[1] - a[1]), 2) + Math.Pow((b[2] - a[2]), 2));
}

Console.Write($"Расстояние между точкой А({A[0]}, {A[1]}, {A[2]}) и точкой B({B[0]}, {B[1]}, {B[2]}) равно {DistanceBetweenPoints(A, B)}");




// int digit = Convert.ToInt32(Console.ReadLine());

// if (digit < 10000 || digit > 99999) Console.Write("Число не пятизначное");
// else if (CheckPalindrome(digit) == true) Console.Write($"Число {digit} является палиндромом");
// else Console.Write($"Число {digit} не является палиндромом");