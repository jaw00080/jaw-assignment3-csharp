using System;
using System.Collections.Generic;
using System.Text;

namespace Multi_Window_WPF
{
    public class Person
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }

        public String FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}
