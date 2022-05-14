using BankPAO.Infrastructure;
using BankPAO.Infrastructure.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPAO.ViewModel.Base
{
	public class BaseContent : OnPropertyChangedClass
	{
		private RelayCommand JumpCommand { get; }

		public BaseContent(Action<object> execute, Func<object, bool> canExecute = null) => 
			JumpCommand = new RelayCommand(execute, canExecute);
	}
}
