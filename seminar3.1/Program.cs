Boolean CheckPalindrome(int a)
{
    int a1 = a % 10;
    int a2 = a / 10 % 10;
    int a3 = a / 1000 % 10;
    int a4 = a / 10000;

    if (a1 == a4 && a2 == a3) return true;
    else return false;
}

Console.Write("Введите пятизначное число: ");
int digit = Convert.ToInt32(Console.ReadLine());

if (digit < 10000 || digit > 99999) Console.Write("Число не пятизначное");
else if (CheckPalindrome(digit) == true) Console.Write($"Число {digit} является палиндромом");
else Console.Write($"Число {digit} не является палиндромом");

