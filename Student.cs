using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Setters_and_Getters
{
    internal class Student
    {
        public string name;
        public int age;
        public string gender;

        public static int Studentcount = 0;

        //constructor
        public Student(string aName, int aAge, string aGender)
        {
            name = aName;
            age = aAge;
            Gender = aGender;
            Studentcount += 1;

        }
        public string Gender 
        { 
            get 
            { return gender; }

            set
            {
                if (value == "Male" || value == "Female")
                { gender = value; }
                else { gender = "Prefer not to say"; }

            }
        }
        
    }
}

