using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vokabeltrainer
{
    public class Subject
    {
        private string name;
        private string language;

        public string propLanguage
        {
            get { return language; }
            set { language = value; }
        }

        public string propName
        {
            get { return name; }
            set { name = value; }
        }

        public Subject(string name, string language)
        {
            propName = name;
            propLanguage = language;
        }
    }
}
