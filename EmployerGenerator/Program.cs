using System;
using System.IO;
using EmployerGenerator.Entities;
using EmployerGenerator.Services;

namespace EmployerGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool execute = true;
            var ES = new EmployeeService();
            var E = new Employee(ES);

            while (execute)
            {
                Console.WriteLine("Do you wish to create an user employee bot? (Y/N) ");
                char choice = Char.Parse(Console.ReadLine());

                if(choice == 'Y' || choice == 'y')
                {
                    E.ProcessData();
                    Console.WriteLine(E);
                }

            }
            
        }
    }
}