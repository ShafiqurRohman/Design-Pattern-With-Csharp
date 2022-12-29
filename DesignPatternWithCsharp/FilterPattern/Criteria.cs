using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.FilterPattern
{
    public interface Criteria
    {
        public List<PersonInfo> meetCriteria(List<PersonInfo> persons);
    }
}
