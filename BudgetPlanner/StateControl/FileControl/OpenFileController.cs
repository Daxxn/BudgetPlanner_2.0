using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateControl.FileControl
{
    public static class OpenFileController
	{
		#region - Fields & Properties

		#endregion

		#region - Methods
		public static string OpenFile(  )
		{
			OpenFileDialog dialog = new OpenFileDialog()
			{
				AddExtension = true,
				DefaultExt = ".bdg",
			};

			dialog.ShowDialog();
			return dialog.FileName;
		}
		#endregion

		#region - Full Properties

		#endregion
	}
}
