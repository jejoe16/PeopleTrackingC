using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleTrackingC.User
{
    public class User 
    {
        private String possition;
        public string GetPossition()
        {
            return possition;
        }

        public void SetPossition(string poss)
        {
           this.possition = poss;
        }
    }
}
