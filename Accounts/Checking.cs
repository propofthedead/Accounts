using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
	class Checking : Account
	{
		static int TransactionId = 0;

		public void Tranaction(decimal amount) {
			balance += amount;
			++TransactionId;
			Console.WriteLine($"The amount {amount} was either added or withdrawn from {base.id} to make the {base.balance} dollars");
		}
	}
}
