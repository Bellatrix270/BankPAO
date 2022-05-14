using BankPAO.Model;
using BankPAO.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPAO.ViewModel
{
	public class DepositDescriptionContent : BaseContent
	{
		public string Title => "Bank PAO";
		private List<Deposit> _deposits;
		public List<Deposit> Deposits { get; set; }

		public DepositDescriptionContent(Action<object> execute, Func<object, bool> canExecute = null)
			: base(execute, canExecute) 
		{
			Deposits = new List<Deposit>() { new Deposit {Name = "Nice deposit" }, new Deposit { Name = "Great deposit" } };
		}
	}
}
