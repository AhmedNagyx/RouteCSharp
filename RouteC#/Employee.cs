using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public DateTime HiringDate { get; set; }
        public SecurityPrivileges SecurityPrivileges { get; set; }
        private char gender;
        public char Gender
        {
            get { return gender; }
            set
            {
                if (value == 'M' || value == 'F')
                {
                    gender = value;
                }
                else
                {
                    Console.WriteLine("Must be M or F");
                }
            }
        }
        public Employee(int id,string name,decimal salary,DateTime _hiringDate,SecurityPrivileges securityPrivileges,char gender)
        {
            Id = id;
            Name = name;
            Salary = salary;
            HiringDate = _hiringDate;
            SecurityPrivileges = securityPrivileges;
            Gender = gender;

        }
        public override string ToString() 
        {
            return ($"ID = {Id} \nName = {Name} \nSalary = {GetSalaryCurrency()} \nHiring Date = {HiringDate} \nSecurity Privileges = {SecurityPrivileges} \nGender = {Gender} \n");        
        }
        public string GetSalaryCurrency()
        {
            return String.Format(CultureInfo.InvariantCulture, "{0:C}", Salary);
        }

    }
}
