using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.ObserverPattern
{
    class HexaObserver : Observer
    {
        public HexaObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.attach(this);
        }

        public override void update()
        {
            Console.WriteLine("Hexa String: {0}", Convert.ToString(subject.getState(), 16).ToUpper());
        }
    }
}
