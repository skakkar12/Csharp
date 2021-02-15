using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace Csharp2013.Class_Interface
{

  


    abstract public class BankAccount
    {
        abstract public void Withdrawal(double dwithdrawal);
    }

    public class SavingsAccount : BankAccount
    {
        override public void Withdrawal(double dwithdrawal)
        {
        }
    }

    public class CheckingAccount : BankAccount
    {
        override public void Withdrawal(double dwithdrawal)
        {

        }
    }
}