using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_App_ArielM.BankApp
{
    public class Account
    {
        private Owner owner;
        private double balance;
        private int overdraft;
        private const int MAX_OVERDRAFT = 90_000;
        public Account(Owner owner, double balance, int overdraft) 
        {
            SetOverdraft(overdraft);
            this.balance = balance;
            this.owner = owner;

        }
        public int GetOverdraft()
        {
            return overdraft;
        }
        public double GetBalance()
        {
            return balance;
        }
        public Owner GetOwner()
        {
            return owner;
        }
        public void SetOverdraft(int overdraft)
        {
            if (overdraft > MAX_OVERDRAFT)
            {
                Console.WriteLine("Overdraft cannot be more than " + MAX_OVERDRAFT);
            }
            else
            {
                this.overdraft = overdraft;
            }
        }
        public void Deposit(double sumDepositAmount )
        {
            balance += sumDepositAmount;
        }
        public void Withdraw(double sum)
        {
            double check = this.balance - sum;
            if (check < -overdraft)
            {
                Console.WriteLine("Not possible, sorry");
            }
            else
            {
                this.balance -= sum;
            }
        }
    }
}
