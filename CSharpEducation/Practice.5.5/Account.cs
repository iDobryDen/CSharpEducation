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
			if (takemoney <= _balance)
			{
				_balance -= takemoney;
			}
			else
			{
                Console.WriteLine("на счету не достаточно средств");
            }

        }
        public void ShowBalance()
        {
            Console.WriteLine("Баланс: " + _balance);
        }


    }
}

