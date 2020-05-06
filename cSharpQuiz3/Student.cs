using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpQuiz3
{
    class Student
    {
        private int Id;
        private string FirstName;
        private string LastName;
        private bool isRegistered;

        public Student(int id, string firstName, string lastName, bool isRegistered)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.isRegistered = isRegistered;
        }
    }
}
