using System.Text;
using Tyuiu.ZjatkovDV.Sprint3.Task2.V25.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #3 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #25                                                             *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Написать программу используя цикл do...while, которая          *");
Console.WriteLine("* вычисляет сумму ряда по формуле, при n = 5                              *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

Console.Write("n = ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Стартовое значение = ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write("Конечное значение = ");
int z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(new string('*', 75));
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.GetSumSeries(x, y, z).ToString());

Console.WriteLine(new string('*', 75));
Console.ReadKey();