using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventsandhobbies
{
    internal class User : Event
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { set; get; }
    }
}
