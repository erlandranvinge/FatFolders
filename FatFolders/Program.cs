using System;
using System.Windows.Forms;
using FatFolders.Forms;

namespace FatFolders
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FatFoldersForm());
		}
	}
}
