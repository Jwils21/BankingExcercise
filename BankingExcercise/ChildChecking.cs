using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingExcercise {
	class ChildChecking : Checking {
		public Account ParentAccount { get; set; }

		public ChildChecking(string AccountNbr, string Description, Checking ParentsChecking) : base(AccountNbr, Description) {
			ParentAccount = ParentsChecking;
		}
	}
}
