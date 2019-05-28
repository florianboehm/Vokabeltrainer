using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Vokabeltrainer
{
    public class Globals
    {
        public static ArrayList vocs = new ArrayList();
        public static ArrayList subjects = new ArrayList();
        public static ArrayList topics = new ArrayList();

        public static void loadSubjects()
        {
            subjects.Add(new Subject("Englisch","en"));
            subjects.Add(new Subject("Spanisch", "es"));
            subjects.Add(new Subject("Französisch", "fr"));
            subjects.Add(new Subject("Italenisch", "it"));
        }

        public static void loadTopics()
        {
            topics.Add(new Topic("sights in London", (Subject)subjects[0]));
            topics.Add(new Topic("Atracciones en Madrid", (Subject)subjects[1]));
            topics.Add(new Topic("Attractions à Paris", (Subject)subjects[2]));
            topics.Add(new Topic("Attrazioni a Roma", (Subject)subjects[3]));
        }

        public static void loadVocs()
        {
            vocs.Add(new Topic("sights in London", new Subject("Englisch", "en")));
            vocs.Add(new Topic("Atracciones en Madrid", new Subject("Spanisch", "es")));
            vocs.Add(new Topic("Attractions à Paris", new Subject("Französisch", "fr")));
            vocs.Add(new Topic("Attrazioni a Roma", new Subject("Italenisch", "it")));
        }
    }
}
