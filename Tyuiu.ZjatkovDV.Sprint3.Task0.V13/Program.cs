using System.Text;
using Tyuiu.ZjatkovDV.Sprint3.Task0.V13.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #3 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла for                                                *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #13                                                             *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Написать программу используя цикл for, которая вычисляет сумму *");
Console.WriteLine("* ряда по формуле, при a = 0,5                                            *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

Console.Write("a = ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Стартовое значение = ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write("Конечное значение = ");
int z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(new string('*', 75));
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.GetSumSeries(x, y, z).ToString());

Console.WriteLine(new string('*', 75));
Console.ReadKey();