using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPAO.Model
{
	public class Deposit
	{
		public string Name { get; set; }
		public bool IsReplenished { get; set; }
		public bool Withdrawal { get; set; }
		public bool WithCapitalization { get; set; }
		public TimeSpan MunimalTerm { get; set; }
		public double Percentages { get; set; }
	}
}
