using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.CompositePattern
{
    class CompositePatternDemo
    {
        public static void demo()
        {
            Employee CEO = new Employee("John", "CEO", 30000);

            Employee headSales = new Employee("Robert", "Head Sales", 20000);
            Employee headMarketing = new Employee("Michel", "Head Marketing", 20000);

            Employee clerk1 = new Employee("Laura", "Marketing", 10000);
            Employee clerk2 = new Employee("Bob", "Marketing", 10000);

            Employee salesExecutive1 = new Employee("Richard", "Sales", 10000);
            Employee salesExecutive2 = new Employee("Rob", "Sales", 10000);

            CEO.addEmployee(headSales);
            CEO.addEmployee(headMarketing);

            headSales.addEmployee(salesExecutive1);
            headSales.addEmployee(salesExecutive2);

            headMarketing.addEmployee(clerk1);
            headMarketing.addEmployee(clerk2);


            Console.WriteLine(CEO.toString());

            foreach (Employee headEmployee in CEO.getSubordinates())
            {
                Console.WriteLine(headEmployee.toString());

                foreach (Employee employee in headEmployee.getSubordinates())
                {
                    Console.WriteLine(employee.toString());
                }
            }
        }
    }
}
