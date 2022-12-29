using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.FilterPattern
{
    public class CriteriaSingle : Criteria
    {
        public List<PersonInfo> meetCriteria(List<PersonInfo> persons)
        {
            List<PersonInfo> singlePersons = new List<PersonInfo>();

            foreach (PersonInfo person in persons)
            {
                if (person.getMaritalStatus().Equals("Single", StringComparison.InvariantCultureIgnoreCase))
                {
                    singlePersons.Add(person);
                }
            }
       
            return singlePersons;
        }
    }
}
