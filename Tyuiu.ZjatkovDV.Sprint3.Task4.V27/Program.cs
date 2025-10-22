using System.Text;
using Tyuiu.ZjatkovDV.Sprint3.Task4.V27.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #3 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #27                                                             *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: На отрезке, где x принимает значения от -5 до 5, вычислить     *");
Console.WriteLine("* значение функции y=x/(cos(x)+sin(x)) При х = 0 пропустить значение.     *");
Console.WriteLine("* Полученные значения суммировать.                                        *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

Console.Write("Стартовое значение = ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write("Конечное значение = ");
int z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(new string('*', 75));
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.Calculate(y, z).ToString());

Console.WriteLine(new string('*', 75));
Console.ReadKey();