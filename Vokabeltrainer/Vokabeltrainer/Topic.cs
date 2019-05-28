using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vokabeltrainer
{
    public class Topic
    {
        
        private Subject subject;
        private string name;

        public string propName
        {
            get { return name; }
            set { name = value; }
        }

        public Subject propSubject
        {
            get { return subject; }
            set { subject = value; }
        }

        public Topic(string name, Subject s)
        {
            propSubject = s;
            propName = name;
        }
    }
}
