using System;

namespace UnitTestingBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            BankAccount ba = new BankAccount("Arunkumar",11.88); ;
            ba.Credit(5.77);
            ba.Debit(12.44);
            Console.WriteLine("Current balance is ${0}", ba.Balance);


        }
    }

    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;

        private BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public string CustomerName
        {
            get
            {
                return m_customerName;
            }
        }

        public double Balance
        {
            get
            {
                return m_balance;
            }
        }

        public void Debit(double amount)
        {
            if(amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if(amount <0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            m_balance -= amount;
        }

        public void Credit(double amount)
        {
            if(amount<0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            m_balance += amount;
                
        }
    }


}
