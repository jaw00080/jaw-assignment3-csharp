using System;
using System.Collections.Generic;
using System.Text;

namespace Multi_Window_WPF
{
    public class Person
    {
        public String FirstName { get; set; } // Property for the first name of the person
        public String LastName { get; set; } // Property for the last name of the person
        public int Age { get; set; } // Property for the age of the person

        public String FullName // Property for the full name of the person, where it adds the first name and last name together
        {
            get { return FirstName + " " + LastName; }
        }

        public bool IsAdult // Property for checking if the person is an adult, where it checks if the age is greater than or equal to 18
        {
            get { return Age >= 18; }
        }

    }
}
