using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.FilterPattern
{
    public class OrCriteria : Criteria
    {
        private Criteria criteria;
        private Criteria otherCriteria;

        public OrCriteria(Criteria criteria, Criteria otherCriteria)
        {
            this.criteria = criteria;
            this.otherCriteria = otherCriteria;
        }

        public List<PersonInfo> meetCriteria(List<PersonInfo> persons)
        {
            List<PersonInfo> firstCriteriaItems = criteria.meetCriteria(persons);
            List<PersonInfo> otherCriteriaItems = otherCriteria.meetCriteria(persons);
            foreach (PersonInfo person in otherCriteriaItems)
            {
                if (!firstCriteriaItems.Contains(person))
                {
                    firstCriteriaItems.Add(person);
                }
            }
            return firstCriteriaItems;
        }
    }
}
