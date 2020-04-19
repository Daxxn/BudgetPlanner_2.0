﻿using Microsoft.Win32;
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

			if (dialog.ShowDialog() == true)
			{
				if (!String.IsNullOrEmpty(dialog.FileName))
				{
					return dialog.FileName;
				}
			}
			return null;
		}
		#endregion

		#region - Full Properties

		#endregion
	}
}
