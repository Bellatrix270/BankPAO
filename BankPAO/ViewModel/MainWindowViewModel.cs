using BankPAO.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPAO.ViewModel
{
	class MainWindowViewModel
	{
		public BaseContent Content { get; set; }

		public MainWindowViewModel()
		{
			Content = new DepositDescriptionContent(null);
		}
	}
}
