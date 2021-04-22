using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson11
{
    class Student
    {
        public string name = "Kazys";
        public string surname = "Kazenas";
        public string school = "KTU";
        public string address = "Address";

        public string Name
        {
            get
            {
                Console.WriteLine(name);
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                Console.WriteLine(surname); 
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public string School
        {
            get
            {
                Console.WriteLine(school);
                return school;
            }
            set
            {
                school = value;
            }
        }
        public string Address
        {
            get
            {
                Console.WriteLine(address); 
                return address;
            }
            set
            {
                address = value;
            }
        }


    }
}
