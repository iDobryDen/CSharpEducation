using System;
namespace Practice._5._5
{
	public class Account
	{
		private static int _balance = 0;

		public Account()
		{

		}

		public void AddMoney(int addmoney)
		{
			_balance += addmoney;
		}
        public void TakeMoney(int takemoney)
        {
            _balance -= takemoney;
        }
        public void ShowBalance()
        {
            Console.WriteLine("Баланс: " + _balance);
        }


    }
}

