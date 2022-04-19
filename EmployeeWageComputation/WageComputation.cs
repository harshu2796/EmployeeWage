﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        const int IS_FULL_TIME_PRESENT = 1, IS_PART_TIME_PRESENT = 2;
        public void EmployeeAttendence(string company,int empRatePerHour,int numOfWorkingDays,int maxHoursPerMonth)
        {
            int empHrs, totalEmpHrs=0, totalWorkingDays=0;
            while(totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME_PRESENT:
                        empHrs = 8;
                        break;

                    case IS_PART_TIME_PRESENT:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days :" + totalWorkingDays +" Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Employee Wage for Company: " + company + " is: " + totalEmpWage);
        }
        
    }
}
