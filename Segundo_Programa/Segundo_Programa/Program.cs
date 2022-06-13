// Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de N funcionários.
// Não deve haver repetições de id.
// Em seguida, efetuar o aumento de X por cento no salario de um determinado funcionario. Para isso, o programa
// deve ler um id e o valor X. Se o id informado não existir, mostrar uma mensagem e abortar a operação. Ao final, 
//mostrar a listagem atualizada dos funcionarios, conforme exemplos.
//Lembre-se de aplicar a técnica de encapsulamento não para permitir que o salario possa ser mudado livremente. Um salario
// só pode ser aumentado com base em uma operação de aumento por porcentagem dada.

using Segundo_Programa;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Primeiro_Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the emplyoee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Enter the percentage:");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Update list of employees:");
            foreach (Employee obj in list){
                Console.WriteLine(obj);

            }
        }
    }

}