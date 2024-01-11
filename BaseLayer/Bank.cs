using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLayer
{
    public class Bank
    {
        static float balance;
       public Bank() 
        { 
            balance = 5000;
        }
        public void deposit(float amt)
        {
            balance += amt;
        }
        public float getBalance()
        {
            return balance;
        }
        public void withdraw(float amt)
        {
            balance -= amt;
        }

    }
}
