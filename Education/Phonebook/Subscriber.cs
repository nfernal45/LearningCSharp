using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    
   public class Subscriber
   {
       
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string number;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public Subscriber() { }
        public Subscriber(string name, string number)
        {
            Name = name;
            Number = number;
        }

        public Subscriber(string name)
        {
            Name = name;
        }






   }
    
    
}

    
