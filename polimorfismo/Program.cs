using System;
using System.Collections.Generic;
using polimorfismo.Entities;

namespace polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of Employeers:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i<= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("OutSource(y/n)?");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value Per hours: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                if (ch == 'y')
                {
                    Console.WriteLine("add Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutSourceEmployee(name, hours, valuePerHour, additionalCharge));


                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }


            }


            Console.WriteLine();
            Console.WriteLine("Payments:");

            foreach( Employee emp in list)
            {
                Console.WriteLine(emp.Name + "- $ " + emp.Payment().ToString("F2"));
            }




        }
    }
}
