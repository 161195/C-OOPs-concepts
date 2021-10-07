using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_oops_concept.Encapsulation
{
    class Account
    {
        int accountBalance = 1000;

        public void SetBalance(int amount)
        {
            if(amount<0)
            {
                Console.WriteLine("you can not pass negative value");
            }
            else
            {
                accountBalance = amount;
            }
 
        }
        public void GetBalance()
        {
            Console.WriteLine("Your Account Balance is :" + accountBalance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();
            myAccount.SetBalance(-20);
            myAccount.GetBalance();
            Console.ReadLine();
        }
    }


         
}
