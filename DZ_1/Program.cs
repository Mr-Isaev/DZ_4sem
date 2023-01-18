/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
Console.Clear();
int a = eeee("Введите число: ");
int b = eeee("Введите степень: ");
functstep(a, b);


// Функция возведения в степень
void functstep(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(a + " в степени " + b + " = " + result);
}

// Функция ввода
int eeee(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}