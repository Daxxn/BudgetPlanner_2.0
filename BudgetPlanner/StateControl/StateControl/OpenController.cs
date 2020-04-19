using StateControl.StateControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateControl.StateControl
{
    public static class OpenController
	{
        #region - Fields & Properties

        #endregion

        #region - Methods
        public static (string, SaveState) Open( string path )
        {
            if (String.IsNullOrEmpty(path))
            {
                return ("Path is not valid.", null);
            }

            try
            {
                SaveState state = JsonController.OpenJsonFile<SaveState>(path);

                return (null, state);
            }
            catch (Exception e)
            {
                return (e.Message, null);
            }

        }
        #endregion

        #region - Full Properties

        #endregion
    }
}
