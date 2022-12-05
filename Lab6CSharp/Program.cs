using System;
using pro100user.task2;
using pro100user.task3;

namespace pro100user 
{
    /*
     * Лабараторна робота №6
     * Ткачука Богдана група 341ск
     * Варіант 22
     */
    public class Lab6
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1. Завдання 1-2");
                Console.WriteLine("2. Завдання 3");
                Console.WriteLine("3. Вихід");
                Console.Write("Введіть вибране число: ");
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number == 3)
                    {
                        Console.WriteLine("Вихід...");
                        return;
                    }

                    switch (number)
                    {
                        case 1:
                            Task1AndTask2();
                            break;
                        case 2:
                            Task3();
                            break;
                        default:
                            Console.WriteLine("Ви ввели не те число. Повторіть спробу");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nВи не правильно ввели число. Повторіть спробу");
                }
                Console.WriteLine();
            }
        }
        
        /*
         * Завдання 1.
         * Перебудувати ієрархії в лабораторної робота №5
         * (Побудувати ієрархію класів відповідно до варіанта завдання.
         * Згідно завдання вибрати базовий клас та похідні.
         * В класах задати поля, які характерні для кожного класу.
         * Для всіх класів розробити метод Show(), який виводить дані про об’єкт класу.),
         * з визначення нових сутностей таким чином
         * щоб базовими були декілька інтерфейсів користувача та інтерфейси .NET.
         *
         * 2.7. Тест, іспит, випускний іспит, випробування.
         */
        static void Task1AndTask2()
        {
            List<Examination> examinations = new List<Examination>()
            {
                new ExaminationImpl(),
                new TestImpl(),
                new ExamImpl(),
                new FinalExamImpl()
            };
            examinations.ForEach(exam => exam.Show()); 
        }
        
        /*
         * Завдання 3.
         * Побудувати ієрархію із інтерфейсом, який успадковує інтерфейси .NET.
         * Побудувати похідні класи, які реалізують інтерфейси відповідно до варіанта завдання.
         * У кожному класі задати поля та методи, які характерні для цих нього, та визначити методи інтерфейсів.
         *
         * 3.2. Створити інтерфейс клас Function з методом обчислення значення функції y=f(x) у заданій точці.
         * Створити похідні класи: Line (y=ax+b), Quadratic (y=ax2+bx+c), Hyperbola (y=k/x)
         * зі своїми методами обчислення значення в заданій точці.
         * Створити масив nфункцій і вивести повну інформацію про значення даних функцій у точці х.
         */
        static void Task3()
        {
            double x = 5;
            List<Function> functions = new List<Function>()
            {
                new Line(1, 2, x),
                new Quadratic(1, 2, 3, x),
                new Hyperbola(3, x)
            };
            functions.ForEach(func => Console.WriteLine(func.CalculateY())); 
        }
    }
}
