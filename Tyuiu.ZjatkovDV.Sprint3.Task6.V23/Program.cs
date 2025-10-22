using System.Text;
using Tyuiu.ZjatkovDV.Sprint3.Task6.V23.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #3 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #23                                                             *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Напишите программу, которая ищет среди целых чисел,            *");
Console.WriteLine("* принадлежащих числовому отрезку [18, 28] количество всех делителей      *");
Console.WriteLine("* меньше 11                                                               *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

Console.Write("Стартовое значение отрезка = ");
int startValue1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Конечное значение отрезка = ");
int stopValue1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(new string('*', 75));
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.GetSumTheDivisors(startValue1, stopValue1).ToString());

Console.WriteLine(new string('*', 75));
Console.ReadKey();