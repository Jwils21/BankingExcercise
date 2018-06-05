using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingExcercise {
	class Savings : Account {

		public decimal IntRate { get; set; } = .02M;
		
		public void CalcInt() {
			CalcInt(IntRate);
		}

		public Savings (string AccountNbr, string Description) : base(AccountNbr,Description) {
			this.AcctNbr= AccountNbr;
			this.Description = Description;
			Deposit(0);
		}
	}
}
