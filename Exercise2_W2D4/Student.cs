using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_W2D4
{
    class Student
    {
        #region Public properties

        public int Age { get; set; }
        public string Name { get; set; }
        public decimal TuitionFee { get; set; }
        public DateTime StartingDate { get; set; }
        public string PhoneNumber { get; set; }
        public Conduct StudentConduct { get; private set; }

        #endregion

        #region Public methods

        public void SetConduct(Conduct conduct)
        {
            StudentConduct = conduct;
        }

        public void RaiseTuitionFee(decimal percentage)
        {
            TuitionFee += TuitionFee * percentage;
        }

        public void RaiseTuitionFee()
        {
            switch (StudentConduct)
            {
                case Conduct.Excellent:
                    break;
                case Conduct.Good:
                    RaiseTuitionFee(0.1m);
                    break;
                case Conduct.Bad:
                    RaiseTuitionFee((decimal)0.2);
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Constructors

        // Overide default constructor
        public Student()
        {

        }

        // Constructor overloading
        public Student(int age, string name,
                       decimal tuitionFee, DateTime startingDate,
                       string phoneNumber)
        {
            Age = age;
            Name = name;
            TuitionFee = tuitionFee;
            StartingDate = startingDate;
            PhoneNumber = phoneNumber;
        }

        #endregion
    }
}
