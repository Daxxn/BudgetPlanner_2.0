using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetModels
{
    public static class PercentageCalculator
	{
		#region - Fields & Properties

		#endregion

		#region - Methods
		public static dynamic CalcPercent( dynamic total, dynamic diff )
		{
			return (diff / total) * (dynamic)100;
		}

		public static dynamic CalcTotal( dynamic diff, dynamic percent )
		{
			return diff / (percent / (dynamic)100);
		}

		public static dynamic CalcDiff( dynamic total, dynamic percent )
		{
			return total * (percent / (dynamic)100);
		}
		#endregion

		#region - Full Properties

		#endregion
	}
}
