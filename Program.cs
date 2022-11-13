/* Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

void NaturalNumbersSum(int M, int N)
{
    if (M < 0)
    {
        Console.WriteLine($"Введённое число {M} - не натуральное число.");
        return;
    }
    if (N < 0)
    {
        Console.WriteLine($"Введённое число {N} - не натуральное число.");
        return;
    }
    int sum = (M + N) * (Math.Abs(M - N) + 1) / 2;
    Console.WriteLine(sum);
}

Console.Write("Введите первое из двух натуральных чисел больше 0: ");
int FirstNaturalNumber = int.Parse(Console.ReadLine());

Console.Write("Введите второе из двух натуральных чисел больше 0: ");
int SecondNaturalNumber = int.Parse(Console.ReadLine());

Console.Write($"Сумма всех натуральных чисел в промежутке между {FirstNaturalNumber} и {SecondNaturalNumber}: ");
NaturalNumbersSum(FirstNaturalNumber, SecondNaturalNumber);