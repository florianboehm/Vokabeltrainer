using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vokabeltrainer
{
    class User
    {
        private int id;
        private string username;
        private string email;
        private string firstname;
        private string lastname;

        public string propLastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string propFirstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string  propEmail
        {
            get { return email; }
            set { email = value; }
        }

        public string propusername
        {
            get { return username; }
            set { username = value; }
        }

        public int propId
        {
            get { return id; }
            set { id = value; }
        }

    }
}
