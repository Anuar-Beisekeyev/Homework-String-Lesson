using System;

namespace HomeworkStringLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Написать программу, которая считывает символы с клавиатуры,
            // пока не будет введена точка.Программа должна сосчитать
            // количество введенных пользователем пробелов.

            Console.WriteLine("***** Программа для строк *****");
            char inputCharacter;
            int spaceCount = 0;

            do
            {
                inputCharacter = Console.ReadKey().KeyChar;
                if (inputCharacter == ' ')
                {
                    spaceCount++;
                }

            } while (inputCharacter != '.');

            Console.WriteLine();
            Console.WriteLine($"Количесво пробелов = {spaceCount}\n");


            // 2.Ввести с клавиатуры номер трамвайного билета(6 - значное число)
            // и про-верить является ли данный билет счастливым
            // (если на билете напечатано шестизначное число,
            // и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).

            Console.WriteLine("***** Программа \"Счастливый билет\" ******");
            Console.WriteLine("Введите 6 значный номер трамвайного билета:");

            string strTicket = Console.ReadLine();
            int ticketNumber;
            int leftSummaValue = 0;
            int rightSummaValue = 0;

            if (strTicket.Length > 0 && strTicket.Length <= 6)
            {
                if (int.TryParse(strTicket, out ticketNumber))
                {
                    for (int i = 0; i <= strTicket.Length; i++)
                    {
                        if (strTicket.Length / 2 <= i)
                        {
                            leftSummaValue += ticketNumber % 10;
                            ticketNumber /= 10;
                        }
                        else
                        {
                            rightSummaValue += ticketNumber % 10;
                            ticketNumber /= 10;
                        }

                    }
                    if (rightSummaValue == leftSummaValue)
                    {
                        Console.WriteLine("Поздравляю! У вас счастливый билет.");
                    }
                    else
                    {
                        Console.WriteLine("Билет не является счастливым.");
                    }

                }
                else
                {
                    Console.WriteLine("Не верный ввод.");
                }
            }
            else
            {
                Console.WriteLine("Количество введенных данных не соответствует номеру билета!");
            }
            Console.WriteLine();

            // 3.Числовые значения символов нижнего регистра в коде ASCII отличаются от значений
            // символов верхнего регистра на величину 32.Используя эту информацию,
            // написать программу, которая считывает с клавиатуры и конвертирует все
            // символы нижнего регистра в символы верхнего регистра и наоборот.

            Console.WriteLine("****** Программа для конвертации символов в верхний регистр *****");
            string strInput, strOutput;
            char[] chArray;

            Console.Write("Введите строку: ");
            strInput = Console.ReadLine();

            chArray = strInput.ToCharArray(0, strInput.Length);
            for (int i = 0; i < chArray.Length; i++)
            {
                int symbolCode = (int)chArray[i];
                if (symbolCode >= 65 && symbolCode <= 90)
                {
                    symbolCode += 32;
                }
                else if (symbolCode >= 97 && symbolCode <= 122)
                {
                    symbolCode -= 32;
                }
                chArray[i] = (char)symbolCode;
            }

            strOutput = String.Join("", chArray);

            Console.WriteLine("Введенная строка в верхнем регистре: " + strOutput);
            Console.WriteLine();

            // 4.Даны целые положительные числа A и B(A<B). Вывести все целые числа от A до B включительно;
            // каждое число должно выводиться на новой строке; при этом каждое число должно выводиться количество раз,
            // равное его значению. Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:
            // 3 3 3
            // 4 4 4 4
            // 5 5 5 5 5
            // 6 6 6 6 6 6
            // 7 7 7 7 7 7 7

            Console.WriteLine("***** Программа для вывода чисел лесенкой. *****");
            Console.WriteLine("Введите диапазон чисел А и В. А меньше чем В.");
            int valueA, valueB;
            bool flagIntValue;

            do
            {
                Console.WriteLine("Число А: ");
                flagIntValue = int.TryParse(Console.ReadLine(), out valueA);
                if (!flagIntValue)
                {
                    Console.WriteLine("Не верный ввод.");
                }
            } while (!flagIntValue);

            do
            {
                Console.WriteLine("Число В: ");
                flagIntValue = int.TryParse(Console.ReadLine(), out valueB);
                if (!flagIntValue || valueA > valueB)
                {
                    Console.WriteLine("Не верный ввод.");
                }
            } while (!flagIntValue || valueA > valueB);

            for (; valueA <= valueB; valueA++)
            {
                for (int i = 0; i < valueA; i++)
                {
                    Console.Write(valueA + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // 5.Дано целое число N(> 0), найти число, полученное при прочтении числа N справа налево.
            // Например, если было введено число 345, то программа должна вывести число 543.

            Console.WriteLine("***** Программа для реверса введенного числа. *****");
            Console.WriteLine("Введите челое число: ");

            string strValue,strReverseValue;
            strValue = Console.ReadLine();
            int value;            
            char[] chArrayValue;            

            if (int.TryParse(strValue, out value))
            { 
                chArrayValue = strValue.ToCharArray();
                Array.Reverse(chArrayValue);
                strReverseValue = new string(chArrayValue);

                Console.WriteLine($"Реверс введенного числа = {strReverseValue}");
            }
            else
            {
                Console.WriteLine("Не верный ввод.");
            }

         Console.ReadLine();
        }
    }
}
