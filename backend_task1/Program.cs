using System;

namespace backend_task1
{
    // Q1 + Q2 + Q3: Employee class
    class Employee
    {
        // Q3: private field for salary
        private double salary;

        public string Name { get; set; }
        public int Age { get; set; }

        // Q3: public property with validation
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Salary can't be negative!");
                }
                else
                {
                    salary = value;
                }
            }
        }

        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        // Q2: display employee info
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Salary: " + Salary);
        }

        // Q2: annual salary = monthly salary * 12
        public double CalculateAnnualSalary()
        {
            return Salary * 12;
        }
    }

    // Q4: Manager inherits from Employee
    class Manager : Employee
    {
        public double Bonus { get; set; }

        public Manager(string name, int age, double salary, double bonus)
            : base(name, age, salary)
        {
            Bonus = bonus;
        }

        // Q4: override DisplayInfo to add the bonus
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Bonus: " + Bonus);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Q1: two employee objects with different values
            Employee emp1 = new Employee("Ahmed", 25, 5000);
            Employee emp2 = new Employee("Sara", 30, 7000);

            // Q2: call the methods
            Console.WriteLine(" Employee 1");
            emp1.DisplayInfo();
            Console.WriteLine("Annual Salary: " + emp1.CalculateAnnualSalary());

            Console.WriteLine();
            Console.WriteLine("Employee 2 ");
            emp2.DisplayInfo();
            Console.WriteLine("Annual Salary: " + emp2.CalculateAnnualSalary());

            // Q3: try to set a negative salary
            Console.WriteLine();
            Console.WriteLine(" Testing negative salary ");
            emp1.Salary = -100;
            Console.WriteLine("Salary is still: " + emp1.Salary);

            // Q4: Manager object
            Console.WriteLine();
            Console.WriteLine(" Manager ");
            Manager mgr = new Manager("Omar", 40, 12000, 3000);
            mgr.DisplayInfo();
            Console.WriteLine("Annual Salary: " + mgr.CalculateAnnualSalary());

            Console.ReadLine();
        }
    }
}