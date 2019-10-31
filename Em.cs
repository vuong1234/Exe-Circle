using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Em
    {
        private int Id;
        private string FName;
        private string LName;
        private int Salary;

        public Em(int ID, string FN, string LN, int Sa)
          {
              Id = ID;
              FName = FN;
              LName = LN;
              Salary = Sa;
          }

        public int GetId()
        {
            return Id;
        }

        public string GetFName()
        {
            return FName;
        }

        public string GetLName()
        {
            return LName;
        }

        public string GetName()
        {
            return "a";
        }

        public int GetSalary()
        {
            return Salary;
        }

        public void SetSalary(int NewSalary)
        {
            Salary = NewSalary;
        }

        public int GetAnnualSalary()
        {
            return Salary;
        }

        public int RaiseSalary(int Percent)
        {
            return Percent;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    
    }
}
