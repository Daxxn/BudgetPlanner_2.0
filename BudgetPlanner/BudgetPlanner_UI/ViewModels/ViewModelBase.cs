using StateControl.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner_UI.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = ( sender, e ) => { };

        public void OnPropertyChanged( string name )
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public virtual void OpenData( IState state )
        {
            throw new Exception("OpenData Method must be overridden in derived class!");
        }

        public virtual void Clear( )
        {
            throw new Exception("Clear Method must be overridden in derived class!");
        }

        public virtual void New( )
        {
            throw new Exception("New Method must be overridden in derived class!");
        }
    }
}
