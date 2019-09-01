using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_W2D4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assign properties
            Student s1 = new Student();
            s1.Name = "Michalis";
            s1.Age = 30;
            s1.PhoneNumber = "6974626419";
            s1.StartingDate = new DateTime(2019, 5, 25);
            s1.TuitionFee = 2500;
            s1.SetConduct(Conduct.Good);
            s1.RaiseTuitionFee();
            Console.WriteLine(s1.TuitionFee);
            Console.ReadKey();

            // Object initialization
            Student s2 = new Student
            {
                Age = 30,
                Name = "Michalis",
                PhoneNumber = "6974626419",
                StartingDate = new DateTime(2019, 5, 25),
                TuitionFee = 2500
            };

            Student s3 = new Student(30, "Michalis", 2500,
                                     new DateTime(2019, 5, 25), "6974626419");
        }
    }
}
