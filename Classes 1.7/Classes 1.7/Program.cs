using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_1._7
{
    class Employee
    {
        private string name, lastName;

        public Employee(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }

        public void SalaryAndTaxCalculate(string position, double experience)
        {
            int salaryWithTax = 0;
            int salaryWithoutTax = 0;
            int baseSalary = 1000;
            int positionSalary = 0;
            int experienceSalary = 0;
            int tax = 0;

            switch(position)
            {
                case "Director":
                    positionSalary = 1500;
                    salaryWithoutTax = baseSalary + positionSalary;
                    salaryWithTax = salaryWithoutTax;
                    break;
                case "Accountant":
                    positionSalary = 750;
                    salaryWithoutTax = baseSalary + positionSalary;
                    salaryWithTax = salaryWithoutTax;
                    break;
                case "QA":
                    positionSalary = 1000;
                    salaryWithoutTax = baseSalary + positionSalary;
                    salaryWithTax = salaryWithoutTax;
                    break;
                case "Programmer":
                    positionSalary = 1000;
                    salaryWithoutTax = baseSalary + positionSalary;
                    salaryWithTax = salaryWithoutTax;
                    break;
                case "Administrator":
                    positionSalary = 750;
                    salaryWithoutTax = baseSalary + positionSalary;
                    salaryWithTax = salaryWithoutTax;
                    break;
            }

            if(experience <= 1 && experience >= 0)
            {
                experienceSalary = 100;
                salaryWithoutTax += experienceSalary;
                salaryWithTax = salaryWithoutTax;
            }
            else if(experience > 1 && experience <= 3)
            {
                experienceSalary = 500;
                salaryWithoutTax += experienceSalary;
                salaryWithTax = salaryWithoutTax;
            }
            else if(experience > 3 && experience <= 5)
            {
                experienceSalary = 1200;
                salaryWithoutTax += experienceSalary;
                salaryWithTax = salaryWithoutTax;
            }
            else if(experience > 5 && experience <= 10)
            {
                experienceSalary = 5000;
                salaryWithoutTax += experienceSalary;
                salaryWithTax = salaryWithoutTax;
            }
            else if(experience > 10 && experience <= 15)
            {
                experienceSalary = 6000;
                salaryWithoutTax += experienceSalary;
                salaryWithTax = salaryWithoutTax;
            }
            else
            {
                experienceSalary = 7000;
                salaryWithoutTax += experienceSalary;
                salaryWithTax = salaryWithoutTax;
            }

            if (salaryWithoutTax < 2250)
            {
                tax = 5;
            }
            else if(salaryWithoutTax < 6750)
            {
                tax = 10;
            }
            else if(salaryWithoutTax >= 6750)
            {
                tax = 15;
            }

            salaryWithTax = salaryWithoutTax - (salaryWithoutTax * tax) / 100;

            Console.WriteLine("Name: {0}\nLast name: {1}\nPosition: {2}\nExperience: {3} years\nSalary without tax: {4}\nSalary with tax: {5}", name, lastName, position, experience, salaryWithoutTax, salaryWithTax);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Mark", "Somebody");

            employee.SalaryAndTaxCalculate("Programmer", 10);
        }
    }
}
