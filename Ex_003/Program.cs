// Напишите программу, которая выводит третью цифру заданного числа или сообщает
// что третьей цифры нет. Например:
// 456 -> 6
// 78 -> третьей цифры нет
// 2345 -> 4

int EnterNumber(string message)      // Метод по вводу числа (из терминала)
{
    System.Console.Write(message + ": ");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

bool ValidateNumber (int number)        // Функция на провреку трехзначного числа
{
    if (number > 99)
    {
        return true;
    }

    Console.WriteLine("Третьей цифры нет");
    return false;
}

int number = EnterNumber("Введите число ");     // Вводим число с помощью функции
if (ValidateNumber(number))
{
    if (number > 99 && number < 1000)
    {
    int result = number%10;
    Console.WriteLine("Третья цифра данного числа - " + result);
    }
    else
    {
    int PromResult = number%100;
    int PromResult1 = PromResult / 10;
    Console.WriteLine("Третья цифра данного числа - " + PromResult1);
    }
}