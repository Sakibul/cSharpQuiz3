using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpQuiz3
{
    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool isRegistered { get; set; }

        public Student(int id, string firstName, string lastName, bool isRegistered)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.isRegistered = isRegistered;
        }

        public override string ToString()
        {
            return $"{this.Id} :: {this.FirstName} :: {this.LastName} :: Registered = {isRegistered}";
        }
    }
}
