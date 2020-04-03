using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner_UI.CustomEventArgs
{
    public class TaxEstimateEventArgs : EventArgs
    {
        public string Selection { get; private set; }
        public int SelectionIndex { get; private set; }

        public TaxEstimateEventArgs( string selection, int selectionIndex )
        {
            Selection = selection;
            SelectionIndex = selectionIndex;
        }
        public TaxEstimateEventArgs( int selection )
        {
            SelectionIndex = selection;
        }
    }
}
