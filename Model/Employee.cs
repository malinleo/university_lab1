using System;
using System.Collections.Generic;

namespace Model
{
    public class Employee
    {
        public Employee(string name, int exp, int dsalary, int rsalary)
        {
            Name = name;
            Experience = exp;
            DesiredSalary = dsalary;
            RealSalary = rsalary;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public int DesiredSalary { get; }
        public int RealSalary { get; set; }
        public override string ToString()
        {
            return Name + "-" + Experience + " years exp -" + RealSalary;
        }
    }
}
