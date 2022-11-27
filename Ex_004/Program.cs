// Напишите программу, которая на вход принимает цифру, обозначающую день недели, и
// проверяет, является ли этот день выходным. Не использовать строки. Например:
// 6 -> да
// 7 -> да
// 1 -> нет

int EnterNumber(string message)      // Метод по вводу числа (из терминала)
{
    System.Console.Write(message + ": ");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

bool ValidateNumber (int number)        // Функция на провреку дня недели
{
    if (number < 8)
    {
        return true;
    }

    Console.WriteLine("Таких дней в неделе не существует");
    return false;
}

int number = EnterNumber("Введите день недели с помощью цифры ");     // Вводим число с помощью функции
if (ValidateNumber(number))
{
    if (number > 5)
    {
    Console.WriteLine("Да");
    }
    else
    {
    Console.WriteLine("Нет");
    }
}
