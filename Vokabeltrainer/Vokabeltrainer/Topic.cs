using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vokabeltrainer
{
    class Topic
    {
        
        private Lesson lesson;
        private string name;

        public string propName
        {
            get { return name; }
            set { name = value; }
        }

        public Lesson propLesson
        {
            get { return lesson; }
            set { lesson = value; }
        }

    }
}
