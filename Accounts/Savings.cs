using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
	class Savings :Account
	{
		protected decimal IntRate { get; set; }

		public decimal CalcInterest(decimal years) {
			decimal interest = balance*(1 + (IntRate * years));

			return interest;
		}

		public void addInterest(decimal years) {
			balance += CalcInterest(years);
		}
	}
}
