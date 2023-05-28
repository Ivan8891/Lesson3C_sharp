// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите 5-ти значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9999 && number < 100000)
{
    int[] array = new int[5];
    for (int i = 0; i < array.Length; i++)
    {
        int num = number % 10;
        array[i] = num;
        number /= 10;
    }
    if (array[0] == array[4] && array[1] == array[3])
    {
        Console.WriteLine("Это число - палиндром.");
    }
    else
    {
        Console.WriteLine("Это число не палиндром.");
    }   
}
else
{
    Console.WriteLine("Вы ввели не 5-ти значное число.");
}