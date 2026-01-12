using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    public static class StudentExtensions
    {
        public static int GetNbDaysSubscribed(this Student student)
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            return today.DayNumber - student.SubscribeDate.DayNumber;
        }

        public static Person? ToPerson(this Student student)
        {
            if (student is null) return null;
            return new Person()
            {
                FirstName = student.FirstName,
                LastName = student.LastName
            };
        }

        public static Person? ToPerson(this Student student, DateOnly birthdate)
        {
            if (student is null) return null;
            return new Person()
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                BirthDate = birthdate
            };
        }

        /*public static Person? ToPerson(this Student student) =>
            (student is null) ?
            null :
            new Person()
            {
                FirstName = student.FirstName,
                LastName = student.LastName
            };
        */
    }
}
