using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.FilterPattern
{
    public class PersonInfo
    {
        private string name;
        private string gender;
        private string maritalStatus;

        public PersonInfo(string name, string gender, string maritalStatus)
        {
            this.name = name;
            this.gender = gender;
            this.maritalStatus = maritalStatus;
        }

        public string getName()
        {
            return name;
        }
        
        public string getGender()
        {
            return gender;
        }
        
        public string getMaritalStatus()
        {
            return maritalStatus;
        }
        
    }
}
