using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOf55Stars
{
    class TriangleStart
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(new string('*', i));
            }

            var goshka = new Student("Goshka");

            var goshkaBaba = new Student("Goshka", "Baba");

            var goshkaWithEgn = new Student("Goshka", 123123123);

        }
    }

    class Student
    {
        public Student(string firstName)
        {
            this.FirstName = firstName;
        }

        public Student(string firstName, string LastName)
        {
            this.FirstName = firstName;
            this.LastName = LastName;
        }

        public Student(string firstName, int egn)
        {
            this.FirstName = firstName;
            this.Egn = egn;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Egn { get; private set; }
    }
}
