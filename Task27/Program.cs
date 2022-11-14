// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число: "); 
int n = int.Parse(Console.ReadLine()!); 
SumN(n);


void SumN(int n)
{
    int sum = 0;
    for (int i = 0; i <= n; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}


