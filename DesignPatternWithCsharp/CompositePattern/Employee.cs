using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.CompositePattern
{
    class Employee
    {
        private string name;
        private string department;
        private int salary;
        private List<Employee> subordinates;


        public Employee(string name, string department, int salary)
        {
            this.name = name;
            this.department = department;
            this.salary = salary;
            subordinates = new List<Employee>();
        }

        public void addEmployee(Employee e)
        {
            subordinates.Add(e);
        }
        
        public void removeEmployee(Employee e)
        {
            subordinates.Remove(e);
        }

        public List<Employee> getSubordinates()
        {
            return subordinates;
        }

        public String toString()
        {
            return String.Concat(("Employee :[ Name :  "+name+" dept : "+department+" salary :"+salary+" salary]"));
        }
    }
}
