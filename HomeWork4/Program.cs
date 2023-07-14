/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Аргумент\tЗначение функции");
        for (int x = -10; x <= 50; x +=2)
        {
            double result = 2 * Math.Cos(x) - 1;
            Console.WriteLine(x + "\t\t" + result);
        }
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Аргумент\tЗначение функции");
        for (int x = -100; x <=10; x +=2)
        {
            double result = 1 / Math.Tan(x) + 1;
            Console.WriteLine(x + "\t\t" + result);
        }
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Аргумент\tЗначение функции");
        for (int x = -45; x <=45; x+=2)
        {
            double result = Math.Cos(x) + 1 / Math.Tan(x);
            Console.WriteLine(x + "\t\t" + result);
        }
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Аргумент\tЗначение функции");
        for (int x = -30; x <=50; x+=2)
        {
            double result = Math.Sin(x) + Math.Tan(x);
            Console.WriteLine(x + "\t\t" +result);
        }
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Аргумент\tЗначение функции");

        for (int x = -55; x <= 66; x += 2)
        {
            double result = Math.Sin(x) - Math.Cos(x);
            Console.WriteLine(x + "\t\t" + result);
        }
        Console.ReadKey();
    }
}*/

//Компьютер "загадал" число в определенном диапазоне от A до B (А и B вводятся с консоли), пользователю необходимо отгадать его, вводя свои ответы в консоль. Если пользователь не угадал, программа должна сообщить о том, что число пользователя больше или меньше «загаданного». Программа завершиться только после того, как пользователь угадает число. (Для генерации «загаданного» числа использовать Random)
/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите диапазон чисел (A и B):");
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        // Создаем объект класса Random для генерации случайного числа
        Random random = new Random();
        int x = random.Next(A, B + 1);

        Console.WriteLine("Компьютер загадал число в диапазоне от " + A + " до " + B);

        int attempts = 0;
        int answer = 0;

        while (answer != x)
        {
            Console.Write("Введите ваш ответ: ");
            answer = int.Parse(Console.ReadLine());
            attempts++;

            if (answer < x)
            {
                Console.WriteLine("Загаданное число меньше вашего ответа");
            }
            else if (answer > x)
            {
                Console.WriteLine("Загаданное число больше вашего ответа");
            }
        }

        Console.WriteLine("Поздравляем! Вы угадали число " + x + " за " + attempts + " попыток.");
        Console.ReadKey();
    }
    
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число от 1 до 100(включительно) : ");
        Console.WriteLine("Я буду пытаться отгадать ваше число :) ");
        int min = 1;
        int max = 100;
        int attemps = 0;
        Random random = new Random();
        int answer;
        do
        {
            answer = random.Next(min, max + 1);
            Console.WriteLine("Мой ответ: " + answer);
            Console.WriteLine("Введите 0, если ваше число меньше, 1, если больше, или 5, если я угадал.");
            int useranswer = int.Parse(Console.ReadLine());
            attemps++;
            if (useranswer == 0)
            {
                max = answer - 1;
            }
            else if (useranswer == 1)
            {
                min = answer + 1;
            }
            else if (useranswer == 5)
            {
                Console.WriteLine("Ура! Я угадал число " + answer + " за " + attemps + " попыток.");
                break;
                
            }
            else
            {
                Console.WriteLine("Неверный ввод,попробуйте ещё раз");
            }
        } while (answer != 5);

        Console.ReadKey();
    }
}*/

