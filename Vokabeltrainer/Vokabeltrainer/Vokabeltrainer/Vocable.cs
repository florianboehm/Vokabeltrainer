using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vokabeltrainer
{
    class Vocable
    {
        private int id;
        private string displayName;
        private string translation; //Wort-Übersetzng
        private string origin; //Original-Wort
        private int succeed; // 3 Stufen: 0, 1 und 2
        private Topic topic;

        public int propSucceed
        {
            get { return succeed; }
            set { succeed = value; }
        }

        public Topic propTopic
        {
            get { return topic; }
            set { topic = value; }
        }

        public string propOrigin
        {
            get { return origin; }
            set { origin = value; }
        }

        public int peopId
        {
            get { return id; }
            set { id = value; }
        }

        public string propTranslation
        {
            get { return translation; }
            set { translation = value; }
        }

        public string propDisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }

        public Vocable(string ow, Topic t) {

            //@todo hier muss jetzt die API greifen sodass hier nicht mehr der test-begriff "translation" steht sondern die richtige Übersetzung

            propOrigin = ow;
            propTranslation = "translation";
            propDisplayName = ow +" - " + "translation";
            propTopic = t;
    }
    }
}
