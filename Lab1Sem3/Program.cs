using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using Model;

namespace Lab1Sem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic logical = new Logic();
        start:
            Console.Clear();
            Console.WriteLine("Резюме:");
            foreach (Employee nh in logical.NotHired)
            {
                Console.WriteLine($"{logical.NotHired.IndexOf(nh) + 1} - {nh.ToString()}");
            }
            Console.WriteLine("\nРаботники:");
            foreach (Employee emp in logical.Emps)
            {
                Console.WriteLine($"{logical.Emps.IndexOf(emp) + 1} - {emp.ToString()}");
            }
            Console.WriteLine("Нанять работника - 1");
            Console.WriteLine("Отказать в найме - 2");
            Console.WriteLine("Изменить зарплату - 3");
            Console.WriteLine("Уволить - 4");
            Console.WriteLine("Выход - 5");
            try
            {
                int key = Int32.Parse(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("Введите номер резюме");
                        int empNumber = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Предложите зарплату");
                        int salary = Int32.Parse(Console.ReadLine());
                        logical.Hire(logical.NotHired.ElementAt(empNumber - 1), salary);
                        goto start;
                    case 2:
                        Console.WriteLine("Введите номер резюме");
                        empNumber = Int32.Parse(Console.ReadLine());
                        logical.Refuse(logical.NotHired.ElementAt(empNumber - 1));
                        goto start;
                    case 3:
                        Console.WriteLine("Введите номер работника");
                        empNumber = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Предложите зарплату");
                        salary = Int32.Parse(Console.ReadLine());
                        logical.ChangeSalary(logical.Emps.ElementAt(empNumber - 1), salary);
                        goto start;
                    case 4:
                        Console.WriteLine("Введите номер работника");
                        empNumber = Int32.Parse(Console.ReadLine());
                        logical.Fire(logical.Emps.ElementAt(empNumber - 1));
                        goto start;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неверный номер");
                        Console.ReadKey();
                        goto start;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректные данные");
                Console.ReadKey();
                goto start;
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Некорректные данные");
                Console.ReadKey();
                goto start;
            }
        }
    }
}
