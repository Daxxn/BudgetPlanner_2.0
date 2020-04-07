using BudgetModels.Models_V1.BudgetModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetModels.Models_V1.BudgetModels
{
	public class BudgetBase : BaseModel, IBudgetBase
	{
		#region - Fields & Properties
		private int _iDNumber;
		private string _title;
		private string _description;
		private decimal _amount;
		private DateTime _dueDate;
		#endregion

		#region - Constructors
		public BudgetBase( ) { }
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties
		public int IDNumber
		{
			get { return _iDNumber; }
			set
			{
				_iDNumber = value;
				OnPropertyChanged(nameof(IDNumber));
			}
		}

		public string Title
		{
			get { return _title; }
			set
			{
				_title = value;
				OnPropertyChanged(nameof(Title));
			}
		}

		public string Description
		{
			get { return _description; }
			set
			{
				_description = value;
				OnPropertyChanged(nameof(Description));
			}
		}

		public decimal Amount
		{
			get { return _amount; }
			set
			{
				_amount = value;
				OnPropertyChanged(nameof(Amount));
			}
		}

		public DateTime DueDate
		{
			get { return _dueDate; }
			set
			{
				_dueDate = value;
				OnPropertyChanged(nameof(DueDate));
			}
		}
		#endregion
	}
}
