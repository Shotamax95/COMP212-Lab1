using System;
using System.Collections.Generic;
using System.Text;

namespace Question1
{
    public class Student : IComparable<Student>
    {
        public Student(string fName, string lName, int sNumber)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.StudentNumber = sNumber;
        }

        public Student(int sNumber)
        {
            this.StudentNumber = sNumber;
        }

        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }

        public int StudentNumber
        {
            get;
            set;
        }

        public override string ToString() => $"{FirstName}, {LastName}, {StudentNumber}\n";


        public int CompareTo(Student s)
        {

            if (this.StudentNumber < s.StudentNumber)
            {
                return -1;
            }
            else if (this.StudentNumber == s.StudentNumber)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }

    }
}
