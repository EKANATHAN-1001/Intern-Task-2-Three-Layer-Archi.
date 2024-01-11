using BaseLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLayer
{
    public class Transaction
    {
        Bank b = new Bank();
        
        public void checkWithdraw(float amt)
        {
            float bal = b.getBalance();
            if (bal - amt >= 1000)
                b.withdraw(amt);
        }
        public void checkDeposit(float amt)
        {
            if (amt <= 100000)
                b.deposit(amt);
            
        }
    }
}
