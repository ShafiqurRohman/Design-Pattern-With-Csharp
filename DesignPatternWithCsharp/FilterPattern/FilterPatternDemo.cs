using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.FilterPattern
{
    public class FilterPatternDemo
    {
        public static void demo()
        {
            List<PersonInfo> persons = new List<PersonInfo>();

            persons.Add(new PersonInfo("Robert", "Male", "Single"));
            persons.Add(new PersonInfo("John", "Male", "Married"));
            persons.Add(new PersonInfo("Laura", "Female", "Married"));
            persons.Add(new PersonInfo("Diana", "Female", "Single"));
            persons.Add(new PersonInfo("Mike", "Male", "Single"));
            persons.Add(new PersonInfo("Bobby", "Male", "Single"));

            Criteria male = new CriteriaMale();
            Criteria female = new CriteriaFemale();
            Criteria single = new CriteriaSingle();
            Criteria singleMale = new AndCriteria(single, male);
            Criteria singleOrFemale = new OrCriteria(single, female);

            Console.WriteLine("Males: ");
            printPersons(male.meetCriteria(persons));

            Console.WriteLine("\nFemales: ");
            printPersons(female.meetCriteria(persons));

            Console.WriteLine("\nSingle Males: ");
            printPersons(singleMale.meetCriteria(persons));

            Console.WriteLine("\nSingle Or Females: ");
            printPersons(singleOrFemale.meetCriteria(persons));
        }

        public static void printPersons(List<PersonInfo> persons)
        {

            foreach (PersonInfo person in persons)
            {
                Console.WriteLine("Person : [ Name : " + person.getName() + ", Gender : " + person.getGender() + ", Marital Status : " + person.getMaritalStatus() + " ]");
            }
        }
    }
}
