using System;
using Model;
using System.Collections.Generic;

namespace BL
{
    public class Logic
    {
        public List<Employee> NotHired { get; set; } = new List<Employee>()
        {
            new Employee("John", 3, 110000, 110000),
            new Employee("Lisa", 7, 200000, 200000),
            new Employee("James", 1, 70000, 70000),
            new Employee("Gregory", 14, 250000, 250000),
            new Employee("Ann", 6, 180000, 180000),
            new Employee("Catherine", 9, 200000, 200000),
            new Employee("Paul", 0, 50000, 50000),
        };
        public List<Employee> Emps { get; set; } = new List<Employee>();
        public Employee SelectedButNotHired { get; set; }
        public Employee SelectedEmployee { get; set; }

        private bool IsEnough(Employee selemp, int salary)
        {
            if(salary >= selemp.DesiredSalary * 0.75)
            {
                return true;
            }
            return false;
        }

        public void Hire(Employee selemp, int salary)
        {
            if(IsEnough(selemp, salary))
            {
                selemp.RealSalary = salary;
                Emps.Add(selemp);
                NotHired.Remove(selemp);
            }
            SelectedButNotHired = null;
        }

        public void Refuse(Employee selemp)
        {
            NotHired.Remove(selemp);
            SelectedButNotHired = null;
        }

        public void Fire(Employee selemp)
        {
            Emps.Remove(selemp);
            SelectedEmployee = null;
        }

        public void ChangeSalary(Employee selemp, int salary)
        {
            if(IsEnough(selemp, salary))
            {
                selemp.RealSalary = salary;
            }
            SelectedEmployee = null;
        }
    }
}
