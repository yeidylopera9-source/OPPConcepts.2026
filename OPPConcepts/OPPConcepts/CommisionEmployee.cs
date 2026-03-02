using System;
using System.Collections.Generic;
using System.Text;

namespace OPPConcepts.Backend
{
    public class CommisionEmployee : Employee
    {
        //fiels
        private float _commisionPorcent;
        private decimal _sales;

        // constructors
        public CommisionEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate, float commisionPorcent, decimal sales) : 
            base(id, firstName, lastName, isActive, bornDate, hireDate)
        {
            CommisionPorcent = commisionPorcent;
            Sales = sales;
        }

        // properties
        public float CommisionPorcent 
            {
                 get => _commisionPorcent; 
                 set => _commisionPorcent = ValidateCommisionPorcent(value); 
             }   
          public decimal Sales 
            {
                 get => _sales;
                 set => _sales = ValidateSales(value);
            }

        //methods
        public override decimal GetValueToPay() => (decimal)CommisionPorcent * Sales;
            

        public override string ToString() => base.ToString() + $"\n\t" +
            $"Commision Percent: {CommisionPorcent,20:P2}\n\t" +     //P simbolo de porcentaje
            $"Sales............: {Sales,20:C2}";
        
        private float ValidateCommisionPorcent(float commisionPorcent)
        {
            if (commisionPorcent < 0 || commisionPorcent > 1)
            {
                throw new ArgumentOutOfRangeException(nameof(commisionPorcent), "Commision percent must be between 0 and 1. ");
            }
            return commisionPorcent;
        }
        private decimal ValidateSales(decimal sales)
        {
            if (sales < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(sales), "Sales must be greater than or equal to 0. ");
            }
            return sales;
        }
    } 
}
