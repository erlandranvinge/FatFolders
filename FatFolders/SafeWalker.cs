using System;
using System.Collections.Generic;
using System.IO;

namespace FatFolders
{
	public static class SafeWalker
	{
		private static bool _cancel;
		private static List<string> _result = new List<string>(); 

		public static List<string> GetFolders(string path)
		{
			_result.Clear();
			_cancel = false;
			_result.Add(path);
			GetSubFolders(path);
			return _result;
		}

		private static void GetSubFolders(string path)
		{
			try
			{
				//result.Add(path);
				var subFolders = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);
				foreach (var subFolder in subFolders)
				{
					if (_cancel)
						break;
					_result.Add(subFolder);
					GetSubFolders(subFolder);
				}
			}
			catch (UnauthorizedAccessException) {}
		}

		public static void Cancel()
		{
			_cancel = true;
		}
	}
}