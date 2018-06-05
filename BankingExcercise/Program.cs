using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingExcercise {
	class Program {
		static void Main(string[] args) {
			Checking Chk1 = new Checking("123", "First CHecking") {
				Owner = "Jonathan"
			};

			Chk1.Deposit(1500);
			Chk1.Withdrawal(500);
			Chk1.Deposit(-100);

			Savings Sav1 = new Savings("456", "First Savings") {
				Owner = "Jonathan"
			};
			Sav1.Deposit(1000);
			Sav1.Withdrawal(400);
			Sav1.Withdrawal(-100);

			Console.WriteLine($"The balance for {Chk1.Owner} is: {Chk1.GetBalance()}");
			Console.WriteLine($"The balance for {Sav1.Owner} is: {Sav1.GetBalance()}");

			Sav1.CalcInt(1);
			Console.WriteLine($"The balance for {Sav1.Owner} is: {Sav1.GetBalance()}");

			ChildChecking JonathanSon = new ChildChecking("789", "Jonathan's Sons Checking", Chk1) {
				Owner = "Jonahan's Son"
			};
			JonathanSon.Deposit(200);
			JonathanSon.Withdrawal(100);
			Console.WriteLine($"The balance for {JonathanSon.Owner} is: {JonathanSon.GetBalance()}");

			List<Account> Accounts = new List<Account> { Chk1, Sav1, JonathanSon };
			decimal totalAllAccounts = 0;
			foreach (Account account in Accounts) {
				totalAllAccounts += account.GetBalance();
			}
			Console.WriteLine($"Total Balance: {totalAllAccounts}");

		}
	}
}
