using Tyuiu.BrezinaYS.Sprint3.Task4.V29.Lib;
namespace Tyuiu.BrezinaYS.Sprint3.Task4.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Брезина Ю. С. | ИИПб-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Использование опреаторов continue и break в цикле                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #29                                                              *");
            Console.WriteLine("* Выполнил: Брезина Юлия Сергеевна | ИИПб-24-2                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5,                        *");
            Console.WriteLine("* вычислить значение функции y=cos(x)/x                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);

            Console.WriteLine("Старт шага  = " + startValue);
            Console.WriteLine("Конец шага  = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда = " + res);
            Console.ReadKey();
        }
    }
}
