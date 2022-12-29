using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.FilterPattern
{
    public class CriteriaFemale : Criteria
    {
        public List<PersonInfo> meetCriteria(List<PersonInfo> persons)
        {
            List<PersonInfo> femalePersons = new List<PersonInfo>();

            foreach(PersonInfo person in persons){
                if(person.getGender().Equals("Female", StringComparison.InvariantCultureIgnoreCase))
                {
                    femalePersons.Add(person);
                }
            }
            return femalePersons;
        }
    }
}
