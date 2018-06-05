using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
	class Account
	{
		static long actNum = 1000;
		public decimal balance { get; set; }
		protected string Owner { get; set; }
		protected string Description { get; set; }
		protected long id;
		public Account()
		{
			id = ++actNum;
		}

		public void deposit(decimal amount) {
			if (amount < 0) {
				Console.WriteLine("You can not put in a negative");
				return;
					}
			balance += amount;
		}
		public void withdraw(decimal amount) {
			if (amount < 0) { Console.WriteLine("You can not put in a negative");
				return;
			}
			balance -= amount;
			if (balance < 0) {
				Console.WriteLine("You are now in the negatives");
			}
		}
		public Account(decimal amount) {
			balance = amount;
			id = ++actNum;
		}
	}
}
