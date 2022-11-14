// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

Console.WriteLine("Введите число А"); 
int numA = int.Parse(Console.ReadLine()!); 
Console.WriteLine("Введите число В"); 
int numB = int.Parse(Console.ReadLine()!);
Grade(numA, numB);


void Grade(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = result * numA;
    }
    Console.WriteLine("Результат возведения в степень " + result);
}
