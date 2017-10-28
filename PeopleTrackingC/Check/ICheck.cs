using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleTrackingC.Check
{
    interface ICheck
    {
        Boolean CheckIn(Workers.User user, String poss);
        Boolean CheckOut(Workers.User user, String poss);
    }
}
