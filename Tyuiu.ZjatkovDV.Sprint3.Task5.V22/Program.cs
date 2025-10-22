using System.Text;
using Tyuiu.ZjatkovDV.Sprint3.Task5.V22.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #3 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Вложенные циклы                                                   *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #22                                                             *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: *Формула суммы ряда*                                           *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

Console.Write("x = ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Стартовое значение (1) = ");
int startValue1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Конечное значение (1) = ");
int stopValue1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Стартовое значение (2) = ");
int startValue2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Конечное значение (2) = ");
int stopValue2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(new string('*', 75));
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2).ToString());

Console.WriteLine(new string('*', 75));
Console.ReadKey();