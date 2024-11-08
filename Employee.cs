using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___OOP_Generic_collections
{
    internal class Employee
    {
        //Id, Name, Gender, Salary.
        public string Name { get; set; }
        public string Id {  get; set; }
        public int Salary {  get; set; }
        public string Gender { get; set; }

        public Employee(string name, string id, int salary, string gender) {
            Name = name;
            Id = id;
            Salary = salary;
            Gender = gender;
        }
       

        public static void PrintValues(Employee employee)
        {
            Console.WriteLine($"Name: {employee.Name} , Id: {employee.Id}, Salary: {employee.Salary}, Gender: {employee.Gender}. ");
           
        }
    }
}
