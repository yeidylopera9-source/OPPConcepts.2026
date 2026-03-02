using System;
using System.Collections.Generic;
using System.Text;

namespace OPPConcepts.Backend
{
    public class BaseCommisionEmployee : CommisionEmployee
    {
        //fiels
        private decimal _salary;

        //constructors
        public BaseCommisionEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate, float commisionPorcent,  decimal sales, decimal salary) :
            base(id, firstName, lastName, isActive, bornDate, hireDate,commisionPorcent, sales)
        {
            Salary = salary;
        }
        // propieties

        public decimal Salary 
        {
            get => _salary; 
            set => _salary = ValidateSalary(value); 
        }


        //metodos
        public override decimal GetValueToPay() => base.GetValueToPay() + Salary;
        public override string ToString() => $"{base.ToString()}" +
            $"\n\tSalary base.....: {Salary,20:C2}";  
        
        private decimal ValidateSalary(decimal salary)
        {
            if (salary < 500000)
            {
                throw new ArgumentOutOfRangeException(nameof(salary),  "Salary base must be greather than or equal to $500.000. ");
            }
            return  salary;
        }
    }
}
