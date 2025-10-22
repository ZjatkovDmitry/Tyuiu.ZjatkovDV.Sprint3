using System.Text;
using Tyuiu.ZjatkovDV.Sprint3.Task3.V20.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #3 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #20                                                             *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Используя цикл foreach подсчитать количество букв “f” в        *");
Console.WriteLine("* строке: gfft ntf f opf                                                  *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: \"gfft ntf f opf\"                                   *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

Console.WriteLine(new string('*', 75));
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.GetCharCount("gfft ntf f opf", 'f').ToString());

Console.WriteLine(new string('*', 75));
Console.ReadKey();