using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingExcercise {
	class Account {
		public string AcctNbr { get; set; }
		public string Owner { get; set; }
		public decimal Balance { get; private set; }
		public string Description { get; set; }

		public void Deposit (decimal DepAmt) {
			if (DepAmt <0) {
				Console.WriteLine("Amount is less than 0");
				return;
			}
			Balance += DepAmt;
		}

		public void Withdrawal (decimal WithAmt) {
			if(WithAmt < 0) {
				Console.WriteLine("Amount is less than 0");
				return;
			}
			Balance -= WithAmt;
		}

		public decimal GetBalance() {
			return Balance;
		}

		public Account(string AccountNbr, string Description) {
			this.AcctNbr = AccountNbr;
			this.Description = Description;
			this.Balance = 0;
		}

		protected void CalcInt (decimal IntRate) {
			Balance *= (1 + (IntRate / 12));
		}
	}
}
