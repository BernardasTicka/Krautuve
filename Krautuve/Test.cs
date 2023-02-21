using Krautuve.HR;
using System;

namespace Kratuve.Tests
{
    public class EmployeeTests
    {
        public void PerformWork_Adds_NumberOfHours()
        {
            Employee employee = new Employee("Rita", "Makaka", "Rita@one.lt", new DateTime(1979, 1, 16), 25);

            int numberOfHours = 3;
           
            employee.PerformWork(numberOfHours);

        }

        public void PerformWork_Adds_DefaultNumberOfHours_IfNoValueSpecified()
        {
            Employee employee = new Employee("Rita", "Makaka", "Rita@one.lt", new DateTime(1979, 1, 16), 25);

            employee.PerformWork();
           
        }
    }
}