using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp2013.Class_Interface
{

   

    public class BankAccunt
    {
        public static int nNextAccountNo = 1000;
        public int nAccountNumber;
        public double Balance;

        public void InitBankAccount()
        {
            nAccountNumber = ++nNextAccountNo;
        }
        public void Deposit(double Amount)
        {
            if (Amount>0.0)
            {
                Balance += Amount;
            }
        }

        public double Withdraw(double withdraw)
        {
            return 0.2;
        }
    }
}
