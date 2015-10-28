using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //простейшая программа
            Console.WriteLine("Hello World!");

            //---------------------------работа с простыми типами---------------------
            //целые и дробные числа
            int number;
            number = 10; 
            Console.WriteLine(number);
            number = 100;
            Console.WriteLine(number);
            int number2 = 15;
            Console.WriteLine(15);

            number = 10 * 2345 - 567;
            number = 10 - number;
            Console.WriteLine();
            number = 56 / 10;
            Console.WriteLine(number); //выведется 5, а не 5.6
            number = 56 % 10; //остаток от деления = 6
            Console.WriteLine(number);

            double price = 56 / 10;
            Console.WriteLine(price); //выведется 5
            price = 56.0 / 10;
            Console.WriteLine(price);//получим дробь

            double price2 = (double)number / number2;
            Console.WriteLine(price2);

            //строки, символы, логические
            string text = "13218138";
            //int number3 = (int)text; - не скомпилируется
            int number3 = int.Parse(text); 
            number3 = number3 + 1;
            Console.WriteLine(number3);

            char symbol = 'A';
            Console.WriteLine(symbol);

            Console.WriteLine("a" + "b" + "c"); //выведет "abc"
            Console.WriteLine('a' + 'b' + 'c'); //выведет 294 
            Console.WriteLine((int)'a');
            Console.WriteLine((int)'0'); //код нуля = 48
            
            bool flag = true; 
            flag = true || false;
            Console.WriteLine(flag);
            flag = true && false;
            Console.WriteLine(flag);
            flag = !flag;
            Console.WriteLine(flag);

            //------------------------работа со структурами------------------
            int day = 12;
            int hour = 14;
            int minute = 45;

            DateTime date = new DateTime(2015, 2, 12, 14, 45, 0);
            Console.WriteLine(date);
            Console.WriteLine(date.DayOfWeek);
            
            int num1 = 45;
            Int32 num2 = 56; //эти две записи эквивалентны

            //---------------------перечисления-----------------------------
            //имеют заданный диапазон значений  - множество

            DateTime date1 = new DateTime(2015, 2, 12, 14, 55, 0);
            Console.WriteLine(date1.DayOfWeek);
            DayOfWeek day11 = DayOfWeek.Friday; //7 значений - через точку выбираем одно из них
            Console.WriteLine(day11);
            Console.WriteLine((int)day11);
            //явное приведение работает в обе стороны
            DayOfWeek day22 = (DayOfWeek)4;
            Console.WriteLine(day22);

            //с помощью перечислений можно реализовывать настройки
            //пример: установим новый цвет букв в консоли
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Желтенький");

            //-----------------------задание с датами----------------------
            /*
             * Вывести целое количество дней, часов и минут между двумя моментами времени.
             */
            //ниже задана первая дата (день, час, минута)
            int day1 = 25;
            int hour1 = 18;
            int minute1 = 46;

            //теперь задаем вторую дату (день, часы, минуты)
            int day2 = 29;
            int hour2 = 16;
            int minute2 = 51;

            // количество минут, прошедших с начала месяца до 25 числа 18 часов 41 минуты
            int total1 = (day1 * 24 + hour1) * 60 + minute1;
            //аналогично для второй даты
            int total2 = (day2 * 24 + hour2) * 60 + minute2;
            //разница между двумя датами в минутах
            int delta = total2 - total1;

            //теперь главные вычисления
            int deltadays = (delta / 60) / 24; //дни
            int deltahours = (delta / 60) % 24; //часы
            int deltaminutes = delta % 60; //минуты
            
            System.Console.WriteLine(deltadays + " дней " + deltahours + " часов " + deltaminutes + " минут ");


            //второй способ: задаем структуры, которые хранят в себе информацию о дате и времени (год, месяц, число, час, минута, секунда)
            DateTime oldDate = new DateTime(2015, 3, day1, hour1, minute1, 0);
            DateTime newDate = new DateTime(2015, 3, day2, hour2, minute2, 0);

            TimeSpan TS = newDate - oldDate; //вычисляем разность

            System.Console.WriteLine(TS.Days + " дней " + TS.Hours + " часов " + TS.Minutes + " минут "); 

            Console.ReadLine();
        }
    }
    //-----------------перечисления---------------
    enum Users
    {
        Admin,
        AuthUser,
        Guest,
        Banned
    }

}
