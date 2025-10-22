using System.Text;
using Tyuiu.ZjatkovDV.Sprint3.Task7.V11.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #3 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #11                                                             *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Написать программу, которая выводит таблицу значений функции.  *");
Console.WriteLine("* Произвести табулирование f(x) на заданном диапазоне [-5; 5] с шагом 1.  *");
Console.WriteLine("* Выполнить проверку деления на ноль — при делении на ноль вернуть        *");
Console.WriteLine("* значение 0. Значения функции занести в массив. Округлить результаты до  *");
Console.WriteLine("* двух знаков после запятой.                                              *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: F(x) = cos(x) + (sin(x)/(2 - 2x)) - 4x                 *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

Console.Write("Стартовое значение отрезка = ");
int startValue1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Конечное значение отрезка = ");
int stopValue1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(new string('*', 75));
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");

Console.Write("[");
foreach (double c in result.GetMassFunction(startValue1, stopValue1))
{
    Console.Write(c + ", ");
}
Console.WriteLine("\b\b]");

Console.WriteLine(new string('*', 75));
Console.ReadKey();