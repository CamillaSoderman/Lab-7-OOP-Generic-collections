using System.Collections.Concurrent;

namespace Lab_7___OOP_Generic_collections
{
    // Developer:   Camilla Söderman
    // Class:       .Net Fullstack
    // Lab:         7 – OOP Generic collections
    // Date:        2024-11-07
    internal class Program
    {

        static void Main(string[] args)
        {

            var employee1 = new Employee("Sandra", "1", 35000 , "Female");    //New employee
            var employee2 = new Employee("Bert", "2", 30000 , "Male");
            var employee3 = new Employee("Kim", "3", 32000, "Male");
            var employee4 = new Employee("Kajsa", "4", 24000, "Female");
            var employee5 = new Employee("Åke", "5", 29000, "Male");

            Stack<Employee> EmplyeeStack = new Stack<Employee>();
            EmplyeeStack.Push(employee1);       // adding new empolyee to the stack using Push()
            EmplyeeStack.Push(employee2);
            EmplyeeStack.Push(employee3);
            EmplyeeStack.Push(employee4);
            EmplyeeStack.Push(employee5);


            foreach (var employee in EmplyeeStack)   // Printing out every employee in stack and count
            {
                Employee.PrintValues(employee);
                Console.WriteLine("Medarbetare i stacken: {0} \n" , EmplyeeStack.Count);
                
            }
            Console.WriteLine("-------------------------------------- \n");
            Console.WriteLine("Retrive using Pop Method");
            while (EmplyeeStack.Count > 0 )             // do as long the stack is not empty and count
            {
                    Employee.PrintValues(EmplyeeStack.Pop());
                    Console.WriteLine("Medarbetare kvar i stacken: {0} efter Pop(); \n", EmplyeeStack.Count);
                    
             
            }
            Console.WriteLine("-------------------------------------- \n");
            EmplyeeStack.Push(employee1);       // adding new empolyee to the stack using Push()
            EmplyeeStack.Push(employee2);
            EmplyeeStack.Push(employee3);
            EmplyeeStack.Push(employee4);
            EmplyeeStack.Push(employee5);

            Console.WriteLine("Retrive using Peek Method");
            Employee.PrintValues(EmplyeeStack.Peek());          //Testing Peek method and counting objects in stack
            Console.WriteLine("Medarbetare kvar i stacken: {0} efter Peek(); \n", EmplyeeStack.Count);
            Employee.PrintValues(EmplyeeStack.Peek());
            Console.WriteLine("Medarbetare kvar i stacken: {0} efter Peek(); \n", EmplyeeStack.Count);
            Console.WriteLine("-------------------------------------- \n");
           
            if ((EmplyeeStack.Contains(employee3) == true))     // Check if object "employee3" is in stack
            {
                
                Console.WriteLine("employee3 is in stack");         // If it does
                
            }
            else
            {
                Console.WriteLine("employee3 is not in Stack");     // If it does not
            }
            Console.WriteLine("-------------------------------------- \n");
            Console.WriteLine("Part 2.\n");

            List<Employee> employeeList = new List<Employee>();         //Create List
            employeeList.Add(employee1);                                // Add all emplyees into List
            employeeList.Add(employee2);
            employeeList.Add(employee3);
            employeeList.Add(employee4);
            employeeList.Add(employee5);

            if (employeeList.Contains(employee2) == true )              // Check if list contain employee2
            {
                Console.WriteLine("employee2 object exists in list");
            }
            else
            {
                Console.WriteLine("employee2 does not exist in list");
            }
            Employee male = employeeList.Find( e => e.Gender == "Male");        // Find first male in list and print
            Employee.PrintValues(male);
            Console.WriteLine();

            
            List<Employee> allMale = employeeList.FindAll(e => e.Gender == "Male"); // Find and print all males in List
           foreach (var males in allMale)
            {
                Employee.PrintValues(males);
            }
            
            
            Console.ReadKey();



        }
    }
}
