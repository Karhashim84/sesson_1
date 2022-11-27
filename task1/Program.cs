//Комментарий в С#
//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

//Например:
//4 -> 16 
//-3 -> 9 
//-7 -> 49
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); // тип_данных имя = значение;

// Как получить число в квадрате?

//Переменная с результатом
int result = number * number; //number^2 = result
Console.WriteLine(result);

//1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет
//camelCase используется firstNumber, secondNumber, thirdNumber

Console.Write("Введите первое число: "); //Текст подсказка, помогает получить первое число
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: "); //Текст подсказка, помогает получить первое число
int secondNumber = Convert.ToInt32(Console.ReadLine());
//точка с запятой не ставиться перед "{"
if (secondNumber * secondNumber == firstNumber) //"да"
{
    Console.WriteLine("Первое число является квадратом второго");
}
else Console.WriteLine("Первое число является не квадратом второго");

//3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//	3 -> Среда 
//5 -> Пятница

int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber == 1) Console.WriteLine("Понедельник");

// 5. Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

int positiveNumber = Convert.ToInt32(Console.ReadLine()); // N
if (positiveNumber < 0) positiveNumber*= -1;
int negativeNumber = positiveNumber * (-1); // -5 = 5 * (-1), -N

while (negativeNumber <= positiveNumber) //пока условие истино
{
    System.Console.WriteLine(negativeNumber);
    negativeNumber++;
    // negativeNumber +1
}