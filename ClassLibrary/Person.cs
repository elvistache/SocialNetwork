using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public enum Gender { Male, Female}

    public class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        
        //password
        public DateTime Birthdate { get; private set; }
        public Gender Gender { get; private set; }

        public int Age
        {
            get
            {
                return (int)((DateTime.Now - this.Birthdate).TotalDays / 365.25);
            }
        }

        public Person(string firstName, string lastName, DateTime birthdate, Gender gender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            
            this.Birthdate = birthdate;
            this.Gender = gender;


        }


    }
}
