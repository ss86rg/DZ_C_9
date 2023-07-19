// Задача 1: Задайте значения M и N. Напишите программу, которая выведет
// все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"

int M = ReadInt("Введите m");
int N = ReadInt("Введите n");
positivNum(M, N);

int ReadInt(string massage)
{
    System.Console.WriteLine(massage);
    return Convert.ToInt32(Console.ReadLine());
}


void positivNum(int arg1, int arg2)
{
    if (arg1 <= arg2)
    {
        return;
    }
    positivNum(arg2-1);
    System.Console.WriteLine(arg2);
    
}