//Задачи с конструкцией switch

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите школьную отметку");
        int mark = int.Parse(Console.ReadLine());
        string description;
        switch(mark)
        {
            case 1:
                description = "плохо";
                break;
            case 2:
                description = "неудовлетворительно";
                break;
            case 3:
                description = "удовлетворительно";
                break;
            case 4:
                description = "хорошо";
                break;
            case 5:
                description = "отлично";
                break;
            default:
                description = "неверная отметка";
                break;
        }
        Console.WriteLine("Описание отметки: " + description);
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите цифру от 0 до 9 ");
        int number = int.Parse(Console.ReadLine());
        string name;

        switch(number)
        {
            case 0:
                name = "zero";
                break;
            case 1:
                name = "one";
                break;
            case 2:
                name = "two";
                break;
            case 3:
                name = "three";
                break;
            case 4:
                name = "four";
                break;
            case 5:
                name = "five";
                break;
            case 6:
                name = "six";
                break;
            case 7:
                name = "seven";
                break;
            case 8:
                name = "eight";
                break;
            case 9:
                name = "nine";
                break;
            default:
                name = "Введена некорректная цифра!";
                break;
        }
        Console.WriteLine("Название цифры : " +  name);
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    

    static void Main()
    {
        Console.WriteLine("Введите номер месяца (от 1 до 12): ");
        int month = int.Parse(Console.ReadLine());
        string NextMonth;
        switch(month)
        {
            case 1:
                NextMonth = "Февраль";
                break;
            case 2:
                NextMonth = "Март";
                break;
            case 3:
                NextMonth = "Апрель";
                break;
            case 4:
                NextMonth = "Май";
                break;
            case 5:
                NextMonth = "Июнь";
                break;
            case 6:
                NextMonth = "Июль";
                break;
            case 7:
                NextMonth = "Август";
                break;
            case 8:
                NextMonth = "Сентябрь";
                break;
            case 9:
                NextMonth = "Октябрь";
                break;
            case 10:
                NextMonth = "Ноябрь";
                break;
            case 11:
                NextMonth = "Декабрь";
                break;
            case 12:
                NextMonth = "Январь";
                break;
            default:
                NextMonth = "Введено некорректное число!";
                break;
        }
        Console.WriteLine("Следующий месяц: " + NextMonth);
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число от 3 до 12: ");
        int num = int.Parse(Console.ReadLine());

        string description;

        switch(num)
        {
            case 3:
                description = "Треугольник";
                break;
            case 4:
                description = "Квадрат";
                break;
            case 5:
                description = "Пятиугольник";
                break;
            case 6:
                description = "Шестиугольник";
                break;
            case 7:
                description = "Семиугольник";
                break;
            case 8:
                description = "Восьмиугольник";
                break;
            case 9:
                description = "Девятиугольник";
                break;
            case 10:
                description = "Десятиугольник";
                break;
            case 11:
                description = "Одиннадцатиугольник";
                break;
            case 12:
                description = "Двенадцатиугольник";
                break;
            default:
                description = "Введено некорректное число!";
                break;
        }
        Console.WriteLine("Описание геометрической фигуры: " + description);
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число в граммах: ");
        double numberInGrams = double.Parse(Console.ReadLine());
        Console.WriteLine("Выберите единицу измерения для преоброзования: ");
        Console.WriteLine("1 - килограммы");
        Console.WriteLine("2 - тонны");
        Console.WriteLine("3 - милиграммы");
        Console.WriteLine("4 - мегатонны");
        Console.WriteLine("5 - микрограммы");
        int choice = int.Parse(Console.ReadLine());
        double result;

        switch (choice)
        {
            case 1:
                result = numberInGrams / 1000;
                Console.WriteLine("Результат: " + result + " кг");
                break;
            case 2:
                result = numberInGrams / 1000000;
                Console.WriteLine("Результат: " + result + " т");
                break;
            case 3:
                result = numberInGrams * 1000;
                Console.WriteLine("Результат: " + result + " мг");
                break;
            case 4:
                result = numberInGrams / 1000000000;
                Console.WriteLine("Результат: " + result + " мт");
                break;
            case 5:
                result = numberInGrams * 1000000;
                Console.WriteLine("Результат: " + result + " мкг");
                break;
            default:
                Console.WriteLine("Некорректный выбор единицы измерения");
                break;
        }
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    

    static void Main()
    {
        Console.WriteLine("Введите номер месяца (от 1 до 12): ");
        int month = int.Parse(Console.ReadLine());
        string NextMonth;
        switch(month)
        {
            case 1:
                NextMonth = "Январь";
                break;
            case 2:
                NextMonth = "Февраль";
                break;
            case 3:
                NextMonth = "Март";
                break;
            case 4:
                NextMonth = "Апрель";
                break;
            case 5:
                NextMonth = "Май";
                break;
            case 6:
                NextMonth = "Июнь";
                break;
            case 7:
                NextMonth = "Июль";
                break;
            case 8:
                NextMonth = "Август";
                break;
            case 9:
                NextMonth = "Сентябрь";
                break;
            case 10:
                NextMonth = "Октябрь";
                break;
            case 11:
                NextMonth = "Ноябрь";
                break;
            case 12:
                NextMonth = "Декабрь";
                break;
            default:
                NextMonth = "Введено некорректное число!";
                break;
        }
        Console.WriteLine("Следующий месяц: " + NextMonth);
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число от 1 до 9 : ");
        int num = int.Parse(Console.ReadLine());
        string name;

        switch (num)
        {
            case 1:
                name = "Первый";
                break;
            case 2:
                name = "Второй";
                break;
            case 3:
                name = "Третий";
                break;
            case 4:
                name = "Четвёртый";
                break;
            case 5:
                name = "Пятый";
                break;
            case 6:
                name = "Шестой";
                break;
            case 7:
                name = "Седьмой";
                break;
            case 8:
                name = "Восьмой";
                break;
            case 9:
                name = "Девятый";
                break;
            default:
                name = "Некорректное число!";
                break;
        }
        Console.WriteLine("Название числа: " + name);
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число от 1 до 9 : ");
        int num = int.Parse(Console.ReadLine());
        string name;

        switch (num)
        {
            case 1:
                name = "красный";
                break;
            case 2:
                name = "синий";
                break;
            case 3:
                name = "зелёный";
                break;
            case 4:
                name = "голубой";
                break;
            case 5:
                name = "желтый";
                break;
            case 6:
                name = "серый";
                break;
            case 7:
                name = "чёрный";
                break;
            case 8:
                name = "оранжевый";
                break;
            case 9:
                name = "белый";
                break;
            default:
                name = "Некорректное число!";
                break;
        }
        Console.WriteLine("Название числа: " + name);
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер пары от 1 до 6: ");
        int pairNum = int.Parse(Console.ReadLine());
        string timeStart;

        switch (pairNum)
        {
            case 1:
                timeStart = "08:30";
                break;
            case 2:
                timeStart = "10:05";
                break;
            case 3:
                timeStart = "12:00";
                break;
            case 4:
                timeStart = "14:05";
                break;
            case 5:
                timeStart = "15:50";
                break;
            case 6:
                timeStart = "17:25";
                break;
            default:
                timeStart = "Некорректный номер пары!";
                break;
        }
        Console.WriteLine("Время начала пары: " + timeStart);
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер времени года (от 1 до 4)");
        int Season = int.Parse(Console.ReadLine());
        string name;
        switch (Season)
        {
            case 1:
                name = "Зима";
                break;
            case 2:
                name = "Весна";
                break;
            case 3:
                name = "Лето";
                break;
            case 4:
                name = "Осень";
                break;
            default:
                name = "Некорректный номер времени года!";
                break;
        }
        Console.WriteLine("Время года: " + name);
        Console.ReadKey();
    }
}*/