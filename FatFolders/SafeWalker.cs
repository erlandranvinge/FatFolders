using System;
using System.Collections.Generic;
using System.IO;

namespace FatFolders
{
	public static class SafeWalker
	{
		private static bool _cancel;

		public static List<string> GetFolders(string path)
		{
			_cancel = false;
			var result = new List<string>();
			result.Add(path);
			GetSubFolders(path, ref result);
			return result;
		}

		private static void GetSubFolders(string path, ref List<string> result)
		{
			try
			{
				//result.Add(path);
				var subFolders = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);
				foreach (var subFolder in subFolders)
				{
					if (_cancel)
						break;
					result.Add(subFolder);
					GetSubFolders(subFolder, ref result);
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