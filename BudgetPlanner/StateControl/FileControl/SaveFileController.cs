using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateControl.FileControl
{
    public static class SaveFileController
	{
		#region - Fields & Properties

		#endregion

		#region - Methods
		public static string SaveDialog( )
		{
			string output = null;
			SaveFileDialog dialog = new SaveFileDialog
			{
				AddExtension = true,
				DefaultExt = ".bdg",
				OverwritePrompt = true,
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
			};

			if (dialog.ShowDialog() == true)
			{
				if (dialog.FileName != null)
				{
					output = dialog.FileName;
				}
			}

			return output;
		}
		#endregion

		#region - Full Properties

		#endregion
	}
}
