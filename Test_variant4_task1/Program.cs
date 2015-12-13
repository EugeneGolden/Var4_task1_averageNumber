using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_variant4_task1
{
    //Написати програму, яка в циклі введе 11 значень і порахує 
    //середнє арифметичне позитивних чисел і середнє арифметичне від'ємних чисел.
    class AverageNumber
    {
        static void Main(string[] args)
        {
            int n = 11;

            float[] enteredNumbers = new float[n];
           
            float positiveSumma = 0;
            float negativeSumma = 0;

            int amountOfPositiveNumbers = 0;
            int amountOfNegativeNumbers = 0;

            //Ввод n чисел
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите " + (i + 1) + "-е число: ");
                enteredNumbers[i] = float.Parse(Console.ReadLine());

            }

            //Вычисление суммы положительных и отрицательных чисел, 
            //а также количества слагаемых в ней участвующих
            for (int i = 0; i < enteredNumbers.Length; i++)
            {
                if (enteredNumbers[i] >= 0)
                {
                    positiveSumma = positiveSumma + enteredNumbers[i];
                    amountOfPositiveNumbers++;
                }
                else
                {
                    negativeSumma = negativeSumma + enteredNumbers[i];
                    amountOfNegativeNumbers++;
                }
            }

            //Вычисление среднего арифметического для положительных и отрицательных чисел
            if (amountOfPositiveNumbers != 0)
            {
                float positiveAverage = positiveSumma / amountOfPositiveNumbers;
                Console.Write("Среднее арифметическое положительных чисел: " + positiveAverage);
                Console.ReadLine();
            }
            else if (amountOfPositiveNumbers == 0)
            {
                Console.Write("Среди введенных чисел нет положительных");
                Console.ReadLine();
            }

            if (amountOfNegativeNumbers != 0)
            {
                float negativeAverage = negativeSumma / amountOfNegativeNumbers;
                Console.Write("Среднее арифметическое отрицательных чисел: " + negativeAverage);
                Console.ReadKey();
            }
            else if (amountOfNegativeNumbers == 0)
            {
                Console.Write("Среди введенных чисел нет отрицательных");
                Console.ReadKey();
            }

        }
    }
}
