// Напишите программу, которая принимает на вход трехзначное число и на выходе
// показывет ВТОРУЮ цифру этого числа. Например:
// 456 -> 5

int EnterNumber(string message)      // Метод по вводу числа (из терминала)
{
    System.Console.Write(message + ": ");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

bool ValidateNumber (int number)        // Функция на провреку трехзначного числа
{
    if (number > 99 && number < 1000)
    {
        return true;
    }

    Console.WriteLine("Число не является трехзначным");
    return false;
}

int number = EnterNumber("Введите трехзначное число ");     // Вводим число с помощью функции
if (ValidateNumber(number))
{
    int PromResult = number / 10;
    int result = PromResult % 10;
    Console.WriteLine("Второй цифрой числа " + number + " является - " + result);
}