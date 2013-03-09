using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    public class Worker : Human
    {
        public decimal WeekSalary { get; set; }
        public int WorkHoursPerDay{ get; set; }

        public Worker()
        {
        }

        public Worker(string fName, string lName)
            : this()
        {
            this.firstName = fName;
            this.lastName = lName;
        }

        public Worker(string fName, string lName, decimal weekSlary, int workHoursPerDay)
            : this(fName, lName)
        {
            this.WeekSalary = weekSlary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / this.WorkHoursPerDay * 5;
        }

        public override string ToString()
        {
            return string.Format( "{0} makes: {1:N2} per hour",base.ToString(), this.MoneyPerHour());
        }
    }
}
