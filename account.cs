using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABTASK6
{
    class account
    {
        private string accName;
        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }

        private string acid;
        public string Acid
        {
            get { return acid; }
            set { acid = value; }
        }

        private int balance;
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public account()
        {
            Console.WriteLine("Empty Constructor");
        }

        public account(String accName, String acid, int balance)
        {

            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }

        public void Deposit(int amount)
        {
            balance += amount;
        }

        public void Withdraw (int amount)
        {
            if (amount < balance)
            {
                balance -= amount ;
            }
            else
                Console.WriteLine("Insufficient Balance");
        }

        public Boolean transfer(int amount, Account receiver)
        {
            if (this.balance < amount)
            {
                return false;
            }
            else
            {
                if (receiver != null)
                {
                    receiver.balance += amount;
                    this.balance -= amount;
                    return true;
                }
                else
                {
                    return false;
                }

                public void showinfo()
        {
            Console.WriteLine("Account Name :" + accName);
            Console.WriteLine("Account ID :" + acid);
            Console.WriteLine("Balance :" + balance);
           
        }





    }
}
