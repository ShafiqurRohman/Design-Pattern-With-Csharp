using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.SingletonPattern
{
    public sealed class Singelton
    {
        public static Singelton singeltonObj = null;
        public static int counter = 0;
        
        public static Singelton getSingeltonObj
        {
            get
            {
                if (singeltonObj == null)
                    singeltonObj = new Singelton();
                return singeltonObj;
            }
        }
        Singelton()
        {
            Console.WriteLine("This is Singleton Pattern example");
            Console.WriteLine("the counter value is {0}", counter);
        }
    }
}
