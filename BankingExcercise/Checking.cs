using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingExcercise {
	class Checking : Account {
		public static int NextCheckNbr { get; set; } = 1;
		public string Payee { get; set; }

		public void WriteCheck(string Payee, decimal Amount) {
			int CkeckNbr = NextCheckNbr++;
			this.Payee = Payee;
			Withdrawal(Amount);
		}

		public Checking (string AccountNbr, string Description) : base(AccountNbr,Description) {
			this.AcctNbr = AccountNbr;
			this.Description = Description;
		}

	}
}
