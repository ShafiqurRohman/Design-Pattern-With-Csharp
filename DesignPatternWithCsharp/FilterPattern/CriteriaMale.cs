using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.FilterPattern
{
    public class CriteriaMale : Criteria
    {
        public List<PersonInfo> meetCriteria(List<PersonInfo> persons)
        {
            List<PersonInfo> malePersons = new List<PersonInfo>();

            foreach (PersonInfo person in persons)
            {
                if (person.getGender().Equals("male", StringComparison.InvariantCultureIgnoreCase))
                {
                    malePersons.Add(person);
                }
            }
            return malePersons;
        }
    }
}
