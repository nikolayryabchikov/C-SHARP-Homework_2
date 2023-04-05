//Homework #2

// Задача #1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int Div(int num)
{
    return (num/10)%10;
}

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
 if (num<100 || num >=1000)
 {
    Console.WriteLine("Уважаемый юзер, вы ввели не трёхзначное число");
 }
else
{
Console.WriteLine("Вторая цифра из введённого числа " + (Div(num)));
}
*/

// Задача #2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

/*
int Div2(int num1)
{
    if (num1 < 100)
    {
        return num1;
    }
    else
    {
        while (num1 > 1000)
        {
            num1 = num1 / 10;
        }

        return num1 % 10;
    }
}

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 == Div2(num1))
{
    Console.WriteLine($"В вашем числе {num1} нет третьей цифры");
}
else
{
    Console.WriteLine("Третья цифра в вашем числе - " + Div2(num1));
}
*/
// Задача #3.  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным


bool Div3(int num2)
{
    if (num2 >= 1 && num2 <= 5 || num2 > 8)
    {
        return false;
    }
    else
    {
        return true;
    }
}

Console.Write("Введите день недели: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Div3(num2));
